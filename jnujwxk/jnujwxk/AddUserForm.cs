using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Web.Security;

namespace jnujwxk
{
    public partial class AddUserForm : Form
    {
        // admin权限：添加用户子窗口

        public AddUserForm()
        {
            InitializeComponent();
        }

        private String md5(String str)   // MD5
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(str, "md5");
        }

        private void clear()    // 清空全部输入框
        { 
            this.IDBox.Text = "";
            this.NameBox.Text = "";
            this.SexBox.Text = "";
            this.MajorBox.Text = "";
            this.TitleBox.Text = "";
        }

        #region 选择框选择功能：学生/老师显示不同输入
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 选择学生框改变
            if (checkBox1.CheckState == CheckState.Checked)  // 选择为学生
            {
                if(checkBox2.CheckState== CheckState.Checked) // 教师选择框为unchecked
                {
                    checkBox2.CheckState = CheckState.Unchecked;
                }
                // 显示需要显示的功能：职称框关闭/专业框显示
                this.label6.Visible = false;     
                this.TitleBox.Visible = false;
                this.label5.Text = "*专业：";
                this.label5.Visible = true;
                this.MajorBox.Visible = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // 选择教师框改变
            if (checkBox2.CheckState == CheckState.Checked)  // 选择为教师
            {
                if (checkBox1.CheckState == CheckState.Checked)  // 学生选择框为unchecked
                {
                    checkBox1.CheckState = CheckState.Unchecked;
                }
                // 显示需要显示的共能：职称框+学院框
                this.label6.Visible = true;
                this.TitleBox.Visible = true;
                this.label5.Text = "*学院：";
                this.label5.Visible = true;
                this.MajorBox.Visible = true;
            }
        }
        #endregion


        #region 添加用户功能实现
        private void AddBtn_Click(object sender, EventArgs e)//添加用户，对各种错误情况纠正
        {
            #region 信息错误提示
            if (IDBox.Text == "" || NameBox.Text == "")   // 姓名id均为空时提示错误
            {
                MessageBox.Show("星号信息不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.clear();
                return;
            }
            if (this.checkBox1.CheckState == CheckState.Unchecked && this.checkBox2.CheckState == CheckState.Unchecked)
            {
                MessageBox.Show("请选择用户身份！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.clear();
                return;
            }
            #endregion


            if (this.checkBox1.CheckState == CheckState.Checked)//学生时
            {
                #region 为学生时的错误提示+id用正则表达式识别
                if (MajorBox.Text == "")
                {
                    MessageBox.Show("星号信息不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Regex uid = new Regex(@"2020101[0-9]{3}");   //正则判断uid格式：2020101...
                if (!uid.IsMatch(IDBox.Text))
                {
                    MessageBox.Show("编号格式不正确！");
                    return;
                }
                #endregion

                #region 调用mysql，添加学生用户
                MysqlHelper mysql = new MysqlHelper();
                string sql1 = "insert into userlist values('"+IDBox.Text+"','"+md5(IDBox.Text)+"','0');";//默认密码为用户名，权限为学生
                string sql2 = "insert into studentlist values('" + IDBox.Text + "','" + NameBox.Text + "','" + SexBox.Text + "','" + MajorBox.Text + "');";
                try
                {
                    int result1 = mysql.ExecuteNonQuery(sql1);
                    int result2 = mysql.ExecuteNonQuery(sql2);
                    if (result1 > 0 && result2>0)
                    {
                        MessageBox.Show("添加成功", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("添加失败", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion


            }
            else//老师时
            {
                #region 教师信息错误提示+正则表达式识别
                if (MajorBox.Text == ""|| TitleBox.Text == "")
                {
                    MessageBox.Show("星号信息不能为空！", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Regex uid = new Regex(@"[0-9]{3}");   //正则判断uid格式：00...
                if (!uid.IsMatch(IDBox.Text))
                {
                    MessageBox.Show("编号格式不正确！");
                    return;
                }
                #endregion

                #region 调用mysql，添加教师用户
                MysqlHelper mysql = new MysqlHelper();
                string sql1 = "insert into userlist values('" + IDBox.Text + "','" + md5(IDBox.Text) + "','1');";//默认密码用户名，权限为教师权限
                string sql2 = "insert into teacherlist values('" + IDBox.Text + "','" + NameBox.Text + "','" + SexBox.Text + "','" + MajorBox.Text + "','" + TitleBox.Text+"');";
                try
                {
                    int result1 = mysql.ExecuteNonQuery(sql1);
                    int result2 = mysql.ExecuteNonQuery(sql2);
                    if (result1 > 0 && result2 > 0)
                    {
                        MessageBox.Show("添加成功", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.clear();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加失败", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加失败", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion
            }
        }
        #endregion


    }
}
