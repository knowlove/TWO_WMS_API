using System;
using System.Collections.Generic;
using System.Data.SqlClient;//引用数据库客户端安装程序包System.Data.SqlClient
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;
namespace Dal
{
    public class DBHelper
    {
        //连接数据库
        //static SqlConnection conn = new SqlConnection(@"Server=.;Initial Catalog=StuEvil;Persist Security Info=True;User ID=sa;Password=074110;MultipleActiveResultSets=True");
        static readonly SqlConnection conn = new SqlConnection(@"Data Source=10.3.38.2;Initial Catalog=WMSManagement;User ID=sa;pwd=1234");
        static SqlDataReader sdr;
        /// <summary>
        /// 获取数据流  查询、显示、绑定下拉
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private static SqlDataReader GetDataReader(string sql)
        {
            try
            {
                //打开
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                //命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                 sdr = cmd.ExecuteReader();
                return sdr;
            }
            catch (Exception)
            {
                if (sdr!=null&&!sdr.IsClosed)//数据流关闭
                {
                    sdr.Close();
                }
                throw;
            }

        }
        /// <summary>
        /// 返回受影响行数  
        /// 添加、删除、修改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql)
        {
            try
            {
                //打开
                //判断状态
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                //命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                int n = cmd.ExecuteNonQuery();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return n;
            }
            catch (Exception)
            {
               
                throw;
            }
        }
        /// <summary>
        /// 数据流转List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sdr"></param>
        /// <returns></returns>
        private static List<T> DataReaderToList<T>(SqlDataReader sdr) {
            Type t = typeof(T);//获取类型
            //获取所有属性
            PropertyInfo[] p = t.GetProperties();
            //定义集合
            List<T> list = new List<T>();
            //遍历数据流
            while (sdr.Read()) {
                //创建对象
                T obj = (T)Activator.CreateInstance(t);
                //数据流列数
                string[] sdrFileName = new string[sdr.FieldCount];
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    sdrFileName[i] = sdr.GetName(i).Trim();
                }
                foreach (PropertyInfo item in p)
                {
                    //判断Model中的属性是否在流的列名中
                    if (sdrFileName.ToList().IndexOf(item.Name) > -1)
                    {
                        if (sdr[item.Name] != null)
                        {
                            item.SetValue(obj, sdr[item.Name]);//对象属性赋值
                        }
                        else
                        {
                            item.SetValue(obj, null);//对象属性赋值
                        }
                    }
                    else {
                        item.SetValue(obj, null);//对象属性赋值
                    }
                   
                }
                list.Add(obj);
            }
            return list;
        }
        /// <summary>
        /// 获取list集合
        ///  查询、显示、绑定下拉
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetList<T>(string sql) {
            //获取流数据
            SqlDataReader sdr = GetDataReader(sql);
            List<T> list = DataReaderToList<T>(sdr);
            if (!sdr.IsClosed)//数据流关闭
            {
                sdr.Close();
            }
            return list;
        }
        /// <summary>
        /// 查询实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static T Get<T>(string sql)
        {
            List<T> lis = GetList<T>(sql);
            if (lis.Count>0)
            {
                return GetList<T>(sql)[0];
            }
            else
            {
                return default(T);
            }
        }
        /// <summary>
        /// 返回首行首列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql)
        {
            try
            {
                //打开
                //判断状态
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                //命令对象
                SqlCommand cmd = new SqlCommand(sql, conn);
                object n = cmd.ExecuteScalar();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                return n;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /*===========================Ado.NET存储过程===========================
        const string ConnStr = "Data Source=_鸿儒;Initial Catalog=物联网学院2020年4月SOA框架开发月考技能试题;Integrated Security=True";
        public static DataTable SelectDataTable(string SqlStr, CommandType type, SqlParameter[] parameter=null) {
            DataSet set=new DataSet();
            using ( SqlConnection conn = new SqlConnection(ConnStr) ) {
                //打开数据库
                conn.Open();
                //创建SqlCommand对象
                SqlCommand cmd=new SqlCommand();
                //指定一个数据库连接
                cmd.Connection = conn;
                //执行的Sql文本
                cmd.CommandText = SqlStr;
                //执行的sql文本的类型(Sql语句或存储过程)
                cmd.CommandType = type;
                //如果类型为存储过程
                if ( type==CommandType.StoredProcedure )
                {
                    //传参
                    cmd.Parameters.AddRange(parameter);
                }
                //创建SqlDataAdapter对象,用于填充数据到DataSet里面
                SqlDataAdapter adaper=new SqlDataAdapter(cmd);
                //填充数据到DataSet
                adaper.Fill(set);
                //是否得到结果集,如果是···则
                if ( set.Tables.Count>0 )
                {
                    //返回第一张表
                    return set.Tables[0];
                }
            }
            return null;
        }
        //sql语句得添加，删除，修改
        public int ExecDataTable(string sql)
        {
            int result = 0;//默认为失败
            using ( SqlConnection conn = new SqlConnection(ConnStr) )
            {
                //打开数据库
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                result = cmd.ExecuteNonQuery();
            }
            return result;
        }
        //===========================Ado.NET存储过程===========================*/
    }
}
