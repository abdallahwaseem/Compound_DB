using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Compound_DB.Resident
{
    class Resident_controller
    {
        DBManager dbMan;
        public Resident_controller()
        {
            dbMan = new DBManager();
        }
        public DataTable ViewInvoices(int id)
        {
            string query = "SELECT ID, Inv_Type as Type, Inv_Status as Status, Due_Date, Amount,Penalty FROM Invoice WHERE Resident_ID=" + id + ";";
            return dbMan.ExecuteReader(query);

        }
        public DataTable ViewPaidInvoices(int id)
        {
            string query = "SELECT ID, Inv_Type as Type, Inv_Status as Status, Due_Date, Amount,Penalty FROM Invoice WHERE Resident_ID=" + id + "AND Inv_Status= 'Paid';";
            return dbMan.ExecuteReader(query);

        }
        public DataTable ViewPendingInvoices(int id)
        {
            string query = "SELECT ID, Inv_Type as Type, Inv_Status as Status, Due_Date, Amount,Penalty FROM Invoice WHERE Resident_ID=" + id + "AND (Inv_Status = 'Pending' OR Inv_Status = 'Overdue') ;";
            return dbMan.ExecuteReader(query);

        }
        public int UpdateInvoiceStatus(int id, String status)
        {
            string query = "UPDATE Invoice SET Inv_Status='" + status + "' WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ViewRequests(int id)
        {
            string query = "SELECT Request.ID as Request_Number, Request.Req_Status as Status, Request.Req_Date, Request.Feedback as YourFeedback ,Provided_Services.Ser_Name as Service " +
                "FROM Request , Provided_Services WHERE Request.Resident_ID=" + id + "AND Provided_Services.ID=Request.Service_ID ;";
            return dbMan.ExecuteReader(query);

        }
        public int UpdateRequestFeedback(int id, String feedback)
        {
            string query = "UPDATE Request SET Feedback='" + feedback + "' WHERE ID='" + id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetRequestStatus(int id)
        {
            string query = "SELECT Req_Status FROM Request WHERE ID=" + id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAssignedStaff_ID(int Req_id)
        {
            string query = "SELECT Assigned_Staff_ID FROM Request WHERE ID='" + Req_id + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetStaffRating(int staff_id)
        {
            string query = "SELECT Rating FROM Compound_Staff WHERE ID='" + staff_id + "';";
            return dbMan.ExecuteReader(query);
        }
        public int UpdateStaffRating(int staff_id, int Rating)
        {
            string query = "UPDATE Compound_Staff SET Rating=" + Rating + " WHERE ID='" + staff_id + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertInRequest(DateTime req_date, int Service_id, int Resident_id)
        {
            string query = "INSERT INTO Request " +
                            "VALUES ('Pending','" + req_date + "',null," + Service_id + "," + Resident_id + ",null);";
            return dbMan.ExecuteNonQuery(query);

        }
        public DataTable GetServiceID(string sername)
        {
            string query = "SELECT ID FROM Provided_Services WHERE Ser_Name='" + sername + "';";
            return dbMan.ExecuteReader(query);
        }
        public int getSimilarRequests(DateTime req_date, int ser_id, int Rid)
        {
            string query = "SELECT COUNT(ID) FROM Request WHERE Service_ID=" + ser_id + " AND Req_Date='" + req_date + "'AND Resident_ID=" + Rid + ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable GetServicesProvided()
        {
            string query = "SELECT * FROM Provided_Services;";
            return dbMan.ExecuteReader(query);

        }
        public DataTable getAddedReqID(DateTime req_date, int ser_id, int Rid)
        {
            string query = "SELECT ID FROM Request WHERE Service_ID=" + ser_id + " AND Req_Date='" + req_date + "'AND Resident_ID=" + Rid + ";";
            return dbMan.ExecuteReader(query);
        }
        public int InsertInEntranceReq(int Resident_id, string visitorNmame, DateTime date)
        {
            string query = "INSERT INTO Entrance_Request " +
                            "VALUES (" + Resident_id + ",'" + visitorNmame + "','" + date + "');";
            return dbMan.ExecuteNonQuery(query);

        }
        public int getSimilarEntranceCodes(int Resident_id, string visitorNmame, DateTime date)
        {
            string query = "SELECT COUNT(Entrance_Code) FROM Entrance_Request WHERE Name_Of_Visitor='" + visitorNmame + "' AND Validation_End_Date='" + date + "'AND Resident_ID=" + Resident_id + ";";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable getEntranceCode(int Resident_id, string visitorNmame, DateTime date)
        {
            string query = "SELECT Entrance_Code FROM Entrance_Request WHERE Name_Of_Visitor='" + visitorNmame + "' AND Validation_End_Date='" + date + "'AND Resident_ID=" + Resident_id + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable viewResidentparkingSlots(int res_id)
        {
            string query = "SELECT ID as ParkingSlotNum, Building_ID FROM Parking_Slot WHERE Resident_ID=" + res_id + ";";
            return dbMan.ExecuteReader(query);

        }
        public int ResidentpendingParkingslotReq(DateTime req_date, int ser_id, int Rid)
        {
            string query = "SELECT COUNT(ID) FROM Request WHERE Service_ID=" + ser_id + " AND Req_Date='" + req_date + "'AND Resident_ID=" + Rid + "AND Req_Status='Pending';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable GETBuildingandUnit(int res_id)
        {
            string query = "SELECT Building_ID , Unit_ID FROM Resident WHERE ID=" + res_id + ";";
            return dbMan.ExecuteReader(query);
        }
        public int InsertInSellingReq(int Resident_id, int Building_ID, int Unit_ID)
        {
            string query = "INSERT INTO Selling_Request " +
                            "VALUES (" + Resident_id + "," + Building_ID + "," + Unit_ID + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int getSimilarSellingReq(int Resident_id)
        {
            string query = "SELECT COUNT(Resident_ID) FROM Selling_Request WHERE Resident_ID=" + Resident_id + ";";
            return (int)dbMan.ExecuteScalar(query);
        }


    }
}
