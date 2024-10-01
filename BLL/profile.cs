using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class profile
    {
        Connectionclass objdal = new Connectionclass();

        public SqlDataReader fun_GetData(int id)
        {
            string strsel = "select name,age,address,Photo from Tab6 where Id=" + id + "";
            SqlDataReader dr = objdal.Fun_exeReader(strsel);
            return dr;
        }
    }
}
