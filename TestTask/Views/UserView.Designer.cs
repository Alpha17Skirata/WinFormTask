namespace TestTask
{
    partial class UserView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.changeUserRole = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textFlat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textHouseNumber = new System.Windows.Forms.TextBox();
            this.textHumanName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBirthdayDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textFlat);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textHouseNumber);
            this.panel1.Controls.Add(this.textHumanName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textSurname);
            this.panel1.Controls.Add(this.textNumber);
            this.panel1.Controls.Add(this.textMiddleName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBirthdayDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 628);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(11, 364);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "Формат номера: х-хх-хх";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.changeUserRole);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 99);
            this.panel2.TabIndex = 2;
            // 
            // changeUserRole
            // 
            this.changeUserRole.Location = new System.Drawing.Point(66, 41);
            this.changeUserRole.Name = "changeUserRole";
            this.changeUserRole.Size = new System.Drawing.Size(139, 23);
            this.changeUserRole.TabIndex = 42;
            this.changeUserRole.Text = "К выбору роли";
            this.changeUserRole.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 40;
            this.label8.Text = "Квартира";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(11, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Формат даты: dd.mm.yyyy";
            // 
            // textFlat
            // 
            this.textFlat.Location = new System.Drawing.Point(11, 503);
            this.textFlat.Name = "textFlat";
            this.textFlat.Size = new System.Drawing.Size(234, 20);
            this.textFlat.TabIndex = 39;
            this.textFlat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHouseNumberFlat_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(11, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Номер дома";
            // 
            // textHouseNumber
            // 
            this.textHouseNumber.Location = new System.Drawing.Point(11, 456);
            this.textHouseNumber.Name = "textHouseNumber";
            this.textHouseNumber.Size = new System.Drawing.Size(234, 20);
            this.textHouseNumber.TabIndex = 37;
            this.textHouseNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textHouseNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHouseNumberFlat_KeyPress);
            // 
            // textHumanName
            // 
            this.textHumanName.Location = new System.Drawing.Point(11, 134);
            this.textHumanName.Name = "textHumanName";
            this.textHumanName.Size = new System.Drawing.Size(234, 20);
            this.textHumanName.TabIndex = 25;
            this.textHumanName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textHumanName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameSurnameMiddleName_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Улица";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(11, 409);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(234, 20);
            this.textAddress.TabIndex = 31;
            this.textAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAddress_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 36;
            this.label6.Text = "Номер";
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(11, 181);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(234, 20);
            this.textSurname.TabIndex = 26;
            this.textSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameSurnameMiddleName_KeyPress);
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(11, 344);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(234, 20);
            this.textNumber.TabIndex = 35;
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged_1);
            this.textNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(11, 228);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(234, 20);
            this.textMiddleName.TabIndex = 29;
            this.textMiddleName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNameSurnameMiddleName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Дата рождения";
            // 
            // textBirthdayDate
            // 
            this.textBirthdayDate.Location = new System.Drawing.Point(11, 276);
            this.textBirthdayDate.Name = "textBirthdayDate";
            this.textBirthdayDate.Size = new System.Drawing.Size(233, 20);
            this.textBirthdayDate.TabIndex = 33;
            this.textBirthdayDate.TextChanged += new System.EventHandler(this.textBirthdayDate_TextChanged);
            this.textBirthdayDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            this.textBirthdayDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNumber_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Отчество";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(94, 39);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 41;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(271, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 470);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Indigo;
            this.panel4.Controls.Add(this.searchButton);
            this.panel4.Location = new System.Drawing.Point(1, 529);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 99);
            this.panel4.TabIndex = 43;
            // 
            // UserView
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1337, 629);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFlat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textHouseNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBirthdayDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textHumanName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button changeUserRole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
    }
}