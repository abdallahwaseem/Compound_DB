using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Compound_DB.Login
{
    public class Login_Controller
    {
        DBManager dbMan;

        public Login_Controller()
        {
            dbMan = new DBManager();
        }

        public int CheckUserInDB(string username)
        {
            string query = "SELECT COUNT(*) FROM Login_Details WHERE Login_Username = '" + username + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public string GetUserPassword(string username)
        {
            string query = "SELECT Login_Password FROM Login_Details WHERE Login_Username = '" + username + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetUserType(string username)
        {
            string query = "SELECT User_Type FROM Login_Details WHERE Login_Username = '" + username + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public string GetResidentName(string username)
        {
            string query = "SELECT R_Name FROM Resident WHERE Username = '" + username + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int GetResidentId(string username)
        {
            string query = "SELECT ID FROM Resident WHERE Username = '" + username + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public string GetStaffName(string username)
        {
            string query = "SELECT Staff_Name FROM Compound_Staff WHERE Username = '" + username + "';";
            return (string)dbMan.ExecuteScalar(query);
        }
        public int GetStaffId(string username)
        {
            string query = "SELECT ID FROM Compound_Staff WHERE Username = '" + username + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int GetStaffDeptId(string username)
        {
            string query = "SELECT Dept_ID FROM Compound_Staff WHERE Username = '" + username + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        //SELECT D_Name FROM Department WHERE ID = 1
        public string GetStaffDeptName(int deptId)
        {
            string query = "SELECT D_Name FROM Department WHERE ID =" + deptId + ";";
            return (string)dbMan.ExecuteScalar(query);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}