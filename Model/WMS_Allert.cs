using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WMS_Allert
    {
        public int WId { get; set; }                  //仓库id
        public string WName { get; set; }               //仓库
        public int CId { get; set; }                   //类别ID
        public string CName { get; set; }                //类别名
        public int Id { get; set; }                     //序号
        public int WarehouseId { get; set; }                //所在仓库id
        public int CategoryId { get; set; }                //产品品类id
        public string Coding { get; set; }                //产品编号
        public string Name { get; set; }                    //产品名称
        public string Specification { get; set; }                //产品规格
        public string Unit { get; set; }                    //计量单位
        public string Quantity { get; set; }                    //库存数量
        public string Congelation { get; set; }                //冻结数量
        public string Available { get; set; }                //可用库存
        public string Production { get; set; }                //生产二部
        public string Inventory { get; set; }                //库存下限
        public string Below { get; set; }                //低于安全库存
        public string Merchandise { get; set; }                //产品信息
        public DateTime Manufacture { get; set; }                      //生产日期
        public DateTime Valid { get; set; }                    //有效期至
        public string Expiration { get; set; }                    //剩余保质期
        public string Shelf { get; set; }                    //剩余货架期
        public int Static { get; set; }                    //上架下架
        public int Type { get; set; }                             //类型 0为废品，1为商品，2为产品      

        public int S_Id { get; set; }                           
        public string S_Order { get; set; }
        public string S_Odd { get; set; }
        public int W_Id { get; set; }
        public int T_Id { get; set; }
        public string S_Sent { get; set; }
        public string S_Entry { get; set; }
        public int Wa_Id { get; set; }
        public int S_Total { get; set; }
        public string S_Dispatchers { get; set; }
        public string S_Consignee { get; set; }
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
        public int Q_Id { get; set; }
        //单据编号
        public string Q_Coding { get; set; }
        //调拨入库单号
        public string Q_Order { get; set; }
        //门店外键

        //商品编码
        public string Q_Code { get; set; }
        //商品名称
        public string Q_Name { get; set; }
        //规格
        public string Q_Specifications { get; set; }
        //数量
        public int Q_Number { get; set; }
        //处理人
        public string Q_Handler { get; set; }
        //处理日期
        public string Q_Date { get; set; }
        //状态
        public int Q_Status { get; set; }

        public string WType { get; set; }
        public DateTime WTime { get; set; }
        public string WGoods { get; set; }
        public string WCompletion { get; set; }

       
    }
}
