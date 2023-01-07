using BLL;
using Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_EntityFramework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void toLoginLbl_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            LoginEmailTextbox.Text = "";
            LoginPasswordTextbox.Text = "";
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isAnyFeildEmpty())
            {
                MessageBox.Show("Fields cannot be empty!!!", "Empty Feild", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (LoginEmailTextbox.Text == "admin@gmail.com" && LoginPasswordTextbox.Text == "admin")
                {
                    todolistForm todolistForm  = new todolistForm();
                    this.Hide();
                    todolistForm.ShowDialog();
                }
                else
                {
                    BusinessLayer businessLayer = new BusinessLayer();
                    User u = businessLayer.IsUserExist(LoginEmailTextbox.Text.Trim(), LoginPasswordTextbox.Text.Trim());
                    if (u != null)
                    {
                        userToDoListForm userToDo = new userToDoListForm(u.Email, u.Nickname);
                        this.Hide();
                        userToDo.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private bool isAnyFeildEmpty()
        {
            if(LoginEmailTextbox.Text.Trim() == "" ||
            LoginPasswordTextbox.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }
    }
}
