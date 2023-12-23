using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Classes
{
    internal class Rent
    {
        public int LesseeID { get; set; }
        public int CarID { get; set; }
        public string CarName { get; set; }
        public int LessorID { get; set; }
        public DateTime PickUp { get; set; }
        public DateTime DropOff { get; set; }
        public void InsertRent()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " insert into tblRentCar";
            sql += " values (";
            sql += " @LesseeID,";
            sql += " @CarID,";
            sql += " @CarName,";
            sql += " @LessorId,";
            sql += " @PickUp,";
            sql += " @DropOff";
            sql += " )";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@LesseeID", LesseeID));
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cmd.Parameters.Add(new SqlParameter("@CarName", CarName));
            cmd.Parameters.Add(new SqlParameter("@LessorID", LessorID));
            cmd.Parameters.Add(new SqlParameter("@PickUp", PickUp));
            cmd.Parameters.Add(new SqlParameter("@DropOff", DropOff));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdateRent()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " update tblRentCar";
            sql += " set PickUp = @PickUp,";
            sql += " DropOff = @DropOff";
            sql += " where LesseeID = @LesseeID";
            sql += " and CarID = @CarID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@LesseeID", LesseeID));
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cmd.Parameters.Add(new SqlParameter("@PickUp", PickUp));
            cmd.Parameters.Add(new SqlParameter("DropOff", DropOff));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void DeleteRent()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " delete tblRentCar";
            sql += " where LesseeID = @LesseeID";
            sql += " and CarID = @CarID";
            cmd.Parameters.Add(new SqlParameter("@LesseeID", LesseeID));
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cmd.CommandText = sql;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public List<Rent> GetRentCarByLesseeID()
        {
            List<Rent> rentedCars = new List<Rent>();
            Classes.Rent rent = new Classes.Rent();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = " select * from tblRentCar";
            sql += " where LesseeID = @LesseeID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@LesseeID", LesseeID));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                rent.LesseeID = Convert.ToInt32(dr["LesseeID"]);
                rent.CarID = Convert.ToInt32(dr["CarID"]);
                rent.CarName = dr["CarName"].ToString();
                rent.LessorID = Convert.ToInt32(dr["LessorID"]);
                rent.PickUp = Convert.ToDateTime(dr["PickUp"]);
                rent.DropOff = Convert.ToDateTime(dr["DropOff"]);
                rentedCars.Add(rent);
            }
            cn.Close();
            return rentedCars;
        }
        public static Rent GetRentCarByLesseeIDandCarID(int LesseeID, int CarID)
        {
            Classes.Rent rent = new Classes.Rent();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = " select * from tblRentCar";
            sql += " where LesseeID = @LesseeID";
            sql += " and CarID = @CarID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@LesseeID", LesseeID));
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rent.LesseeID = Convert.ToInt32(dr["LesseeID"]);
                rent.CarID = Convert.ToInt32(dr["CarID"]);
                rent.CarName = dr["CarName"].ToString();
                rent.LessorID = Convert.ToInt32(dr["LessorID"]);
                rent.PickUp = Convert.ToDateTime(dr["PickUp"]);
                rent.DropOff = Convert.ToDateTime(dr["DropOff"]);
            }
            cn.Close();
            return rent;
        }
    }
}
