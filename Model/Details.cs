using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Details
    {
        //序号
        public int D_Id { get; set; }
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
        //调拨外键
        public int R_Id { get; set; }
        //审核意见
        public string A_Opinion { get; set; }
        //备注
        public string A_Notes { get; set; }
        //待审核调拨总数
        public int A_Review { get; set; }
    }
}
