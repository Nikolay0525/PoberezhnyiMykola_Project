namespace Project
{
    partial class RegistrationWindow
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
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegistrateAccountButton = new System.Windows.Forms.Button();
            this.TeacherCheck = new System.Windows.Forms.CheckBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(13, 211);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(276, 27);
            this.PasswordTextBox.TabIndex = 6;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameTextBox.Location = new System.Drawing.Point(13, 154);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(276, 27);
            this.UsernameTextBox.TabIndex = 7;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsernameLabel.Location = new System.Drawing.Point(106, 129);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(80, 20);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabelRegistration_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(107, 186);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(79, 20);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabelRegistration_Click);
            // 
            // RegistrateAccountButton
            // 
            this.RegistrateAccountButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistrateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrateAccountButton.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrateAccountButton.Location = new System.Drawing.Point(13, 289);
            this.RegistrateAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegistrateAccountButton.Name = "RegistrateAccountButton";
            this.RegistrateAccountButton.Size = new System.Drawing.Size(278, 67);
            this.RegistrateAccountButton.TabIndex = 14;
            this.RegistrateAccountButton.Text = "Registrate";
            this.RegistrateAccountButton.UseVisualStyleBackColor = false;
            this.RegistrateAccountButton.Click += new System.EventHandler(this.RegistrateAccountButton_Click);
            // 
            // TeacherCheck
            // 
            this.TeacherCheck.AutoSize = true;
            this.TeacherCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TeacherCheck.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TeacherCheck.Location = new System.Drawing.Point(198, 255);
            this.TeacherCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TeacherCheck.Name = "TeacherCheck";
            this.TeacherCheck.Size = new System.Drawing.Size(93, 24);
            this.TeacherCheck.TabIndex = 16;
            this.TeacherCheck.Text = "Teacher?";
            this.TeacherCheck.UseVisualStyleBackColor = false;
            this.TeacherCheck.CheckedChanged += new System.EventHandler(this.TeacherCheck_CheckedChanged);
            // 
            // MessageLabel
            // 
            this.MessageLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MessageLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageLabel.ForeColor = System.Drawing.Color.Red;
            this.MessageLabel.Location = new System.Drawing.Point(16, 96);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(260, 20);
            this.MessageLabel.TabIndex = 17;
            this.MessageLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegistrationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 368);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.TeacherCheck);
            this.Controls.Add(this.RegistrateAccountButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistrationWindow";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.RegistrationWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegistrateAccountButton;
        private System.Windows.Forms.CheckBox TeacherCheck;
        private System.Windows.Forms.Label MessageLabel;
    }
}