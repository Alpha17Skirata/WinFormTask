namespace TestTask
{
    partial class Authentication
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 303);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestTask.Properties.Resources._4171933_admin_administration_administrator_area_accesss_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestTask.Properties.Resources._4200769_user_avatar_profile_people_icon__1_;
            this.pictureBox2.Location = new System.Drawing.Point(3, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 126);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.SkyBlue;
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.adminButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Location = new System.Drawing.Point(155, 171);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(252, 130);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "Admin";
            this.adminButton.UseVisualStyleBackColor = false;
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.SkyBlue;
            this.userButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userButton.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Location = new System.Drawing.Point(155, 25);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(252, 126);
            this.userButton.TabIndex = 3;
            this.userButton.Text = "User";
            this.userButton.UseVisualStyleBackColor = false;
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(419, 327);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button userButton;
    }
}