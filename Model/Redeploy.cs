using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Redeploy
    {
        //序号
        public int R_Id { get; set; }
        //调拨单号
        public string R_Number { get; set; }
        //仓库调出
        public int W_Id { get; set; }
        //仓库调入
        public int T_Id { get; set; }
        //调拨日期
        public string R_Date { get; set; }
        //调拨人
        public string R_Dispatchers { get; set; }
        //审核状态
        public int R_Audit { get; set; }
        //调拨状态
        public int R_Status { get; set; }
        //装框数量
        public int R_Frames { get; set; }
        //仓库名称
        public string W_Name { get; set; }
        //仓库调入名称
        public string T_Name { get; set; }
        //物品编码
        public string D_Code { get; set; }
        //物品名称
        public string D_Name { get; set; }
        //可用库存
        public int D_Available { get; set; }
        //申请数量
        public int D_Applications { get; set; }
        //审批数量
        public int D_Apprvals { get; set; }
        //已出库数量
        public int D_Stock { get; set; }
        //周转筐
        public string D_Basket { get; set; }
        //计量单位
        public string D_Unit { get; set; }
        //单价
        public int D_Price { get; set; }
        //图片
        public string D_Img { get; set; }
        //审核意见
        public string A_Opinion { get; set; }
        //备注
        public string A_Notes { get; set; }
        //待审核调拨总数
        public int A_Review { get; set; }
    }
}
