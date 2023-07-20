using System;
using System.Globalization;
using System.Windows.Forms;
namespace jnujwxk
{
    public partial class DateChangeForm : Form
    {
        // 编辑选课退课时间窗口

        private ChartForm parentform;   // 父窗口引用
        public void set_parentform(ChartForm parent)
        {
            // 父窗口调用设置引用
            this.parentform = parent;
        }

        #region 窗口构造器
        // 窗口构造器
        public DateChangeForm()
        {
            InitializeComponent();
            // 填充必要信息
            label1.Text = "当前日期：" + DateTime.Now.ToShortDateString();
            s1.Text = UserInfo.choosedate_start;
            e1.Text = UserInfo.choosedate_end;

            s2.Text = UserInfo.changedate_start;
            e2.Text = UserInfo.changedate_end;
        }
        #endregion


        #region 点击修改功能
        private void button1_Click(object sender, EventArgs e)  //修改时间
        {
            if (s1.Text != "" && s2.Text != "" && e1.Text != "" && e2.Text != "")
            {
                #region 时间设置逻辑不正确提示
                //时间逻辑不正确
                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy/MM/dd";
                DateTime temp1 = Convert.ToDateTime(s1.Text, dtFormat);
                DateTime temp2 = Convert.ToDateTime(s2.Text, dtFormat);
                DateTime temp3 = Convert.ToDateTime(e1.Text, dtFormat);
                DateTime temp4 = Convert.ToDateTime(e2.Text, dtFormat);
                if (temp1>temp3||temp2>temp4)
                {
                    MessageBox.Show("带点脑子！");
                    return;
                }
                #endregion

                #region 更改退课选课时间信息
                try
                {
                    // 调用UserInfo中的setting函数（调用mysql更改退课选课时间信息）
                    UserInfo.setting_date(s1.Text, s2.Text, e1.Text, e2.Text);
                    MessageBox.Show("设置成功！");
                    parentform.refreshtimelabel();
                    this.Close();
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("设置失败！");
                    return;
                }
                #endregion
            }
            else
            {
                #region 信息为空提示
                MessageBox.Show("信息不能为空！");
                return;
                #endregion
            }
        }
        #endregion



    }
}
