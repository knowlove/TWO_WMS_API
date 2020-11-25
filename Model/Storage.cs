using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Storage
    {
        //序号
        public int S_Id { get; set; }
        //调拨入库单号
        public string S_Order { get; set; }
        //TS调出单号
        public string S_Odd { get; set; }
        //仓库调出
        public int W_Id { get; set; }
        //仓库调入
        public int T_Id { get; set; }
        //发送日期
        public string S_Sent { get; set; }
        //入库日期
        public string S_Entry { get; set; }
        //温区外键
        public int Wa_Id { get; set; }
        //商品总数
        public int S_Total { get; set; }
        //调拨人
        public string S_Dispatchers { get; set; }
        //收货人
        public string S_Consignee { get; set; }
        //温区名称
        public string Wa_Name { get; set; }
        //仓库调入名称
        public string T_Name { get; set; }
        //仓库名称
        public string W_Name { get; set; }
    }
}
