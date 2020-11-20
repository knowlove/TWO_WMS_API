using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Bll;
using Model;
using Newtonsoft.Json;

namespace TWO_WMS_API.Controllers
{
    public class WMS_AlaetrController : ApiController
    {
        WMS_AllerBLL bl = new WMS_AllerBLL();
        // 显示查询
        [HttpGet]
        public IHttpActionResult Show(int page,int rows, string CName = "", string WName = "", string Coding = "", string Name = "", string Manufacture="",string Valid="")
        {
            List<WMS_Allert> list = bl.Show();
            if (!string.IsNullOrEmpty(CName))
            {
                list = list.Where(s => s.CName.Contains(CName)).ToList();
            }
            if (!string.IsNullOrEmpty(WName))
            {
                list = list.Where(s => s.WName.Contains(WName)).ToList();
            }
            if (!string.IsNullOrEmpty(Coding))
            {
                list = list.Where(s => s.Coding.Contains(Coding)).ToList();
            }
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.Name.Contains(Name)).ToList();
            }
            if (!string.IsNullOrEmpty(Manufacture))
            {
                list = list.Where(s => s.Manufacture >= Convert.ToDateTime(Manufacture)).ToList();
            }
            if (!string.IsNullOrEmpty(Valid))
            {
                list = list.Where(s => s.Valid >= Convert.ToDateTime(Valid)).ToList();
            }
            int totalCount = list.Count;
            list = list.Skip((page - 1) * rows).Take(rows).ToList();
            var model = new
            {
                total = totalCount,
                rows=list
            };
            return Ok(model);
        }
        // 明细
        [HttpGet]
        public List<WMS_Allert> Mingxi(int Id)
        {
            return bl.Mingxi(Id);
        }
        [HttpGet]
        // 修改上下架状态
        public int Update(WMS_Allert s)
        {
            return bl.Update(s);
        }
        [HttpGet]
        //下拉
        public List<WMS_Allert> Xiala()
        {
            return bl.Xiala();
        }
        [HttpGet]
        //报警显示
        public List<WMS_Allert> BaojingShow()
        {
            return bl.BaojingShow();
        }
        [HttpGet]
        // 移库显示
        public IHttpActionResult YiKuShow(int page, int rows, string CName = "", string WName = "", string Coding = "", string Name = "",string S_Sent="",string S_Entry="")
        {
            List<WMS_Allert> list = bl.YiKuShow();
            if (!string.IsNullOrEmpty(CName))
            {
                list = list.Where(s => s.CName.Contains(CName)).ToList();
            }
            if (!string.IsNullOrEmpty(WName))
            {
                list = list.Where(s => s.WName.Contains(WName)).ToList();
            }
            if (!string.IsNullOrEmpty(Coding))
            {
                list = list.Where(s => s.Coding.Contains(Coding)).ToList();
            }
            if (!string.IsNullOrEmpty(Name))
            {
                list = list.Where(s => s.Name.Contains(Name)).ToList();
            }
            if (!string.IsNullOrEmpty(S_Sent))
            {
                list = list.Where(s => s.S_Sent.Contains(S_Sent)).ToList();
            }
            if (!string.IsNullOrEmpty(S_Entry))
            {
                list = list.Where(s => s.S_Entry.Contains(S_Entry)).ToList();
            }
            int totalCount = list.Count;
            list = list.Skip((page - 1) * rows).Take(rows).ToList();
            var model = new
            {
                total = totalCount,
                rows = list
            };
            return Ok(model);
        }
    }
}
