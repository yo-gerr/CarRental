using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmUpdateCar : Form
    {
        private int CarID;
        private string CarPhoto { get; set; }
        public void SetCarID(int carID)
        {
            CarID = carID;
        }
        public int GetCarID()
        {
            return CarID;
        }
        public frmUpdateCar()
        {
            InitializeComponent();
        }
        private void frmUpdate_Load(object sender, EventArgs e)
        {
            SelectedCar();
        }
        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpeg;*.jpg;*.webp|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(ofd.FileName).Equals(".png") ||
                    Path.GetExtension(ofd.FileName).Equals(".jpg") ||
                    Path.GetExtension(ofd.FileName).Equals(".jpeg"))

                {
                    this.CarPhoto = Path.GetFullPath(ofd.FileName);
                    ptbCarPhoto.Image = new Bitmap(ofd.FileName);
                }
                else
                {
                    MessageBox.Show("Invalid File Type");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Classes.Cars carInfo = new Classes.Cars();
            if (txtCarName.Text != "" && txtCarType.Text != "" && txtCapacity.Text != "" && txtPlateNumber.Text != "" && txtLocation.Text != "" && this.CarPhoto != null)
            {
                DialogResult result = MessageBox.Show("Save changes?",
                                              "Update Lessee Car",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    carInfo.CarID = GetCarID();
                    carInfo.CarName = txtCarName.Text;
                    carInfo.CarType = txtCarType.Text;
                    carInfo.Capacity = Convert.ToInt32(txtCapacity.Text);
                    carInfo.ModelYear = dtpModelYear.Value;
                    carInfo.PlateNumber = txtPlateNumber.Text;
                    carInfo.Location = txtLocation.Text;
                    carInfo.CarPhoto = this.CarPhoto;
                    carInfo.UpdateCar();
                    MessageBox.Show("Changes saved.", "Update Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please do not leave any fields blank; kindly enter all the required details.",
                                    "Enter all details",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
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
        }
    }
}
