using System;
using System.Windows.Forms;
using System.Web.Security;

namespace jnujwxk
{
    public partial class SubChangePWDForm : Form
    {
        // 修改用户密码子窗口
        public SubChangePWDForm()
        {
            InitializeComponent();
        }

        private String md5(String str)   // MD5加密函数
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
        }

        #region 修改密码按钮功能
        private void YesBtn_Click(object sender, EventArgs e) //确认修改密码按钮
        {

            #region 错误信息提示
            if (this.NewPWDtextBox1.Text == "")      // 修改密码未填入
            {
                MessageBox.Show("请输入要更改的密码！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.NewPWDtextBox1.Text != this.NewPWDtextBox2.Text)    // 两次密码不一致错误
            {
                MessageBox.Show("两次密码不一致！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // 同时清空密码框
                this.NewPWDtextBox1.Text = "";
                this.NewPWDtextBox2.Text = "";
                return;
            }
            #endregion

            #region 提交数据库
            // 输入修改密码无误后，提交到数据库修改
            MysqlHelper mysql = new MysqlHelper();
            string sql = "update userlist set pwd = '" +md5(this.NewPWDtextBox2.Text)+"' where uid = '"+UserInfo.uid +"';";
            try
            {
                int result = mysql.ExecuteNonQuery(sql);     // 返回修改数据行数
                if (result > 0)
                {
                    MessageBox.Show("修改成功！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 同时清空数据
                    this.NewPWDtextBox1.Text = "";
                    this.NewPWDtextBox2.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch(Exception ex)       // 出错提示
            {
                MessageBox.Show("修改失败！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            #endregion
        }
        #endregion

    }
}
