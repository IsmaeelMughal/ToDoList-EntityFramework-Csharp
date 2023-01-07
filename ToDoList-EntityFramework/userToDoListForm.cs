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
    public partial class userToDoListForm : Form
    {
        String email;
        public userToDoListForm(String e, String nickname)
        {
            InitializeComponent();
            usrEmailLabel.Text = "Email: " + e;
            userNicknameLabel.Text = "Nickname: " + nickname;
            this.email = e;
            updateDataGridView(email);
        }

        private void updateDataGridView(String e)
        {
            BusinessLayer businessLayer = new BusinessLayer();
            List<TodoTasks> todos = businessLayer.GetAlltodosOfUser(e);
            dgvTodo.DataSource = todos;
        }

        private void dgvTodo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleTextbox.Text = (string)dgvTodo.Rows[e.RowIndex].Cells[0].Value;
            try
            {
                descriptionTextbox.Text = (string)dgvTodo.Rows[e.RowIndex].Cells[1].Value;
            }
            catch
            {
                descriptionTextbox.Text = "";
            }
        }

        private void userNicknameLabel_Click(object sender, EventArgs e)
        {

        }
        private bool isTitleExists()
        {
            for (int i = 0; i < dgvTodo.Rows.Count; i++)
            {
                if (dgvTodo.Rows[i].Cells[0].Value.ToString() == titleTextbox.Text.Trim())
                {
                    return true;
                }
            }
            return false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (titleTextbox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Title Cannot be Empty!!!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isTitleExists())
                {
                    BusinessLayer businessLayer = new BusinessLayer();
                    bool flag = businessLayer.DeleteTaskForUser(titleTextbox.Text.Trim(), descriptionTextbox.Text.Trim(), email);
                    if (flag)
                    {
                        MessageBox.Show("Task Deleted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataGridView(email);
                    }
                    else
                    {
                        MessageBox.Show("Task Not Deleted!!!", "Task", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }

                }
                else
                {
                    MessageBox.Show("Title Does'nt Match!!! Please Enter Correct Title to Delete!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userToDoListForm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtnClick(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();  
        }
    }
}
