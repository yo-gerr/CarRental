using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Classes
{
    internal class Cars
    {
        public string Username;
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public int Capacity { get; set; }
        public DateTime ModelYear { get; set; }
        public string PlateNumber { get; set; }
        public string CarPhoto { get; set; }
        public int OwnerID { get; set; }
        public string Location { get; set; }
        public float Rate { get; set; }
        public bool Status { get; set; }
        public string Category { get; set; }
        public string Search { get; set; }
        public void InsertCar()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " insert into tblCar";
            sql += " (CarName, CarType, Capacity, ModelYear, PlateNumber, OwnerID, Location, CarPhoto)";
            sql += " values (";
            sql += " @CarName,";
            sql += " @CarType,";
            sql += " @Capacity,";
            sql += " @ModelYear,";
            sql += " @PlateNumber,";
            sql += " (select AccountID from tblAccount where Username like @Username),";
            sql += " @Location,";
            sql += " @CarPhoto";
            sql += " )";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@CarName", CarName));
            cmd.Parameters.Add(new SqlParameter("@CarType", CarType));
            cmd.Parameters.Add(new SqlParameter("@Capacity", Capacity));
            cmd.Parameters.Add(new SqlParameter("@ModelYear", ModelYear));
            cmd.Parameters.Add(new SqlParameter("@PlateNumber", PlateNumber));
            cmd.Parameters.Add(new SqlParameter("@Location", Location));
            cmd.Parameters.Add(new SqlParameter("@CarPhoto", CarPhoto));
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdateCar()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " update tblCar";
            sql += " set CarName = @CarName,";
            sql += " CarType = @CarType,";
            sql += " Capacity = @Capacity,";
            sql += " ModelYear = @ModelYear,";
            sql += " PlateNumber = @PlateNumber,";
            sql += " Location = @Location,";
            sql += " CarPhoto = @CarPhoto";
            sql += " where CarID = @CarID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cmd.Parameters.Add(new SqlParameter("@CarName", CarName));
            cmd.Parameters.Add(new SqlParameter("@CarType", CarType));
            cmd.Parameters.Add(new SqlParameter("@Capacity", Capacity));
            cmd.Parameters.Add(new SqlParameter("@ModelYear", ModelYear));
            cmd.Parameters.Add(new SqlParameter("@PlateNumber", PlateNumber));
            cmd.Parameters.Add(new SqlParameter("@Location", Location));
            cmd.Parameters.Add(new SqlParameter("@CarPhoto", CarPhoto));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdateStatusRented()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " update tblCar";
            sql += " set Status = @Status";
            sql += " where CarID = @CarID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Status", true));
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void UpdateStatusAvailable()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " update tblCar";
            sql += " set Status = @Status";
            sql += " where CarID = @CarID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Status", false));
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public void DeleteCar()
        {
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " delete from tblCar";
            sql += " where CarID = @CarID";
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cmd.CommandText = sql;
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
        public List<Cars> GetLesseeCars()
        {
            List<Classes.Cars> cars = new List<Classes.Cars>();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = " select * from tblCar";
            cmd.CommandText = sql;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Classes.Cars car = new Classes.Cars();
                car.CarID = Convert.ToInt32(dr["CarID"]);
                car.CarName = dr["CarName"].ToString();
                car.CarType = dr["CarType"].ToString();
                car.Capacity = Convert.ToInt32(dr["Capacity"]);
                car.ModelYear = Convert.ToDateTime(dr["ModelYear"]);
                car.PlateNumber = dr["PlateNumber"].ToString();
                car.OwnerID = Convert.ToInt32(dr["OwnerID"]);
                car.Location = dr["Location"].ToString();
                car.CarPhoto = dr["CarPhoto"].ToString();
                car.Rate = float.Parse(dr["Rate"].ToString());
                car.Status = Convert.ToBoolean(dr["Status"]);
                cars.Add(car);
            }
            cn.Close();
            return cars;
        }
        public List<Cars> GetLessorCars()
        {
            List<Classes.Cars> cars = new List<Classes.Cars>();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = " select * from tblCar where OwnerID = (select LessorID from tblLessorAccount where Username like @Username)";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Username", Username));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Classes.Cars car = new Classes.Cars();
                car.CarID = Convert.ToInt32(dr["CarID"]);
                car.CarName = dr["CarName"].ToString();
                car.CarType = dr["CarType"].ToString();
                car.Capacity = Convert.ToInt32(dr["Capacity"]);
                car.ModelYear = Convert.ToDateTime(dr["ModelYear"]);
                car.PlateNumber = dr["PlateNumber"].ToString();
                car.OwnerID = Convert.ToInt32(dr["OwnerID"]);
                car.Location = dr["Location"].ToString();
                car.CarPhoto = dr["CarPhoto"].ToString();
                car.Rate = float.Parse(dr["Rate"].ToString());
                car.Status = Convert.ToBoolean(dr["Status"]);
                cars.Add(car);
            }
            cn.Close();
            return cars;
        }
        public static Cars GetLessorCarByCarID(int CarID)
        {
            List<Classes.Cars> cars = new List<Classes.Cars>();
            Classes.Cars car = new Classes.Cars();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = " select * from tblCar";
            sql += " where CarID = @CarID";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                car.CarID = Convert.ToInt32(dr["CarID"]);
                car.CarName = dr["CarName"].ToString();
                car.CarType = dr["CarType"].ToString();
                car.Capacity = Convert.ToInt32(dr["Capacity"]);
                car.ModelYear = Convert.ToDateTime(dr["ModelYear"]);
                car.PlateNumber = dr["PlateNumber"].ToString();
                car.OwnerID = Convert.ToInt32(dr["OwnerID"]);
                car.Location = dr["Location"].ToString();
                car.CarPhoto = dr["CarPhoto"].ToString();
                car.Rate = float.Parse(dr["Rate"].ToString());
                car.Status = Convert.ToBoolean(dr["Status"]);
                cars.Add(car);
            }
            cn.Close();
            return car;
        }
        public bool GetPlateNumber()
        {
            bool exist = false;
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblCar";
            sql += " where PlateNumber like @PlateNumber";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@PlateNumber", "%" + PlateNumber + "%"));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                exist = true;
            }
            cn.Close();
            return exist;
        }
        public bool GetStatusRented(int CarID)
        {
            bool rented = false;
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select *";
            sql += " from tblCar";
            sql += " where CarID = @CarID and Status = @Status";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@CarID", CarID));
            cmd.Parameters.Add(new SqlParameter("@Status", true));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                rented = true;
            }
            cn.Close();
            return rented;
        }
        public List<Cars> GetCarWithCategory()
        {
            List<Classes.Cars> cars = new List<Classes.Cars>();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            if (Status == true)
            {
                switch (Category)
                {
                    case "CarName":
                        cmd.CommandText = " select * from tblCar where CarName like @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                        break;
                    case "Capacity":
                        cmd.CommandText = " select * from tblCar where Capacity = @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", Convert.ToInt32(Search)));
                        break;
                    case "CarType":
                        cmd.CommandText = " select * from tblCar where CarType like @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                        break;
                    case "Location":
                        cmd.CommandText = " select * from tblCar where Location like @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                        break;
                }
                cmd.Parameters.Add(new SqlParameter("@Status", true));
            }
            else if (Status == false)
            {
                switch (Category)
                {
                    case "CarName":
                        cmd.CommandText = " select * from tblCar where CarName like @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                        break;
                    case "Capacity":
                        cmd.CommandText = " select * from tblCar where Capacity = @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", Convert.ToInt32(Search)));
                        break;
                    case "CarType":
                        cmd.CommandText = " select * from tblCar where CarType like @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                        break;
                    case "Location":
                        cmd.CommandText = " select * from tblCar where Location like @Search and Status = @Status";
                        cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                        break;
                }
                cmd.Parameters.Add(new SqlParameter("@Status", false));
            }
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Classes.Cars car = new Classes.Cars();
                car.CarID = Convert.ToInt32(dr["CarID"]);
                car.CarName = dr["CarName"].ToString();
                car.CarType = dr["CarType"].ToString();
                car.Capacity = Convert.ToInt32(dr["Capacity"]);
                car.ModelYear = Convert.ToDateTime(dr["ModelYear"]);
                car.PlateNumber = dr["PlateNumber"].ToString();
                car.OwnerID = Convert.ToInt32(dr["OwnerID"]);
                car.Location = dr["Location"].ToString();
                car.Rate = float.Parse(dr["Rate"].ToString());
                car.Status = Convert.ToBoolean(dr["Status"]);
                cars.Add(car);
            }
            cn.Close();
            return cars;
        }
        public List<Cars> GetCarWithCategoryWithoutStatus()
        {
            List<Classes.Cars> cars = new List<Classes.Cars>();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            switch (Category)
            {
                case "CarName":
                    cmd.CommandText = " select * from tblCar where CarName like @Search";
                    cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                    break;
                case "Capacity":
                    cmd.CommandText = " select * from tblCar where Capacity = @Search";
                    cmd.Parameters.Add(new SqlParameter("@Search", Convert.ToInt32(Search)));
                    break;
                case "CarType":
                    cmd.CommandText = " select * from tblCar where CarType like @Search";
                    cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                    break;
                case "Location":
                    cmd.CommandText = " select * from tblCar where Location like @Search";
                    cmd.Parameters.Add(new SqlParameter("@Search", "%" + Search + "%"));
                    break;
            }
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Classes.Cars car = new Classes.Cars();
                car.CarID = Convert.ToInt32(dr["CarID"]);
                car.CarName = dr["CarName"].ToString();
                car.CarType = dr["CarType"].ToString();
                car.Capacity = Convert.ToInt32(dr["Capacity"]);
                car.ModelYear = Convert.ToDateTime(dr["ModelYear"]);
                car.PlateNumber = dr["PlateNumber"].ToString();
                car.OwnerID = Convert.ToInt32(dr["OwnerID"]);
                car.Location = dr["Location"].ToString();
                car.Rate = float.Parse(dr["Rate"].ToString());
                car.Status = Convert.ToBoolean(dr["Status"]);
                cars.Add(car);
            }
            cn.Close();
            return cars;
        }
        public List<Cars> GetCarWithStatus()
        {
            List<Classes.Cars> cars = new List<Classes.Cars>();
            SqlConnection cn = new SqlConnection(Configuration.ConnString);
            SqlCommand cmd = cn.CreateCommand();
            string sql = "";
            sql += " select * from tblCar";
            sql += " where Status = @Status";
            cmd.CommandText = sql;
            cmd.Parameters.Add(new SqlParameter("@Status", Status));
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Classes.Cars car = new Classes.Cars();
                car.CarID = Convert.ToInt32(dr["CarID"]);
                car.CarName = dr["CarName"].ToString();
                car.CarType = dr["CarType"].ToString();
                car.Capacity = Convert.ToInt32(dr["Capacity"]);
                car.ModelYear = Convert.ToDateTime(dr["ModelYear"]);
                car.PlateNumber = dr["PlateNumber"].ToString();
                car.OwnerID = Convert.ToInt32(dr["OwnerID"]);
                car.Location = dr["Location"].ToString();
                car.Rate = float.Parse(dr["Rate"].ToString());
                car.Status = Convert.ToBoolean(dr["Status"]);
                cars.Add(car);
            }
            cn.Close();
            return cars;
        }
    }
}