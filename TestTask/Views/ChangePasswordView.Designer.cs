namespace TestTask.Views
{
    partial class ChangePasswordView
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
            this.label3 = new System.Windows.Forms.Label();
            this.savePasswordBtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Введите пароль:";
            // 
            // savePasswordBtn
            // 
            this.savePasswordBtn.Location = new System.Drawing.Point(177, 212);
            this.savePasswordBtn.Name = "savePasswordBtn";
            this.savePasswordBtn.Size = new System.Drawing.Size(75, 23);
            this.savePasswordBtn.TabIndex = 15;
            this.savePasswordBtn.Text = "Сохранить";
            this.savePasswordBtn.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(80, 117);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(262, 20);
            this.passwordTextBox.TabIndex = 14;
            // 
            // backBtn
            // 
            this.backBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(139, 23);
            this.backBtn.TabIndex = 13;
            this.backBtn.Text = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordView
            // 
            this.AcceptButton = this.savePasswordBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.backBtn;
            this.ClientSize = new System.Drawing.Size(420, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.savePasswordBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.backBtn);
            this.Name = "ChangePasswordView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savePasswordBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button backBtn;
    }
}