namespace Student_Task_Management
{
    partial class StudentDashboard
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
            this.evaluatedTasksPanel = new System.Windows.Forms.Panel();
            this.evaluatedDataGridView = new System.Windows.Forms.DataGridView();
            this.evltTaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evltTaskScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedTsksPanel = new System.Windows.Forms.Panel();
            this.assignedDataGridView = new System.Windows.Forms.DataGridView();
            this.taskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskOpen = new System.Windows.Forms.DataGridViewButtonColumn();
            this.taskSubmit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluatedTasksButton = new System.Windows.Forms.Button();
            this.assignedTasksButton = new System.Windows.Forms.Button();
            this.studentHeaderPanel = new System.Windows.Forms.Panel();
            this.stHdrIdDisLabel = new System.Windows.Forms.Label();
            this.stHdrDeptDisLabel = new System.Windows.Forms.Label();
            this.stHdrNameDisLabel = new System.Windows.Forms.Label();
            this.stHdrIdLabel = new System.Windows.Forms.Label();
            this.stHdrDeptLabel = new System.Windows.Forms.Label();
            this.stHdrNameLabel = new System.Windows.Forms.Label();
            this.studentLogoutButton = new System.Windows.Forms.Button();
            this.studBtnPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.evaluatedTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluatedDataGridView)).BeginInit();
            this.assignedTsksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedDataGridView)).BeginInit();
            this.studentHeaderPanel.SuspendLayout();
            this.studBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // evaluatedTasksPanel
            // 
            this.evaluatedTasksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evaluatedTasksPanel.Controls.Add(this.evaluatedDataGridView);
            this.evaluatedTasksPanel.Location = new System.Drawing.Point(111, 95);
            this.evaluatedTasksPanel.Name = "evaluatedTasksPanel";
            this.evaluatedTasksPanel.Size = new System.Drawing.Size(684, 356);
            this.evaluatedTasksPanel.TabIndex = 8;
            this.evaluatedTasksPanel.Visible = false;
            this.evaluatedTasksPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.evaluatedTasksPanel_Paint);
            // 
            // evaluatedDataGridView
            // 
            this.evaluatedDataGridView.AllowUserToAddRows = false;
            this.evaluatedDataGridView.AllowUserToDeleteRows = false;
            this.evaluatedDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evaluatedDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.evaluatedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.evaluatedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.evaluatedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.evaluatedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evltTaskName,
            this.evltTaskScore});
            this.evaluatedDataGridView.Location = new System.Drawing.Point(0, 0);
            this.evaluatedDataGridView.Name = "evaluatedDataGridView";
            this.evaluatedDataGridView.ReadOnly = true;
            this.evaluatedDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.evaluatedDataGridView.Size = new System.Drawing.Size(659, 309);
            this.evaluatedDataGridView.TabIndex = 0;
            this.evaluatedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // evltTaskName
            // 
            this.evltTaskName.HeaderText = "Task Name";
            this.evltTaskName.Name = "evltTaskName";
            this.evltTaskName.ReadOnly = true;
            // 
            // evltTaskScore
            // 
            this.evltTaskScore.HeaderText = "Score";
            this.evltTaskScore.Name = "evltTaskScore";
            this.evltTaskScore.ReadOnly = true;
            // 
            // assignedTsksPanel
            // 
            this.assignedTsksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignedTsksPanel.Controls.Add(this.assignedDataGridView);
            this.assignedTsksPanel.Location = new System.Drawing.Point(108, 95);
            this.assignedTsksPanel.Name = "assignedTsksPanel";
            this.assignedTsksPanel.Size = new System.Drawing.Size(689, 359);
            this.assignedTsksPanel.TabIndex = 7;
            // 
            // assignedDataGridView
            // 
            this.assignedDataGridView.AllowUserToAddRows = false;
            this.assignedDataGridView.AllowUserToDeleteRows = false;
            this.assignedDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignedDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.assignedDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assignedDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.assignedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assignedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskID,
            this.taskName,
            this.taskDescription,
            this.dueDate,
            this.taskOpen,
            this.taskSubmit});
            this.assignedDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.assignedDataGridView.Location = new System.Drawing.Point(10, 28);
            this.assignedDataGridView.Name = "assignedDataGridView";
            this.assignedDataGridView.ReadOnly = true;
            this.assignedDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.assignedDataGridView.Size = new System.Drawing.Size(670, 273);
            this.assignedDataGridView.TabIndex = 10;
            this.assignedDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evaluatedDataGridView_CellContentClick);
            // 
            // taskID
            // 
            this.taskID.HeaderText = "Task ID";
            this.taskID.Name = "taskID";
            this.taskID.ReadOnly = true;
            // 
            // taskName
            // 
            this.taskName.HeaderText = "Task Name";
            this.taskName.Name = "taskName";
            this.taskName.ReadOnly = true;
            // 
            // taskDescription
            // 
            this.taskDescription.HeaderText = "Task Description";
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.ReadOnly = true;
            // 
            // dueDate
            // 
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            // 
            // taskOpen
            // 
            this.taskOpen.HeaderText = "Open";
            this.taskOpen.Name = "taskOpen";
            this.taskOpen.ReadOnly = true;
            this.taskOpen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.taskOpen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // taskSubmit
            // 
            this.taskSubmit.HeaderText = "Submit";
            this.taskSubmit.Name = "taskSubmit";
            this.taskSubmit.ReadOnly = true;
            // 
            // evaluatedTasksButton
            // 
            this.evaluatedTasksButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.evaluatedTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.evaluatedTasksButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluatedTasksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.evaluatedTasksButton.Location = new System.Drawing.Point(126, 0);
            this.evaluatedTasksButton.Name = "evaluatedTasksButton";
            this.evaluatedTasksButton.Size = new System.Drawing.Size(138, 31);
            this.evaluatedTasksButton.TabIndex = 6;
            this.evaluatedTasksButton.Text = "  Evaluated Task";
            this.evaluatedTasksButton.UseVisualStyleBackColor = false;
            this.evaluatedTasksButton.Click += new System.EventHandler(this.evaluatedTasksButton_Click);
            // 
            // assignedTasksButton
            // 
            this.assignedTasksButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.assignedTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignedTasksButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedTasksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assignedTasksButton.Location = new System.Drawing.Point(0, 0);
            this.assignedTasksButton.Name = "assignedTasksButton";
            this.assignedTasksButton.Size = new System.Drawing.Size(137, 31);
            this.assignedTasksButton.TabIndex = 5;
            this.assignedTasksButton.Text = "Assigned Tasks";
            this.assignedTasksButton.UseVisualStyleBackColor = false;
            this.assignedTasksButton.Click += new System.EventHandler(this.assignedTasksButton_Click);
            // 
            // studentHeaderPanel
            // 
            this.studentHeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentHeaderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.studentHeaderPanel.Controls.Add(this.stHdrIdDisLabel);
            this.studentHeaderPanel.Controls.Add(this.stHdrDeptDisLabel);
            this.studentHeaderPanel.Controls.Add(this.stHdrNameDisLabel);
            this.studentHeaderPanel.Controls.Add(this.stHdrIdLabel);
            this.studentHeaderPanel.Controls.Add(this.stHdrDeptLabel);
            this.studentHeaderPanel.Controls.Add(this.stHdrNameLabel);
            this.studentHeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.studentHeaderPanel.Location = new System.Drawing.Point(2, 1);
            this.studentHeaderPanel.Name = "studentHeaderPanel";
            this.studentHeaderPanel.Padding = new System.Windows.Forms.Padding(1);
            this.studentHeaderPanel.Size = new System.Drawing.Size(795, 67);
            this.studentHeaderPanel.TabIndex = 0;
            // 
            // stHdrIdDisLabel
            // 
            this.stHdrIdDisLabel.AutoSize = true;
            this.stHdrIdDisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stHdrIdDisLabel.ForeColor = System.Drawing.Color.Black;
            this.stHdrIdDisLabel.Location = new System.Drawing.Point(123, 42);
            this.stHdrIdDisLabel.Name = "stHdrIdDisLabel";
            this.stHdrIdDisLabel.Size = new System.Drawing.Size(105, 16);
            this.stHdrIdDisLabel.TabIndex = 1;
            this.stHdrIdDisLabel.Text = "Display Name";
            // 
            // stHdrDeptDisLabel
            // 
            this.stHdrDeptDisLabel.AutoSize = true;
            this.stHdrDeptDisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stHdrDeptDisLabel.ForeColor = System.Drawing.Color.Black;
            this.stHdrDeptDisLabel.Location = new System.Drawing.Point(123, 26);
            this.stHdrDeptDisLabel.Name = "stHdrDeptDisLabel";
            this.stHdrDeptDisLabel.Size = new System.Drawing.Size(105, 16);
            this.stHdrDeptDisLabel.TabIndex = 1;
            this.stHdrDeptDisLabel.Text = "Display Name";
            // 
            // stHdrNameDisLabel
            // 
            this.stHdrNameDisLabel.AutoSize = true;
            this.stHdrNameDisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stHdrNameDisLabel.ForeColor = System.Drawing.Color.Black;
            this.stHdrNameDisLabel.Location = new System.Drawing.Point(123, 10);
            this.stHdrNameDisLabel.Name = "stHdrNameDisLabel";
            this.stHdrNameDisLabel.Size = new System.Drawing.Size(105, 16);
            this.stHdrNameDisLabel.TabIndex = 1;
            this.stHdrNameDisLabel.Text = "Display Name";
            // 
            // stHdrIdLabel
            // 
            this.stHdrIdLabel.AutoSize = true;
            this.stHdrIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stHdrIdLabel.ForeColor = System.Drawing.Color.Black;
            this.stHdrIdLabel.Location = new System.Drawing.Point(36, 42);
            this.stHdrIdLabel.Name = "stHdrIdLabel";
            this.stHdrIdLabel.Size = new System.Drawing.Size(26, 16);
            this.stHdrIdLabel.TabIndex = 0;
            this.stHdrIdLabel.Text = "ID:";
            this.stHdrIdLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // stHdrDeptLabel
            // 
            this.stHdrDeptLabel.AutoSize = true;
            this.stHdrDeptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stHdrDeptLabel.ForeColor = System.Drawing.Color.Black;
            this.stHdrDeptLabel.Location = new System.Drawing.Point(36, 26);
            this.stHdrDeptLabel.Name = "stHdrDeptLabel";
            this.stHdrDeptLabel.Size = new System.Drawing.Size(91, 16);
            this.stHdrDeptLabel.TabIndex = 0;
            this.stHdrDeptLabel.Text = "Department:";
            this.stHdrDeptLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // stHdrNameLabel
            // 
            this.stHdrNameLabel.AutoSize = true;
            this.stHdrNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stHdrNameLabel.ForeColor = System.Drawing.Color.Black;
            this.stHdrNameLabel.Location = new System.Drawing.Point(36, 10);
            this.stHdrNameLabel.Name = "stHdrNameLabel";
            this.stHdrNameLabel.Size = new System.Drawing.Size(81, 16);
            this.stHdrNameLabel.TabIndex = 0;
            this.stHdrNameLabel.Text = "Full Name:";
            this.stHdrNameLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // studentLogoutButton
            // 
            this.studentLogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.studentLogoutButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.studentLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentLogoutButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLogoutButton.Location = new System.Drawing.Point(726, 0);
            this.studentLogoutButton.Name = "studentLogoutButton";
            this.studentLogoutButton.Size = new System.Drawing.Size(69, 31);
            this.studentLogoutButton.TabIndex = 2;
            this.studentLogoutButton.Text = "Log out";
            this.studentLogoutButton.UseVisualStyleBackColor = false;
            this.studentLogoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // studBtnPanel
            // 
            this.studBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studBtnPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studBtnPanel.Controls.Add(this.studentLogoutButton);
            this.studBtnPanel.Controls.Add(this.assignedTasksButton);
            this.studBtnPanel.Controls.Add(this.evaluatedTasksButton);
            this.studBtnPanel.Location = new System.Drawing.Point(2, 66);
            this.studBtnPanel.Name = "studBtnPanel";
            this.studBtnPanel.Size = new System.Drawing.Size(795, 31);
            this.studBtnPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::Student_Task_Management.Properties.Resources.studentIcon;
            this.pictureBox1.Location = new System.Drawing.Point(2, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studBtnPanel);
            this.Controls.Add(this.evaluatedTasksPanel);
            this.Controls.Add(this.assignedTsksPanel);
            this.Controls.Add(this.studentHeaderPanel);
            this.Name = "StudentDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.Label1_Click);
            this.Click += new System.EventHandler(this.StudentDashboard_Click);
            this.evaluatedTasksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.evaluatedDataGridView)).EndInit();
            this.assignedTsksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assignedDataGridView)).EndInit();
            this.studentHeaderPanel.ResumeLayout(false);
            this.studentHeaderPanel.PerformLayout();
            this.studBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel studentHeaderPanel;
        private System.Windows.Forms.Label stHdrNameLabel;
        private System.Windows.Forms.Label stHdrIdDisLabel;
        private System.Windows.Forms.Label stHdrDeptDisLabel;
        private System.Windows.Forms.Label stHdrNameDisLabel;
        private System.Windows.Forms.Label stHdrIdLabel;
        private System.Windows.Forms.Label stHdrDeptLabel;
        private System.Windows.Forms.Button evaluatedTasksButton;
        private System.Windows.Forms.Button assignedTasksButton;
        private System.Windows.Forms.Panel evaluatedTasksPanel;
        private System.Windows.Forms.Panel assignedTsksPanel;
        private System.Windows.Forms.Button studentLogoutButton;
        private System.Windows.Forms.Panel studBtnPanel;
        private System.Windows.Forms.DataGridView assignedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewButtonColumn taskOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskSubmit;
        private System.Windows.Forms.DataGridView evaluatedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn evltTaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn evltTaskScore;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}