using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class Emp_Dal
    {

        public List<Emp_Model> Show(string Cgdh, string Gys, string Pl, string Cgr, string Rkzt)
        {

            string sql = string.Format("select * from Dh_Table where 1=1");
            if (Cgdh!="")
            {

                sql += string.Format(" and DhCgdh like '%{0}%'", Cgdh);

            }
            if (Gys!="")
            {
                sql += string.Format(" and DhGys like '%{0}%'", Gys);
            }
            if (Pl!="")
            {
                sql += string.Format(" and DhPl like '%{0}%'", Pl);
            }
            if (Cgr!="")
            {
                sql += string.Format(" and DhName like '%{0}%'", Cgr);
            }
            if (Rkzt!="")
            {
                sql += string.Format(" and DhType like '%{0}%'", Rkzt);
            }
            return DBHelper.GetList<Emp_Model>(sql);


        }
        public List<Emp_Model> GetAll()
        {

            string sql = string.Format("select * from Dh_Table");
            return DBHelper.GetList<Emp_Model>(sql);

        }
        public List<Emp_Model> GetXqy(int id)
        {

            string sql = string.Format("select * from Dh_Table where DhId = {0}", id);
            return DBHelper.GetList<Emp_Model>(sql);

        }
        public int DelDhEmp(int id)
        {

            string sql = string.Format("delete from Dh_Table where DhId = {0}", id);
            return DBHelper.ExecuteNonQuery(sql);

        }
        public int UpEmp(string Gys,string Xhqy, string Cgsl, string Cgdj, string Je, string Sl, string Rq,string Bz,string id)
        {

            string sql = string.Format("update Dh_Table set DhGys='{0}',DhHq ='{1}' ,DhCgsl='{2}',DhJe='{3}',DhSl='{4}',DhRq='{5}',DhBz='{6}',DhDj='{7}' where DhId='{8}'", Gys, Xhqy, Cgsl, Cgdj, Je, Sl, Rq, Bz,Cgdj, id);
            return DBHelper.ExecuteNonQuery(sql);

        }
    }
}
