using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace jnujwxk
{
    public partial class CourseInfoForm : Form
    {
        public CourseInfoForm()
        {
            InitializeComponent();
        }
        #region 加载数据初始化函数
        public void init()
        {
            init_dgvcourselist();//加载课程信息
            init_combobox();//加载下拉框选项
            init_dgvteachtable();//加载授课信息
        }
        public void init_dgvteachtable()//加载授课信息
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            sql = "select skid 授课编号, cid 课程编号, cname 课程名称, tid 教师编号,teaname 教师姓名, location 授课地址, date_time 授课时间, stunum 选课人数 from allteach_view;";
            DataTable dt_teachtble = mysql.GetDataTable(sql);
            dgvteachtable.DataSource = dt_teachtble;
        }
        public void init_dgvcourselist()//加载课程信息
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            sql = "select cid 课程编号, cname 课程名称, points 学分 from courselist;";
            DataTable dt_courselist = mysql.GetDataTable(sql);
            dgvCourselist.DataSource = dt_courselist;
        }
        public void init_combobox()//加载下拉选择框
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            sql = "select cid 课程编号, cname 课程名称 from courselist;";
            DataTable dt_courselist = mysql.GetDataTable(sql);
            //新添加一个选项：空
            DataRow nothing = dt_courselist.NewRow();
            nothing["课程名称"] = "空";
            nothing["课程编号"] = "-1";
            dt_courselist.Rows.InsertAt(nothing,0);  //添加 默认选择空
            comboBox1.DataSource = dt_courselist;
            //显示和值一一绑定
            comboBox1.DisplayMember = "课程名称";
            comboBox1.ValueMember = "课程编号";
            //默认选择空
            comboBox1.SelectedIndex = 0;

        }
        #endregion

        private void CourseInfoForm_Load(object sender, EventArgs e)  //打开窗口时初始化
        {
            init();
        }


        #region 搜索功能实现
        private void SearchCourseBtn_Click(object sender, EventArgs e)//搜索课程信息
        {
            if (CidTextBox.Text=="") //为空时默认显示所有信息
            {
                init_dgvcourselist();
            }
            else
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql;
                sql = "select cid 课程编号, cname 课程名称, points 学分 from courselist where cid like '%" + CidTextBox.Text + "%';"; //支持模糊查询
                DataTable dt_courselist = mysql.GetDataTable(sql);
                dgvCourselist.DataSource = dt_courselist;
            }
        }

        private void SearchTeachBtn_Click(object sender, EventArgs e)//搜索授课信息
        {
            string comboselected = comboBox1.SelectedValue.ToString();
            if (TeanameTextBox.Text == "" && comboBox1.SelectedIndex == 0) //为空时默认显示所有信息
            {
                init_dgvteachtable();
            }
            else if (TeanameTextBox.Text == "" && comboBox1.SelectedIndex != 0) // combobox内容不为空时
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql;
                sql = "select skid 授课编号, cid 课程编号, cname 课程名称, tid 教师编号,teaname 教师姓名, location 授课地址, date_time 授课时间, stunum 选课人数 from allteach_view where cid = '" + comboselected + "';";
                DataTable dt_teachtble = mysql.GetDataTable(sql);
                dgvteachtable.DataSource = dt_teachtble;
            }
            else if (TeanameTextBox.Text != "" && comboBox1.SelectedIndex == 0) // 教师名不为空时
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql;
                sql = "select skid 授课编号, cid 课程编号, cname 课程名称, tid 教师编号,teaname 教师姓名, location 授课地址, date_time 授课时间, stunum 选课人数 from allteach_view where teaname like '%" + TeanameTextBox.Text.Trim() + "%';";
                DataTable dt_teachtble = mysql.GetDataTable(sql);
                dgvteachtable.DataSource = dt_teachtble;
            }
            else     // 均不为空时
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql;
                sql = "select skid 授课编号, cid 课程编号, cname 课程名称, tid 教师编号,teaname 教师姓名, location 授课地址, date_time 授课时间, stunum 选课人数 from allteach_view where  cid = '" + comboselected + "' and teaname like '%" + TeanameTextBox.Text.Trim() + "%';";
                DataTable dt_teachtble = mysql.GetDataTable(sql);
                dgvteachtable.DataSource = dt_teachtble;
            }

        }
        #endregion




        #region 授课信息管理


        #region 修改授课信息
        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)  // 修改授课信息
        {
            //获取该行全部数据
            string[] info = new string[dgvteachtable.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());
            int index = dgvteachtable.CurrentRow.Index;
            for (int i = 0; i < dgvteachtable.ColumnCount; i++)
            {
                info[i] = dgvteachtable.Rows[index].Cells[i].Value.ToString();
            }
            // 将数据提交给edit子窗口处理
            EditTeachForm editform = new EditTeachForm(info);
            // 传递引用
            editform.setparent(this);
            editform.Show();
        }
        #endregion


        #region 添加授课信息
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)  // 添加授课信息
        {
            AddTeachForm addform = new AddTeachForm();
            addform.setparent(this);
            addform.Show();
        }
        #endregion


        #region 删除授课信息
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)  // 删除授课信息
        {
            #region 获取dgv该行的全部信息
            string[] str = new string[dgvteachtable.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());

            int index = dgvteachtable.CurrentRow.Index;
            for (int i = 0; i < dgvteachtable.ColumnCount; i++)
            {
                str[i] = dgvteachtable.Rows[index].Cells[i].Value.ToString();
            }
            #endregion

            #region 调用mysql删除授课信息（数据库中 级联删除）
            DialogResult result = MessageBox.Show("确认删除该授课?", "tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)  // 确认删除
            {
                #region 确认删除
                MysqlHelper mysql = new MysqlHelper();
                string sql = "delete from teachtable where skid = @skid";
                MySqlParameter[] paras = { 
                    new MySqlParameter("@skid", str[0])
                };
                try
                {
                    if (mysql.ExecuteNonQuery(sql, paras) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        init();       // 初始化更新
                        return;
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败！");
                    return;
                }
                Application.ExitThread();   //解决消息循环
                #endregion

            }
            else  // 取消删除
            {
                return;
            }
            #endregion
        }
        #endregion



        #endregion


        #region 课程信息管理

        #region 课程信息修改
        private void 修改ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string[] str = new string[dgvCourselist.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());

            int index = dgvCourselist.CurrentRow.Index;
            for (int i = 0; i < dgvCourselist.ColumnCount; i++)
            {
                str[i] = dgvCourselist.Rows[index].Cells[i].Value.ToString();
            }                                                                   //获取信息 传入editform
            EditCourseForm1 editform = new EditCourseForm1(str);
            editform.setparent(this);
            editform.Show();
        }
        #endregion


        #region 添加课程信息
        private void 添加ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // 调用添加课程子窗口完成
            AddCourseForm addform = new AddCourseForm();
            addform.setparent(this);
            addform.Show();
        }
        #endregion


        #region 删除课程信息
        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            #region 获取该课程全部信息
            string[] str = new string[dgvCourselist.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());
            // 获取dgv当前选择的行信息
            int index = dgvCourselist.CurrentRow.Index;
            for (int i = 0; i < dgvCourselist.ColumnCount; i++)
            {
                str[i] = dgvCourselist.Rows[index].Cells[i].Value.ToString();
            }
            #endregion


            DialogResult result = MessageBox.Show("确认删除课程："+str[1]+"?", "tips", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                #region 确认删除（调用mysql删除信息）
                MysqlHelper mysql = new MysqlHelper();
                string sql = "delete from courselist where cid = @cid";
                MySqlParameter[] paras = { new MySqlParameter("@cid", str[0]) };
                try
                {
                    if(mysql.ExecuteNonQuery(sql, paras) > 0)
                    {
                        MessageBox.Show("删除成功！");
                        init();    // 初始化（刷新）
                        return;
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("删除失败！");
                    return;
                }
                Application.ExitThread();   //解决消息循环
                #endregion
            }
            else  // 取消删除
            {
                return;
            }
        }

        #endregion

        #endregion


        #region 导出水晶报表形式的学生名单
        private void 导出学生名单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*水晶报表形式*/
            /* 获取该行所有数据; 授课编号， 课程编号，课程名称， 教师编号， 教师姓名， 授课地址， 授课时间， 选课人数 */
            string[] info = new string[dgvteachtable.ColumnCount];
            //MessageBox.Show(dgvuserInfo.ColumnCount.ToString());
            int index = dgvteachtable.CurrentRow.Index;
            for (int i = 0; i < dgvteachtable.ColumnCount; i++)
            {
                info[i] = dgvteachtable.Rows[index].Cells[i].Value.ToString();
            }
            /*    调试
            String temp2 = "";
            foreach(String temp in info)
            {
                temp2 += temp + " ";
            }
            MessageBox.Show(temp2);
            */

            /* 提交mysql获取数据，构造数据集 dataset */

            String sql = "select uid 学生编号, stuname 学生姓名, sex 性别, major 专业 from allstudy_view where skid ='" + info[0] +"';";
            /*提交mysql获取dataset*/
            MysqlHelper mysql = new MysqlHelper();
            DataTable stutable = new DataTable();
            stutable = mysql.GetDataTable(sql);

            /* 测试
            String temp = stutable.Rows.Count.ToString()+"  "+stutable.Columns.Count.ToString();
            MessageBox.Show(temp);
            */

            /*打开水晶报表窗口*/
            CrystalReportForm mycrystal = new CrystalReportForm(stutable, info[2], info[4], info[5], info[6], info[7]);
            mycrystal.Show();
        }
        #endregion
    }
}
