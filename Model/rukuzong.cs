using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class rukuzong
    {
        //序号
        public int Q_Id { get; set; }
        //单据编号
        public string Q_Coding { get; set; }
        //调拨入库单号
        public string Q_Order { get; set; }
        //门店外键
        public int S_Id { get; set; }
        //温区外键
        public int Wa_Id { get; set; }
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
        //温区名称
        public string Wa_Name { get; set; }
    }
}
