namespace TestTask.Views
{
    partial class CheckPasswordView
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
            this.changeRole = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.checkPasswordBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeRole
            // 
            this.changeRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeRole.Location = new System.Drawing.Point(12, 12);
            this.changeRole.Name = "changeRole";
            this.changeRole.Size = new System.Drawing.Size(139, 23);
            this.changeRole.TabIndex = 1;
            this.changeRole.Text = "К выбору роли";
            this.changeRole.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(80, 117);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(262, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // checkPasswordBtn
            // 
            this.checkPasswordBtn.Location = new System.Drawing.Point(172, 215);
            this.checkPasswordBtn.Name = "checkPasswordBtn";
            this.checkPasswordBtn.Size = new System.Drawing.Size(75, 23);
            this.checkPasswordBtn.TabIndex = 3;
            this.checkPasswordBtn.Text = "Войти";
            this.checkPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введите пароль:";
            // 
            // CheckPasswordView
            // 
            this.AcceptButton = this.checkPasswordBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.changeRole;
            this.ClientSize = new System.Drawing.Size(422, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkPasswordBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.changeRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CheckPasswordView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordCheckView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeRole;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button checkPasswordBtn;
        private System.Windows.Forms.Label label3;
    }
}