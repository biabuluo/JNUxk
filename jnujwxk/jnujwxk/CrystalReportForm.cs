using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace jnujwxk
{
    public partial class CrystalReportForm : Form
    {
        private DataTable stutable;
        private String coursename;
        private String teachername;
        private String location;
        private String time;
        private String number;

        public CrystalReportForm(DataTable stutable, String course, String teaname, String loc, String time, String num)
        {
            this.stutable = stutable;
            this.coursename = course;
            this.teachername = teaname;
            this.location = loc;
            this.time = time;
            this.number = num;
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            /*创建report实例*/
            MyReport cr = new MyReport();
            /*填充数据*/
            cr.SetDataSource(stutable);
            this.crystalReportViewer1.ReportSource = cr;
            /*获取document对象*/
            ReportDocument document = (ReportDocument)cr;
            /*设置标题*/
            document.SummaryInfo.ReportTitle = coursename+"学生名单";
            document.SummaryInfo.ReportAuthor = "教师："+teachername+" 地点："+location+" 时间："+time+" 人数："+number;
            this.crystalReportViewer1.ReportSource = document;
            crystalReportViewer1.Zoom(75);
        }
    }
}
