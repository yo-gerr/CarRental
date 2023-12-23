using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class frmUpdateRentCar : Form
    {
        public int LesseeID { get; set; }
        public int CarID { get; set; }
        public frmUpdateRentCar()
        {
            InitializeComponent();
        }
        private void frmUpdateRentCar_Load(object sender, EventArgs e)
        {
            SelectedRentedCar();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save changes?",
                                              "Update Lessee Car",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Classes.Rent rent = new Classes.Rent();
                rent.LesseeID = LesseeID;
                rent.CarID = CarID;
                rent.PickUp = dtpPickUp.Value;
                rent.DropOff = dtpDropOff.Value;
                rent.UpdateRent();
                MessageBox.Show("Changes saved.", "Update Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cancel updating rented car?",
                                                  "Update Rented Car",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Visible = false;
            }
        }
        private void SelectedRentedCar()
        {
            Classes.Rent rent = Classes.Rent.GetRentCarByLesseeIDandCarID(LesseeID, CarID);
            dtpPickUp.Value = rent.PickUp;
            dtpDropOff.Value = rent.DropOff;
        }
    }
}
