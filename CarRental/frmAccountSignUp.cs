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
using System.IO;

namespace CarRental
{
    public partial class frmAccountSignUp : Form
    {
        public string CarPhoto {  get; set; }
        public frmAccountSignUp()
        {
            InitializeComponent();
            tbcSignUp.SelectedTab = tbpMyProfile;
        }
        private void frmAccountSignUp_Load(object sender, EventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tbcSignUp.SelectedTab == tbpMyProfile)
            {
                if (txtGivenName.Text != "" && txtSurname.Text != "" && txtUsername.Text != "" &&
                   (rdbMale.Checked == true || rdbFemale.Checked == true) && txtPassword.Text != "" &&
                   txtRetypePassword.Text != "")
                {
                    if (txtPassword.Text == txtRetypePassword.Text)
                    {
                        Classes.Account account = new Classes.Account();
                        account.Username = txtUsername.Text;
                        if (account.GetUsername() == true)
                        {
                            MessageBox.Show("Username is already existed.",
                                            "Username Exist",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                            txtUsername.Text = "";
                        }
                        else
                        {
                            tbcSignUp.SelectedTab = tbpContactDetails;
                            pbContactDetails.Image = CarRental.Properties.Resources.CheckMark;
                            btnBack.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password do not match.",
                                        "Confirm Password",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                        txtRetypePassword.Text = "";
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
            else if (tbcSignUp.SelectedTab == tbpContactDetails)
            {
                if (txtEmail.Text != "" && mtxtPhoneNumber.MaskCompleted && txtAddress.Text != "")
                {
                    tbcSignUp.SelectedTab = tbpAccountType;
                    pbAccountType.Image = CarRental.Properties.Resources.CheckMark;
                    btnNext.Visible = false;
                    btnSubmit.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please do not leave any fields blank; kindly enter all the required details.",
                                    "Enter all details",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Classes.Account accInfo = new Classes.Account();
            Classes.Cars carInfo = new Classes.Cars();
            if (txtLicenceNumber.Text != "" || (txtCarName.Text != "" && txtCarType.Text != "" && txtCapacity.Text != "" && txtPlateNumber.Text != "" && CarPhoto != ""))
            {
                accInfo.LicenceNumber = txtLicenceNumber.Text;
                carInfo.PlateNumber = txtPlateNumber.Text;
                if (rdbLessee.Checked == true && accInfo.GetLicenceNumber() == true)
                {

                    MessageBox.Show("Licence number is already existed.",
                                            "Licence Number Exist",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                    txtLicenceNumber.Text = "";
                }
                else if (rdbLessor.Checked == true && carInfo.GetPlateNumber() == true)
                {
                    MessageBox.Show("Plate number is already existed.",
                                                    "Plate Number Exist",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Information);
                    txtPlateNumber.Text = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Would you like to submit your account information\nand create an account?",
                                                                  "Sign Up",
                                                                  MessageBoxButtons.YesNo,
                                                                  MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        List<Classes.Account> account = new List<Classes.Account>();
                        List<Classes.Cars> car = new List<Classes.Cars>();
                        accInfo.GivenName = txtGivenName.Text;
                        accInfo.Surname = txtSurname.Text;
                        accInfo.Username = txtUsername.Text;
                        if (rdbMale.Checked == true)
                        {
                            accInfo.Gender = true;
                        }
                        else
                        {
                            accInfo.Gender = false;
                        }
                        accInfo.Password = txtPassword.Text;
                        accInfo.Email = txtEmail.Text;
                        accInfo.PhoneNumber = mtxtPhoneNumber.Text.Remove(0, 5).Trim();
                        accInfo.Address = txtAddress.Text;
                        if (rdbLessee.Checked == true)
                        {
                            accInfo.AccountType = false;
                            accInfo.LicenceNumber = txtLicenceNumber.Text;
                            accInfo.IssueDate = dtpIssueDate.Value;
                            account.Add(accInfo);
                            accInfo.Insert();
                        }
                        else
                        {
                            accInfo.AccountType = true;
                            carInfo.Username = txtUsername.Text;
                            carInfo.CarName = txtCarName.Text;
                            carInfo.CarType = txtCarType.Text;
                            carInfo.Capacity = Convert.ToInt32(txtCapacity.Text);
                            carInfo.ModelYear = dtpModelYear.Value;
                            carInfo.PlateNumber = txtPlateNumber.Text;
                            carInfo.Location = txtAddress.Text;
                            carInfo.CarPhoto = this.CarPhoto;
                            account.Add(accInfo);
                            accInfo.Insert();
                            car.Add(carInfo);
                            carInfo.InsertCar();
                        }                 
                        MessageBox.Show("Your account has been successfully created.", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAccountSignIn frmSignIn = new frmAccountSignIn();
                        frmSignIn.Show();
                        Visible = false;
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tbcSignUp.SelectedTab == tbpContactDetails)
            {
                tbcSignUp.SelectedTab = tbpMyProfile;
                pbContactDetails.Image = CarRental.Properties.Resources.UncheckMark;
                btnBack.Visible = false;
            }
            else if (tbcSignUp.SelectedTab == tbpAccountType)
            {
                tbcSignUp.SelectedTab = tbpContactDetails;
                pbAccountType.Image = CarRental.Properties.Resources.UncheckMark;
                btnSubmit.Visible = false;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to cancel the sign-up process?",
                                                  "Cancel",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmAccountSignIn frm = new frmAccountSignIn();
                frm.Show();
                Visible = false;
            }
        }
        private void rdbLessee_CheckedChanged(object sender, EventArgs e)
        {
            lblAdditionalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            LessorType(false);
            LesseeType(true);
            txtPlateNumber.Text = "";
            txtCarName.Text = "";
            txtCarType.Text = "";
            txtCapacity.Text = "";
            this.CarPhoto = "";
            ptbCarPhoto.Image = null;
        }
        private void rdbLessor_CheckedChanged(object sender, EventArgs e)
        {
            lblAdditionalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            LesseeType(false);
            LessorType(true);
            txtLicenceNumber.Text = "";
        }
        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            pbShowPassword.Visible = false;
            pbHidePassword.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void pbHidePassword_Click(object sender, EventArgs e)
        {
            pbHidePassword.Visible = false;
            pbShowPassword.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }
        private void LesseeType(bool visibility)
        {
            lblLicenceNumber.Visible = visibility;
            txtLicenceNumber.Visible = visibility;
            lblIssueDate.Visible = visibility;
            dtpIssueDate.Visible = visibility;
        }
        private void LessorType(bool visibility)
        {
            ptbCarPhoto.Visible = visibility;
            btnUploadPhoto.Visible = visibility;
            lblCarName.Visible = visibility;
            txtCarName.Visible = visibility;
            lblCarType.Visible = visibility;
            txtCarType.Visible = visibility;
            lblCapacity.Visible = visibility;
            txtCapacity.Visible = visibility;
            lblCapacity.Visible = visibility;
            lblModelYear.Visible = visibility;
            dtpModelYear.Visible = visibility;
            lblPlateNumber.Visible = visibility;
            txtPlateNumber.Visible = visibility;
        }
    }
}