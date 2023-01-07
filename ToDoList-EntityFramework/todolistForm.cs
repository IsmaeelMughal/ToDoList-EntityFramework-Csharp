using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BLL;
using Common.Models;

namespace ToDoList_EntityFramework
{
    public partial class todolistForm : Form
    {
        public todolistForm()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void todolistForm_Load(object sender, EventArgs e)
        {
            BusinessLayer businessLayer = new BusinessLayer();
            List<User> usrs = businessLayer.GetAllUsers();
            if (usrs != null)
            {
                usersCombobox.DataSource = usrs;
                usersCombobox.DisplayMember = "Nickname";
                usersCombobox.ValueMember = "Email";

                updateDataGridView();
            }
            else
            {
                MessageBox.Show("Failed To Get Users Data", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateDataGridView()
        {
            BusinessLayer businessLayer = new BusinessLayer();
            List<TodoTasks> todos = businessLayer.GetAlltodosOfUser(usersCombobox.SelectedValue.ToString());
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

        private bool isUniqueTitle()
        {
            for (int i = 0; i < dgvTodo.Rows.Count; i++)
            {
                if (dgvTodo.Rows[i].Cells[0].Value.ToString().ToLower() == titleTextbox.Text.ToLower().Trim())
                {
                    return false;
                }
            }
            return true;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (titleTextbox.Text.Equals(string.Empty))
            {
                MessageBox.Show("Title Cannot be Empty!!!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isUniqueTitle())
                {
                    //string conStr = "server=MUGHAL\\SQLEXPRESS; database=Todo_List; Integrated Security=SSPI;";
                    //SqlConnection conn = new SqlConnection(conStr);
                    //try
                    //{
                    //    conn.Open();
                    //    String query = String.Format("INSERT INTO todos(Title, Description) VALUES('{0}', '{1}')",
                    //        this.titleTextbox.Text.Trim(), this.descriptionTextbox.Text.Trim());
                    //    SqlCommand cmd = new SqlCommand(query, conn);
                    //    cmd.ExecuteNonQuery();
                    //    todolistForm_Load(sender, e);
                    //    MessageBox.Show("Task Added Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //catch (SqlException ex)
                    //{
                    //    MessageBox.Show("Please Check Insert Query Or Connection!!!", ex.Message);
                    //    Application.Exit();
                    //}
                    //finally
                    //{
                    //    if (conn.State == ConnectionState.Open)
                    //    {
                    //        conn.Close();
                    //    }
                    //}
                    BusinessLayer businessLayer = new BusinessLayer();
                    bool flag = businessLayer.AddTaskForUser(titleTextbox.Text.Trim(), descriptionTextbox.Text.Trim(), usersCombobox.SelectedValue.ToString());
                    if (flag)
                    {
                        MessageBox.Show("Task Added Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Task Not Added!!!", "Task", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }
                else
                {
                    MessageBox.Show("Title Must Be Unique!!!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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

        private void updateBtn_Click(object sender, EventArgs e)
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
                    bool flag = businessLayer.UpdateTaskForUser(titleTextbox.Text.Trim(), descriptionTextbox.Text.Trim(), usersCombobox.SelectedValue.ToString());
                    if (flag)
                    {
                        MessageBox.Show("Task Updated Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Task Not Updated!!!", "Task", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    }
                }
                else
                {
                    MessageBox.Show("Title Does'nt Match!!! Please Enter Correct Title to Update!", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
                    //string conStr = "server=MUGHAL\\SQLEXPRESS; database=Todo_List; Integrated Security=SSPI;";
                    //SqlConnection conn = new SqlConnection(conStr);
                    //try
                    //{
                    //    conn.Open();
                    //    String query = String.Format("DELETE FROM todos WHERE Title='{0}'",
                    //        this.titleTextbox.Text.Trim());
                    //    SqlCommand cmd = new SqlCommand(query, conn);
                    //    cmd.ExecuteNonQuery();
                    //    todolistForm_Load(sender, e);
                    //    MessageBox.Show("Task Deleted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
                    //catch (SqlException ex)
                    //{
                    //    MessageBox.Show("Please Check Insert Query Or Connection!!!", ex.Message);
                    //    Application.Exit();
                    //}
                    //finally
                    //{
                    //    if (conn.State == ConnectionState.Open)
                    //    {
                    //        conn.Close();
                    //    }
                    //}
                    BusinessLayer businessLayer = new BusinessLayer();
                    bool flag = businessLayer.DeleteTaskForUser(titleTextbox.Text.Trim(), descriptionTextbox.Text.Trim(), usersCombobox.SelectedValue.ToString());
                    if (flag)
                    {
                        MessageBox.Show("Task Deleted Successfully!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        updateDataGridView();
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

        private void dgvTodo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toDoTitle_Click(object sender, EventArgs e)
        {

        }

        private void titleTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usersCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            this.Hide();
            form.ShowDialog();
        }
    }
}
