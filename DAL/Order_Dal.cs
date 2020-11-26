using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Dal
{
    public class Order_Dal
    {
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <returns></returns>
        public List<Order_Model> Show()
        {
            string sql = $"select * from Dh_Table";

            return DBHelper.GetList<Order_Model>(sql);
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <returns></returns>
        public List<Order_Model> Mingxi(int Id)
        {
            string sql = $"select * from Dh_Table where DhId={Id}";
            return DBHelper.GetList<Order_Model>(sql);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <returns></returns>
        public List<Order_Model> DelOrder(int Id)
        {
            string sql = $"delete from Dh_Table where DhId={Id}";
            return DBHelper.GetList<Order_Model>(sql);
        }
        //修改
        public int UpOrder(    string Cgsl, string Cgdj, string Je, string Sl,  string Bz, string id)
        {

            string sql = string.Format("update Dh_Table set DhCgsl='{0}',DhJe='{1}',DhSl='{2}',DhBz='{3}',DhDj='{4}' where DhId='{5}'", Cgsl,Je,Sl,Bz, Cgdj, id);
            return DBHelper.ExecuteNonQuery(sql);

        }
        public int AddOrder(string DhCgdh, string DhGys, string DhPl, string DhRq, string DhName, string DhType, string DhYlbm, string DhYlmc, string DhWq, string DhYlGg, string DhCgsl, string DhBz, string DhHq, string DhJe, string DhSl, string DhDj)
        {
            string sql = string.Format("insert into Dh_Table values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", DhCgdh, DhGys, DhPl, DhRq, DhName, DhType, DhYlbm, DhYlmc, DhWq, DhYlGg, DhCgsl, DhBz, DhHq, DhJe, DhSl, DhDj);
            return DBHelper.ExecuteNonQuery(sql);

        }
    }
}
