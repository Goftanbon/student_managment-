namespace Student_Task_Management
{
    partial class InstructorDashboard
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
            this.instructorHeaderPanel = new System.Windows.Forms.Panel();
            this.instHdrIdDisLabel = new System.Windows.Forms.Label();
            this.instHdrSubjDisLabel = new System.Windows.Forms.Label();
            this.instHdrNameDisLabel = new System.Windows.Forms.Label();
            this.instHdrIdLabel = new System.Windows.Forms.Label();
            this.instHdrSubjtLabel = new System.Windows.Forms.Label();
            this.instHdrNameLabel = new System.Windows.Forms.Label();
            this.instructorLogoutButton = new System.Windows.Forms.Button();
            this.addTasksButton = new System.Windows.Forms.Button();
            this.submittedTasksButton = new System.Windows.Forms.Button();
            this.taskNameLabel = new System.Windows.Forms.Label();
            this.dueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dueDateLabel = new System.Windows.Forms.Label();
            this.descriptonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.instSubmitButton = new System.Windows.Forms.Button();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.addTasksPanel = new System.Windows.Forms.Panel();
            this.submittedTasksPanel = new System.Windows.Forms.Panel();
            this.submittedTasksDataGridView = new System.Windows.Forms.DataGridView();
            this.taskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.selectFileTextBox = new System.Windows.Forms.TextBox();
            this.selectFileLabel = new System.Windows.Forms.Label();
            this.instOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.instBtnPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.instructorHeaderPanel.SuspendLayout();
            this.addTasksPanel.SuspendLayout();
            this.submittedTasksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.submittedTasksDataGridView)).BeginInit();
            this.instBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // instructorHeaderPanel
            // 
            this.instructorHeaderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructorHeaderPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.instructorHeaderPanel.Controls.Add(this.instHdrIdDisLabel);
            this.instructorHeaderPanel.Controls.Add(this.instHdrSubjDisLabel);
            this.instructorHeaderPanel.Controls.Add(this.instHdrNameDisLabel);
            this.instructorHeaderPanel.Controls.Add(this.instHdrIdLabel);
            this.instructorHeaderPanel.Controls.Add(this.instHdrSubjtLabel);
            this.instructorHeaderPanel.Controls.Add(this.instHdrNameLabel);
            this.instructorHeaderPanel.Location = new System.Drawing.Point(2, 0);
            this.instructorHeaderPanel.Name = "instructorHeaderPanel";
            this.instructorHeaderPanel.Padding = new System.Windows.Forms.Padding(1);
            this.instructorHeaderPanel.Size = new System.Drawing.Size(795, 78);
            this.instructorHeaderPanel.TabIndex = 1;
            this.instructorHeaderPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.instructorHeaderPanel_Paint);
            // 
            // instHdrIdDisLabel
            // 
            this.instHdrIdDisLabel.AutoSize = true;
            this.instHdrIdDisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instHdrIdDisLabel.ForeColor = System.Drawing.Color.Black;
            this.instHdrIdDisLabel.Location = new System.Drawing.Point(123, 46);
            this.instHdrIdDisLabel.Name = "instHdrIdDisLabel";
            this.instHdrIdDisLabel.Size = new System.Drawing.Size(79, 16);
            this.instHdrIdDisLabel.TabIndex = 3;
            this.instHdrIdDisLabel.Text = "Display ID";
            this.instHdrIdDisLabel.Click += new System.EventHandler(this.instHdrIdDisLabel_Click);
            // 
            // instHdrSubjDisLabel
            // 
            this.instHdrSubjDisLabel.AutoSize = true;
            this.instHdrSubjDisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instHdrSubjDisLabel.ForeColor = System.Drawing.Color.Black;
            this.instHdrSubjDisLabel.Location = new System.Drawing.Point(123, 26);
            this.instHdrSubjDisLabel.Name = "instHdrSubjDisLabel";
            this.instHdrSubjDisLabel.Size = new System.Drawing.Size(116, 16);
            this.instHdrSubjDisLabel.TabIndex = 1;
            this.instHdrSubjDisLabel.Text = "Display Subject";
            this.instHdrSubjDisLabel.Click += new System.EventHandler(this.instHdrSubjDisLabel_Click);
            // 
            // instHdrNameDisLabel
            // 
            this.instHdrNameDisLabel.AutoSize = true;
            this.instHdrNameDisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instHdrNameDisLabel.ForeColor = System.Drawing.Color.Black;
            this.instHdrNameDisLabel.Location = new System.Drawing.Point(123, 10);
            this.instHdrNameDisLabel.Name = "instHdrNameDisLabel";
            this.instHdrNameDisLabel.Size = new System.Drawing.Size(105, 16);
            this.instHdrNameDisLabel.TabIndex = 1;
            this.instHdrNameDisLabel.Text = "Display Name";
            this.instHdrNameDisLabel.Click += new System.EventHandler(this.instHdrNameDisLabel_Click);
            // 
            // instHdrIdLabel
            // 
            this.instHdrIdLabel.AutoSize = true;
            this.instHdrIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instHdrIdLabel.ForeColor = System.Drawing.Color.Black;
            this.instHdrIdLabel.Location = new System.Drawing.Point(36, 46);
            this.instHdrIdLabel.Name = "instHdrIdLabel";
            this.instHdrIdLabel.Size = new System.Drawing.Size(26, 16);
            this.instHdrIdLabel.TabIndex = 0;
            this.instHdrIdLabel.Text = "ID:";
            // 
            // instHdrSubjtLabel
            // 
            this.instHdrSubjtLabel.AutoSize = true;
            this.instHdrSubjtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instHdrSubjtLabel.ForeColor = System.Drawing.Color.Black;
            this.instHdrSubjtLabel.Location = new System.Drawing.Point(36, 26);
            this.instHdrSubjtLabel.Name = "instHdrSubjtLabel";
            this.instHdrSubjtLabel.Size = new System.Drawing.Size(63, 16);
            this.instHdrSubjtLabel.TabIndex = 0;
            this.instHdrSubjtLabel.Text = "Subject:";
            // 
            // instHdrNameLabel
            // 
            this.instHdrNameLabel.AutoSize = true;
            this.instHdrNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instHdrNameLabel.ForeColor = System.Drawing.Color.Black;
            this.instHdrNameLabel.Location = new System.Drawing.Point(36, 10);
            this.instHdrNameLabel.Name = "instHdrNameLabel";
            this.instHdrNameLabel.Size = new System.Drawing.Size(81, 16);
            this.instHdrNameLabel.TabIndex = 0;
            this.instHdrNameLabel.Text = "Full Name:";
            // 
            // instructorLogoutButton
            // 
            this.instructorLogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.instructorLogoutButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.instructorLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorLogoutButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorLogoutButton.Location = new System.Drawing.Point(722, 0);
            this.instructorLogoutButton.Name = "instructorLogoutButton";
            this.instructorLogoutButton.Size = new System.Drawing.Size(69, 27);
            this.instructorLogoutButton.TabIndex = 2;
            this.instructorLogoutButton.Text = "Log out";
            this.instructorLogoutButton.UseVisualStyleBackColor = false;
            this.instructorLogoutButton.Click += new System.EventHandler(this.instructorLogoutButton_Click);
            // 
            // addTasksButton
            // 
            this.addTasksButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.addTasksButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTasksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addTasksButton.Location = new System.Drawing.Point(-2, -1);
            this.addTasksButton.Name = "addTasksButton";
            this.addTasksButton.Size = new System.Drawing.Size(139, 27);
            this.addTasksButton.TabIndex = 6;
            this.addTasksButton.Text = "Add Tasks";
            this.addTasksButton.UseVisualStyleBackColor = false;
            this.addTasksButton.Click += new System.EventHandler(this.addTasksButton_Click);
            // 
            // submittedTasksButton
            // 
            this.submittedTasksButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.submittedTasksButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submittedTasksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.submittedTasksButton.Location = new System.Drawing.Point(136, 0);
            this.submittedTasksButton.Name = "submittedTasksButton";
            this.submittedTasksButton.Size = new System.Drawing.Size(141, 27);
            this.submittedTasksButton.TabIndex = 7;
            this.submittedTasksButton.Text = "Submitted Tasks";
            this.submittedTasksButton.UseVisualStyleBackColor = false;
            this.submittedTasksButton.Click += new System.EventHandler(this.submittedTasksButton_Click);
            // 
            // taskNameLabel
            // 
            this.taskNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskNameLabel.AutoSize = true;
            this.taskNameLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.taskNameLabel.Location = new System.Drawing.Point(169, 58);
            this.taskNameLabel.Name = "taskNameLabel";
            this.taskNameLabel.Size = new System.Drawing.Size(73, 16);
            this.taskNameLabel.TabIndex = 1;
            this.taskNameLabel.Text = "Task Name:";
            // 
            // dueDateTimePicker
            // 
            this.dueDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dueDateTimePicker.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dueDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Honeydew;
            this.dueDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.CornflowerBlue;
            this.dueDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.MidnightBlue;
            this.dueDateTimePicker.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateTimePicker.Location = new System.Drawing.Point(261, 129);
            this.dueDateTimePicker.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dueDateTimePicker.Name = "dueDateTimePicker";
            this.dueDateTimePicker.Size = new System.Drawing.Size(192, 21);
            this.dueDateTimePicker.TabIndex = 6;
            // 
            // dueDateLabel
            // 
            this.dueDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dueDateLabel.AutoSize = true;
            this.dueDateLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dueDateLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.dueDateLabel.Location = new System.Drawing.Point(169, 133);
            this.dueDateLabel.Name = "dueDateLabel";
            this.dueDateLabel.Size = new System.Drawing.Size(63, 16);
            this.dueDateLabel.TabIndex = 7;
            this.dueDateLabel.Text = "Due Date:";
            // 
            // descriptonRichTextBox
            // 
            this.descriptonRichTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptonRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.descriptonRichTextBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptonRichTextBox.Location = new System.Drawing.Point(261, 178);
            this.descriptonRichTextBox.Name = "descriptonRichTextBox";
            this.descriptonRichTextBox.Size = new System.Drawing.Size(192, 56);
            this.descriptonRichTextBox.TabIndex = 9;
            this.descriptonRichTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.descriptionLabel.Location = new System.Drawing.Point(169, 179);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(76, 16);
            this.descriptionLabel.TabIndex = 10;
            this.descriptionLabel.Text = "Description:";
            // 
            // instSubmitButton
            // 
            this.instSubmitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instSubmitButton.BackColor = System.Drawing.Color.SteelBlue;
            this.instSubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instSubmitButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instSubmitButton.ForeColor = System.Drawing.Color.Black;
            this.instSubmitButton.Location = new System.Drawing.Point(378, 264);
            this.instSubmitButton.Name = "instSubmitButton";
            this.instSubmitButton.Padding = new System.Windows.Forms.Padding(1);
            this.instSubmitButton.Size = new System.Drawing.Size(75, 29);
            this.instSubmitButton.TabIndex = 11;
            this.instSubmitButton.Text = "Submit";
            this.instSubmitButton.UseVisualStyleBackColor = false;
            this.instSubmitButton.Click += new System.EventHandler(this.instSubmitButton_Click);
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.taskNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.taskNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskNameTextBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameTextBox.Location = new System.Drawing.Point(261, 58);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(200, 14);
            this.taskNameTextBox.TabIndex = 12;
            this.taskNameTextBox.TextChanged += new System.EventHandler(this.taskNameTextBox_TextChanged);
            // 
            // addTasksPanel
            // 
            this.addTasksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addTasksPanel.BackColor = System.Drawing.Color.Honeydew;
            this.addTasksPanel.Controls.Add(this.submittedTasksPanel);
            this.addTasksPanel.Controls.Add(this.selectFileButton);
            this.addTasksPanel.Controls.Add(this.selectFileTextBox);
            this.addTasksPanel.Controls.Add(this.selectFileLabel);
            this.addTasksPanel.Controls.Add(this.taskNameLabel);
            this.addTasksPanel.Controls.Add(this.instSubmitButton);
            this.addTasksPanel.Controls.Add(this.taskNameTextBox);
            this.addTasksPanel.Controls.Add(this.descriptonRichTextBox);
            this.addTasksPanel.Controls.Add(this.dueDateLabel);
            this.addTasksPanel.Controls.Add(this.descriptionLabel);
            this.addTasksPanel.Controls.Add(this.dueDateTimePicker);
            this.addTasksPanel.Location = new System.Drawing.Point(103, 105);
            this.addTasksPanel.Name = "addTasksPanel";
            this.addTasksPanel.Size = new System.Drawing.Size(694, 345);
            this.addTasksPanel.TabIndex = 13;
            // 
            // submittedTasksPanel
            // 
            this.submittedTasksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submittedTasksPanel.Controls.Add(this.submittedTasksDataGridView);
            this.submittedTasksPanel.Location = new System.Drawing.Point(0, 0);
            this.submittedTasksPanel.Name = "submittedTasksPanel";
            this.submittedTasksPanel.Size = new System.Drawing.Size(692, 345);
            this.submittedTasksPanel.TabIndex = 16;
            this.submittedTasksPanel.Visible = false;
            // 
            // submittedTasksDataGridView
            // 
            this.submittedTasksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submittedTasksDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.submittedTasksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.submittedTasksDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.submittedTasksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.submittedTasksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskName,
            this.studentName,
            this.section});
            this.submittedTasksDataGridView.Location = new System.Drawing.Point(-2, 0);
            this.submittedTasksDataGridView.Name = "submittedTasksDataGridView";
            this.submittedTasksDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.submittedTasksDataGridView.Size = new System.Drawing.Size(694, 277);
            this.submittedTasksDataGridView.TabIndex = 0;
            // 
            // taskName
            // 
            this.taskName.HeaderText = "Task Name";
            this.taskName.Name = "taskName";
            // 
            // studentName
            // 
            this.studentName.HeaderText = "Student Name";
            this.studentName.Name = "studentName";
            // 
            // section
            // 
            this.section.HeaderText = "Section";
            this.section.Name = "section";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFileButton.BackColor = System.Drawing.Color.SteelBlue;
            this.selectFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFileButton.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileButton.Location = new System.Drawing.Point(467, 88);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 24);
            this.selectFileButton.TabIndex = 15;
            this.selectFileButton.Text = "Browse";
            this.selectFileButton.UseVisualStyleBackColor = false;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // selectFileTextBox
            // 
            this.selectFileTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFileTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selectFileTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectFileTextBox.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileTextBox.Location = new System.Drawing.Point(261, 94);
            this.selectFileTextBox.Name = "selectFileTextBox";
            this.selectFileTextBox.Size = new System.Drawing.Size(200, 14);
            this.selectFileTextBox.TabIndex = 14;
            // 
            // selectFileLabel
            // 
            this.selectFileLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectFileLabel.AutoSize = true;
            this.selectFileLabel.BackColor = System.Drawing.SystemColors.Control;
            this.selectFileLabel.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFileLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.selectFileLabel.Location = new System.Drawing.Point(169, 92);
            this.selectFileLabel.Name = "selectFileLabel";
            this.selectFileLabel.Size = new System.Drawing.Size(70, 16);
            this.selectFileLabel.TabIndex = 13;
            this.selectFileLabel.Text = "Select File;";
            // 
            // instOpenFileDialog
            // 
            this.instOpenFileDialog.FileName = "openFileDialog1";
            // 
            // instBtnPanel
            // 
            this.instBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instBtnPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.instBtnPanel.Controls.Add(this.addTasksButton);
            this.instBtnPanel.Controls.Add(this.instructorLogoutButton);
            this.instBtnPanel.Controls.Add(this.submittedTasksButton);
            this.instBtnPanel.Location = new System.Drawing.Point(4, 79);
            this.instBtnPanel.Name = "instBtnPanel";
            this.instBtnPanel.Size = new System.Drawing.Size(793, 27);
            this.instBtnPanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::Student_Task_Management.Properties.Resources.lecturerIcon;
            this.pictureBox1.Location = new System.Drawing.Point(4, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.addTasksPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.instBtnPanel);
            this.Controls.Add(this.instructorHeaderPanel);
            this.Name = "InstructorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructorDashboard";
            this.Load += new System.EventHandler(this.InstructorDashboard_Load);
            this.instructorHeaderPanel.ResumeLayout(false);
            this.instructorHeaderPanel.PerformLayout();
            this.addTasksPanel.ResumeLayout(false);
            this.addTasksPanel.PerformLayout();
            this.submittedTasksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.submittedTasksDataGridView)).EndInit();
            this.instBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button instructorLogoutButton;
        private System.Windows.Forms.Label instHdrNameDisLabel;
        private System.Windows.Forms.Label instHdrIdLabel;
        private System.Windows.Forms.Label instHdrSubjtLabel;
        private System.Windows.Forms.Label instHdrNameLabel;
        private System.Windows.Forms.Button addTasksButton;
        private System.Windows.Forms.Button submittedTasksButton;
        private System.Windows.Forms.Label taskNameLabel;
        private System.Windows.Forms.Label dueDateLabel;
        private System.Windows.Forms.DateTimePicker dueDateTimePicker;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptonRichTextBox;
        private System.Windows.Forms.Button instSubmitButton;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private System.Windows.Forms.Panel addTasksPanel;
        private System.Windows.Forms.Label selectFileLabel;
        private System.Windows.Forms.TextBox selectFileTextBox;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.OpenFileDialog instOpenFileDialog;
        private System.Windows.Forms.Panel instBtnPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel submittedTasksPanel;
        private System.Windows.Forms.DataGridView submittedTasksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn section;
        internal System.Windows.Forms.Panel instructorHeaderPanel;
        internal System.Windows.Forms.Label instHdrSubjDisLabel;
        internal System.Windows.Forms.Label instHdrIdDisLabel;
    }
}