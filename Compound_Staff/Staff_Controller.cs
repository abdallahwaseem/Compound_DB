using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Compound_DB.Compound_Staff
{
    public class Staff_Controller
    {
        DBManager dbMan;

        public Staff_Controller()
        {
            dbMan = new DBManager();
        }

        

        public DataTable GetMyRequestsDetails(int Dept_Id)
        {
            string query = "SELECT Req.ID, Req_Status, R_name as Resident_Name, Unit_ID, Ser_Name as Service_Name" +
                            "FROM Request Req, Resident Res, Provided_Services Serv" +
                            "WHERE Serv.ID = Req.Service_ID AND Req.Resident_ID = Res.ID AND Req_Status = 'Pending' " +
                            "AND Service_ID in (SELECT ID FROM Provided_Services WHERE Dept_ID =" + Dept_Id + ")";
            return dbMan.ExecuteReader(query);
        }

    }
}
