using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    
    public class Insert
    {
        Connectionclass objdal = new Connectionclass();

        public int DBInsert(string na,int ag,string addr,string ph,string una,string pwd)
        {
            string ins="Insert into Tab6 values('"+na+"'," + ag + ",'" + addr + "','" + ph + "','" + una + "','" + pwd + "')";
            int i = objdal.Fun_exenonquery(ins);
            return i;
        }

    }
}
