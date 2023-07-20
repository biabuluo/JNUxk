using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class StuChooseCourseForm : Form
    {
        // 学生选课子窗口
        public StuChooseCourseForm()
        {
            InitializeComponent();
        }

        #region 初始化datagridview
        private void init_dgvStuChoosecourse() //初始化dgv
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql = "select a.skid 授课编号, a.cid 课程编号, cname 课程名称, points 学分, tid 教师编号, teaname 教师姓名, location 授课地点, date_time 授课时间, stunum 选课人数 from allteach_view a where not exists(\r\nselect * from studytable b\r\nwhere b.uid = '" + UserInfo.uid + "' and a.skid = b.skid\r\n);";
            DataTable dt_allteachlist = mysql.GetDataTable(sql);
            dgvStuChooseCourse.DataSource = dt_allteachlist;
        }
        #endregion


        private void StuChooseCourseForm_Load(object sender, EventArgs e)    // 当子页面打开时
        {
            // 初始化datagridview
            init_dgvStuChoosecourse();
        }

        #region 搜索课程功能完善
        private void SearchBtn_Click(object sender, EventArgs e)  //搜索按钮+功能完善：支持模糊搜索
        {
            //条件均为空时显示全部信息
            if (CourseNameBox.Text==""&& TeacherNameBox.Text == "")
            {
                init_dgvStuChoosecourse();
            }
            //课程信息不为空时
            else if(CourseNameBox.Text != "" && TeacherNameBox.Text == "")   // 课程名称不为空时
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid 授课编号,  a.cid 课程编号, cname 课程名称, points 学分, tid 教师编号, teaname 教师姓名, location 授课地点, date_time 授课时间, stunum 选课人数 from allteach_view a where not exists(\r\nselect * from studytable b\r\nwhere b.uid = '" + UserInfo.uid + "' and a.skid = b.skid\r\n) and a.cname like '%"+ CourseNameBox.Text.Trim() + "%';";
                DataTable dt_allteachlist = mysql.GetDataTable(sql);
                dgvStuChooseCourse.DataSource = dt_allteachlist;
            }
            else if(CourseNameBox.Text == "" && TeacherNameBox.Text != "")    // 教师姓名不为空时
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid 授课编号,  a.cid 课程编号, cname 课程名称, points 学分, tid 教师编号, teaname 教师姓名, location 授课地点, date_time 授课时间, stunum 选课人数 from allteach_view a where not exists(\r\nselect * from studytable b\r\nwhere b.uid = '" + UserInfo.uid + "' and a.skid = b.skid\r\n) and a.teaname like '%" + TeacherNameBox.Text.Trim() + "%';";
                DataTable dt_allteachlist = mysql.GetDataTable(sql);
                dgvStuChooseCourse.DataSource = dt_allteachlist;
            }
            else if(CourseNameBox.Text != "" && TeacherNameBox.Text != "")    // 课程信息和授课教师均不为空时
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid 授课编号, a.cid 课程编号, cname 课程名称, points 学分, tid 教师编号, teaname 教师姓名, location 授课地点, date_time 授课时间, stunum 选课人数 " +
                    "from allteach_view a where not exists(select * from studytable b where b.uid = '" + UserInfo.uid + "'and a.skid = b.skid) " +
                    "and a.cname like '%" + CourseNameBox.Text.Trim() + "%' and a.teaname like '%" + TeacherNameBox.Text.Trim() + "%';";
                DataTable dt_allteachlist = mysql.GetDataTable(sql);
                dgvStuChooseCourse.DataSource = dt_allteachlist;
            }
        }
        #endregion


        
        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)   //右键选课
        {
            #region 获取选课时间信息
            // 获取选课时间信息
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy/MM/dd";
            DateTime temp1 = Convert.ToDateTime(UserInfo.choosedate_start, dtFormat);
            DateTime temp2 = Convert.ToDateTime(UserInfo.choosedate_end, dtFormat);
            #endregion

            #region 判断选课时间是否符合要求
            //判断选课时间是否符合
            if (!(DateTime.Now>temp1 && DateTime.Now < temp2))
            {
                MessageBox.Show("未到选课时间段！"+"\n"+ UserInfo.choosedate_start + "\n至\n"+ UserInfo.choosedate_end, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion


            // 获取dgv的列数
            string[] str = new string[dgvStuChooseCourse.ColumnCount];
            // 获取当前datagridview选择的行
            int index = dgvStuChooseCourse.CurrentRow.Index;
            // 获取该行全部数据存入str中
            for (int i = 0; i < dgvStuChooseCourse.ColumnCount; i++)
            {
                str[i] = dgvStuChooseCourse.Rows[index].Cells[i].Value.ToString();
            }
            // 选课信息提示
            DialogResult result = MessageBox.Show("确认选择该授课?", "tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)  // 确认选课
            {

                #region 判断选课是否冲突：条件->时间
                MysqlHelper mysql = new MysqlHelper();
                //判断选课时间段是否和已选冲突
 
                string sql = "select date_time from studytable a, teachtable b where uid = '"+ UserInfo.uid+"' and a.skid = b.skid;";
                MySqlDataReader reader = mysql.ExecuteReader(sql);
                while (reader.Read())  // 遍历该用户全部选课
                {
                    if (str[7].Trim().Equals(reader.GetString("date_time").ToString()))      // 判断时间是否冲突
                    {
                        MessageBox.Show("时间与已选课程冲突！");
                        return;
                    }
                }
                #endregion

                #region 对数据库增操作：添加选课记录
                //选课操作
                sql = "insert into studytable values (@skid, @uid)";
                MySqlParameter[] paras = {
                    new MySqlParameter("@uid", UserInfo.uid),
                    new MySqlParameter("@skid", str[0]),
                };
                try
                {
                    if (mysql.ExecuteNonQuery(sql, paras) > 0)
                    {
                        MessageBox.Show("选课成功！");
                        init_dgvStuChoosecourse();          // 更新dgv
                        return;
                    }
                    else
                    {
                        MessageBox.Show("选课失败！");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("选课失败！");
                    return;
                }
                Application.ExitThread();   //解决消息循环
                #endregion
            }
            else                             // 取消选课
            {
                return;
            }
        }
        



    }
}
