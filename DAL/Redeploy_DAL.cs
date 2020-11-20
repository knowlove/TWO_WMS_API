using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Redeploy_DAL
    {

        StringBuilder builder = new StringBuilder();
        /// <summary>
        /// 调拨单列表显示
        /// </summary>
        /// <returns></returns>
        public List<Redeploy> GetRedeploys()
        {
            return DBHelper.GetList<Redeploy>(builder.Append("select * from Redeploy r join Warehouse w on w.W_Id=r.W_Id join Transfers t on t.T_Id=r.T_Id join Details d on d.R_Id=r.R_Id").ToString());
        }

        /// <summary>
        /// 调拨列表详情
        /// </summary>
        /// <returns></returns>
        public List<Details> GetDetails(int id)
        {
            string sql = $"select * from Redeploy r join Details d on d.R_Id = r.R_Id join Warehouse w on w.W_Id = r.W_Id join Transfers t on t.T_Id = r.T_Id where d.R_Id = '{id}' order by r.R_Id desc";
            return DBHelper.GetList<Details>(sql);
        }

        /// <summary>
        /// 删除调拨列表信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelRedeploys(int id)
        {
            string sql = $"delete from Redeploy where R_Id='{id}'";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 仓库调出下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Warehouse> GetWarehouses()
        {
            return DBHelper.GetList<Warehouse>(builder.Append("select * from Warehouse").ToString());
        }

        /// <summary>
        /// 仓库调入下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Transfers> GetTransfers()
        {
            return DBHelper.GetList<Transfers>(builder.Append("select * from Transfers").ToString());
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptRedeploys(int id, string Yj)
        {
            string sql = $"update Redeploy set R_Audit=1 where R_Id='{id}';update Details set A_Opinion='{Yj}' FROM Details d , Redeploy r WHERE d.R_Id=r.R_Id";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 审核未通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptDetails(int id, string Yj)
        {
            string sql = $"update Redeploy set R_Audit=2 where R_Id='{id}';update Details set A_Opinion='{Yj}' FROM Details d , Redeploy r WHERE d.R_Id=r.R_Id";
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 调出发配区
        /// </summary>
        /// <returns></returns>
        public List<Distribution> GetDistributions()
        {
            return DBHelper.GetList<Distribution>(builder.Append("select * from Distribution d join Warm w on w.Wa_Id=d.Wa_Id").ToString());
        }

        /// <summary>
        /// 调拨入库
        /// </summary>
        /// <returns></returns>
        public List<Storage> GetStorages()
        {
            return DBHelper.GetList<Storage>(builder.Append("select * from Storage s join Warehouse w on w.W_Id=s.W_Id join Warm wa on wa.Wa_Id=s.Wa_Id join Transfers t on t.T_Id=s.T_Id").ToString());
        }

    }
}
