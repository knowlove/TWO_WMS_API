using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Demand
    {
        //序号
        public int D_Id { get; set; }
        //补货单号
        public string D_Order { get; set; }
        //补货日期
        public string D_Date { get; set; }
        //一级品类外键
        public int C_Id { get; set; }
        //商店外键
        public int S_Id { get; set; }
        //商品外键
        public int Ct_Id { get; set; }
        //规格
        public string D_Specifications { get; set; }
        //价格
        public int D_Price { get; set; }
        //数量
        public int D_Number { get; set; }
        //可用库存
        public int D_Available { get; set; }
        //合计补货
        public string D_Total { get; set; }
        //审核
        public int D_Audit { get; set; }
        //审核合计数
        public int D_AuditTotal { get; set; }
        //对比需求
        public int D_Contrast { get; set; }
        //商店名称
        public string S_Name { get; set; }
        //品类名称
        public string C_Name { get; set; }
    }
}
