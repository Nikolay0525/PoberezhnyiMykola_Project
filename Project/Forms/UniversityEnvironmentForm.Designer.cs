namespace Project.Forms
{
    partial class UniversityEnvironmentForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PersonRole = new System.Windows.Forms.Label();
            this.PersonName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.ActualCoursesTable = new System.Windows.Forms.DataGridView();
            this.ActualGridColumnCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualGridColumnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualGridColumnCourseFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.AvailableCoursesTable = new System.Windows.Forms.DataGridView();
            this.RowCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GridColumnCourseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridColumnCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridColumnCourseFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ActualCoursesTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCoursesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.ItemSize = new System.Drawing.Size(150, 25);
            this.tabControl.Location = new System.Drawing.Point(0, 64);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 336);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.CloseButton);
            this.tabPage1.Controls.Add(this.PersonRole);
            this.tabPage1.Controls.Add(this.PersonName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.RoleLabel);
            this.tabPage1.Controls.Add(this.ActualCoursesTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Profile";
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(170, 252);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(416, 39);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Sign out";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PersonRole
            // 
            this.PersonRole.BackColor = System.Drawing.SystemColors.Control;
            this.PersonRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonRole.Location = new System.Drawing.Point(13, 267);
            this.PersonRole.Name = "PersonRole";
            this.PersonRole.Size = new System.Drawing.Size(151, 25);
            this.PersonRole.TabIndex = 2;
            // 
            // PersonName
            // 
            this.PersonName.BackColor = System.Drawing.SystemColors.Control;
            this.PersonName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonName.Location = new System.Drawing.Point(14, 204);
            this.PersonName.Name = "PersonName";
            this.PersonName.Size = new System.Drawing.Size(150, 25);
            this.PersonName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(324, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "My Courses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(40, 179);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(100, 25);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoleLabel
            // 
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleLabel.Location = new System.Drawing.Point(40, 242);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(100, 25);
            this.RoleLabel.TabIndex = 2;
            this.RoleLabel.Text = "Role";
            this.RoleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActualCoursesTable
            // 
            this.ActualCoursesTable.AllowUserToAddRows = false;
            this.ActualCoursesTable.AllowUserToDeleteRows = false;
            this.ActualCoursesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ActualCoursesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActualCoursesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActualGridColumnCourseId,
            this.ActualGridColumnCourseName,
            this.ActualGridColumnCourseFaculty});
            this.ActualCoursesTable.Location = new System.Drawing.Point(170, 28);
            this.ActualCoursesTable.Name = "ActualCoursesTable";
            this.ActualCoursesTable.ReadOnly = true;
            this.ActualCoursesTable.Size = new System.Drawing.Size(419, 218);
            this.ActualCoursesTable.TabIndex = 1;
            this.ActualCoursesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActualCoursesTable_CellContentClick);
            // 
            // ActualGridColumnCourseId
            // 
            this.ActualGridColumnCourseId.HeaderText = "ID";
            this.ActualGridColumnCourseId.Name = "ActualGridColumnCourseId";
            this.ActualGridColumnCourseId.ReadOnly = true;
            this.ActualGridColumnCourseId.Width = 30;
            // 
            // ActualGridColumnCourseName
            // 
            this.ActualGridColumnCourseName.HeaderText = "Course";
            this.ActualGridColumnCourseName.Name = "ActualGridColumnCourseName";
            this.ActualGridColumnCourseName.ReadOnly = true;
            this.ActualGridColumnCourseName.Width = 146;
            // 
            // ActualGridColumnCourseFaculty
            // 
            this.ActualGridColumnCourseFaculty.HeaderText = "Faculty";
            this.ActualGridColumnCourseFaculty.Name = "ActualGridColumnCourseFaculty";
            this.ActualGridColumnCourseFaculty.ReadOnly = true;
            this.ActualGridColumnCourseFaculty.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.SignButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.AvailableCoursesTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(9, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 84);
            this.button1.TabIndex = 6;
            this.button1.Text = "Unsign from courses";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UnsignButton_Click);
            // 
            // SignButton
            // 
            this.SignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignButton.Location = new System.Drawing.Point(9, 28);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(136, 177);
            this.SignButton.TabIndex = 4;
            this.SignButton.Text = "Sign to courses";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(291, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Available Courses";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvailableCoursesTable
            // 
            this.AvailableCoursesTable.AllowUserToAddRows = false;
            this.AvailableCoursesTable.AllowUserToDeleteRows = false;
            this.AvailableCoursesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.AvailableCoursesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailableCoursesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowCheck,
            this.GridColumnCourseId,
            this.GridColumnCourseName,
            this.GridColumnCourseFaculty});
            this.AvailableCoursesTable.Location = new System.Drawing.Point(150, 28);
            this.AvailableCoursesTable.Name = "AvailableCoursesTable";
            this.AvailableCoursesTable.Size = new System.Drawing.Size(439, 269);
            this.AvailableCoursesTable.TabIndex = 2;
            // 
            // RowCheck
            // 
            this.RowCheck.HeaderText = "";
            this.RowCheck.Name = "RowCheck";
            this.RowCheck.Width = 20;
            // 
            // GridColumnCourseId
            // 
            this.GridColumnCourseId.HeaderText = "ID";
            this.GridColumnCourseId.Name = "GridColumnCourseId";
            this.GridColumnCourseId.ReadOnly = true;
            this.GridColumnCourseId.Width = 30;
            // 
            // GridColumnCourseName
            // 
            this.GridColumnCourseName.HeaderText = "Course";
            this.GridColumnCourseName.Name = "GridColumnCourseName";
            this.GridColumnCourseName.ReadOnly = true;
            this.GridColumnCourseName.Width = 146;
            // 
            // GridColumnCourseFaculty
            // 
            this.GridColumnCourseFaculty.HeaderText = "Faculty";
            this.GridColumnCourseFaculty.Name = "GridColumnCourseFaculty";
            this.GridColumnCourseFaculty.ReadOnly = true;
            this.GridColumnCourseFaculty.Width = 200;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Project.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UniversityEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.tabControl);
            this.Name = "UniversityEnvironmentForm";
            this.Text = "Welcome back to environment!";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ActualCoursesTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvailableCoursesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label PersonName;
        private System.Windows.Forms.DataGridView ActualCoursesTable;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PersonRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AvailableCoursesTable;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualGridColumnCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualGridColumnCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualGridColumnCourseFaculty;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RowCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridColumnCourseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridColumnCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridColumnCourseFaculty;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}