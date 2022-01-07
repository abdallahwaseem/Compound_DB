using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Compound_DB.Manager
{
    class Manager_Controller
    {
        DBManager dbMan;

        public Manager_Controller()
        {
            dbMan = new DBManager();
        }
        /*       public DataTable CheckInvoices(int SSN)
               {
                   string query = "SELECT Pname FROM Project, Works_On WHERE Essn='" + SSN + "' AND Pnumber=Pno;";
                   return dbMan.ExecuteReader(query);
               }*/

        public int UpdatePenalty(int Pnum, int Dnum)
        {
            string query = "UPDATE Project SET Dnum='" + Dnum + "' WHERE Pnumber='" + Pnum + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
