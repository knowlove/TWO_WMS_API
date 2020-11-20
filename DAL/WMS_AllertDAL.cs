using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Dal
{
    public class WMS_AllertDAL
    {
        /// <summary>
        /// 显示查询
        /// </summary>
        /// <param name="CName">仓库名</param>
        /// <param name="WName">类别</param>
        /// <param name="Coding">编号</param>
        /// <param name="Name">商品名</param>
        /// <returns></returns>
        public List<WMS_Allert> Show() 
        {
            string sql = $"select * from WMS_Statement s inner join WMS_Category c on c.CId=s.CategoryId join WMS_warehouse w on s.WarehouseId=w.WId";
        
            return DBHelper.GetList<WMS_Allert>(sql);
        }
        /// <summary>
        /// 详情
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> Mingxi(int Id)
        {
            string sql = $"select * from WMS_Statement s inner join WMS_Category c on c.CId=s.CategoryId join WMS_warehouse w on s.WarehouseId=w.WId where Id={Id}";
            return DBHelper.GetList<WMS_Allert>(sql);
        }
        /// <summary>
        /// 报警显示
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> BaojingShow()
        {
            string sql = $"select * from WMS_Statement s inner join WMS_Category c on c.CId=s.CategoryId join WMS_warehouse w on s.WarehouseId=w.WId";
            return DBHelper.GetList<WMS_Allert>(sql);
        }
        /// <summary>
        /// 修改上下架状态
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Update(WMS_Allert s)
        {
            string sql = $"update WMS_Statement set static={s.Static} where Id={s.Id}";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 下拉
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> Xiala()
        {
            string sql = $"select * from WMS_Category";
            return DBHelper.GetList<WMS_Allert>(sql);
        }
        /// <summary>
        /// 移库显示
        /// </summary>
        /// <returns></returns>
        public List<WMS_Allert> YiKuShow() 
        {
            string sql = $"select * from  WMS_Statement w join Storage s on w.Id=s.S_Id ";
            return DBHelper.GetList<WMS_Allert>(sql); 
        }
    }
}

