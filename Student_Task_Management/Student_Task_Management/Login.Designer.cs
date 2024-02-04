namespace Student_Task_Management
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.loginLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.rolePictureBox = new System.Windows.Forms.PictureBox();
            this.passPictureBox = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userErrorLabel = new System.Windows.Forms.Label();
            this.passErrorLabel = new System.Windows.Forms.Label();
            this.roleErrorLabel = new System.Windows.Forms.Label();
            this.validationErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rolePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.loginLabel.Location = new System.Drawing.Point(349, 111);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(132, 37);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "LOG IN";
            // 
            // userPanel
            // 
            this.userPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.userPanel.Location = new System.Drawing.Point(280, 215);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(236, 1);
            this.userPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(280, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(280, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 3;
            // 
            // userTextBox
            // 
            this.userTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.Location = new System.Drawing.Point(326, 189);
            this.userTextBox.Multiline = true;
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(181, 20);
            this.userTextBox.TabIndex = 4;
            this.userTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // passTextBox
            // 
            this.passTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTextBox.Location = new System.Drawing.Point(326, 246);
            this.passTextBox.Multiline = true;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '*';
            this.passTextBox.Size = new System.Drawing.Size(181, 20);
            this.passTextBox.TabIndex = 4;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // roleComboBox
            // 
            this.roleComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Items.AddRange(new object[] {
            "Student",
            "Instructor",
            "Admin"});
            this.roleComboBox.Location = new System.Drawing.Point(326, 300);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(181, 24);
            this.roleComboBox.TabIndex = 5;
            this.roleComboBox.TextChanged += new System.EventHandler(this.roleComboBox_TextChanged);
            // 
            // rolePictureBox
            // 
            this.rolePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rolePictureBox.Image = global::Student_Task_Management.Properties.Resources.rrIcon;
            this.rolePictureBox.Location = new System.Drawing.Point(280, 299);
            this.rolePictureBox.Name = "rolePictureBox";
            this.rolePictureBox.Size = new System.Drawing.Size(25, 25);
            this.rolePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rolePictureBox.TabIndex = 2;
            this.rolePictureBox.TabStop = false;
            // 
            // passPictureBox
            // 
            this.passPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passPictureBox.Image = global::Student_Task_Management.Properties.Resources.passIcon;
            this.passPictureBox.Location = new System.Drawing.Point(280, 241);
            this.passPictureBox.Name = "passPictureBox";
            this.passPictureBox.Size = new System.Drawing.Size(25, 25);
            this.passPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passPictureBox.TabIndex = 2;
            this.passPictureBox.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userPictureBox.Image = global::Student_Task_Management.Properties.Resources.usernameIcon;
            this.userPictureBox.Location = new System.Drawing.Point(280, 184);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(25, 25);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 2;
            this.userPictureBox.TabStop = false;
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPictureBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginPictureBox.Image = global::Student_Task_Management.Properties.Resources.loginIcon;
            this.loginPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(800, 90);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPictureBox.TabIndex = 0;
            this.loginPictureBox.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginButton.Location = new System.Drawing.Point(280, 366);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(236, 34);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // userErrorLabel
            // 
            this.userErrorLabel.AutoSize = true;
            this.userErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.userErrorLabel.Location = new System.Drawing.Point(326, 173);
            this.userErrorLabel.Name = "userErrorLabel";
            this.userErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.userErrorLabel.TabIndex = 7;
            // 
            // passErrorLabel
            // 
            this.passErrorLabel.AutoSize = true;
            this.passErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passErrorLabel.Location = new System.Drawing.Point(326, 227);
            this.passErrorLabel.Name = "passErrorLabel";
            this.passErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.passErrorLabel.TabIndex = 8;
            // 
            // roleErrorLabel
            // 
            this.roleErrorLabel.AutoSize = true;
            this.roleErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.roleErrorLabel.Location = new System.Drawing.Point(326, 284);
            this.roleErrorLabel.Name = "roleErrorLabel";
            this.roleErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.roleErrorLabel.TabIndex = 9;
            // 
            // validationErrorLabel
            // 
            this.validationErrorLabel.AutoSize = true;
            this.validationErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.validationErrorLabel.Location = new System.Drawing.Point(323, 350);
            this.validationErrorLabel.Name = "validationErrorLabel";
            this.validationErrorLabel.Size = new System.Drawing.Size(58, 13);
            this.validationErrorLabel.TabIndex = 10;
            this.validationErrorLabel.Text = "                 ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.validationErrorLabel);
            this.Controls.Add(this.roleErrorLabel);
            this.Controls.Add(this.passErrorLabel);
            this.Controls.Add(this.userErrorLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.rolePictureBox);
            this.Controls.Add(this.passPictureBox);
            this.Controls.Add(this.userPictureBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.PictureBox passPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox rolePictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label roleErrorLabel;
        private System.Windows.Forms.Label passErrorLabel;
        private System.Windows.Forms.Label userErrorLabel;
        private System.Windows.Forms.Label validationErrorLabel;
    }
}