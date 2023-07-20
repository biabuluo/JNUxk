using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class AddTeachForm : Form
    {
        // 添加授课信息窗口
        private CourseInfoForm parent;   // 父窗口引用

        public void setparent(CourseInfoForm parent) // 父窗口调用设置引用
        {
            this.parent = parent;
        }

        public AddTeachForm()
        {
            InitializeComponent();
        }

        #region 点击添加功能
        private void SureBtn_Click(object sender, EventArgs e)     // 确认按钮点击时
        {
            #region 信息为空提示
            if (CidtextBox.Text == "" || TidtextBox.Text == "" || LocationtextBox.Text == "" || DatetextBox.Text == "")
            {
                MessageBox.Show("必要信息不能为空！");
                return;
            }
            #endregion

            #region 正则表达式判断授课时间和地点是否冲突
            //正则表达式判断location和date是否符合格式：
            Regex location = new Regex(@"^N[0-9]{3}");
            Regex date_time = new Regex(@"[1-5]-[1-5]");
            if (!location.IsMatch(LocationtextBox.Text.Trim()) || !date_time.IsMatch(DatetextBox.Text.Trim()))
            {
                MessageBox.Show("格式错误！");
                return;
            }
            #endregion

            MysqlHelper mysql = new MysqlHelper();

            #region 判断该授课时间是否与该教师的课程安排冲突
            //判断该授课时间是否与该教师的课程安排冲突（课程时间冲突）
            List<string> coursedate = new List<string>();
            // 获取该教师的所有日程安排
            string sql = "select date_time from teachtable where tid = '" + TidtextBox.Text.Trim() + "';";
            MySqlDataReader reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                coursedate.Add(reader.GetString("date_time"));
            }
            // 如果日程安排中存在冲突
            if (coursedate.Contains(DatetextBox.Text.Trim()))
            {
                MessageBox.Show("时间冲突！");
                return;      // 错误返回
            }
            #endregion

            #region 判断该授课地点是否与其他教师的课程安排冲突
            //课程地点冲突:相同时间，相同地点
            List<string> coursedate_time = new List<string>();
            // 获取授课信息的所有该地点安排的时间
            sql = "select date_time from teachtable where location = '" + LocationtextBox.Text.Trim() + "';";
            reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                coursedate.Add(reader.GetString("date_time"));
            }
            // 如果日程安排中存在冲突
            if (coursedate.Contains(DatetextBox.Text.Trim()))
            {
                MessageBox.Show("地点冲突！");
                return;      // 错误返回
            }
            #endregion

            #region 提交mysql添加课程安排
            sql = "insert into teachtable(cid, tid, location, date_time) values(@cid, @tid, @location, @date_time);";
            MySqlParameter[] paras =
            {
                new MySqlParameter("@cid",CidtextBox.Text.Trim()),
                new MySqlParameter("@tid",TidtextBox.Text.Trim()),
                new MySqlParameter("@location", LocationtextBox.Text.Trim()),
                new MySqlParameter("@date_time",DatetextBox.Text.Trim())
            };

            /*
            mysql.ExecuteNonQuery(sql, paras);
            */
            
            try
            {
                if(mysql.ExecuteNonQuery(sql, paras) > 0)
                {
                    MessageBox.Show("添加成功！");
                    parent.init();        // 调用父窗口初始化
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("添加失败！");

            }
            #endregion
            

        }
        #endregion


    }
}
