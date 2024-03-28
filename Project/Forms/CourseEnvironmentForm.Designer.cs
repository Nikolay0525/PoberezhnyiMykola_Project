namespace Project.Forms
{
    partial class CourseEnvironmentForm
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
            this.JournalButton = new System.Windows.Forms.Button();
            this.TeacherTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTable)).BeginInit();
            this.SuspendLayout();
            // 
            // JournalButton
            // 
            this.JournalButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.JournalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JournalButton.Location = new System.Drawing.Point(374, 311);
            this.JournalButton.Name = "JournalButton";
            this.JournalButton.Size = new System.Drawing.Size(223, 39);
            this.JournalButton.TabIndex = 0;
            this.JournalButton.Text = "Journal";
            this.JournalButton.UseVisualStyleBackColor = false;
            this.JournalButton.Click += new System.EventHandler(this.JournalButton_Click);
            // 
            // TeacherTable
            // 
            this.TeacherTable.AllowUserToAddRows = false;
            this.TeacherTable.AllowUserToDeleteRows = false;
            this.TeacherTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TeacherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            this.TeacherTable.Location = new System.Drawing.Point(374, 63);
            this.TeacherTable.Name = "TeacherTable";
            this.TeacherTable.ReadOnly = true;
            this.TeacherTable.Size = new System.Drawing.Size(223, 243);
            this.TeacherTable.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Course Teachers ";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserName.Width = 180;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(374, 355);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(223, 40);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Go back";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CourseEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.TeacherTable);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.JournalButton);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CourseEnvironmentForm";
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button JournalButton;
        private System.Windows.Forms.DataGridView TeacherTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.Button CloseButton;
    }
}