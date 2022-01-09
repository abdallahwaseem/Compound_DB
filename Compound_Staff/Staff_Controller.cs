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

        public int GetManagerId(int staffId)
        {
            string query = "SELECT M.ID FROM Compound_Staff as C, Department as D, " +
                            "Manager as M WHERE C.Dept_ID = D.ID AND D.Mgr_ID = M.ID AND C.ID = " + staffId;
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable GetSalary(int staffId)
        {
            string query = "SELECT Salary FROM Compound_Staff WHERE ID = " + staffId;
            return dbMan.ExecuteReader(query);
        }
        public DataTable CheckIfRequestedBefore(int staffId)
        {
            string query = "SELECT Staff_ID FROM Raise_Request WHERE Staff_ID = " + staffId;
            return dbMan.ExecuteReader(query);
        }
        public int RequestRaise(int staffId, int mgrId, float newSalary)
        {
            string query = "INSERT INTO Raise_Request(Staff_ID, Manager_ID, New_Salary) values( " + staffId + ", " + mgrId + ", " + newSalary + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetRaiseRequests(int staffId)
        {
            string query = "SELECT Staff_Name , New_Salary, Req_Status FROM Raise_Request, Compound_Staff WHERE Staff_ID = ID AND Staff_ID = " + staffId;
            return dbMan.ExecuteReader(query);
        }

        //public DataTable GetRaiseRequests(int staffId)
        //{
        //    string query = "SELECT Staff_Name , New_Salary, Req_Status FROM Raise_Request, Compound_Staff WHERE Staff_ID = ID AND Staff_ID = " + staffId;
        //    return dbMan.ExecuteReader(query);
        //}
        public string GetStaffDoB(int staffId)
        {
            string query = "SELECT DoB FROM Compound_Staff WHERE ID = " + staffId;

            return (string)dbMan.ExecuteScalar(query);
        }
        public char GetStaffGender(int staffId)
        {
            string query = "SELECT Gender FROM Compound_Staff WHERE ID = " + staffId;
            return (char)dbMan.ExecuteScalar(query);
        }
        public double GetStaffRating(int staffId)
        {
            string query = "SELECT Rating FROM Compound_Staff WHERE ID = " + staffId;
            return (double)dbMan.ExecuteScalar(query);
        }
        public string GetStaffPhoneNum(int staffId)
        {
            string query = "SELECT Phone_Number FROM Compound_Staff WHERE ID = " + staffId;
            return (string)dbMan.ExecuteScalar(query);
        }
    }
}
