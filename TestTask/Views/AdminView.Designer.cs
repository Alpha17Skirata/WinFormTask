namespace TestTask.Views
{
    partial class AdminView
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
            this.textHumanName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeAdminRole = new System.Windows.Forms.Button();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBirthdayDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textFlat = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textHumanName
            // 
            this.textHumanName.Location = new System.Drawing.Point(211, 33);
            this.textHumanName.Name = "textHumanName";
            this.textHumanName.Size = new System.Drawing.Size(230, 20);
            this.textHumanName.TabIndex = 0;
            this.textHumanName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textHumanName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameSurnameMiddleName_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 410);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.changeAdminRole);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 99);
            this.panel2.TabIndex = 1;
            // 
            // changeAdminRole
            // 
            this.changeAdminRole.Location = new System.Drawing.Point(32, 33);
            this.changeAdminRole.Name = "changeAdminRole";
            this.changeAdminRole.Size = new System.Drawing.Size(139, 23);
            this.changeAdminRole.TabIndex = 0;
            this.changeAdminRole.Text = "К выбору роли";
            this.changeAdminRole.UseVisualStyleBackColor = true;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(211, 80);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(230, 20);
            this.textSurname.TabIndex = 2;
            this.textSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameSurnameMiddleName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(206, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(211, 127);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(230, 20);
            this.textMiddleName.TabIndex = 10;
            this.textMiddleName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameSurnameMiddleName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(207, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Улица";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(211, 269);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(230, 20);
            this.textAddress.TabIndex = 12;
            this.textAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddress_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(207, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дата рождения";
            // 
            // textBirthdayDate
            // 
            this.textBirthdayDate.Location = new System.Drawing.Point(210, 175);
            this.textBirthdayDate.Name = "textBirthdayDate";
            this.textBirthdayDate.Size = new System.Drawing.Size(230, 20);
            this.textBirthdayDate.TabIndex = 16;
            this.textBirthdayDate.TextChanged += new System.EventHandler(this.textBirthdayDate_TextChanged);
            this.textBirthdayDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textBirthdayDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBirthdayDate_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(207, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Номер";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(211, 222);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(230, 20);
            this.textNumber.TabIndex = 18;
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            this.textNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(121, 24);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 20;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(207, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 22;
            this.label7.Text = "Номер дома";
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Location = new System.Drawing.Point(211, 316);
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.Size = new System.Drawing.Size(230, 20);
            this.textHouseNumber.TabIndex = 21;
            this.textHouseNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textHouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHouseNumberFlat_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(207, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Квартира";
            // 
            // textFlat
            // 
            this.textFlat.Location = new System.Drawing.Point(211, 363);
            this.textFlat.Name = "textFlat";
            this.textFlat.Size = new System.Drawing.Size(230, 20);
            this.textFlat.TabIndex = 23;
            this.textFlat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHouseNumberFlat_KeyPress);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(4, 24);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(104, 23);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Очистить поля";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(447, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Формат даты: dd.mm.yyyy";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(447, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "Формат номера: х-хх-хх";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.cancelBtn);
            this.panel3.Controls.Add(this.saveBtn);
            this.panel3.Location = new System.Drawing.Point(447, 339);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 71);
            this.panel3.TabIndex = 2;
            // 
            // AdminView
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textFlat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textHouseNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBirthdayDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textMiddleName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textHumanName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminView_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textHumanName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBirthdayDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFlat;
        private System.Windows.Forms.Button changeAdminRole;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}