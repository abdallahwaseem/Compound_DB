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
        public DataTable GetAllRequestsDetails(int Dept_Id)
        {
            string query = "SELECT Req.ID, Req_Status, R_name as Resident_Name, Unit_ID"
                            + ", Ser_Name as Service_Name FROM Request Req, Resident Res," + 
                            " Provided_Services Serv WHERE Serv.ID = Req.Service_ID AND " + 
                            "Req.Resident_ID = Res.ID AND Req_Status = 'Pending' AND "+ 
                            "Service_ID in ( SELECT ID FROM Provided_Services WHERE Dept_ID =" + 1 + ")";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetMyRequestsDetails(int staffId)
        {
            string query = "SELECT Req.ID, Req_Status, R_name as Resident_Name, Unit_ID, Ser_Name as Service_Name "+
                            "FROM Request Req, Resident Res, Provided_Services Serv WHERE Req.Assigned_Staff_ID = "+ staffId  +
                            " AND Serv.ID = Req.Service_ID AND Req.Resident_ID = Res.ID AND Req_Status = 'Assigned'";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetMyCompletedRequestsDetails(int staffId)
        {
            string query = "SELECT Req.ID, Req_Status, R_name as Resident_Name, Unit_ID, Ser_Name as Service_Name " +
                            "FROM Request Req, Resident Res, Provided_Services Serv WHERE Req.Assigned_Staff_ID = " + staffId +
                            " AND Serv.ID = Req.Service_ID AND Req.Resident_ID = Res.ID AND Req_Status = 'Completed'";
            return dbMan.ExecuteReader(query);
        }

        public int AcceptRequest(int staffId, int reqId)
        {
            string query = "UPDATE Request SET Assigned_Staff_ID = "+ staffId+ ", Req_Status = 'Assigned' WHERE ID = " + reqId;
            return dbMan.ExecuteNonQuery(query);
        }
        public int CompleteRequest(int staffId, int reqId)
        {
            string query = "UPDATE Request SET Assigned_Staff_ID = " + staffId + ", Req_Status = 'Completed' WHERE ID = " + reqId;
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
