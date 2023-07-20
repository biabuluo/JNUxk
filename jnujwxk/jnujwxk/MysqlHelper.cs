using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace jnujwxk
{
    internal class MysqlHelper
    {   
    //    该类用于封装一切关于调用mysql的方法
    //    包括增删改查

        //使用stringbuilder来创建连接字符串
        private MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();

        //初始化mysqlhelper
        //使用配置文件中的变量创建连接字符串
        public MysqlHelper()
        {
            builder.Server = ConfigurationManager.AppSettings["server"];                 // 服务器
            builder.Port = uint.Parse(ConfigurationManager.AppSettings["port"]);         // 端口
            builder.Database = ConfigurationManager.AppSettings["db"];                   // 数据库
            builder.UserID = ConfigurationManager.AppSettings["uid"];                    // 用户名
            builder.Password = ConfigurationManager.AppSettings["pwd"];                  // 密码
        }
        public object ExecuteScalar(string sql)
        {
            // executeScalar; 返回查询结果的第一行第一列
            //与数据库进行通信 检查账户密码信息
            //建立数据库连接
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            //写查询语句 sql
            //创建command对象
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            //打开连接
            connection.Open();
            //执行命令
            object o = cmd.ExecuteScalar(); //放回结果集 （第一列的值）object类型
                                            //关闭连接  mysql自动关闭
            connection.Close();                                //处理结果
            return o;
        }

        public MySqlDataReader ExecuteReader(string sql)
        {
            // 对数据库进行查询，返回mysqldatareader对象
            //建立数据库连接
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            //写查询语句
            //创建command对象
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            //打开连接
            connection.Open();
            //执行命令
            MySqlDataReader reader = cmd.ExecuteReader(); //放回结果集 （第一列的值）
                                                          //关闭连接  mysql自动关闭
                                                          //处理结果
            return reader;
        }


        public int ExecuteNonQuery(string sql)
        {
            // 返回没有返回值的增删改操作
            //建立数据库连接
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            //写查询语句
            //创建command对象
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            //打开连接
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            //执行命令
            connection.Close();
            return result;
            //关闭连接  mysql自动关闭
            //处理结果
        }

        public  DataTable GetDataTable(string sql)
        {
            //mysql数据适配器，连接dataset和数据库
            DataTable dt = new DataTable();                   // 临时数据表
            using (MySqlConnection connection = new MySqlConnection(builder.ConnectionString))
            {
                //写查询语句
                //创建command对象
                MySqlDataAdapter da = new MySqlDataAdapter(sql, connection);
                da.Fill(dt);
                connection.Close();
            };
            return dt;                   // 返回数据表
        }


        //重载，，使用参数化sql   由于该程序是我边学边做的，发现参数化sql语句更具健壮性
        // 所以稍微改进一下
        public int ExecuteNonQuery(string sql, MySqlParameter[] paras)
        {
            //建立数据库连接
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paras);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return result;
            //写查询语句
        }

        public object ExecuteScalar(string sql, MySqlParameter[] paras) 
        {
            // executeScalar; 返回查询结果的第一行第一列
            //与数据库进行通信 检查账户密码信息
            //建立数据库连接
            MySqlConnection connection = new MySqlConnection(builder.ConnectionString);
            //写查询语句 sql
            //创建command对象
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paras);
            //打开连接
            connection.Open();
            //执行命令
            object o = cmd.ExecuteScalar(); //放回结果集 （第一列的值）object类型
                                            //关闭连接  mysql自动关闭
                                            //处理结果
            connection.Close();
            return o;
        }
    }
}
