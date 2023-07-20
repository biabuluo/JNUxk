using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class ChartForm : Form
    {
        // 应用数据子窗口 

        #region 图表数据需求（各种x/y）
        List<string> pie_x = new List<string>() { "学生", "教师", "管理员" };
        List<int> pie_y = new List<int>();
        List<string> bar_x = new List<string>();
        List<int> bar_y = new List<int> ();
        List<string> bar2_x = new List<string>();
        List<int> bar2_y = new List<int>();
        #endregion

        #region 窗口构造器
        public ChartForm()
        {
            InitializeComponent();
            #region 获取数据库数据
            MysqlHelper mysql = new MysqlHelper();
            string sql1 = "select identity, count(*) 人数 from userlist group by identity order by identity;";
            MySqlDataReader reader = mysql.ExecuteReader(sql1);
            while (reader.Read())
            {
                pie_y.Add(int.Parse(reader.GetString("人数")));
            }
            string sql2 = "select major 专业, count(*) 人数 from studentlist group by major;";
            reader = mysql.ExecuteReader(sql2);
            while (reader.Read())
            {
                bar_x.Add(reader.GetString("专业"));
                bar_y.Add(int.Parse(reader.GetString("人数")));
            }
            string sql3 = "select college 学院, count(*) 人数 from teacherlist group by college;";
            reader = mysql.ExecuteReader(sql3);
            while (reader.Read())
            {
                bar2_x.Add(reader.GetString("学院"));
                bar2_y.Add(int.Parse(reader.GetString("人数")));
            }
            /*
            string test = "";
            foreach (int i in pie_y)
            {
                test += i.ToString() + " ";
            }
            MessageBox.Show(test);
            */
            #endregion

            //时间lebel
            refreshtimelabel();

        }
        #endregion


        private void ChartForm_Load(object sender, EventArgs e) // 打开窗口时
        {

            #region 饼状图
            PieChart.Titles.Add("应用用户数据");
            PieChart.Titles[0].Alignment = ContentAlignment.TopCenter;
            //将文字移到外侧
            PieChart.Series[0]["PieLabelStyle"] = "Outside";
            //黑色连线
            PieChart.Series[0]["PieLineColor"] = "Black";
            //鼠标停靠显示
            PieChart.Series["Series1"].ToolTip = "#VAL";
            //绑定数据
            PieChart.Series[0].Points.DataBindXY(pie_x, pie_y);
            #endregion


            #region 条形图
            BarChart.Titles.Add("学生统计数据");
            BarChart.Titles[0].Alignment = ContentAlignment.TopCenter;
            BarChart.Series[0].Points.DataBindXY(bar_x, bar_y);
            #endregion


            #region 柱状图
            BarChart2.Titles.Add("学院教师统计");
            BarChart2.Titles[0].Alignment = ContentAlignment.TopCenter;
            BarChart2.Series[0].Points.DataBindXY(bar2_x, bar2_y);
            #endregion

        }
        

        //修改选课退课时间要求

        public void refreshtimelabel()  // timelabel（退课选课时间）刷新一下
        {
            editdatebtn.Text = DateTime.Now.ToShortDateString().ToString();
            label4.Text = UserInfo.choosedate_start.ToString();
            label5.Text = UserInfo.choosedate_end.ToString();
            label6.Text = UserInfo.changedate_start.ToString();
            label7.Text = UserInfo.changedate_end.ToString();
        }

        private void editdatebtn_Click(object sender, EventArgs e)  // 点击显示当前时间的按钮
        {
            // 打开编辑窗口
            DateChangeForm changeform = new DateChangeForm();
            changeform.set_parentform(this);  // 设置该窗口调用
            changeform.Show();
        }
    }
}
