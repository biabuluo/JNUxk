using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace jnujwxk
{
    public partial class MyCoursesForm : Form
    {
        // 我的课程/日程表子窗口
        class arrangement //每个任务：课程或者授课安排
        {
            public string cid;  //课程编号
            public string cname; //课程名称
            public string loc;   //课程地点
            public int date;     //周几
            public int time;     //第几节
        }
        private List<arrangement> arrlist = new List<arrangement>(); //存储日程表信息
        private List<List<Label>> labellist = new List<List<Label>>();  //label的二维数组
        public MyCoursesForm()
        {
            InitializeComponent();
        }
        private void init_label()   //初始化标签：5*5个
        {
            List<Label> list1 = new List<Label>();
            list1.Add(label1_1);
            list1.Add(label1_2);
            list1.Add(label1_3);
            list1.Add(label1_4);
            list1.Add(label1_5);
            List<Label> list2 = new List<Label>();
            list2.Add(label2_1);
            list2.Add(label2_2);
            list2.Add(label2_3);
            list2.Add(label2_4);
            list2.Add(label2_5);
            List<Label> list3 = new List<Label>();
            list3.Add(label3_1);
            list3.Add(label3_2);
            list3.Add(label3_3);
            list3.Add(label3_4);
            list3.Add(label3_5);
            List<Label> list4 = new List<Label>();
            list4.Add(label4_1);
            list4.Add(label4_2);
            list4.Add(label4_3);
            list4.Add(label4_4);
            list4.Add(label4_5);
            List<Label> list5 = new List<Label>();
            list5.Add(label5_1);
            list5.Add(label5_2);
            list5.Add(label5_3);
            list5.Add(label5_4);
            list5.Add(label5_5);
            labellist.Add(list1);
            labellist.Add(list2);
            labellist.Add(list3);
            labellist.Add(list4);
            labellist.Add(list5);

            foreach (List<Label> a in labellist)    //遍历设置文案为空
            {
                foreach (Label b in a)
                {
                    b.Text = "";
                }
            }
        }



        #region 查询课程信息存储到arrlist中
        private void init_arrlist() // 调用数据库信息查询用户的课程信息
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql;
            if (UserInfo.identity == 0)  //用户为学生
            {
                sql = "select b.cid 课程编号, b.cname 课程名称, location 地址, date_time 时间 from studytable a, allteach_view b where a.uid = '"+UserInfo.uid+"' and a.skid = b.skid ;";
            }
            else   //用户为教师
            {
                sql = "select cid 课程编号, cname 课程名称, location 地址, date_time 时间 from  allteach_view  where tid = '"+UserInfo.uid+"';";
            }
            MySqlDataReader reader = mysql.ExecuteReader(sql);
            while (reader.Read())   //添加到arrlist
            {
                // 创建一个临时的arrangement类
                arrangement temp = new arrangement();
                temp.cid = reader.GetString("课程编号");
                temp.cname = reader.GetString("课程名称");
                temp.loc = reader.GetString("地址");
                // 处理课程时间信息，切割
                string[] str = reader.GetString("时间").Split('-');
                temp.date = int.Parse(str[0]);
                temp.time = int.Parse(str[1]);
                // 添加到arrlist中
                arrlist.Add(temp);
            }
        }
        #endregion



        private void MyCoursesForm_Load(object sender, EventArgs e)      // 该子窗口打开时
        {
            // 初始化任务表，标签信息
            init_arrlist();
            //test
            //MessageBox.Show(arrlist[0].cname+' '+ arrlist[0].loc+' ' + arrlist[0].date.ToString()+' ' + arrlist[0].time.ToString());
            //test

            init_label();
            set_labeltext();
        }




        #region 处理arrlistd的每个arrangement到labellist中

        private void set_labeltext()
        {
            foreach (arrangement a in arrlist)
            {
                int i = a.date;
                int j = a.time;
                labellist[i-1][j-1].Text = a.cname + "    " + a.loc;
            }
        }

        #endregion

    }
}
