using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CarRental
{
    public partial class frmProfile : Form
    {
        Classes.Account account = new Classes.Account();
        private int AccountID { get; set; }
        private string Username {  get; set; }
        private string Password { get; set; }
        public frmProfile()
        {
            InitializeComponent();
        }
        private void frmProfile_Load(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to change your account information?", "Update Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtEmail.ReadOnly = false;
                mtxtPhoneNumber.ReadOnly = false;
                txtAddress.ReadOnly = false;
                btnBack.Visible = false;
                btnSave.Visible = true;
                btnEdit.Visible = false;
                btnCancel.Visible = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && mtxtPhoneNumber.Text != "" && txtAddress.Text != "")
            {
                DialogResult result = MessageBox.Show("Save changes?",
                                              "Update Account",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Classes.Account accInfo = new Classes.Account();
                    accInfo.ID = this.AccountID;
                    accInfo.Email = txtEmail.Text;
                    accInfo.PhoneNumber = mtxtPhoneNumber.Text.Remove(0, 5).Trim();
                    accInfo.Address = txtAddress.Text;
                    accInfo.Update();
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
            DialogResult result = MessageBox.Show("Do you want to cancel updating your account information?", "Update Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtEmail.ReadOnly = true;
                mtxtPhoneNumber.ReadOnly = true;
                txtAddress.ReadOnly = true;
                btnBack.Visible = true;
                btnSave.Visible = false;
                btnEdit.Visible = true;
                btnCancel.Visible = false;
                Profile(this.Username, this.Password);
            }          
        }
        public void Profile(string Username, string Password)
        {
            account.Username = Username;
            account.Password = Password;
            this.Username = Username;
            this.Password = Password;
            Classes.Account accInfo = account.GetAccountByUsernamePassword();
            txtName.Text = accInfo.GivenName.ToString() + " " + accInfo.Surname.ToString();
            if (accInfo.Gender == true)
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            txtEmail.Text = accInfo.Email.ToString();
            mtxtPhoneNumber.Text = accInfo.PhoneNumber.ToString().Trim();
            txtAddress.Text = accInfo.Address.ToString();
            this.AccountID = accInfo.ID;
        }
    }
}
