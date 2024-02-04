namespace Student_Task_Management
{
    partial class StartForm
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
            this.startbtn = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.startPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startbtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.startbtn.Location = new System.Drawing.Point(343, 382);
            this.startbtn.Name = "startbtn";
            this.startbtn.Padding = new System.Windows.Forms.Padding(1);
            this.startbtn.Size = new System.Drawing.Size(116, 39);
            this.startbtn.TabIndex = 1;
            this.startbtn.Text = "Get Started";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // startLabel
            // 
            this.startLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.startLabel.Location = new System.Drawing.Point(299, 322);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(191, 42);
            this.startLabel.TabIndex = 0;
            this.startLabel.Text = "Welcome!";
            this.startLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // startPictureBox
            // 
            this.startPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startPictureBox.Image = global::Student_Task_Management.Properties.Resources.startIcon;
            this.startPictureBox.Location = new System.Drawing.Point(3, 2);
            this.startPictureBox.Name = "startPictureBox";
            this.startPictureBox.Size = new System.Drawing.Size(833, 296);
            this.startPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startPictureBox.TabIndex = 2;
            this.startPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 451);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.startPictureBox);
            this.Controls.Add(this.startLabel);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stud_Tsk_Mgt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.Stud_Tsk_Mgt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.PictureBox startPictureBox;
    }
}