using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRental.Classes
{
    internal class Account
    {
        public int ID { get; set; }
        public string GivenName { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public bool Gender { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool AccountType { get; set; }
        public int LesseeID { get; set; }
        public int LessorID { get; set; }
        public string LicenceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public bool SignInResult;
        public void Insert()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " insert into tblAccount";
            sql += " values (";
            sql += " @GivenName,";
            sql += " @Surname,";
            sql += " @Username,";
            sql += " @Gender,";
            sql += " @Password,";
            sql += " @Email,";
            sql += " @PhoneNumber,";
            sql += " @Address,";
            sql += " @AccountType";
            sql += " )";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@GivenName", GivenName));
            cmd.Parameters.Add(new SqlParameter("@Surname", Surname));
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cmd.Parameters.Add(new SqlParameter("@Gender", Gender));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cmd.Parameters.Add(new SqlParameter("@Email", Email));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cmd.Parameters.Add(new SqlParameter("@AccountType", AccountType));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            if (AccountType == true)
            {
                InsertLessorAccount();
            }
            else
            {
                InsertLesseeAccount();
            }
        }
        private void InsertLesseeAccount()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " insert into tblLesseeAccount";
            sql += " (Username, LesseeID, LicenceNumber, IssueDate)";
            sql += " values (";
            sql += " @Username,";
            sql += " (select AccountID from tblAccount where Username like @Username),";
            sql += " @LicenceNumber,";
            sql += " @IssueDate";
            sql += " )";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cmd.Parameters.Add(new SqlParameter("@LicenceNumber", LicenceNumber));
            cmd.Parameters.Add(new SqlParameter("@IssueDate", IssueDate));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        private void InsertLessorAccount()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " insert into tblLessorAccount";
            sql += " (Username, LessorID)";
            sql += " values (";
            sql += " @Username,";
            sql += " (select AccountID from tblAccount where Username like @Username)";
            sql += " )";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void Update()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " update tblAccount";
            sql += " set Email = @Email,";
            sql += " PhoneNumber = @PhoneNumber,";
            sql += " Address = @Address";
            sql += " where AccountID = @AccountID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@AccountID", ID));
            cmd.Parameters.Add(new SqlParameter("@Email", Email));
            cmd.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
            cmd.Parameters.Add(new SqlParameter("@Address", Address));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public Account GetAccountByUsernamePassword()
        {
            SignInResult = false;
            List<Account> account = new List<Account>();
            Classes.Account accInfo = new Classes.Account();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblAccount";
            sql += " where Username like @Username";
            sql += " and Password like @Password";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cmd.Parameters.Add(new SqlParameter("@Password", Password));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                accInfo.ID = Convert.ToInt32(dr["AccountID"]);
                accInfo.GivenName = dr["GivenName"].ToString();
                accInfo.Surname = dr["Surname"].ToString();
                accInfo.Username = dr["Username"].ToString();
                accInfo.Gender = Convert.ToBoolean(dr["Gender"]);
                accInfo.Password = dr["Password"].ToString();
                accInfo.Email = dr["Email"].ToString();
                accInfo.PhoneNumber = dr["PhoneNumber"].ToString();
                accInfo.Address = dr["Address"].ToString();
                accInfo.AccountType = Convert.ToBoolean(dr["AccountType"]);
                account.Add(accInfo);
                SignInResult = true;
            }
            cn.Close();
            if (accInfo.AccountType == true)
            {
                accInfo.GetLessorAccount(accInfo.ID);
            }
            else
            {
                accInfo.GetLesseeAccount(accInfo.ID);
            }
            return accInfo;
        }
        public Account GetLesseeByUsername()
        {
            List<Account> account = new List<Account>();
            Classes.Account accInfo = new Classes.Account();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblLesseeAccount";
            sql += " where Username like @Username";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                accInfo.LesseeID = Convert.ToInt32(dr["LesseeID"]);
                accInfo.LicenceNumber = dr["LicenceNumber"].ToString();
                accInfo.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                account.Add(accInfo);
            }
            cn.Close();
            return accInfo;
        }
        public Account GetLessorAccountByID()
        {
            List<Account> account = new List<Account>();
            Classes.Account accInfo = new Classes.Account();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblAccount";
            sql += " where AccountID = @LessorID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@LessorID", LessorID));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                accInfo.ID = Convert.ToInt32(dr["AccountID"]);
                accInfo.GivenName = dr["GivenName"].ToString();
                accInfo.Surname = dr["Surname"].ToString();
                accInfo.Username = dr["Username"].ToString();
                accInfo.Gender = Convert.ToBoolean(dr["Gender"]);
                accInfo.Password = dr["Password"].ToString();
                accInfo.Email = dr["Email"].ToString();
                accInfo.PhoneNumber = dr["PhoneNumber"].ToString();
                accInfo.Address = dr["Address"].ToString();
                accInfo.AccountType = Convert.ToBoolean(dr["AccountType"]);
                account.Add(accInfo);
            }
            cn.Close();
            return accInfo;
        }
        public bool GetUsername()
        {
            bool exist = false;
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblAccount";
            sql += " where Username like @Username";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Username", "%" + Username + "%"));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                exist = true;
            }
            cn.Close();
            return exist;
        }
        public bool GetLicenceNumber()
        {
            bool exist = false;
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblLesseeAccount";
            sql += " where LicenceNumber like @LicenceNumber";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@LicenceNumber", "%" + LicenceNumber + "%"));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                exist = true;
            }
            cn.Close();
            return exist;
        }
        public List<Account> GetLesseeAccount(int ID)
        {
            List<Account> account = new List<Account>();
            Classes.Account accInfo = new Classes.Account();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblLesseeAccount";
            sql += " where LesseeID = @ID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                accInfo.LesseeID = Convert.ToInt32(dr["LesseeID"]);
                accInfo.LicenceNumber = dr["LicenceNumber"].ToString();
                accInfo.IssueDate = Convert.ToDateTime(dr["IssueDate"]);
                account.Add(accInfo);
            }
            cn.Close();
            return account;
        }
        public List<Account> GetLessorAccount(int ID)
        {
            List<Account> account = new List<Account>();
            Classes.Account accInfo = new Classes.Account();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblLessorAccount";
            sql += " where LessorID = @ID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@ID", ID));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                accInfo.LessorID = Convert.ToInt32(dr["LessorID"]);
                account.Add(accInfo);
            }
            cn.Close();
            return account;
        }
    }
}
