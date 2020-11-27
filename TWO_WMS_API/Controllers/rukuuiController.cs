using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Model;
using Bll;
namespace TWO_WMS_API.Controllers
{
    public class rukuuiController : ApiController
    {
        rukubll bl = new rukubll();
        // 显示查询
        [HttpGet]
        public IHttpActionResult Show(int page, int rows,string Q_Coding = "", string Q_Order = "", string Q_Name = "", string Q_Date = "")
        {
            List<rukuzong> list = bl.show();
            if (!string.IsNullOrEmpty(Q_Coding))
            {
                list = list.Where(s => s.Q_Coding.Contains(Q_Coding)).ToList();
            }
            if (!string.IsNullOrEmpty(Q_Order))
            {
                list = list.Where(s => s.Q_Order.Contains(Q_Order)).ToList();
            }
            if (!string.IsNullOrEmpty(Q_Name))
            {
                list = list.Where(s => s.Q_Name.Contains(Q_Name)).ToList();
            }
            if (!string.IsNullOrEmpty(Q_Date))
            {
                list = list.Where(s => s.Q_Date.Contains(Q_Date)).ToList();
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
        [HttpGet]
        public List<rukuzong> showxq(int Q_Id)
        {
            return bl.showxq(Q_Id);
        }
    }
}
