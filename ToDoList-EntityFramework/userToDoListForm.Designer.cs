namespace ToDoList_EntityFramework
{
    partial class userToDoListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.usrEmailLabel = new System.Windows.Forms.Label();
            this.userNicknameLabel = new System.Windows.Forms.Label();
            this.dgvTodo = new System.Windows.Forms.DataGridView();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.toDoTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.descriptionTextbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.titleTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 726);
            this.panel1.TabIndex = 0;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Location = new System.Drawing.Point(32, 172);
            this.descriptionTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(428, 179);
            this.descriptionTextbox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Description";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(32, 92);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(428, 26);
            this.titleTextbox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Only Title is needed!";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(570, 291);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(140, 62);
            this.deleteBtn.TabIndex = 22;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.SignOutButton);
            this.mainPanel.Controls.Add(this.deleteBtn);
            this.mainPanel.Controls.Add(this.usrEmailLabel);
            this.mainPanel.Controls.Add(this.userNicknameLabel);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(777, 726);
            this.mainPanel.TabIndex = 6;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOutButton.ForeColor = System.Drawing.Color.White;
            this.SignOutButton.Location = new System.Drawing.Point(570, 209);
            this.SignOutButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(140, 48);
            this.SignOutButton.TabIndex = 22;
            this.SignOutButton.Text = "SIGNOUT";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.logoutBtnClick);
            // 
            // usrEmailLabel
            // 
            this.usrEmailLabel.AutoSize = true;
            this.usrEmailLabel.Location = new System.Drawing.Point(492, 68);
            this.usrEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usrEmailLabel.Name = "usrEmailLabel";
            this.usrEmailLabel.Size = new System.Drawing.Size(48, 20);
            this.usrEmailLabel.TabIndex = 26;
            this.usrEmailLabel.Text = "Email";
            // 
            // userNicknameLabel
            // 
            this.userNicknameLabel.AutoSize = true;
            this.userNicknameLabel.Location = new System.Drawing.Point(492, 120);
            this.userNicknameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNicknameLabel.Name = "userNicknameLabel";
            this.userNicknameLabel.Size = new System.Drawing.Size(87, 20);
            this.userNicknameLabel.TabIndex = 26;
            this.userNicknameLabel.Text = "Nickname: ";
            this.userNicknameLabel.Click += new System.EventHandler(this.userNicknameLabel_Click);
            // 
            // dgvTodo
            // 
            this.dgvTodo.AllowUserToAddRows = false;
            this.dgvTodo.AllowUserToDeleteRows = false;
            this.dgvTodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTodo.BackgroundColor = System.Drawing.Color.White;
            this.dgvTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTodo.Location = new System.Drawing.Point(0, 381);
            this.dgvTodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTodo.Name = "dgvTodo";
            this.dgvTodo.ReadOnly = true;
            this.dgvTodo.RowHeadersWidth = 62;
            this.dgvTodo.Size = new System.Drawing.Size(777, 345);
            this.dgvTodo.TabIndex = 7;
            this.dgvTodo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTodo_CellDoubleClick);
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.toDoTitle);
            this.titlePanel.Controls.Add(this.label3);
            this.titlePanel.Controls.Add(this.exitBtn);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(777, 48);
            this.titlePanel.TabIndex = 9;
            // 
            // toDoTitle
            // 
            this.toDoTitle.AutoSize = true;
            this.toDoTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.toDoTitle.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.toDoTitle.Location = new System.Drawing.Point(0, 0);
            this.toDoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toDoTitle.Name = "toDoTitle";
            this.toDoTitle.Size = new System.Drawing.Size(227, 45);
            this.toDoTitle.TabIndex = 23;
            this.toDoTitle.Text = "My ToDo List!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, -172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nickname: ";
            this.label3.Click += new System.EventHandler(this.userNicknameLabel_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.exitBtn.Location = new System.Drawing.Point(690, 0);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(87, 48);
            this.exitBtn.TabIndex = 22;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // userToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(777, 726);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.dgvTodo);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "userToDoListForm";
            this.Text = "userToDoListForm";
            this.Load += new System.EventHandler(this.userToDoListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodo)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.DataGridView dgvTodo;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label toDoTitle;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label usrEmailLabel;
        private System.Windows.Forms.Label userNicknameLabel;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Label label3;
    }
}