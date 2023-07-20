using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.Util;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class StuList : Form
    {
        // 教师权限的学生列表展示子窗口

        private DataTable dtlist;   // dgv(dgvstuList)关联的数据表
        public StuList()
        {
            InitializeComponent();
        }

        #region 初始化dgv（dgvstuList）
        private void init_stuList()  //初始化dgv
        {
            // 调用数据库获取数据
            MysqlHelper mysql = new MysqlHelper();
            string sql = "select a.skid 授课编号, a.cid 课程编号, b.cname 课程名称, uid 学号, stuname 姓名, sex 性别, major 专业 from allstudy_view a, courselist b where tid = '"+UserInfo.uid+"' and a.cid = b.cid";
            DataTable dt_stulist = mysql.GetDataTable(sql);
            dtlist = dt_stulist;
            // 填充dgv
            dgvstulist.DataSource = dt_stulist;
        }
        #endregion

        #region 初始化下拉选择框
        private void init_combobox()//加载下拉选择框
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            sql = "select skid 授课编号, cname 课程名称 from allteach_view where tid = '" + UserInfo.uid + "' ;";
            DataTable dt_courselist = mysql.GetDataTable(sql);
            //新添加一个选项：空
            DataRow nothing = dt_courselist.NewRow();
            nothing["课程名称"] = "空";
            nothing["授课编号"] = "-1";
            dt_courselist.Rows.InsertAt(nothing, 0);  //添加 默认选择空
            comboBox1.DataSource = dt_courselist;
            //显示和值一一绑定
            comboBox1.DisplayMember = "课程名称";
            comboBox1.ValueMember = "授课编号";
            //默认选择空
            comboBox1.SelectedIndex = 0;
        }
        #endregion


        private void stuList_Load(object sender, EventArgs e)  // 当该子窗口打开时
        {
            init_stuList();      // 初始化dgv（dgvstuList）
            init_combobox();     // 初始化combobox：包含教师的所有授课课程名称
        }

        #region 点击确认查询
        private void SureBtn_Click(object sender, EventArgs e)  // 当点击确定查询按钮
        {
            if (comboBox1.SelectedIndex == 0)  // 选择下拉框选择为空时
            {
                init_stuList();
            }
            else        // 否则选择该课程的所有学生信息
            {
                MysqlHelper mysql = new MysqlHelper();
                string sql = "select a.skid, a.cid 课程编号, b.cname 课程名称, a.uid 学号, a.stuname 姓名, a.sex 性别, a.major 专业 from allstudy_view a, courselist b where tid = '" + UserInfo.uid + "' and a.cid = b.cid  and a.skid = '" +comboBox1.SelectedValue +"';";
                DataTable dt_stulist = mysql.GetDataTable(sql);
                dtlist = dt_stulist;
                dgvstulist.DataSource = dt_stulist;
            }
        }
        #endregion


        #region 学生名单导出excel文件
        //导出学生名单
        private void ExportBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog kk = new SaveFileDialog();
            kk.Title = "保存EXECL文件";
            //文件默认名字
            kk.FileName = comboBox1.Text + "stulist";
            //默认拓展名
            kk.DefaultExt = "xlsx";
            kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*";
            kk.FilterIndex = 1;
            if (kk.ShowDialog() == DialogResult.OK)
            {
                string FileName = kk.FileName;
                //文件存在则替换
                if (File.Exists(FileName))
                    File.Delete(FileName);
                FileStream objFileStream;
                StreamWriter objStreamWriter;
                string strLine = "";
                objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
                for (int i = 0; i < dtlist.Columns.Count; i++)
                {
                    strLine = strLine + dtlist.Columns[i].Caption.ToString() + Convert.ToChar(9);
                }
                objStreamWriter.WriteLine(strLine);
                strLine = "";
                for (int i = 0; i < dtlist.Rows.Count; i++)
                {
                    for (int j = 0; j < dtlist.Columns.Count; j++)
                    {
                        if (dtlist.Rows[i].ItemArray[j] == null)
                            strLine = strLine + " " + Convert.ToChar(9);
                        else
                        {
                            string rowstr = "";
                            rowstr = dtlist.Rows[i].ItemArray[j].ToString();
                            if (rowstr.IndexOf("\r\n") > 0)
                                rowstr = rowstr.Replace("\r\n", " ");
                            if (rowstr.IndexOf("\t") > 0)
                                rowstr = rowstr.Replace("\t", " ");
                            strLine = strLine + rowstr + Convert.ToChar(9);
                        }
                    }
                    objStreamWriter.WriteLine(strLine);
                    strLine = "";
                }
                objStreamWriter.Close();
                objFileStream.Close();
                MessageBox.Show(this, "保存EXCEL成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


    }
}
