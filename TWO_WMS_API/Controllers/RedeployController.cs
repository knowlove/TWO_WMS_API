using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TWO_WMS_API.Controllers
{
    public class RedeployController : ApiController
    {
        Redeploy_BLL bll = new Redeploy_BLL();

        /// <summary>
        /// 调拨单列表显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Redeploy> GetRedeploys(/*string Dc, string Dr,*/ string Bm = "", string Mc = "", string Rq = "", string Dh = "", int pageindex = 1, int pagesize = 2)
        {
            List<Redeploy> list = bll.GetRedeploys();

            ////根据调出查询
            //if (!string.IsNullOrEmpty(Dc))
            //{
            //    list = list.Where(s => s.W_Name.Contains(Dc)).ToList();
            //}
            ////根据调入查询
            //if (!string.IsNullOrEmpty(Dr))
            //{
            //    list = list.Where(s => s.T_Name.Contains(Dr)).ToList();
            //}
            //根据商品编码查询
            if (!string.IsNullOrEmpty(Bm))
            {
                list = list.Where(s => s.D_Code.Contains(Bm)).ToList();
            }
            //根据商品名称查询
            if (!string.IsNullOrEmpty(Mc))
            {
                list = list.Where(s => s.D_Name.Contains(Mc)).ToList();
            }
            //根据调拨单号查询
            if (!string.IsNullOrEmpty(Dh))
            {
                list = list.Where(s => s.R_Number.Contains(Dh)).ToList();
            }
            //分页
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            return list;
        }

        /// <summary>
        /// 调拨列表详情
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Details> GetDetails(int id)
        {
            return bll.GetDetails(id);
        }

        /// <summary>
        /// 删除调拨列表信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public int DelRedeploys(int id)
        {
            return bll.DelRedeploys(id);
        }

        /// <summary>
        /// 仓库调出下拉绑定
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Warehouse> GetWarehouses()
        {
            return bll.GetWarehouses();
        }

        /// <summary>
        /// 仓库调入下拉绑定
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Transfers> GetTransfers()
        {
            return bll.GetTransfers();
        }

        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public int UptRedeploys(int id, string Yj)
        {
            return bll.UptRedeploys(id, Yj);
        }

        /// <summary>
        /// 审核未通过
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        public int UptDetails(int id, string Yj)
        {
            return bll.UptDetails(id, Yj);
        }

        /// <summary>
        /// 调出发配区
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Distribution> GetDistributions(string Bm = "", string Ztd = "")
        {
            List<Distribution> list = bll.GetDistributions();

            if (!string.IsNullOrEmpty(Bm))
            {
                list = list.Where(s => s.D_Coding.Contains(Bm)).ToList();
            }
            if (!string.IsNullOrEmpty(Ztd))
            {
                list = list.Where(s => s.D_Point.Contains(Ztd)).ToList();
            }
            return list;
        }

        /// <summary>
        /// 调拨入库
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Storage> GetStorages(string Dh = "", string Dbr = "", string Rk = "", string Rq = "")
        {
            List<Storage> list = bll.GetStorages();
            //TS调拨单号查询
            if (!string.IsNullOrEmpty(Dh))
            {
                list = list.Where(s => s.S_Odd.Contains(Dh)).ToList();
            }
            //调拨人查询
            if (!string.IsNullOrEmpty(Dbr))
            {
                list = list.Where(s => s.S_Dispatchers.Contains(Dbr)).ToList();
            }
            //入库单号查询
            if (!string.IsNullOrEmpty(Rk))
            {
                list = list.Where(s => s.S_Order.Contains(Rk)).ToList();
            }
            //入库日期查询
            if (!string.IsNullOrEmpty(Rq))
            {
                list = list.Where(s => s.S_Entry.Contains(Rq)).ToList();
            }

            return list;
        }

    }
}
