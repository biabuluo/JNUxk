using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class EditUserForm : Form
    {
        // 编辑用户信息子窗口
        private string uid;  // 存储用户id
        private int isSelect; // 是否为教师？0->学生/1->教师
        private UserInfoForm parentForm;  // 父窗口引用
        public void setParentform(UserInfoForm parent)  // 设置父窗口函数，用于父窗口调用设置
        {
            parentForm = parent;
        }

        #region 构造器
        public EditUserForm(int isSelect, string[] info )  // 编辑子窗口构造器
        {
            InitializeComponent();
            this.uid = info[0];//保存必要信息：uid+是否是教师
            this.isSelect = isSelect;
            if (isSelect == 1)  //教师修改
            {
                DeptLabel.Text = "学院：";
                Titlelabel.Visible = true;
                textBox4.Visible = true;
                textBox1.Text = info[1];
                textBox2.Text = info[2];
                textBox3.Text = info[3];
                textBox4.Text = info[4];
            }
            else   //学生修改
            {
                DeptLabel.Text = "专业：";
                Titlelabel.Visible = false;
                textBox4.Visible = false;
                textBox1.Text = info[1];
                textBox2.Text = info[2];
                textBox3.Text = info[3];
            }
        }
        #endregion


        #region 确认编辑
        private void EditForSure_Click(object sender, EventArgs e)   // 点击编辑
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            if (isSelect == 1) //教师表更新
            {
                #region 教师信息更新
                sql = "update teacherlist set teaname = @teachername, sex = @sex, college = @college, title = @title where uid = @uid";
                MySqlParameter[] paras =
                {
                    new MySqlParameter("@teachername",textBox1.Text),
                    new MySqlParameter("@sex", textBox2.Text),
                    new MySqlParameter("@college", textBox3.Text),
                    new MySqlParameter("@title", textBox4.Text),
                    new MySqlParameter("@uid", this.uid),
                };

                /*cmd.Parameters.AddWithValue("@teachername",textBox1.Text);
                cmd.Parameters.AddWithValue("@sex", textBox2.Text);
                cmd.Parameters.AddWithValue("@college", textBox3.Text);
                cmd.Parameters.AddWithValue("@title", textBox4.Text);
                cmd.Parameters.AddWithValue("@uid", this.uid);*/
                //打开连接
                //执行命令
                try
                {
                    if (mysql.ExecuteNonQuery(sql, paras) > 0)
                    {
                        MessageBox.Show("修改成功！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        parentForm.init_dgv();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("修改失败1！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //关闭连接  mysql自动关闭
                //处理结果*/
                #endregion
            }
            else
            {
                #region 学生更新
                sql = "update studentlist set stuname = @stuname, sex = @sex, major = @major where uid = @uid";
                MySqlParameter[] paras =
                {
                    new MySqlParameter("@stuname", textBox1.Text),
                    new MySqlParameter("@sex", textBox2.Text),
                    new MySqlParameter("@major", textBox3.Text),
                    new MySqlParameter("@uid", this.uid),
                };
                /*cmd.Parameters.AddWithValue("@stuname", textBox1.Text);
                cmd.Parameters.AddWithValue("@sex", textBox2.Text);
                cmd.Parameters.AddWithValue("@major", textBox3.Text);
                cmd.Parameters.AddWithValue("@uid", this.uid);*/

                //执行命令
                try
                {
                    if (mysql.ExecuteNonQuery(sql, paras) > 0)
                    {
                        MessageBox.Show("修改成功！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        parentForm.init_dgv();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改失败！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改失败！", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //关闭连接  mysql自动关闭
                //处理结果
                #endregion
            }
        }
        #endregion


    }
}
