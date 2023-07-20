using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class StuForm : Form
    {

        // 学生用户主界面
        public StuForm()
        {
            InitializeComponent();

            #region 用户信息+问候
            // 对主界面中的问候语+用户信息提示填充
            MysqlHelper mysql = new MysqlHelper();
            this.Uidlabel.Text = UserInfo.uid;
            string sql = "select stuname, major from studentlist where uid = '"+ UserInfo.uid+"';";
            MySqlDataReader reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                // 对主界面中的两个text赋值
                this.Namelabel.Text = reader.GetString("stuname");
                this.Majorlabel.Text = reader.GetString("major");
            }
            #endregion 
        }

        #region 关闭窗体
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)//关闭窗体
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
        private void ExitBtn_Click(object sender, EventArgs e)   //登出功能
        {
            MessageBox.Show("已登出！", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // 返回登陆界面
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

        #region 点击暨大logo清空子窗口
        private void pictureBox1_Click(object sender, EventArgs e) // 点击暨大logo清空子窗口
        {
            if (activeform != null)
                activeform.Close();
        }
        #endregion

        #region 各种子窗口功能


        #region 修改密码窗口
        private void UpdateBtn_Click(object sender, EventArgs e)   //修改密码
        {
            open_childform(new SubChangePWDForm());          // 打开修改密码子窗口
        }
        #endregion

        #region 课表窗口

        private void CourseBtn_Click(object sender, EventArgs e)  //课表功能
        {
            open_childform(new MyCoursesForm());             // 打开课表子窗口
        }
        #endregion

        #region 选课窗口

        private void ChooseBtn_Click(object sender, EventArgs e)   //选课功能
        {
            open_childform(new StuChooseCourseForm());       // 打开选课子窗口
        }
        #endregion

        #region 退课窗口

        private void DropBtn_Click(object sender, EventArgs e)     //退课功能
        {
            open_childform(new StuDropCourseForm());         // 打开退课子窗口
        }
        #endregion


        #endregion

        #region github logo:跳转到我的github 小彩蛋
        private void GithubBtn_Click(object sender, EventArgs e)
        {
            //小github logo：跳转到我的github
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "https://github.com/biabuluo");
        }
        #endregion
    }
}
