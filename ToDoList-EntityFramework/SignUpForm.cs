using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace ToDoList_EntityFramework
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void toLoginLbl_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (IsAnyEmptyField())
            {
                MessageBox.Show("Fields cannot be empty!!!", "Empty Feild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isSamePasswords())
                {
                    if (isAdminemail())
                    {
                        MessageBox.Show("This email is reserverd!!!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        BusinessLayer bll = new BusinessLayer();
                        if (bll.AddUser(signupNicknameTextBox.Text.Trim(),
                            signupEmailTextbox.Text.Trim(),
                            signupPasswordTextbox.Text.Trim()))
                        {
                            MessageBox.Show("User Added Successfully!!!", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to Add User!!!", "User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password Dose'nt Match!!!", "Password Feild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool isAdminemail()
        {
            if (signupEmailTextbox.Text.Trim().ToLower().Contains("admin"))
            {
                return true;
            }
            return false;
        }

        private bool isSamePasswords()
        {
            if (signupPasswordTextbox.Text == signupConfirmPasswordTextbox.Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsAnyEmptyField()
        {
            if (signupNicknameTextBox.Text.Trim() == "" ||
            signupEmailTextbox.Text.Trim() == "" ||
            signupPasswordTextbox.Text.Trim() == "" ||
            signupConfirmPasswordTextbox.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            signupNicknameTextBox.Text = "";
            signupEmailTextbox.Text = "";
            signupPasswordTextbox.Text = "";
            signupConfirmPasswordTextbox.Text = "";
        }
    }
}
