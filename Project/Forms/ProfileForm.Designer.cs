namespace Project.Forms
{
    partial class ProfileForm
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
            this.ProfileTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MessageButton = new System.Windows.Forms.Button();
            this.ExpelButton = new System.Windows.Forms.Button();
            this.CoursesList = new System.Windows.Forms.ListView();
            this.CoursesLabel = new System.Windows.Forms.Label();
            this.DegreeLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Degree = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.ProfileTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileTab
            // 
            this.ProfileTab.Controls.Add(this.tabPage1);
            this.ProfileTab.Controls.Add(this.tabPage2);
            this.ProfileTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProfileTab.Location = new System.Drawing.Point(0, 63);
            this.ProfileTab.Name = "ProfileTab";
            this.ProfileTab.SelectedIndex = 0;
            this.ProfileTab.Size = new System.Drawing.Size(304, 305);
            this.ProfileTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MessageButton);
            this.tabPage1.Controls.Add(this.ExpelButton);
            this.tabPage1.Controls.Add(this.CoursesList);
            this.tabPage1.Controls.Add(this.CoursesLabel);
            this.tabPage1.Controls.Add(this.DegreeLabel);
            this.tabPage1.Controls.Add(this.RoleLabel);
            this.tabPage1.Controls.Add(this.SurnameLabel);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.Degree);
            this.tabPage1.Controls.Add(this.Role);
            this.tabPage1.Controls.Add(this.LastName);
            this.tabPage1.Controls.Add(this.FirstName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(296, 272);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(296, 272);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MessageButton
            // 
            this.MessageButton.Location = new System.Drawing.Point(139, 229);
            this.MessageButton.Name = "MessageButton";
            this.MessageButton.Size = new System.Drawing.Size(137, 37);
            this.MessageButton.TabIndex = 23;
            this.MessageButton.Text = "Send message";
            this.MessageButton.UseVisualStyleBackColor = true;
            // 
            // ExpelButton
            // 
            this.ExpelButton.Location = new System.Drawing.Point(139, 193);
            this.ExpelButton.Name = "ExpelButton";
            this.ExpelButton.Size = new System.Drawing.Size(137, 30);
            this.ExpelButton.TabIndex = 24;
            this.ExpelButton.Text = "Expel";
            this.ExpelButton.UseVisualStyleBackColor = true;
            // 
            // CoursesList
            // 
            this.CoursesList.HideSelection = false;
            this.CoursesList.Location = new System.Drawing.Point(8, 193);
            this.CoursesList.Name = "CoursesList";
            this.CoursesList.Size = new System.Drawing.Size(118, 73);
            this.CoursesList.TabIndex = 22;
            this.CoursesList.UseCompatibleStateImageBehavior = false;
            // 
            // CoursesLabel
            // 
            this.CoursesLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CoursesLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoursesLabel.Location = new System.Drawing.Point(17, 165);
            this.CoursesLabel.Name = "CoursesLabel";
            this.CoursesLabel.Size = new System.Drawing.Size(100, 25);
            this.CoursesLabel.TabIndex = 21;
            this.CoursesLabel.Text = "Courses";
            this.CoursesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DegreeLabel
            // 
            this.DegreeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DegreeLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DegreeLabel.Location = new System.Drawing.Point(161, 165);
            this.DegreeLabel.Name = "DegreeLabel";
            this.DegreeLabel.Size = new System.Drawing.Size(100, 25);
            this.DegreeLabel.TabIndex = 17;
            this.DegreeLabel.Text = "Degree";
            this.DegreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleLabel
            // 
            this.RoleLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoleLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.Location = new System.Drawing.Point(161, 115);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(100, 25);
            this.RoleLabel.TabIndex = 18;
            this.RoleLabel.Text = "Role";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SurnameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameLabel.Location = new System.Drawing.Point(161, 65);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(100, 25);
            this.SurnameLabel.TabIndex = 19;
            this.SurnameLabel.Text = "Surname";
            this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(161, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 25);
            this.NameLabel.TabIndex = 20;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Project.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(8, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // Degree
            // 
            this.Degree.BackColor = System.Drawing.SystemColors.Control;
            this.Degree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Degree.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Degree.Location = new System.Drawing.Point(139, 190);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(137, 25);
            this.Degree.TabIndex = 12;
            // 
            // Role
            // 
            this.Role.BackColor = System.Drawing.SystemColors.Control;
            this.Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Role.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Role.Location = new System.Drawing.Point(139, 140);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(137, 25);
            this.Role.TabIndex = 13;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.SystemColors.Control;
            this.LastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(139, 90);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(137, 25);
            this.LastName.TabIndex = 14;
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.SystemColors.Control;
            this.FirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(139, 40);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(137, 25);
            this.FirstName.TabIndex = 15;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 368);
            this.Controls.Add(this.ProfileTab);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.ProfileTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ProfileTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button MessageButton;
        private System.Windows.Forms.Button ExpelButton;
        private System.Windows.Forms.ListView CoursesList;
        private System.Windows.Forms.Label CoursesLabel;
        private System.Windows.Forms.Label DegreeLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Degree;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.TabPage tabPage2;
    }
}