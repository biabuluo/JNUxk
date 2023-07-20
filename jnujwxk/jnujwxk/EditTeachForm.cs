using MySql.Data.MySqlClient;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class EditTeachForm : Form
    {
        // 修改授课子窗口

        private string skid;
        private string cid;              // 课程id
        private CourseInfoForm parent;   // 父窗口引用
        private string old_location;
        private string old_date;

        public void setparent(CourseInfoForm parent) // 父窗口调用设置引用
        {
            this.parent = parent;
        }


        #region 窗口构造器
        public EditTeachForm(string[] info)
        {
            InitializeComponent();
            // 获取课程信息并填充
            skid = info[0];
            cid = info[1];
            this.label4.Text = "编号：" + info[0];
            this.TeachNamelabel.Text = info[2];
            tidtextBox.Text = info[3];
            locationtextBox.Text = info[5];
            datetimetextBox.Text = info[6];
            old_location = info[5];
            old_date = info[6];
        }
        #endregion



        #region 确认修改功能
        private void SureBtn_Click(object sender, EventArgs e)
        {
            #region 信息为空提示
            if (tidtextBox.Text == "" || locationtextBox.Text == "" || datetimetextBox.Text == "")
            {
                MessageBox.Show("必要信息不能为空！");
                return;
            }
            #endregion

            #region 正则表达式判断授课地点/授课时间是否符合格式
            //正则表达式判断location和date是否符合格式：
            Regex location = new Regex(@"N[0-9]{3}");
            Regex date_time = new Regex(@"[1-5]-[1-5]");
            if (!location.IsMatch(locationtextBox.Text.Trim()) || !date_time.IsMatch(datetimetextBox.Text.Trim()))
            {
                MessageBox.Show("格式错误！");
                return;
            }
            #endregion

            #region 判断修改的时间地点是否冲突

            MysqlHelper mysql = new MysqlHelper();
            #region 判断该授课时间是否与该教师的课程安排冲突
            //判断该授课时间是否与该教师的课程安排冲突（课程时间冲突）
            List<string> coursedate = new List<string>();
            // 获取该教师的所有日程安排但除开选择的课程
            string sql = "select date_time from teachtable where tid = '" + tidtextBox.Text.Trim() + "'and skid != '"+ skid+"';";
            MySqlDataReader reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                coursedate.Add(reader.GetString("date_time"));
            }
            // 如果日程安排中存在冲突
            if (coursedate.Contains(datetimetextBox.Text.Trim()))
            {
                MessageBox.Show("时间冲突！");
                return;      // 错误返回
            }
            #endregion

            #region 判断该授课地点是否与其他教师的课程安排冲突
            //课程地点冲突:相同时间，相同地点
            List<string> coursedate_time = new List<string>();
            // 获取授课信息的所有该地点安排的时间但除开选择的课程
            sql = "select date_time from teachtable where location = '" + locationtextBox.Text.Trim() + "'and skid != '" + skid +  "';";
            reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                coursedate.Add(reader.GetString("date_time"));
            }
            // 如果日程安排中存在冲突
            if (coursedate.Contains(datetimetextBox.Text.Trim()))
            {
                MessageBox.Show("地点冲突！");
                return;      // 错误返回
            }
            #endregion

            #endregion

            #region 删除所有已选择该课程的学生的选课记录， 强制学生重新选课
                // 如果时间地点任意改变，进行操作
            if(old_location != locationtextBox.Text || old_date != datetimetextBox.Text)
            {
                sql = "delete from studytable where skid = '"+ skid+"';";
                try
                {
                    mysql.ExecuteNonQuery(sql);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error");
                    return;
                }
            }
            #endregion

            #region 提交mysql修改授课信息
            sql = "update teachtable set location = @location, date_time = @date where skid = @skid;";
            MySqlParameter[] paras =
            {
                new MySqlParameter("@skid",skid),
                new MySqlParameter("@location",locationtextBox.Text.Trim()),
                new MySqlParameter("@date",datetimetextBox.Text.Trim()),
            };

            try
            {
                if (mysql.ExecuteNonQuery(sql, paras)>0)
                {
                    MessageBox.Show("修改成功！");
                    parent.init();                      // 调用父窗口初始化dgv
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("修改失败！");
            }
            #endregion

        }
        #endregion

    }
}
