using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmCarFullDescription : Form
    {
        public int CarID { get; set; }
        private string CarPhoto { get; set; }
        public frmCarFullDescription()
        {
            InitializeComponent();
        }
        private void frmCarFullDescription_Load(object sender, EventArgs e)
        {
            SelectedCar();
        }
        private void SelectedCar()
        {
            Classes.Cars car = Classes.Cars.GetLessorCarByCarID(CarID);
            txtCarName.Text = car.CarName.ToString();
            txtCarType.Text = car.CarType.ToString();
            txtCapacity.Text = car.Capacity.ToString();
            txtPlateNumber.Text = car.PlateNumber.ToString();
            txtLocation.Text = car.Location.ToString();
            this.CarPhoto = car.CarPhoto;
            ptbCarPhoto.Image = new Bitmap(car.CarPhoto);
            if (car.Status == true)
            {
                txtCarStatus.Text = "Rented";
            }
            else
            {
                txtCarStatus.Text = "Available";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
