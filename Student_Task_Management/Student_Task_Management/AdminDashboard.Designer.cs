namespace Student_Task_Management
{
    partial class AdminDashboard
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
            this.assignInstructorsButton = new System.Windows.Forms.Button();
            this.changePanel = new System.Windows.Forms.Panel();
            this.changeButton = new System.Windows.Forms.Button();
            this.OldInstTextBox = new System.Windows.Forms.TextBox();
            this.OldInstIDTextBox = new System.Windows.Forms.Label();
            this.ChangeSectionTextBox = new System.Windows.Forms.TextBox();
            this.NewInstTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewInstLabel = new System.Windows.Forms.Label();
            this.studBtnPanel = new System.Windows.Forms.Panel();
            this.changeInstBtn = new System.Windows.Forms.Button();
            this.instructorLogoutButton = new System.Windows.Forms.Button();
            this.registerStudentsButton = new System.Windows.Forms.Button();
            this.registerInstructorButton = new System.Windows.Forms.Button();
            this.instAssignPanel = new System.Windows.Forms.Panel();
            this.instAssignPictureBox = new System.Windows.Forms.PictureBox();
            this.adAssignBtn = new System.Windows.Forms.Button();
            this.instAssignSectionTextBox = new System.Windows.Forms.TextBox();
            this.instAssignIDTextBox = new System.Windows.Forms.TextBox();
            this.instAssignSectionLabel = new System.Windows.Forms.Label();
            this.instAssignIDLabel = new System.Windows.Forms.Label();
            this.instRegPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.instRegButton = new System.Windows.Forms.Button();
            this.instRegPassTextBox = new System.Windows.Forms.TextBox();
            this.instRegUserTextBox = new System.Windows.Forms.TextBox();
            this.instRegCourseTextBox = new System.Windows.Forms.TextBox();
            this.instRegNameTextBox = new System.Windows.Forms.TextBox();
            this.instRegIDTextBox = new System.Windows.Forms.TextBox();
            this.instRegPassLabel = new System.Windows.Forms.Label();
            this.instRegUserLabel = new System.Windows.Forms.Label();
            this.instRegCourseLabel = new System.Windows.Forms.Label();
            this.instRegNameLabel = new System.Windows.Forms.Label();
            this.instRegIDLabel = new System.Windows.Forms.Label();
            this.studRegPanel = new System.Windows.Forms.Panel();
            this.studRegPictureBox = new System.Windows.Forms.PictureBox();
            this.studRegisterButton = new System.Windows.Forms.Button();
            this.studRegPassTextBox = new System.Windows.Forms.TextBox();
            this.studRegUserTextBox = new System.Windows.Forms.TextBox();
            this.studRegDeptTextBox = new System.Windows.Forms.TextBox();
            this.studRegSectionTextBox = new System.Windows.Forms.TextBox();
            this.studRegNameTextBox = new System.Windows.Forms.TextBox();
            this.studRegIDTextBox = new System.Windows.Forms.TextBox();
            this.studRegPassLabel = new System.Windows.Forms.Label();
            this.studRegUserLabel = new System.Windows.Forms.Label();
            this.studRegDeptLabel = new System.Windows.Forms.Label();
            this.studRegSecLabel = new System.Windows.Forms.Label();
            this.studRegNameLabel = new System.Windows.Forms.Label();
            this.studRegIDLabel = new System.Windows.Forms.Label();
            this.changePanel.SuspendLayout();
            this.studBtnPanel.SuspendLayout();
            this.instAssignPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instAssignPictureBox)).BeginInit();
            this.instRegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.studRegPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studRegPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // assignInstructorsButton
            // 
            this.assignInstructorsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.assignInstructorsButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.assignInstructorsButton.FlatAppearance.BorderSize = 0;
            this.assignInstructorsButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignInstructorsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.assignInstructorsButton.Location = new System.Drawing.Point(301, 0);
            this.assignInstructorsButton.Name = "assignInstructorsButton";
            this.assignInstructorsButton.Size = new System.Drawing.Size(153, 30);
            this.assignInstructorsButton.TabIndex = 3;
            this.assignInstructorsButton.Text = " Assign Instructors";
            this.assignInstructorsButton.UseVisualStyleBackColor = false;
            this.assignInstructorsButton.Click += new System.EventHandler(this.assignInstructorsButton_Click);
            // 
            // changePanel
            // 
            this.changePanel.BackColor = System.Drawing.Color.Honeydew;
            this.changePanel.Controls.Add(this.changeButton);
            this.changePanel.Controls.Add(this.OldInstTextBox);
            this.changePanel.Controls.Add(this.OldInstIDTextBox);
            this.changePanel.Controls.Add(this.ChangeSectionTextBox);
            this.changePanel.Controls.Add(this.NewInstTextBox);
            this.changePanel.Controls.Add(this.label1);
            this.changePanel.Controls.Add(this.NewInstLabel);
            this.changePanel.Location = new System.Drawing.Point(0, 35);
            this.changePanel.Name = "changePanel";
            this.changePanel.Size = new System.Drawing.Size(796, 412);
            this.changePanel.TabIndex = 15;
            this.changePanel.Visible = false;
            this.changePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.changePanel_Paint);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.changeButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(346, 229);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(95, 32);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // OldInstTextBox
            // 
            this.OldInstTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OldInstTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OldInstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OldInstTextBox.Location = new System.Drawing.Point(322, 84);
            this.OldInstTextBox.Name = "OldInstTextBox";
            this.OldInstTextBox.Size = new System.Drawing.Size(174, 13);
            this.OldInstTextBox.TabIndex = 9;
            // 
            // OldInstIDTextBox
            // 
            this.OldInstIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OldInstIDTextBox.AutoSize = true;
            this.OldInstIDTextBox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldInstIDTextBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OldInstIDTextBox.Location = new System.Drawing.Point(175, 83);
            this.OldInstIDTextBox.Name = "OldInstIDTextBox";
            this.OldInstIDTextBox.Size = new System.Drawing.Size(90, 19);
            this.OldInstIDTextBox.TabIndex = 8;
            this.OldInstIDTextBox.Text = "Teacher ID:";
            // 
            // ChangeSectionTextBox
            // 
            this.ChangeSectionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChangeSectionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ChangeSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangeSectionTextBox.Location = new System.Drawing.Point(325, 179);
            this.ChangeSectionTextBox.Name = "ChangeSectionTextBox";
            this.ChangeSectionTextBox.Size = new System.Drawing.Size(174, 13);
            this.ChangeSectionTextBox.TabIndex = 7;
            // 
            // NewInstTextBox
            // 
            this.NewInstTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewInstTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NewInstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewInstTextBox.Location = new System.Drawing.Point(323, 130);
            this.NewInstTextBox.Name = "NewInstTextBox";
            this.NewInstTextBox.Size = new System.Drawing.Size(174, 13);
            this.NewInstTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(175, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Section:";
            // 
            // NewInstLabel
            // 
            this.NewInstLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewInstLabel.AutoSize = true;
            this.NewInstLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInstLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NewInstLabel.Location = new System.Drawing.Point(175, 126);
            this.NewInstLabel.Name = "NewInstLabel";
            this.NewInstLabel.Size = new System.Drawing.Size(126, 19);
            this.NewInstLabel.TabIndex = 4;
            this.NewInstLabel.Text = "New Teacher ID:";
            this.NewInstLabel.Click += new System.EventHandler(this.NewInstTextBox_Click);
            // 
            // studBtnPanel
            // 
            this.studBtnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studBtnPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studBtnPanel.Controls.Add(this.changeInstBtn);
            this.studBtnPanel.Controls.Add(this.assignInstructorsButton);
            this.studBtnPanel.Controls.Add(this.instructorLogoutButton);
            this.studBtnPanel.Controls.Add(this.registerStudentsButton);
            this.studBtnPanel.Controls.Add(this.registerInstructorButton);
            this.studBtnPanel.Location = new System.Drawing.Point(0, 1);
            this.studBtnPanel.Name = "studBtnPanel";
            this.studBtnPanel.Size = new System.Drawing.Size(798, 33);
            this.studBtnPanel.TabIndex = 9;
            this.studBtnPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.studBtnPanel_Paint);
            // 
            // changeInstBtn
            // 
            this.changeInstBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.changeInstBtn.Location = new System.Drawing.Point(452, 0);
            this.changeInstBtn.Name = "changeInstBtn";
            this.changeInstBtn.Size = new System.Drawing.Size(141, 30);
            this.changeInstBtn.TabIndex = 8;
            this.changeInstBtn.Text = "Change";
            this.changeInstBtn.UseVisualStyleBackColor = false;
            this.changeInstBtn.Click += new System.EventHandler(this.changeInstBtn_Click);
            // 
            // instructorLogoutButton
            // 
            this.instructorLogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.instructorLogoutButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.instructorLogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructorLogoutButton.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructorLogoutButton.Location = new System.Drawing.Point(729, 0);
            this.instructorLogoutButton.Name = "instructorLogoutButton";
            this.instructorLogoutButton.Size = new System.Drawing.Size(69, 31);
            this.instructorLogoutButton.TabIndex = 7;
            this.instructorLogoutButton.Text = "Log out";
            this.instructorLogoutButton.UseVisualStyleBackColor = false;
            this.instructorLogoutButton.Click += new System.EventHandler(this.instructorLogoutButton_Click);
            // 
            // registerStudentsButton
            // 
            this.registerStudentsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.registerStudentsButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerStudentsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerStudentsButton.Location = new System.Drawing.Point(0, 0);
            this.registerStudentsButton.Name = "registerStudentsButton";
            this.registerStudentsButton.Size = new System.Drawing.Size(137, 31);
            this.registerStudentsButton.TabIndex = 5;
            this.registerStudentsButton.Text = "Register Student";
            this.registerStudentsButton.UseVisualStyleBackColor = false;
            this.registerStudentsButton.Click += new System.EventHandler(this.registerStudentsButton_Click_1);
            // 
            // registerInstructorButton
            // 
            this.registerInstructorButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.registerInstructorButton.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerInstructorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerInstructorButton.Location = new System.Drawing.Point(135, 0);
            this.registerInstructorButton.Name = "registerInstructorButton";
            this.registerInstructorButton.Size = new System.Drawing.Size(167, 31);
            this.registerInstructorButton.TabIndex = 6;
            this.registerInstructorButton.Text = "  Register Instructors";
            this.registerInstructorButton.UseVisualStyleBackColor = false;
            this.registerInstructorButton.Click += new System.EventHandler(this.registerInstructorButton_Click_1);
            // 
            // instAssignPanel
            // 
            this.instAssignPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instAssignPanel.BackColor = System.Drawing.Color.Honeydew;
            this.instAssignPanel.Controls.Add(this.instAssignPictureBox);
            this.instAssignPanel.Controls.Add(this.adAssignBtn);
            this.instAssignPanel.Controls.Add(this.instAssignSectionTextBox);
            this.instAssignPanel.Controls.Add(this.instAssignIDTextBox);
            this.instAssignPanel.Controls.Add(this.instAssignSectionLabel);
            this.instAssignPanel.Controls.Add(this.instAssignIDLabel);
            this.instAssignPanel.Location = new System.Drawing.Point(0, 35);
            this.instAssignPanel.Name = "instAssignPanel";
            this.instAssignPanel.Size = new System.Drawing.Size(798, 409);
            this.instAssignPanel.TabIndex = 17;
            this.instAssignPanel.Visible = false;
            // 
            // instAssignPictureBox
            // 
            this.instAssignPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.instAssignPictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.instAssignPictureBox.Image = global::Student_Task_Management.Properties.Resources.aIcon;
            this.instAssignPictureBox.Location = new System.Drawing.Point(3, 0);
            this.instAssignPictureBox.Name = "instAssignPictureBox";
            this.instAssignPictureBox.Size = new System.Drawing.Size(100, 406);
            this.instAssignPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.instAssignPictureBox.TabIndex = 6;
            this.instAssignPictureBox.TabStop = false;
            // 
            // adAssignBtn
            // 
            this.adAssignBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adAssignBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.adAssignBtn.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adAssignBtn.Location = new System.Drawing.Point(275, 217);
            this.adAssignBtn.Name = "adAssignBtn";
            this.adAssignBtn.Size = new System.Drawing.Size(90, 32);
            this.adAssignBtn.TabIndex = 4;
            this.adAssignBtn.Text = "Assign";
            this.adAssignBtn.UseVisualStyleBackColor = false;
            this.adAssignBtn.Click += new System.EventHandler(this.adAssignBtn_Click);
            // 
            // instAssignSectionTextBox
            // 
            this.instAssignSectionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instAssignSectionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instAssignSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instAssignSectionTextBox.Location = new System.Drawing.Point(364, 160);
            this.instAssignSectionTextBox.Name = "instAssignSectionTextBox";
            this.instAssignSectionTextBox.Size = new System.Drawing.Size(174, 13);
            this.instAssignSectionTextBox.TabIndex = 3;
            // 
            // instAssignIDTextBox
            // 
            this.instAssignIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instAssignIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instAssignIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instAssignIDTextBox.Location = new System.Drawing.Point(364, 109);
            this.instAssignIDTextBox.Name = "instAssignIDTextBox";
            this.instAssignIDTextBox.Size = new System.Drawing.Size(174, 13);
            this.instAssignIDTextBox.TabIndex = 2;
            // 
            // instAssignSectionLabel
            // 
            this.instAssignSectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instAssignSectionLabel.AutoSize = true;
            this.instAssignSectionLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instAssignSectionLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instAssignSectionLabel.Location = new System.Drawing.Point(271, 154);
            this.instAssignSectionLabel.Name = "instAssignSectionLabel";
            this.instAssignSectionLabel.Size = new System.Drawing.Size(67, 19);
            this.instAssignSectionLabel.TabIndex = 1;
            this.instAssignSectionLabel.Text = "Section:";
            // 
            // instAssignIDLabel
            // 
            this.instAssignIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instAssignIDLabel.AutoSize = true;
            this.instAssignIDLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instAssignIDLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instAssignIDLabel.Location = new System.Drawing.Point(271, 104);
            this.instAssignIDLabel.Name = "instAssignIDLabel";
            this.instAssignIDLabel.Size = new System.Drawing.Size(90, 19);
            this.instAssignIDLabel.TabIndex = 0;
            this.instAssignIDLabel.Text = "Teacher ID:";
            // 
            // instRegPanel
            // 
            this.instRegPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instRegPanel.BackColor = System.Drawing.Color.Honeydew;
            this.instRegPanel.Controls.Add(this.pictureBox1);
            this.instRegPanel.Controls.Add(this.instRegButton);
            this.instRegPanel.Controls.Add(this.instRegPassTextBox);
            this.instRegPanel.Controls.Add(this.instRegUserTextBox);
            this.instRegPanel.Controls.Add(this.instRegCourseTextBox);
            this.instRegPanel.Controls.Add(this.instRegNameTextBox);
            this.instRegPanel.Controls.Add(this.instRegIDTextBox);
            this.instRegPanel.Controls.Add(this.instRegPassLabel);
            this.instRegPanel.Controls.Add(this.instRegUserLabel);
            this.instRegPanel.Controls.Add(this.instRegCourseLabel);
            this.instRegPanel.Controls.Add(this.instRegNameLabel);
            this.instRegPanel.Controls.Add(this.instRegIDLabel);
            this.instRegPanel.Location = new System.Drawing.Point(0, 35);
            this.instRegPanel.Name = "instRegPanel";
            this.instRegPanel.Size = new System.Drawing.Size(798, 412);
            this.instRegPanel.TabIndex = 18;
            this.instRegPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pictureBox1.Image = global::Student_Task_Management.Properties.Resources.lecturerIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // instRegButton
            // 
            this.instRegButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegButton.BackColor = System.Drawing.Color.SteelBlue;
            this.instRegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instRegButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instRegButton.Location = new System.Drawing.Point(349, 290);
            this.instRegButton.Name = "instRegButton";
            this.instRegButton.Size = new System.Drawing.Size(87, 32);
            this.instRegButton.TabIndex = 12;
            this.instRegButton.Text = "Register";
            this.instRegButton.UseVisualStyleBackColor = false;
            // 
            // instRegPassTextBox
            // 
            this.instRegPassTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instRegPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instRegPassTextBox.Location = new System.Drawing.Point(377, 251);
            this.instRegPassTextBox.Name = "instRegPassTextBox";
            this.instRegPassTextBox.Size = new System.Drawing.Size(171, 13);
            this.instRegPassTextBox.TabIndex = 9;
            // 
            // instRegUserTextBox
            // 
            this.instRegUserTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instRegUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instRegUserTextBox.Location = new System.Drawing.Point(377, 212);
            this.instRegUserTextBox.Name = "instRegUserTextBox";
            this.instRegUserTextBox.Size = new System.Drawing.Size(171, 13);
            this.instRegUserTextBox.TabIndex = 8;
            // 
            // instRegCourseTextBox
            // 
            this.instRegCourseTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegCourseTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instRegCourseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instRegCourseTextBox.Location = new System.Drawing.Point(377, 172);
            this.instRegCourseTextBox.Name = "instRegCourseTextBox";
            this.instRegCourseTextBox.Size = new System.Drawing.Size(171, 13);
            this.instRegCourseTextBox.TabIndex = 7;
            // 
            // instRegNameTextBox
            // 
            this.instRegNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instRegNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instRegNameTextBox.Location = new System.Drawing.Point(377, 135);
            this.instRegNameTextBox.Name = "instRegNameTextBox";
            this.instRegNameTextBox.Size = new System.Drawing.Size(171, 13);
            this.instRegNameTextBox.TabIndex = 6;
            // 
            // instRegIDTextBox
            // 
            this.instRegIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.instRegIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instRegIDTextBox.Location = new System.Drawing.Point(379, 93);
            this.instRegIDTextBox.Name = "instRegIDTextBox";
            this.instRegIDTextBox.Size = new System.Drawing.Size(171, 13);
            this.instRegIDTextBox.TabIndex = 5;
            // 
            // instRegPassLabel
            // 
            this.instRegPassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegPassLabel.AutoSize = true;
            this.instRegPassLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instRegPassLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instRegPassLabel.Location = new System.Drawing.Point(270, 247);
            this.instRegPassLabel.Name = "instRegPassLabel";
            this.instRegPassLabel.Size = new System.Drawing.Size(85, 19);
            this.instRegPassLabel.TabIndex = 4;
            this.instRegPassLabel.Text = "Password:";
            // 
            // instRegUserLabel
            // 
            this.instRegUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegUserLabel.AutoSize = true;
            this.instRegUserLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instRegUserLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instRegUserLabel.Location = new System.Drawing.Point(269, 207);
            this.instRegUserLabel.Name = "instRegUserLabel";
            this.instRegUserLabel.Size = new System.Drawing.Size(94, 19);
            this.instRegUserLabel.TabIndex = 3;
            this.instRegUserLabel.Text = "User Name:";
            // 
            // instRegCourseLabel
            // 
            this.instRegCourseLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegCourseLabel.AutoSize = true;
            this.instRegCourseLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instRegCourseLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instRegCourseLabel.Location = new System.Drawing.Point(270, 167);
            this.instRegCourseLabel.Name = "instRegCourseLabel";
            this.instRegCourseLabel.Size = new System.Drawing.Size(65, 19);
            this.instRegCourseLabel.TabIndex = 2;
            this.instRegCourseLabel.Text = "Course:";
            // 
            // instRegNameLabel
            // 
            this.instRegNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegNameLabel.AutoSize = true;
            this.instRegNameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instRegNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instRegNameLabel.Location = new System.Drawing.Point(269, 129);
            this.instRegNameLabel.Name = "instRegNameLabel";
            this.instRegNameLabel.Size = new System.Drawing.Size(56, 19);
            this.instRegNameLabel.TabIndex = 1;
            this.instRegNameLabel.Text = "Name:";
            // 
            // instRegIDLabel
            // 
            this.instRegIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.instRegIDLabel.AutoSize = true;
            this.instRegIDLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instRegIDLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instRegIDLabel.Location = new System.Drawing.Point(270, 88);
            this.instRegIDLabel.Name = "instRegIDLabel";
            this.instRegIDLabel.Size = new System.Drawing.Size(103, 19);
            this.instRegIDLabel.TabIndex = 0;
            this.instRegIDLabel.Text = "Instructor ID:";
            // 
            // studRegPanel
            // 
            this.studRegPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studRegPanel.BackColor = System.Drawing.Color.Honeydew;
            this.studRegPanel.Controls.Add(this.studRegPictureBox);
            this.studRegPanel.Controls.Add(this.studRegisterButton);
            this.studRegPanel.Controls.Add(this.studRegPassTextBox);
            this.studRegPanel.Controls.Add(this.studRegUserTextBox);
            this.studRegPanel.Controls.Add(this.studRegDeptTextBox);
            this.studRegPanel.Controls.Add(this.studRegSectionTextBox);
            this.studRegPanel.Controls.Add(this.studRegNameTextBox);
            this.studRegPanel.Controls.Add(this.studRegIDTextBox);
            this.studRegPanel.Controls.Add(this.studRegPassLabel);
            this.studRegPanel.Controls.Add(this.studRegUserLabel);
            this.studRegPanel.Controls.Add(this.studRegDeptLabel);
            this.studRegPanel.Controls.Add(this.studRegSecLabel);
            this.studRegPanel.Controls.Add(this.studRegNameLabel);
            this.studRegPanel.Controls.Add(this.studRegIDLabel);
            this.studRegPanel.Location = new System.Drawing.Point(2, 32);
            this.studRegPanel.Name = "studRegPanel";
            this.studRegPanel.Size = new System.Drawing.Size(796, 418);
            this.studRegPanel.TabIndex = 16;
            // 
            // studRegPictureBox
            // 
            this.studRegPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.studRegPictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.studRegPictureBox.Image = global::Student_Task_Management.Properties.Resources.studentIcon;
            this.studRegPictureBox.Location = new System.Drawing.Point(0, 3);
            this.studRegPictureBox.Name = "studRegPictureBox";
            this.studRegPictureBox.Size = new System.Drawing.Size(101, 413);
            this.studRegPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studRegPictureBox.TabIndex = 14;
            this.studRegPictureBox.TabStop = false;
            // 
            // studRegisterButton
            // 
            this.studRegisterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegisterButton.BackColor = System.Drawing.Color.SteelBlue;
            this.studRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studRegisterButton.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegisterButton.Location = new System.Drawing.Point(355, 323);
            this.studRegisterButton.Name = "studRegisterButton";
            this.studRegisterButton.Size = new System.Drawing.Size(97, 32);
            this.studRegisterButton.TabIndex = 13;
            this.studRegisterButton.Text = "Register";
            this.studRegisterButton.UseVisualStyleBackColor = false;
            // 
            // studRegPassTextBox
            // 
            this.studRegPassTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studRegPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studRegPassTextBox.Location = new System.Drawing.Point(324, 273);
            this.studRegPassTextBox.Name = "studRegPassTextBox";
            this.studRegPassTextBox.Size = new System.Drawing.Size(199, 13);
            this.studRegPassTextBox.TabIndex = 11;
            // 
            // studRegUserTextBox
            // 
            this.studRegUserTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studRegUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studRegUserTextBox.Location = new System.Drawing.Point(324, 216);
            this.studRegUserTextBox.Name = "studRegUserTextBox";
            this.studRegUserTextBox.Size = new System.Drawing.Size(199, 13);
            this.studRegUserTextBox.TabIndex = 10;
            // 
            // studRegDeptTextBox
            // 
            this.studRegDeptTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegDeptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studRegDeptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studRegDeptTextBox.Location = new System.Drawing.Point(324, 170);
            this.studRegDeptTextBox.Name = "studRegDeptTextBox";
            this.studRegDeptTextBox.Size = new System.Drawing.Size(199, 13);
            this.studRegDeptTextBox.TabIndex = 9;
            // 
            // studRegSectionTextBox
            // 
            this.studRegSectionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegSectionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studRegSectionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studRegSectionTextBox.Location = new System.Drawing.Point(324, 129);
            this.studRegSectionTextBox.Name = "studRegSectionTextBox";
            this.studRegSectionTextBox.Size = new System.Drawing.Size(199, 13);
            this.studRegSectionTextBox.TabIndex = 8;
            // 
            // studRegNameTextBox
            // 
            this.studRegNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studRegNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studRegNameTextBox.Location = new System.Drawing.Point(324, 86);
            this.studRegNameTextBox.Name = "studRegNameTextBox";
            this.studRegNameTextBox.Size = new System.Drawing.Size(199, 13);
            this.studRegNameTextBox.TabIndex = 7;
            // 
            // studRegIDTextBox
            // 
            this.studRegIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegIDTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.studRegIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studRegIDTextBox.Location = new System.Drawing.Point(324, 44);
            this.studRegIDTextBox.Name = "studRegIDTextBox";
            this.studRegIDTextBox.Size = new System.Drawing.Size(199, 13);
            this.studRegIDTextBox.TabIndex = 6;
            // 
            // studRegPassLabel
            // 
            this.studRegPassLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegPassLabel.AutoSize = true;
            this.studRegPassLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegPassLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.studRegPassLabel.Location = new System.Drawing.Point(215, 266);
            this.studRegPassLabel.Name = "studRegPassLabel";
            this.studRegPassLabel.Size = new System.Drawing.Size(85, 19);
            this.studRegPassLabel.TabIndex = 5;
            this.studRegPassLabel.Text = "Password:";
            // 
            // studRegUserLabel
            // 
            this.studRegUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegUserLabel.AutoSize = true;
            this.studRegUserLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegUserLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.studRegUserLabel.Location = new System.Drawing.Point(215, 217);
            this.studRegUserLabel.Name = "studRegUserLabel";
            this.studRegUserLabel.Size = new System.Drawing.Size(94, 19);
            this.studRegUserLabel.TabIndex = 4;
            this.studRegUserLabel.Text = "User Name:";
            // 
            // studRegDeptLabel
            // 
            this.studRegDeptLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegDeptLabel.AutoSize = true;
            this.studRegDeptLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegDeptLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.studRegDeptLabel.Location = new System.Drawing.Point(215, 168);
            this.studRegDeptLabel.Name = "studRegDeptLabel";
            this.studRegDeptLabel.Size = new System.Drawing.Size(100, 19);
            this.studRegDeptLabel.TabIndex = 3;
            this.studRegDeptLabel.Text = "Department:";
            // 
            // studRegSecLabel
            // 
            this.studRegSecLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegSecLabel.AutoSize = true;
            this.studRegSecLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegSecLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.studRegSecLabel.Location = new System.Drawing.Point(215, 127);
            this.studRegSecLabel.Name = "studRegSecLabel";
            this.studRegSecLabel.Size = new System.Drawing.Size(67, 19);
            this.studRegSecLabel.TabIndex = 2;
            this.studRegSecLabel.Text = "Section:";
            // 
            // studRegNameLabel
            // 
            this.studRegNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegNameLabel.AutoSize = true;
            this.studRegNameLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.studRegNameLabel.Location = new System.Drawing.Point(215, 84);
            this.studRegNameLabel.Name = "studRegNameLabel";
            this.studRegNameLabel.Size = new System.Drawing.Size(56, 19);
            this.studRegNameLabel.TabIndex = 1;
            this.studRegNameLabel.Text = "Name:";
            // 
            // studRegIDLabel
            // 
            this.studRegIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studRegIDLabel.AutoSize = true;
            this.studRegIDLabel.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studRegIDLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.studRegIDLabel.Location = new System.Drawing.Point(215, 42);
            this.studRegIDLabel.Name = "studRegIDLabel";
            this.studRegIDLabel.Size = new System.Drawing.Size(88, 19);
            this.studRegIDLabel.TabIndex = 0;
            this.studRegIDLabel.Text = "Student ID:";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.instAssignPanel);
            this.Controls.Add(this.changePanel);
            this.Controls.Add(this.instRegPanel);
            this.Controls.Add(this.studRegPanel);
            this.Controls.Add(this.studBtnPanel);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.changePanel.ResumeLayout(false);
            this.changePanel.PerformLayout();
            this.studBtnPanel.ResumeLayout(false);
            this.instAssignPanel.ResumeLayout(false);
            this.instAssignPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.instAssignPictureBox)).EndInit();
            this.instRegPanel.ResumeLayout(false);
            this.instRegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.studRegPanel.ResumeLayout(false);
            this.studRegPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studRegPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button assignInstructorsButton;
        private System.Windows.Forms.Panel studBtnPanel;
        private System.Windows.Forms.Button registerStudentsButton;
        private System.Windows.Forms.Button registerInstructorButton;
        private System.Windows.Forms.Button instructorLogoutButton;
        private System.Windows.Forms.Panel changePanel;
        private System.Windows.Forms.TextBox OldInstTextBox;
        private System.Windows.Forms.Label OldInstIDTextBox;
        private System.Windows.Forms.TextBox ChangeSectionTextBox;
        private System.Windows.Forms.TextBox NewInstTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NewInstLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Panel instAssignPanel;
        private System.Windows.Forms.PictureBox instAssignPictureBox;
        private System.Windows.Forms.Button adAssignBtn;
        private System.Windows.Forms.TextBox instAssignSectionTextBox;
        private System.Windows.Forms.TextBox instAssignIDTextBox;
        private System.Windows.Forms.Label instAssignSectionLabel;
        private System.Windows.Forms.Label instAssignIDLabel;
        private System.Windows.Forms.Panel instRegPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button instRegButton;
        private System.Windows.Forms.TextBox instRegPassTextBox;
        private System.Windows.Forms.TextBox instRegUserTextBox;
        private System.Windows.Forms.TextBox instRegCourseTextBox;
        private System.Windows.Forms.TextBox instRegNameTextBox;
        private System.Windows.Forms.TextBox instRegIDTextBox;
        private System.Windows.Forms.Label instRegPassLabel;
        private System.Windows.Forms.Label instRegUserLabel;
        private System.Windows.Forms.Label instRegCourseLabel;
        private System.Windows.Forms.Label instRegNameLabel;
        private System.Windows.Forms.Label instRegIDLabel;
        private System.Windows.Forms.Panel studRegPanel;
        private System.Windows.Forms.PictureBox studRegPictureBox;
        private System.Windows.Forms.Button studRegisterButton;
        private System.Windows.Forms.TextBox studRegPassTextBox;
        private System.Windows.Forms.TextBox studRegUserTextBox;
        private System.Windows.Forms.TextBox studRegDeptTextBox;
        private System.Windows.Forms.TextBox studRegSectionTextBox;
        private System.Windows.Forms.TextBox studRegNameTextBox;
        private System.Windows.Forms.TextBox studRegIDTextBox;
        private System.Windows.Forms.Label studRegPassLabel;
        private System.Windows.Forms.Label studRegUserLabel;
        private System.Windows.Forms.Label studRegDeptLabel;
        private System.Windows.Forms.Label studRegSecLabel;
        private System.Windows.Forms.Label studRegNameLabel;
        private System.Windows.Forms.Label studRegIDLabel;
        private System.Windows.Forms.Button changeInstBtn;
    }
}