using MySql.Data.MySqlClient;


namespace jnujwxk
{
    internal class UserInfo
    {
        //UserInfo类是静态全局类：
        //    存储一些用户信息

        static public string uid;                       // 用户uid
        static public int identity;                     // 用户身份：老师？学生？管理员？
        static public string choosedate_start;          // 选课开始时间
        static public string choosedate_end;            // 选课结束时间
        static public string changedate_start;          // 退课开始时间
        static public string changedate_end;            // 退课结束时间

        static public void  init_info()
        {
            //初始化信息：用于登出清空用户信息
            uid = "";
            identity = -1;
/*            choosedate_start = DateTime.Now.Date.ToShortDateString();
            choosedate_end = DateTime.Now.Date.ToShortDateString();
            changedate_start = DateTime.Now.Date.ToShortDateString();
            changedate_end = DateTime.Now.Date.ToShortDateString();
*/
        }
        static public void process_date() //处理一下日期形式
        {
            // 只保留时间的年月日
            #region 数据库读取选课退课时间信息
            MysqlHelper mysql = new MysqlHelper();
            string sql = "select * from datelimit;";
            MySqlDataReader reader = mysql.ExecuteReader(sql);
            while (reader.Read())
            {
                UserInfo.choosedate_start = reader.GetString("choose_s");
                UserInfo.choosedate_end = reader.GetString("choose_e");
                UserInfo.changedate_start = reader.GetString("change_s");
                UserInfo.changedate_end = reader.GetString("change_e");
            }
            reader.Close();
            #endregion

            #region 修改日期形式
            // 将日期按空格切割，第一项为所需
            string[] temp = choosedate_start.Split(' ');
            choosedate_start = temp[0];

            temp = choosedate_end.Split(' ');
            choosedate_end = temp[0];

            temp = changedate_start.Split(' ');
            changedate_start = temp[0];

            temp = changedate_end.Split(' ');
            changedate_end = temp[0];
            #endregion
        }


        #region 修改选课退课时间
        //修改设置时间
        static public void setting_date(string s1, string s2, string e1, string e2)
        {
            MysqlHelper mysql = new MysqlHelper();
            string sql = "update datelimit set choose_s = @s1, choose_e = @e1, change_s = @s2, change_e = @e2 where id = 1 ;";
            MySqlParameter[] paras =
            {
                new MySqlParameter("@s1", s1),
                new MySqlParameter("@e1", e1),
                new MySqlParameter("@s2", s2),
                new MySqlParameter("@e2", e2),
            };

            mysql.ExecuteNonQuery(sql, paras);
            process_date();              // 处理日期形式
        }
        #endregion
    }
}
