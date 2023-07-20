using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class AddCourseForm : Form
    {
        // 添加课程子窗口

        private CourseInfoForm parent;   // 父窗口引用

        public void setparent(CourseInfoForm parent) // 父窗口调用设置引用
        {
            this.parent = parent;
        }


        public AddCourseForm()
        {
            InitializeComponent();
        }

        #region 确认添加功能
        private void SureBtn_Click(object sender, EventArgs e)   // 点击确认添加时
        {
            #region 信息为空提示
            if (CidtextBox.Text == "" || CnametextBox.Text == "" || CpointstextBox.Text == "")
            {
                MessageBox.Show("必要信息不能为空！");
                return;
            }
            #endregion

            #region 正则表达式判断cid
            //使用正则表达式判断cid是否满足c***
            Regex cid_regex = new Regex(@"c[0-9]{3}");
            if (!cid_regex.IsMatch(CidtextBox.Text))
            {
                MessageBox.Show("课程编号格式不正确!");
                return;
            }
            #endregion

            #region 调用mysql添加课程信息
            MysqlHelper mysql = new MysqlHelper();
            string sql = "insert into courselist values (@cid, @cname, @cpoints);";
            MySqlParameter[] paras={
                new MySqlParameter("@cid", CidtextBox.Text.Trim()),
                new MySqlParameter("@cname", CnametextBox.Text.Trim()),
                new MySqlParameter("@cpoints", CpointstextBox.Text.Trim()),
            };
            try
            {
                if (mysql.ExecuteNonQuery(sql, paras)>0)
                {
                    MessageBox.Show("添加成功！");
                    parent.init();      // 父窗口初始化
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("添加失败！");
            }
            #endregion

        }
        #endregion


    }
}
