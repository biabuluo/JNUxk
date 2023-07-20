using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class UserInfoForm : Form
    {
        // 用户管理编辑子窗口

        public UserInfoForm()
        {
            InitializeComponent();
        }

        #region 初始化dgv(dgvuserInfo)
        public void init_dgv()
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            if (checkBox1.CheckState == CheckState.Checked)   // 选择为教师时
            {
                sql = "select uid 教师编号, teaname 教师姓名, sex 性别, college 学院, title 职称 from teacherlist;";
                DataTable dt_teacherlist = mysql.GetDataTable(sql);
                dgvuserInfo.DataSource = dt_teacherlist;
            }
            else                                              // 选择为学生时
            {
                sql = "select uid 学生编号, stuname 学生姓名, sex 性别, major 专业 from studentlist;";
                DataTable dt_teacherlist = mysql.GetDataTable(sql);
                dgvuserInfo.DataSource = dt_teacherlist;
            }
        }

        private void UserInfoForm_Load(object sender, EventArgs e) //加载教师表或者学生表
        {
            init_dgv();
        }
        #endregion


        #region 选择框变化时更新dgv
        private void checkBox1_CheckedChanged(object sender, EventArgs e)//当选择框变化时
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            if (checkBox1.CheckState == CheckState.Checked)   // 显示为教师用户dgv
            {
                // mysql中拉取数据
                sql = "select uid 教师编号, teaname 教师姓名, sex 性别, college 学院, title 职称 from teacherlist;";
                DataTable dt_teacherlist = mysql.GetDataTable(sql);
                dgvuserInfo.DataSource = dt_teacherlist;
            }
            else                                              // 显示为学生用户dgv
            {
                // mysql中拉取数据
                sql = "select uid 学生编号, stuname 学生姓名, sex 性别, major 专业 from studentlist;";
                DataTable dt_teacherlist = mysql.GetDataTable(sql);
                dgvuserInfo.DataSource = dt_teacherlist;
            }
        }
        #endregion


        #region 查询功能完善
        private void SearchBtn_Click(object sender, EventArgs e)     // 当搜索按钮点击时
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            if (checkBox1.CheckState == CheckState.Checked)          // 查询为教师+支持id模糊查询
            {
                sql = "select uid 教师编号, teaname 教师姓名, sex 性别, college 学院, title 职称 from teacherlist where uid like '%"+IDbox.Text+"%';";
                DataTable dt_teacherlist = mysql.GetDataTable(sql);
                dgvuserInfo.DataSource = dt_teacherlist;
            }
            else                                                     // 查询为学生+支持id模糊查询
            {
                sql = "select uid 学生编号, stuname 学生姓名, sex 性别, major 专业 from studentlist where uid like '%" + IDbox.Text + "%';";
                DataTable dt_teacherlist = mysql.GetDataTable(sql);
                dgvuserInfo.DataSource = dt_teacherlist;
            }
            this.IDbox.Text = "";
        }
        #endregion


        #region 编辑用户信息
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)//右键编辑信息
        {
            #region 获取dgv选择行数据
            // 获取dgv列数
            string[] str = new string[dgvuserInfo.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());
            // 获取选取行下标
            int index = dgvuserInfo.CurrentRow.Index;
            // 复制所有该行信息->str
            for (int i=0; i < dgvuserInfo.ColumnCount; i++)
            {
                str[i]=dgvuserInfo.Rows[index].Cells[i].Value.ToString();
            }
            #endregion

            if(checkBox1.CheckState == CheckState.Checked)     // 修改教师信息
            {
                EditUserForm edit = new EditUserForm(1, str);   // 打开子窗口（编辑用户信息窗口）
                edit.setParentform(this);                 
                edit.Show();
            }
            else                                               // 修改学生信息
            {
                EditUserForm edit = new EditUserForm(0, str);   // 打开子窗口（编辑用户信息窗口）
                edit.setParentform(this);
                edit.Show();
            }

            /*
            string totalltest = "";
            for(int i = 0; i < dgvuserInfo.ColumnCount; i++)
            {
                totalltest += str[i];
            }
            MessageBox.Show(totalltest);*/ //测试
        }
        #endregion


        private void UserInfoForm_Click(object sender, EventArgs e)//假假的刷新一下 ----测试用（我就不删除了）
        {
            UserInfoForm_Load(sender, e);
        }

        #region 删除用户信息
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region 获取dgv选择行数据
            // 获取dgv列数
            string[] str = new string[dgvuserInfo.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());
            // 获取选取行下标
            int index = dgvuserInfo.CurrentRow.Index;
            // 复制所有该行信息->str
            for (int i = 0; i < dgvuserInfo.ColumnCount; i++)
            {
                str[i] = dgvuserInfo.Rows[index].Cells[i].Value.ToString();
            }
            #endregion

            // 删除用户信息
            string sql = "delete from userlist where uid = '" + str[0] +"';";
            MySqlParameter[] paras =
            {
                new MySqlParameter("uid", str[0])
            };
            DialogResult result =  MessageBox.Show("确认删除用户？（用户所有信息都将删除）","Info",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if(result == DialogResult.OK)  // 确认删除
            {
                MysqlHelper mysql = new MysqlHelper();
                if (mysql.ExecuteNonQuery(sql, paras) > 0)
                {
                    MessageBox.Show("成功删除！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.init_dgv();
                }
                else
                {
                    MessageBox.Show("删除失败！", "tips", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else{
                return;
            }



        }
        #endregion
    }
}
