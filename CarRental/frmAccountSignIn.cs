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
    public partial class frmAccountSignIn : Form
    {
        public frmAccountSignIn()
        {
            InitializeComponent();
        }

        private void frmAccountSignIn_Load(object sender, EventArgs e)
        {

        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmAccountSignUp frm = new frmAccountSignUp();
            frm.Show();
            Visible = false;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Classes.Account account = new Classes.Account();
            account.Username = txtUsername.Text;
            account.Password = txtPassword.Text;
            account.GetAccountByUsernamePassword();
            if (account.SignInResult == true)
            {
                MessageBox.Show("You have successfully signed in.", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmCarRental frm = new frmCarRental(account.Username, account.Password);
                frm.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("Login failed. Please recheck the username and password and try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }
        private void pbHidePassword_Click(object sender, EventArgs e)
        {
            pbHidePassword.Visible = false;
            pbShowPassword.Visible = true;
            txtPassword.UseSystemPasswordChar = false;
        }
        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            pbShowPassword.Visible = false;
            pbHidePassword.Visible = true;
            txtPassword.UseSystemPasswordChar = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Exit.",
                                             "Close Program",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
