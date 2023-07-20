using MySql.Data.MySqlClient;
using System;
using System.Web.Security;
using System.Windows.Forms;

namespace jnujwxk
{
    //登陆窗体
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e) // 退出应用
        {
            // 应用退出按键
            Application.Exit();
        }

        private String md5(String str)   // md5加密函数
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
        }

        private void LoginBtn_Click(object sender, EventArgs e)//完善登陆功能
        {
            // 获取textbox的字符串
            string uid = IDTextBox.Text;
            string pwd = PWDTextBox.Text;

            #region error tips
            // 信息错误提示
            if (uid == "")
            {
                MessageBox.Show("账号为空！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(pwd == "")
            {
                MessageBox.Show("密码为空！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // 清空textbox
                this.IDTextBox.Text = "";
                this.PWDTextBox.Text = ""; 
                return;
            }
            #endregion

            #region 比对账号信息
            // 账号密码信息查找比对
            //string sql = "select count(*) from userlist where uid = '" + uid + "'and pwd = '" + pwd + "';";
            //MysqlHelper mysql = new MysqlHelper();
            //Object o =  mysql.ExecuteScalar(sql);
            //if (o == null || o == DBNull.Value || (Int64)o ==0)
            //{
            //    MessageBox.Show("账号信息有误！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.IDTextBox.Text = "";
            //    this.PWDTextBox.Text = "";
            //    return;
            //}
            //MessageBox.Show("登陆成功！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //UserInfo.init_info();   //清除数据


            // 使用参数化sql：防止注入攻击
            string sql = "select count(*) from userlist where uid = @uid and pwd = @pwd;";
            MySqlParameter[] paras =
            {
                new MySqlParameter("uid", uid),
                new MySqlParameter("pwd", md5(pwd))
            };
            MysqlHelper mysql = new MysqlHelper();
            Object o = mysql.ExecuteScalar(sql, paras);
            // 错误处理
            if (o == null || o == DBNull.Value || (Int64)o == 0)
            {
                MessageBox.Show("账号信息有误！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.IDTextBox.Text = "";
                this.PWDTextBox.Text = "";
                return;
            }
            MessageBox.Show("登陆成功！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UserInfo.init_info();   //清除数据
            #endregion

            #region 获取账号等必要信息
            // 登陆成功-> 获取用户权限和必要信息，存储到userinfo全局类中
            sql = "select identity from userlist where uid = '" + uid + "';";
            
            try
            {
                Object identity = mysql.ExecuteScalar(sql);  //获取权限
                UserInfo.uid = uid;
                UserInfo.identity = (int)identity;
                //获取必要选课安排日期
                UserInfo.process_date();
            }catch(Exception ex)   // 错误处理
            {
                MessageBox.Show("蛋糕了！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region 根据用户权限跳转相应窗口:学生/教师/admin
            //根据获取权限跳转相应窗口
            if (UserInfo.identity == 0)
            {
                StuForm userform = new StuForm();
                //MessageBox.Show(UserInfo.identity.ToString());测试
                userform.Show();             // 学生窗口主界面
                this.Hide();
            }
            else if (UserInfo.identity == 1)
            {
                TeacherForm teacherform = new TeacherForm();
                teacherform.Show();          // 教师窗口主界面
                this.Hide();
            }
            else if(UserInfo.identity == 2)
            {
                AdminForm adminform = new AdminForm();
                adminform.Show();             // admin主界面
                this.Hide();
            }
            /*
            else          // 错误处理
            {
                MessageBox.Show("蛋糕了！", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            #endregion
        }


        #region 应用体验优化
        private void IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)   //键入enter时聚焦密码框
            {
                PWDTextBox.Focus();
            }
        }

        private void PWDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)   //键入enter时登陆
            {
                this.LoginBtn_Click(LoginBtn, e);
            }
        }

        private void login_activate(object sender, EventArgs e)
        {
            IDTextBox.Focus();     //聚焦用户账号框
        }
        #endregion
    }
}
