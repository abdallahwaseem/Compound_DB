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

        public int UpdatePenalty()
        {
            string query = "UPDATE Invoice SET Penalty = Amount * 0.1 Where Inv_Status='Overdue'";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertService(string Ser_Name, float Price, int Dept_ID)
        {
            string query = "Insert into Provided_Services(Ser_Name,Price,Dept_ID)" + "Values('" + Ser_Name + "'," + Price + "," + Dept_ID + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatePriceService(float newPrice,string Ser_Name)
        {
            string query = "UPDATE Provided_Services SET Price = " + newPrice + " WHERE Ser_Name = '" + Ser_Name + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertStaff(string Staff_Name, string DoB, char Gender,int Dept_ID,float Salary,string Phone_Number,string User_Name)
        {
            string query = "Insert into Compound_Staff(Staff_Name,Dob,Gender,Dept_ID,Salary,Phone_Number,Username)" + "Values('" + Staff_Name + "','" + DoB  + "','" + Gender + "',"+Dept_ID+","+Salary+",'"+Phone_Number+"','"+User_Name+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertLoginDetailsStaff(string Username, string Password,string User_Type)
        {
            string query = "Insert into Login_Details(Login_Username,Login_Password,User_Type)" + "Values('" + Username + "','" + Password + "','"+User_Type+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffSalary(int ID,int newSalary)
        {
            string query = "UPDATE Compound_Staff SET Salary = " + newSalary + " WHERE ID = "+ID+";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffDepartment(int Dept_ID, int ID)
        {
            string query = "UPDATE Compound_Staff SET Dept_ID = " + Dept_ID + " WHERE ID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateStaffPhoneNumber(string Phone_Number, int ID)
        {
            string query = "UPDATE Compound_Staff SET Phone_Number = " + Phone_Number + " WHERE ID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int DeleteStaff(int ID)
        {
            string query = "DELETE FROM Compound_Staff WHERE ID="+ID+";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertResident(string R_Name, string DoB, char Gender, string Phone_Number, string User_Name,int Building_ID,int Unit_ID)
        {
            string query = "Insert into Resident(R_Name,DoB,Gender,Phone_Number,Username,Building_ID,Unit_ID)" + "Values('" + R_Name + "','" + DoB + "','" + Gender + "','" + Phone_Number + "','" + User_Name + "',"+Building_ID+","+Unit_ID+");";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateResident(string Phone_Number, int ID)
        {
            string query = "UPDATE Resident SET Phone_Number = " + Phone_Number + " WHERE ID = " + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertOccupants(int Resident_ID,string O_Name,string Relationship)
        {
            string query = "Insert into Occupant" + "Values(" + Resident_ID + ",'" + O_Name + "','"+Relationship+"');";
            return dbMan.ExecuteNonQuery(query);
        }
/*        public int DeleteResident(int ID)
        {
            string query = "DELETE FROM Resident WHERE ID=" + ID + ";";
            return dbMan.ExecuteNonQuery(query);
        }*/
        public int SellUnit(int ID)
        {
            string query = "DELETE FROM Resident WHERE ID in(SELECT Resident_ID FROM Selling_Request WHERE Resident_ID="+ID+");";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdatetOverdueInvoices()
        {
            DateTime today = DateTime.Today;
            string query = "UPDATE Invoice SET Inv_Status = 'Overdue' Where Due_Date <= '"+today+"';";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable ViewOverDueInvoices()
        {
            string query = "SELECT R_Name,Due_Date,Inv_Type,Amount FROM Invoice I,Resident R Where R.ID=I.Resident_ID AND Inv_Status='Overdue';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectInvoices()
        {
            string query = "SELECT R_Name,Due_Date,Inv_Status,Inv_Type,Amount FROM Invoice I,Resident R Where R.ID=I.Resident_ID ;";
            return  dbMan.ExecuteReader(query); 
        }
        public DataTable PenaltyTotalAmount()
        {
            string query = "Select R_Name,Amount,Penalty,(Amount+Penalty) as Total_Amount FROM Invoice I,Resident R Where R.ID=I.Resident_ID AND Inv_Status='Overdue';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetDept_ID()
        {
            string query = "SELECT ID FROM Department";
            return dbMan.ExecuteReader(query);
        }

        public DataTable GetSer_Name()
        {
            string query = "SELECT Ser_Name FROM Provided_Services";
            return dbMan.ExecuteReader(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
