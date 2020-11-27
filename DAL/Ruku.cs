using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Dal
{
    public class Ruku
    {
        public List<rukuzong> show() 
        {
            string sql = $"select * from Qualified q join Warm w on q.Wa_Id=w.Wa_Id";
            return DBHelper.GetList<rukuzong>(sql);
        }
        public List<rukuzong> showxq(int Q_Id)
        {
            string sql = $"select * from Qualified q join Warm w on q.Wa_Id=w.Wa_Id where Q_Id={Q_Id}";
            return DBHelper.GetList<rukuzong>(sql);
        }
    }
}
