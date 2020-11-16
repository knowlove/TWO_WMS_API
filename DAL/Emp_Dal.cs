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
            if (Cgdh.Length > 0)
            {

                sql += string.Format(" and DhCgdh like {0}", Cgdh);

            }
            if (Gys.Length > 0)
            {
                sql += string.Format(" and DhGys like {0}", Gys);
            }
            if (Pl.Length > 0)
            {
                sql += string.Format(" and DhPl like {0}", Pl);
            }
            if (Cgr.Length > 0)
            {
                sql += string.Format(" and DhName like {0}", Cgr);
            }
            if (Rkzt.Length > 0)
            {
                sql += string.Format(" and DhType like {0}", Rkzt);
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
    }
}
