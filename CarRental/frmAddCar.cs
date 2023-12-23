using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmAddCar : Form
    {
        public string Username, Password;
        public string CarPhoto { get; set; }
        public frmAddCar()
        {
            InitializeComponent();
        }
        private void frmAddCar_Load(object sender, EventArgs e)
        {
            Classes.Account account = new Classes.Account();
            account.Username = Username;
            account.Password = Password;
            Classes.Account accInfo = account.GetAccountByUsernamePassword();
            txtLocation.Text = accInfo.Address;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Classes.Cars carInfo = new Classes.Cars();
            List<Classes.Cars> car = new List<Classes.Cars>();
            carInfo.PlateNumber = txtPlateNumber.Text;
            if (txtCarName.Text != "" && txtCarType.Text != "" && txtCapacity.Text != "" && txtPlateNumber.Text != "" && txtLocation.Text != "" && CarPhoto != "")
            {
                if (carInfo.GetPlateNumber() == true)
                {
                    MessageBox.Show("Plate number is already existed.",
                                                        "Plate Number Exist",
                                                        MessageBoxButtons.OK,
                                                        MessageBoxIcon.Information);
                    txtPlateNumber.Text = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Proceed to add lessee car?",
                                                      "Add Lessee Car",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        carInfo.Username = Username;
                        carInfo.CarName = txtCarName.Text;
                        carInfo.CarType = txtCarType.Text;
                        carInfo.Capacity = Convert.ToInt32(txtCapacity.Text);
                        carInfo.ModelYear = dtpModelYear.Value;
                        carInfo.PlateNumber = txtPlateNumber.Text;
                        carInfo.Location = txtLocation.Text;
                        carInfo.CarPhoto = this.CarPhoto;
                        car.Add(carInfo);
                        carInfo.InsertCar();
                        MessageBox.Show("Lessee car are successfully added", "Successfully Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
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
            DialogResult result = MessageBox.Show("Cancel add lessee car?",
                                                  "Add Lessee Car",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Visible = false;
            }
        }
    }
}