using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class EditCourseForm1 : Form
    {
        // 编辑课程信息窗口

        private CourseInfoForm parent;   // 父窗口引用

        public void setparent(CourseInfoForm parent) // 父窗口调用设置引用
        {
            this.parent = parent;
        }

        private string cid;          // 课程id

        #region 构造器
        // 窗口构造器
        public EditCourseForm1(string[] Info)
        {
            InitializeComponent();
            // 填充必要信息
            this.CourseNameBox.Text = Info[1];
            this.PointsBox.Text = Info[2];
            this.cid = Info[0];
        }
        #endregion

        #region 修改课程信息功能
        private void SureBtn_Click(object sender, EventArgs e)  //确认修改
        {
            #region 学分明细不是数字错误提示
            try
            {
                int temp = int.Parse(PointsBox.Text); // string->int
            }
            catch (Exception ex)
            {
                MessageBox.Show("学分明细得是数字！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }                                 //当学分不是数字时报错
            #endregion

            #region 调用mysql修改课程信息
            MysqlHelper mysql = new MysqlHelper();
            string sql = "update courselist set cname = @cname, points = @points where cid = @cid";
            MySqlParameter[] paras =
            {
                new MySqlParameter("@cname",CourseNameBox.Text.Trim()),
                new MySqlParameter("@points",PointsBox.Text.Trim()),
                new MySqlParameter("@cid",cid),
            };

            
            try
            {
                if (mysql.ExecuteNonQuery(sql, paras)>0)
                {
                    MessageBox.Show("修改成功！","tips",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    parent.init();   // 父窗口初始化
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("修改失败！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }
        #endregion


    }
}
