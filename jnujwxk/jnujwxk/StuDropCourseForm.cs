using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class StuDropCourseForm : Form
    {
        // 学生退选子窗口
        public StuDropCourseForm()
        {
            InitializeComponent();
        }

        #region 初始化dgv
        private void init_dgvStuDropCourse()   // 初始化dgv
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql = "select a.skid 授课编号, b.cid 课程编号, cname 课程名称, points 学分, b.tid 教师编号, teaname 教师名称, location 授课地点, date_time 授课时间 from studytable a, allteach_view b\r\nwhere a.uid = '" + UserInfo.uid+"' and a.skid = b.skid;";
            DataTable dt_allchooselist = mysql.GetDataTable(sql);
            // 调用数据库数据填充dgv
            dgvStuDropCourse.DataSource = dt_allchooselist;
        }
        #endregion

        private void StuDropCourseForm_Load(object sender, EventArgs e) 
        {
            // 当子窗口打开时，初始化dgv
            init_dgvStuDropCourse();
        }


        #region 搜索功能完善
        private void SearchBtn_Click(object sender, EventArgs e)       // 搜索按钮点击后+模糊搜索
        {
            //条件均为空时显示全部信息
            if (CourseNameBox.Text == "" && TeacherNameBox.Text == "")
            {
                // 初始化dgv
                init_dgvStuDropCourse();
            }
            //课程信息不为空时
            else if (CourseNameBox.Text != "" && TeacherNameBox.Text == "") // 课程名称不为空
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid 授课编号, b.cid 课程编号, cname 课程名称, points 学分, b.tid 教师编号, teaname 教师名称, location 授课地点, date_time 授课时间 from studytable a, allteach_view b where a.uid = '"+UserInfo.uid+"' and a.skid = b.skid and cname like '%"+CourseNameBox.Text.Trim() +"%';";
                DataTable dt_mystudylist = mysql.GetDataTable(sql);
                dgvStuDropCourse.DataSource = dt_mystudylist;
            }
            else if (CourseNameBox.Text == "" && TeacherNameBox.Text != "")  // 授课教师不为空
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid 授课编号, b.cid 课程编号, cname 课程名称, points 学分, b.tid 教师编号, teaname 教师名称, location 授课地点, date_time 授课时间 from studytable a, allteach_view b where a.uid = '" + UserInfo.uid+"' and a.skid = b.skid and teaname like '%"+ TeacherNameBox.Text.Trim() + "%';";
                DataTable dt_mystudylist = mysql.GetDataTable(sql);
                dgvStuDropCourse.DataSource = dt_mystudylist;
            }
            else if (CourseNameBox.Text != "" && TeacherNameBox.Text != "")  // 均不为空
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid 授课编号, b.cid 课程编号, cname 课程名称, points 学分, b.tid 教师编号, teaname 教师名称, location 授课地点, date_time 授课时间 from studytable a, allteach_view b where a.uid = '" + UserInfo.uid+"' and a.skid = b.skid and teaname like '%"+TeacherNameBox.Text.Trim() +"%' and cname like '%"+ CourseNameBox.Text.Trim()+"%';";
                DataTable dt_mystudylist = mysql.GetDataTable(sql);
                dgvStuDropCourse.DataSource = dt_mystudylist;
            }
        }
        #endregion


        #region 退选功能完善
        private void 退选ToolStripMenuItem_Click(object sender, EventArgs e)   // 退选功能:使用menustrip
        {
            #region 获取退课信息
            // 获取退课时间信息
            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy/MM/dd";
            DateTime temp1 = Convert.ToDateTime(UserInfo.changedate_start, dtFormat);
            DateTime temp2 = Convert.ToDateTime(UserInfo.changedate_end, dtFormat);
            #endregion

            #region 是否符合退课时间要求
            //判断退课时间是否符合
            if (!(DateTime.Now > temp1 && DateTime.Now < temp2))
            {
                MessageBox.Show("未到退课时间段！" + "\n" + UserInfo.changedate_start + "\n至\n" + UserInfo.changedate_end, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            // 获取dgv的列数
            string[] str = new string[dgvStuDropCourse.ColumnCount];
            // 获取当前选择的下标
            int index = dgvStuDropCourse.CurrentRow.Index;
            // 获取改行全部数据
            for (int i = 0; i < dgvStuDropCourse.ColumnCount; i++)
            {
                str[i] = dgvStuDropCourse.Rows[index].Cells[i].Value.ToString();
            }

            #region 退选信息提示
            // 开始退选
            DialogResult result = MessageBox.Show("确认退选该授课?", "tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)      // 确认退选
            {
                #region 提交数据库，确认退选
                MysqlHelper mysql = new MysqlHelper();
                string sql = "delete from studytable where uid = @uid and skid = @skid;";
                MySqlParameter[] paras =
                {
                    new MySqlParameter("@uid",UserInfo.uid),
                    new MySqlParameter("@skid",str[0]),

                };
                try
                {
                    if (mysql.ExecuteNonQuery(sql, paras)>0)   // 返回更改行数
                    {
                        MessageBox.Show("退选成功！");
                        init_dgvStuDropCourse();              // 更新dgv
                        return;
                    }
                    else   // 更改失败
                    {
                        MessageBox.Show("退选失败！");
                        return;
                    }
                }catch(Exception ex) // 更改失败
                {
                    MessageBox.Show("退选失败！");
                    return;
                }
                #endregion

            }
            else     // 取消退选
            {
                return;
            }
            #endregion

        }
        #endregion



    }
}
