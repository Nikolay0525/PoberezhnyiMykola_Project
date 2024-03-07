namespace Project
{
    partial class UniversityLoginWindow
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
            this.RegisterButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.LoginButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FailLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterButton.Depth = 0;
            this.RegisterButton.Icon = null;
            this.RegisterButton.Location = new System.Drawing.Point(174, 249);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Primary = false;
            this.RegisterButton.Size = new System.Drawing.Size(69, 36);
            this.RegisterButton.TabIndex = 0;
            this.RegisterButton.Text = "Sign in";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoginButton.Depth = 0;
            this.LoginButton.Icon = null;
            this.LoginButton.Location = new System.Drawing.Point(174, 201);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoginButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Primary = false;
            this.LoginButton.Size = new System.Drawing.Size(61, 36);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(112, 102);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(185, 20);
            this.UsernameTextBox.TabIndex = 1;
            this.UsernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(112, 172);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(185, 20);
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Depth = 0;
            this.usernameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(170, 76);
            this.usernameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 19);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Depth = 0;
            this.passwordLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(170, 146);
            this.passwordLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(75, 19);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // FailLabel
            // 
            this.FailLabel.AutoSize = true;
            this.FailLabel.Depth = 0;
            this.FailLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FailLabel.Location = new System.Drawing.Point(243, 211);
            this.FailLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FailLabel.Name = "FailLabel";
            this.FailLabel.Size = new System.Drawing.Size(0, 19);
            this.FailLabel.TabIndex = 3;
            // 
            // UniversityLoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.FailLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RegisterButton);
            this.Name = "UniversityLoginWindow";
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton RegisterButton;
        private MaterialSkin.Controls.MaterialFlatButton LoginButton;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private MaterialSkin.Controls.MaterialLabel usernameLabel;
        private MaterialSkin.Controls.MaterialLabel passwordLabel;
        private MaterialSkin.Controls.MaterialLabel FailLabel;
    }
}

