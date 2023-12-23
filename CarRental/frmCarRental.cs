using CarRental.Classes;
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
    public partial class frmCarRental : Form
    {
        public readonly string Username, Password;
        public frmCarRental(string Username, string Password)
        {
            InitializeComponent();
            this.Username = Username;
            this.Password = Password;
        }
        private void frmCarRental_Load(object sender, EventArgs e)
        {
            Classes.Account account = new Classes.Account();
            account.Username = Username;
            account.Password = Password;
            Classes.Account accInfo = account.GetAccountByUsernamePassword();
            if (accInfo.AccountType == true)
            {
                LesseAccount(false);
                LessorAccount(true);
                LoadLessorCars();
            }
            else
            {
                LessorAccount(false);
                LesseAccount(true);
                LoadLesseeCars();
                cbStatus.Text = "All";
            }
        }
        private void pbProfile_Click(object sender, EventArgs e)
        {
            frmProfile frm = new frmProfile();
            frm.Profile(Username, Password);
            frm.ShowDialog();
        }
        private void btnAddLesseeCar_Click(object sender, EventArgs e)
        {
            frmAddCar frm = new frmAddCar();
            frm.Username = Username;
            frm.Password = Password;
            frm.FormClosed += LessorAccount_FormClosed;
            frm.ShowDialog();
        }
        private void btnRemoveLesseeCar_Click(object sender, EventArgs e)
        {
            int carID = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            Classes.Cars cars = new Classes.Cars();
            cars.CarID = carID;
            DialogResult result = MessageBox.Show("Delete selected car?", "Delete Car", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                cars.DeleteCar();
                MessageBox.Show("Car has been deleted.", "Delete Car", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLessorCars();
            }
        }
        private void btnUpdateLesseeCar_Click(object sender, EventArgs e)
        {
            int carID = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            Classes.Cars car = new Classes.Cars();
            if (car.GetStatusRented(carID) == false)
            {
                frmUpdateCar frm = new frmUpdateCar();
                frm.SetCarID(carID);
                frm.FormClosed += LessorAccount_FormClosed;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You cannot change car details as it is currently being rented.",
                                    "Status Rented",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }
        private void btnRent_Click(object sender, EventArgs e)
        {
            int carID = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            Classes.Cars carInfo = new Classes.Cars();
            if (carInfo.GetStatusRented(carID) == false)
            {
                frmRent frm = new frmRent();
                frm.Lessee(Username, Password);
                frm.SelectedCar(carID);
                frm.FormClosed += LesseeCar_FormClosed;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Car is already rented.",
                                    "Status Rented",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }
        private void btnUpdateRent_Click(object sender, EventArgs e)
        {
            int LesseeID = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            int CarID = Convert.ToInt32(dgvCars.CurrentRow.Cells[1].Value);
            frmUpdateRentCar frm = new frmUpdateRentCar();
            frm.LesseeID = LesseeID;
            frm.CarID = CarID;
            frm.FormClosed += RentedCars_FormClosed;
            frm.ShowDialog();
        }
        private void btnCancelRent_Click(object sender, EventArgs e)
        {
            int LesseeID = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            int CarID = Convert.ToInt32(dgvCars.CurrentRow.Cells[1].Value);
            Classes.Rent rent = new Classes.Rent();
            Classes.Cars carInfo = new Classes.Cars();
            rent.LesseeID = LesseeID;
            rent.CarID = CarID;
            carInfo.CarID = CarID;
            DialogResult result = MessageBox.Show("Cance rented car?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                rent.DeleteRent();
                carInfo.UpdateStatusAvailable();
                MessageBox.Show("Rent has been cancelled.", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRentedCars();
            }
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure, you want to sign out?",
                                             "Sign out",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmAccountSignIn frm = new frmAccountSignIn();
                frm.Show();
                this.Close();
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Classes.Cars cars = new Classes.Cars();
            if (cbStatus.Text == "Rented")
            {
                cars.Status = true;
                if (rdbCarName.Checked == true)
                {
                    cars.Category = "CarName";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbCapacity.Checked == true)
                {
                    cars.Category = "Capacity";
                    if (txtSearch.Text != "")
                    {
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else
                    {
                        dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                }
                else if (rdbCarType.Checked == true)
                {
                    cars.Category = "CarType";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbLocation.Checked == true)
                {
                    cars.Category = "Location";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            else if (cbStatus.Text == "Available")
            {
                cars.Status = false;
                if (rdbCarName.Checked == true)
                {
                    cars.Category = "CarName";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbCapacity.Checked == true)
                {
                    cars.Category = "Capacity";
                    if (txtSearch.Text != "")
                    {
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else
                    {
                        dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                }
                else if (rdbCarType.Checked == true)
                {
                    cars.Category = "CarType";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbLocation.Checked == true)
                {
                    cars.Category = "Location";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            else
            {
                if (rdbCarName.Checked == true)
                {
                    cars.Category = "CarName";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbCapacity.Checked == true)
                {
                    cars.Category = "Capacity";
                    if (txtSearch.Text != "")
                    {
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else
                    {
                        dgvCars.DataSource = cars.GetLesseeCars().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                }
                else if (rdbCarType.Checked == true)
                {
                    cars.Category = "CarType";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbLocation.Checked == true)
                {
                    cars.Category = "Location";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = null;
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            StatusInDataGridView();
        }
        private void rdbCarName_CheckedChanged(object sender, EventArgs e)
        {
            Classes.Cars cars = new Classes.Cars();
            dgvCars.DataSource = null;
            cars.Category = "CarName";
            cars.Search = txtSearch.Text;
            if (cbStatus.Text != "All")
            {
                if (cbStatus.Text == "Rented")
                {
                    cars.Status = true;
                }
                else if (cbStatus.Text == "Available")
                {
                    cars.Status = false;
                }
                dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            }
            else
            {
                dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            }
            StatusInDataGridView();
        }
        private void rdbCapacity_CheckedChanged(object sender, EventArgs e)
        {
            Classes.Cars cars = new Classes.Cars();
            dgvCars.DataSource = null;
            cars.Category = "Capacity";
            if (txtSearch.Text == "")
            {
                if (cbStatus.Text != "All")
                {
                    if (cbStatus.Text == "Rented")
                    {
                        cars.Status = true;
                    }
                    else if (cbStatus.Text == "Available")
                    {
                        cars.Status = false;
                    }
                    dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else
                {
                    dgvCars.DataSource = cars.GetLesseeCars().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            else
            {
                cars.Search = txtSearch.Text;
                if (cbStatus.Text != "All")
                {
                    if (cbStatus.Text == "Rented")
                    {
                        cars.Status = true;
                    }
                    else if (cbStatus.Text == "Available")
                    {
                        cars.Status = false;
                    }
                    dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else
                {
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            StatusInDataGridView();
        }
        private void rdbCarType_CheckedChanged(object sender, EventArgs e)
        {
            Classes.Cars cars = new Classes.Cars();
            dgvCars.DataSource = null;
            cars.Category = "CarType";
            cars.Search = txtSearch.Text;
            if (cbStatus.Text != "All")
            {
                if (cbStatus.Text == "Rented")
                {
                    cars.Status = true;
                }
                else if (cbStatus.Text == "Available")
                {
                    cars.Status = false;
                }
                dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            }
            else
            {
                dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            }
            StatusInDataGridView();
        }
        private void rdbLocation_CheckedChanged(object sender, EventArgs e)
        {
            Classes.Cars cars = new Classes.Cars();
            dgvCars.DataSource = null;
            cars.Category = "Location";
            cars.Search = txtSearch.Text;
            if (cbStatus.Text != "All")
            {
                if (cbStatus.Text == "Rented")
                {
                    cars.Status = true;
                }
                else if (cbStatus.Text == "Available")
                {
                    cars.Status = false;
                }
                dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            }
            else
            {
                dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            }
            StatusInDataGridView();
        }
        private void rdbLesseeCars_CheckedChanged(object sender, EventArgs e)
        {
            lblViewLeesseCar.Visible = true;
            lblViewRentedCar.Visible = false;
            pnlRent.Visible = true;
            pnlUpdateRent.Visible = false;
            pnlCancelRent.Visible = false;
            pnlSearch.Visible = true;
            pnlCategory.Visible = true;
            pnlStatus.Visible = true;
            LoadLesseeCars();
        }
        private void rdbRentCars_CheckedChanged(object sender, EventArgs e)
        {
            lblViewLeesseCar.Visible = false;
            lblViewRentedCar.Visible = true;
            pnlRent.Visible = false;
            pnlUpdateRent.Visible = true;
            pnlCancelRent.Visible = true;
            pnlSearch.Visible = false;
            pnlCategory.Visible = false;
            pnlStatus.Visible = false;
            LoadRentedCars();
        }
        private void cbStatus_TextChanged(object sender, EventArgs e)
        {
            Classes.Cars cars = new Classes.Cars();
            dgvCars.DataSource = null;
            if (cbStatus.Text == "Rented")
            {
                cars.Status = true;
                if (rdbCarName.Checked == true || rdbCapacity.Checked == true || rdbCarType.Checked == true || rdbLocation.Checked == true)
                {
                    if (rdbCarName.Checked == true)
                    {
                        cars.Category = "CarName";
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else if (rdbCapacity.Checked == true)
                    {
                        cars.Category = "Capacity";
                        if (txtSearch.Text != "")
                        {
                            cars.Search = txtSearch.Text;
                            dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                        }
                        else
                        {
                            dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                        }
                    }
                    else if (rdbCarType.Checked == true)
                    {
                        cars.Category = "CarType";
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else if (rdbLocation.Checked == true)
                    {
                        cars.Category = "Location";
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                }
                else
                {
                    dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            else if (cbStatus.Text == "Available")
            {
                cars.Status = false;
                if (rdbCarName.Checked == true || rdbCapacity.Checked == true || rdbCarType.Checked == true || rdbLocation.Checked == true)
                {
                    if (rdbCarName.Checked == true)
                    {
                        cars.Category = "CarName";
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else if (rdbCapacity.Checked == true)
                    {
                        cars.Category = "Capacity";
                        if (txtSearch.Text != "")
                        {
                            cars.Search = txtSearch.Text;
                            dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                        }
                        else
                        {
                            dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                        }
                    }
                    else if (rdbCarType.Checked == true)
                    {
                        cars.Category = "CarType";
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else if (rdbLocation.Checked == true)
                    {
                        cars.Category = "Location";
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategory().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                }
                else
                {
                    dgvCars.DataSource = cars.GetCarWithStatus().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            else
            {
                if (rdbCarName.Checked == true)
                {
                    cars.Category = "CarName";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbCapacity.Checked == true)
                {
                    cars.Category = "Capacity";
                    if (txtSearch.Text != "")
                    {
                        cars.Search = txtSearch.Text;
                        dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                    else
                    {
                        dgvCars.DataSource = cars.GetLesseeCars().Select(car => new LoadCarsCapacityCategory { CarID = car.CarID, CarName = car.CarName, Capacity = car.Capacity, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                    }
                }
                else if (rdbCarType.Checked == true)
                {
                    cars.Category = "CarType";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsCarTypeCategory { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else if (rdbLocation.Checked == true)
                {
                    cars.Category = "Location";
                    cars.Search = txtSearch.Text;
                    dgvCars.DataSource = cars.GetCarWithCategoryWithoutStatus().Select(car => new LoadCarsLocationCategory { CarID = car.CarID, CarName = car.CarName, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
                else
                {
                    dgvCars.DataSource = cars.GetLesseeCars().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
                }
            }
            StatusInDataGridView();
        }
        private void dgvCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int CarID = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);
            frmCarFullDescription frm = new frmCarFullDescription();
            frm.CarID = CarID;
            frm.ShowDialog();
        }
        private void LesseAccount(bool visibility)
        {
            pnlRent.Visible = visibility;
            pnlView.Visible = visibility;
            pnlSearch.Visible = visibility;
            pnlCategory.Visible = visibility;
            pnlStatus.Visible = visibility;
            rdbLesseeCars.Checked = visibility;
        }
        private void LessorAccount(bool visibility)
        {
            pnlAddLesseeCar.Visible = visibility;
            pnlUpdateLesseeCar.Visible = visibility;
            pnlRemoveLesseeCar.Visible = visibility;
            pnlRemoveLesseeCar.Visible = visibility;
            pnlUpdateLesseeCar.Visible = visibility;
        }
        private void LoadLesseeCars()
        {
            Classes.Cars cars = new Classes.Cars();
            dgvCars.DataSource = null;
            dgvCars.DataSource = cars.GetLesseeCars().Select(car => new LoadCarsWithoutCategory { CarID = car.CarID, CarName = car.CarName, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            StatusInDataGridView();
        }
        private void LoadLessorCars()
        {
            Classes.Cars cars = new Classes.Cars();
            cars.Username = Username;
            dgvCars.DataSource = null;
            dgvCars.DataSource = cars.GetLessorCars().Select(car => new LoadLessorCars { CarID = car.CarID, CarName = car.CarName, CarType = car.CarType, Capacity = car.Capacity, Location = car.Location, Rate = car.Rate, Status = car.Status.ToString() }).ToList();
            StatusInDataGridView();

        }
        private void LoadRentedCars()
        {
            Classes.Account account = new Classes.Account();
            account.Username = Username;
            account.Password = Password;
            Classes.Account accInfo = account.GetAccountByUsernamePassword();
            Classes.Rent rent = new Classes.Rent();
            rent.LesseeID = accInfo.ID;
            dgvCars.DataSource = null;
            dgvCars.DataSource = rent.GetRentCarByLesseeID();
        }
        private void StatusInDataGridView()
        {
            foreach (DataGridViewRow row in dgvCars.Rows)
            {
                var cell = row.Cells["Status"];

                if (bool.TryParse(cell.Value.ToString(), out bool statusValue))
                {
                    cell.Value = statusValue ? "Rented" : "Available";
                }
            }
        }
        private void LesseeCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadLesseeCars();
        }
        private void LessorAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadLessorCars();
        }
        private void RentedCars_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadRentedCars();
        }
    }
    class LoadCarsWithoutCategory
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public float Rate { get; set; }
        public string Status { get; set; }
    }
    class LoadCarsCapacityCategory
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public int Capacity { get; set; }
        public float Rate { get; set; }
        public string Status { get; set; }
    }
    class LoadCarsCarTypeCategory
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public float Rate { get; set; }
        public string Status { get; set; }
    }
    class LoadCarsLocationCategory
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string Location { get; set; }
        public float Rate { get; set; }
        public string Status { get; set; }
    }
    class LoadLessorCars
    {
        public int CarID { get; set; }
        public string CarName { get; set; }
        public string CarType { get; set; }
        public int Capacity { get; set; }
        public string Location { get; set; }
        public float Rate { get; set; }
        public string Status { get; set; }
    }
}
