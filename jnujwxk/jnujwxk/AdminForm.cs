using System;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class AdminForm : Form
    {
        // 管理员主界面
        public AdminForm()
        {
            InitializeComponent();
            // 填充问候语的text
            this.Namelabel.Text = UserInfo.uid;
        }

        #region 关闭窗体功能完善
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)    // 关闭窗体提醒
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


        #region 登出功能
        private void ExitBtn_Click(object sender, EventArgs e) // 登出按钮功能完善
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

        #region 清空子窗口
        private void pictureBox1_Click(object sender, EventArgs e)      // 点击暨大logo
        {
            if (activeform != null)
                activeform.Close();
        }
        #endregion

        #region 各种子窗口

        #region 修改密码
        private void PWDBtn_Click(object sender, EventArgs e)
        {
            open_childform(new SubChangePWDForm());           // 修改密码子窗口
        }
        #endregion

        #region 添加用户
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            open_childform(new AddUserForm());               // 添加用户按钮子窗口
        }
        #endregion

        #region 用户管理
        private void UserBtn_Click(object sender, EventArgs e)
        {
            open_childform(new UserInfoForm());              // 用户管理子窗口
        }
        #endregion

        #region 课程信息管理
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            open_childform(new CourseInfoForm());            // 课程信息管理子窗口
        }
        #endregion

        #region 应用信息查看
        private void ChartBtn_Click_1(object sender, EventArgs e)
        {
            open_childform(new ChartForm());                // 图表：应用信息子窗口
        }
        #endregion

        #endregion


        #region github功能
        private void GithubBtn_Click(object sender, EventArgs e)         // 跳转到我的github
        {
            //小github logo：跳转到我的github
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge.exe", "https://github.com/biabuluo");

        }
        #endregion
    }
}
