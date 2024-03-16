namespace Project.Forms
{
    partial class JournalForm
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
            this.JournalTable = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JournalTable)).BeginInit();
            this.SuspendLayout();
            // 
            // JournalTable
            // 
            this.JournalTable.AllowUserToAddRows = false;
            this.JournalTable.AllowUserToDeleteRows = false;
            this.JournalTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.JournalTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName});
            this.JournalTable.Location = new System.Drawing.Point(0, 64);
            this.JournalTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JournalTable.Name = "JournalTable";
            this.JournalTable.Size = new System.Drawing.Size(600, 281);
            this.JournalTable.TabIndex = 1;
            this.JournalTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JournalTable_CellContentClick);
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Student";
            this.UserName.Name = "UserName";
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UserName.Width = 180;
            // 
            // ApplyButton
            // 
            this.ApplyButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ApplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplyButton.Location = new System.Drawing.Point(7, 350);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(290, 44);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Apply changes";
            this.ApplyButton.UseVisualStyleBackColor = false;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(304, 350);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(290, 44);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Go back";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.JournalTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "JournalForm";
            ((System.ComponentModel.ISupportInitialize)(this.JournalTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView JournalTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CloseButton;
    }
}