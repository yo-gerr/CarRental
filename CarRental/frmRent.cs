using CarRental.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CarRental
{
    public partial class frmRent : Form
    {
        private int CarID { get; set; }
        private int LesseeID { get; set; }
        private int LessorID { get; set; }
        public frmRent()
        {
            InitializeComponent();
        }
        private void frmRent_Load(object sender, EventArgs e)
        {

        }
        public void Lessee(string Username, string Password)
        {
            Classes.Account account = new Classes.Account();
            account.Username = Username;
            account.Password = Password;
            Classes.Account accInfo = account.GetAccountByUsernamePassword();
            txtLesseeName.Text = accInfo.GivenName.ToString() + " " + accInfo.Surname.ToString();
            txtLesseEmail.Text = accInfo.Email.ToString();
            mtxtLesseePhoneNumber.Text = accInfo.PhoneNumber.ToString().Trim();
            txtLesseeAddress.Text = accInfo.Address.ToString();
            Classes.Account LesseeInfo = account.GetLesseeByUsername();
            txtLesseeLicenceNumber.Text = LesseeInfo.LicenceNumber.ToString();
            LesseeID = accInfo.ID;
        }
        public void SelectedCar(int CarID)
        {
            Classes.Cars car = Classes.Cars.GetLessorCarByCarID(CarID);
            txtCarName.Text = car.CarName.ToString();
            txtCarType.Text = car.CarType.ToString();
            txtCapacity.Text = car.Capacity.ToString();
            mtxtModelYear.Text = car.ModelYear.ToString();
            txtLocation.Text = car.Location.ToString();
            Lessor(car.OwnerID);
            this.CarID = CarID;
        }
        public void Lessor(int LessorID)
        {
            Classes.Account account = new Classes.Account();
            account.LessorID = LessorID;
            Classes.Account accInfo = account.GetLessorAccountByID();
            txtLessorName.Text = accInfo.GivenName.ToString() + " " + accInfo.Surname.ToString();
            txtLessorEmail.Text = accInfo.Email.ToString();
            mtxtLessorPhoneNumber.Text = accInfo.PhoneNumber.ToString().Trim();
            this.LessorID = LessorID;
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            Classes.Cars car = new Classes.Cars();
            DialogResult result = MessageBox.Show("Are you sure you want to rent this car?",
                                              "Rent",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Classes.Rent rentCar = new Classes.Rent();
                List<Classes.Rent> rents = new List<Classes.Rent>();
                rentCar.LesseeID = this.LesseeID;
                rentCar.CarID = this.CarID;
                rentCar.CarName = txtCarName.Text;
                rentCar.LessorID = this.LessorID;
                rentCar.PickUp = dtpPickUp.Value;
                rentCar.DropOff = dtpDropOff.Value;
                rents.Add(rentCar);
                rentCar.InsertRent();
                car.Status = true;
                car.CarID = CarID;
                car.UpdateStatusRented();
                MessageBox.Show("Successfully rented", "Rented Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel updating car?",
                                                  "Update Lessee Car",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Visible = false;
            }
        }
    }
}
