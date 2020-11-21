using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class Redeploy_BLL
    {
        Redeploy_DAL dal = new Redeploy_DAL();

        /// <summary>
        /// 调拨单列表显示
        /// </summary>
        /// <returns></returns>
        public List<Redeploy> GetRedeploys()
        {
            return dal.GetRedeploys();
        }

        /// <summary>
        /// 调拨列表详情
        /// </summary>
        /// <returns></returns>
        public List<Details> GetDetails(int id)
        {
            return dal.GetDetails(id);
        }

        /// <summary>
        /// 删除调拨列表信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelRedeploys(int id)
        {
            return dal.DelRedeploys(id);
        }

        /// <summary>
        /// 仓库调出下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Warehouse> GetWarehouses()
        {
            return dal.GetWarehouses();
        }

        /// <summary>
        /// 仓库调入下拉绑定
        /// </summary>
        /// <returns></returns>
        public List<Transfers> GetTransfers()
        {
            return dal.GetTransfers();
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptRedeploys(int id, string Yj)
        {
            return dal.UptRedeploys(id, Yj);
        }

        /// <summary>
        /// 审核未通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UptDetails(int id, string Yj)
        {
            return dal.UptDetails(id, Yj);
        }

        /// <summary>
        /// 调出发配区
        /// </summary>
        /// <returns></returns>
        public List<Distribution> GetDistributions()
        {
            return dal.GetDistributions();
        }

        /// <summary>
        /// 调拨入库
        /// </summary>
        /// <returns></returns>
        public List<Storage> GetStorages()
        {
            return dal.GetStorages();
        }

    }
}
