using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Logincls
    {
        Connectionclass Objdal = new Connectionclass();
        public string GetCountId(string Una, string Pwd)
        {
            string str = "Select count(Id) from Tab6 where Username='" + Una + "'and Password ='" + Pwd + "'";
            string cid = Objdal.Fun_exescalar(str);
            return cid;
        }
        public string GetId(string una,string pwd)
        {
            string str = "select id from Tab6 where Username='" + una + "' and password='" + pwd + "'";
            string id = Objdal.Fun_exescalar(str);
            return id;
        }
    }
}
