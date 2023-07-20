using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class TeacherForm : Form
    {
        // 教师用户主界面
        public TeacherForm()
        {

            InitializeComponent();
            #region 用户信息+问候
            MysqlHelper mysql = new MysqlHelper();
            this.Uidlabel.Text = UserInfo.uid;
            string sql = "select teaname, title, college from teacherlist where uid = '" + UserInfo.uid + "';";
            MySqlDataReader reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                // 对text进行填充
                this.Namelabel.Text = reader.GetString("teaname");    // 教师名
                this.Titlelabel.Text = reader.GetString("title");     // 职称
                this.CollegeLabel.Text = reader.GetString("college"); // 学院
            }
            #endregion
        }

        #region 关闭窗体
        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确认退出?", "tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();   //解决消息循环
            }
            else
            {
                e.Cancel = true;   //事件体的一个值，为bool类型
            }
        }
        #endregion

        #region 登出按钮+登出功能完善
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已登出！", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm loginfrm = new LoginForm();
            loginfrm.Show();
            this.Hide();
        }
        #endregion

        #region 打开子窗口函数
        Form activeform = null;    //当前的子窗口
        private void open_childform(Form childform)
        {//打开子窗口函数
            if (activeform != null)
            {
                activeform.Close();    //关闭当前子窗口
            }
            activeform = childform;
            childform.TopLevel = false;   //设置为非顶级窗口，像控件一样
            childform.FormBorderStyle = FormBorderStyle.None; //去掉边框
            childform.Dock = DockStyle.Fill;   //填充
            MainPanel.Controls.Add(childform);  //将子窗体添加到容器里
            MainPanel.Tag = childform;  //关联子窗体
            childform.BringToFront();  //带到上层展示
            childform.Show();
        }
        #endregion

        #region 清空子窗体
        private void pictureBox1_Click(object sender, EventArgs e)   // 点击暨大logo清空子窗体
        {
            if (activeform != null)
                activeform.Close();
        }
        #endregion


        #region 各种子窗口

        #region 修改密码
        private void PWDBtn_Click(object sender, EventArgs e)
        {
            open_childform(new SubChangePWDForm());             // 打开修改密码子窗口
        }
        #endregion

        #region 课表
        private void SearchBut_Click(object sender, EventArgs e)
        {
            open_childform(new MyCoursesForm());               // 打开课表子窗口
        }
        #endregion

        #region 学生名单

        private void StuBtn_Click(object sender, EventArgs e)
        {
            open_childform(new StuList());                     // 打开学生名单子窗口
        }
        #endregion

        #endregion


        #region github按钮

        private void GithubBtn_Click(object sender, EventArgs e)       // github logo 跳转到我的github
        {
            //小github logo：跳转到我的github
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "https://github.com/biabuluo");

        }
        #endregion
    }
}
