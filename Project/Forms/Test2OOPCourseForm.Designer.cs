using System.Windows.Forms;
using System;

namespace Project.Forms
{
    partial class Test2OOPCourseForm
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
        /// 
        
        private void InitializeComponent()
        {
            this.Q3Box = new System.Windows.Forms.GroupBox();
            this.Q3Answer3 = new System.Windows.Forms.RadioButton();
            this.Q3Answer2 = new System.Windows.Forms.RadioButton();
            this.Q3Answer1 = new System.Windows.Forms.RadioButton();
            this.Q2Box = new System.Windows.Forms.GroupBox();
            this.Q2Answer3 = new System.Windows.Forms.RadioButton();
            this.Q2Answer2 = new System.Windows.Forms.RadioButton();
            this.Q2Answer1 = new System.Windows.Forms.RadioButton();
            this.Q1Box = new System.Windows.Forms.GroupBox();
            this.Q1Answer3 = new System.Windows.Forms.RadioButton();
            this.Q1Answer1 = new System.Windows.Forms.RadioButton();
            this.Q1Answer2 = new System.Windows.Forms.RadioButton();
            this.Question1Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question2Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question3Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Q3Box.SuspendLayout();
            this.Q2Box.SuspendLayout();
            this.Q1Box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Question1Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question2Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question3Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Q3Box
            // 
            this.Q3Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Q3Box.Controls.Add(this.Q3Answer3);
            this.Q3Box.Controls.Add(this.Q3Answer2);
            this.Q3Box.Controls.Add(this.Q3Answer1);
            this.Q3Box.Location = new System.Drawing.Point(79, 426);
            this.Q3Box.Name = "Q3Box";
            this.Q3Box.Size = new System.Drawing.Size(330, 87);
            this.Q3Box.TabIndex = 28;
            this.Q3Box.TabStop = false;
            // 
            // Q3Answer3
            // 
            this.Q3Answer3.AutoSize = true;
            this.Q3Answer3.Location = new System.Drawing.Point(18, 57);
            this.Q3Answer3.Name = "Q3Answer3";
            this.Q3Answer3.Size = new System.Drawing.Size(188, 24);
            this.Q3Answer3.TabIndex = 0;
            this.Q3Answer3.TabStop = true;
            this.Q3Answer3.Text = "Flexibility, overloading.";
            this.Q3Answer3.UseVisualStyleBackColor = true;
            this.Q3Answer3.CheckedChanged += new System.EventHandler(this.Q3Box_CheckedChanged);
            // 
            // Q3Answer2
            // 
            this.Q3Answer2.AutoSize = true;
            this.Q3Answer2.Location = new System.Drawing.Point(18, 34);
            this.Q3Answer2.Name = "Q3Answer2";
            this.Q3Answer2.Size = new System.Drawing.Size(181, 24);
            this.Q3Answer2.TabIndex = 0;
            this.Q3Answer2.TabStop = true;
            this.Q3Answer2.Text = "Code reuse, hierarchy.";
            this.Q3Answer2.UseVisualStyleBackColor = true;
            this.Q3Answer2.CheckedChanged += new System.EventHandler(this.Q3Box_CheckedChanged);
            // 
            // Q3Answer1
            // 
            this.Q3Answer1.AutoSize = true;
            this.Q3Answer1.Location = new System.Drawing.Point(18, 12);
            this.Q3Answer1.Name = "Q3Answer1";
            this.Q3Answer1.Size = new System.Drawing.Size(199, 24);
            this.Q3Answer1.TabIndex = 0;
            this.Q3Answer1.TabStop = true;
            this.Q3Answer1.Text = "Data hiding, abstraction.";
            this.Q3Answer1.UseVisualStyleBackColor = true;
            this.Q3Answer1.CheckedChanged += new System.EventHandler(this.Q3Box_CheckedChanged);
            // 
            // Q2Box
            // 
            this.Q2Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Q2Box.Controls.Add(this.Q2Answer3);
            this.Q2Box.Controls.Add(this.Q2Answer2);
            this.Q2Box.Controls.Add(this.Q2Answer1);
            this.Q2Box.Location = new System.Drawing.Point(79, 307);
            this.Q2Box.Name = "Q2Box";
            this.Q2Box.Size = new System.Drawing.Size(330, 87);
            this.Q2Box.TabIndex = 29;
            this.Q2Box.TabStop = false;
            // 
            // Q2Answer3
            // 
            this.Q2Answer3.AutoSize = true;
            this.Q2Answer3.Location = new System.Drawing.Point(18, 57);
            this.Q2Answer3.Name = "Q2Answer3";
            this.Q2Answer3.Size = new System.Drawing.Size(188, 24);
            this.Q2Answer3.TabIndex = 0;
            this.Q2Answer3.TabStop = true;
            this.Q2Answer3.Text = "Flexibility, overloading.";
            this.Q2Answer3.UseVisualStyleBackColor = true;
            this.Q2Answer3.CheckedChanged += new System.EventHandler(this.Q2Box_CheckedChanged);
            // 
            // Q2Answer2
            // 
            this.Q2Answer2.AutoSize = true;
            this.Q2Answer2.Location = new System.Drawing.Point(18, 34);
            this.Q2Answer2.Name = "Q2Answer2";
            this.Q2Answer2.Size = new System.Drawing.Size(181, 24);
            this.Q2Answer2.TabIndex = 0;
            this.Q2Answer2.TabStop = true;
            this.Q2Answer2.Text = "Code reuse, hierarchy.";
            this.Q2Answer2.UseVisualStyleBackColor = true;
            this.Q2Answer2.CheckedChanged += new System.EventHandler(this.Q2Box_CheckedChanged);
            // 
            // Q2Answer1
            // 
            this.Q2Answer1.AutoSize = true;
            this.Q2Answer1.Location = new System.Drawing.Point(18, 12);
            this.Q2Answer1.Name = "Q2Answer1";
            this.Q2Answer1.Size = new System.Drawing.Size(199, 24);
            this.Q2Answer1.TabIndex = 0;
            this.Q2Answer1.TabStop = true;
            this.Q2Answer1.Text = "Data hiding, abstraction.";
            this.Q2Answer1.UseVisualStyleBackColor = true;
            this.Q2Answer1.CheckedChanged += new System.EventHandler(this.Q2Box_CheckedChanged);
            // 
            // Q1Box
            // 
            this.Q1Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Q1Box.Controls.Add(this.Q1Answer3);
            this.Q1Box.Controls.Add(this.Q1Answer1);
            this.Q1Box.Controls.Add(this.Q1Answer2);
            this.Q1Box.Location = new System.Drawing.Point(79, 185);
            this.Q1Box.Name = "Q1Box";
            this.Q1Box.Size = new System.Drawing.Size(330, 87);
            this.Q1Box.TabIndex = 27;
            this.Q1Box.TabStop = false;
            // 
            // Q1Answer3
            // 
            this.Q1Answer3.AutoSize = true;
            this.Q1Answer3.Location = new System.Drawing.Point(7, 61);
            this.Q1Answer3.Name = "Q1Answer3";
            this.Q1Answer3.Size = new System.Drawing.Size(188, 24);
            this.Q1Answer3.TabIndex = 1;
            this.Q1Answer3.TabStop = true;
            this.Q1Answer3.Text = "Flexibility, overloading.";
            this.Q1Answer3.UseVisualStyleBackColor = true;
            this.Q1Answer3.CheckedChanged += new System.EventHandler(this.Q1Box_CheckedChanged);
            // 
            // Q1Answer1
            // 
            this.Q1Answer1.AutoSize = true;
            this.Q1Answer1.Location = new System.Drawing.Point(7, 17);
            this.Q1Answer1.Name = "Q1Answer1";
            this.Q1Answer1.Size = new System.Drawing.Size(199, 24);
            this.Q1Answer1.TabIndex = 3;
            this.Q1Answer1.TabStop = true;
            this.Q1Answer1.Text = "Data hiding, abstraction.";
            this.Q1Answer1.UseVisualStyleBackColor = true;
            this.Q1Answer1.CheckedChanged += new System.EventHandler(this.Q1Box_CheckedChanged);
            // 
            // Q1Answer2
            // 
            this.Q1Answer2.AutoSize = true;
            this.Q1Answer2.Location = new System.Drawing.Point(7, 38);
            this.Q1Answer2.Name = "Q1Answer2";
            this.Q1Answer2.Size = new System.Drawing.Size(181, 24);
            this.Q1Answer2.TabIndex = 2;
            this.Q1Answer2.TabStop = true;
            this.Q1Answer2.Text = "Code reuse, hierarchy.";
            this.Q1Answer2.UseVisualStyleBackColor = true;
            this.Q1Answer2.CheckedChanged += new System.EventHandler(this.Q1Box_CheckedChanged);
            // 
            // Question1Table
            // 
            this.Question1Table.AllowUserToAddRows = false;
            this.Question1Table.AllowUserToDeleteRows = false;
            this.Question1Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question1Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.Question1Table.Location = new System.Drawing.Point(592, 156);
            this.Question1Table.Name = "Question1Table";
            this.Question1Table.ReadOnly = true;
            this.Question1Table.Size = new System.Drawing.Size(273, 109);
            this.Question1Table.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Student";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // Question2Table
            // 
            this.Question2Table.AllowUserToAddRows = false;
            this.Question2Table.AllowUserToDeleteRows = false;
            this.Question2Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question2Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Question2Table.Location = new System.Drawing.Point(592, 271);
            this.Question2Table.Name = "Question2Table";
            this.Question2Table.ReadOnly = true;
            this.Question2Table.Size = new System.Drawing.Size(273, 117);
            this.Question2Table.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Student";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // Question3Table
            // 
            this.Question3Table.AllowUserToAddRows = false;
            this.Question3Table.AllowUserToDeleteRows = false;
            this.Question3Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question3Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.Question3Table.Location = new System.Drawing.Point(592, 394);
            this.Question3Table.Name = "Question3Table";
            this.Question3Table.ReadOnly = true;
            this.Question3Table.Size = new System.Drawing.Size(273, 117);
            this.Question3Table.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Student";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Location = new System.Drawing.Point(13, 575);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(474, 56);
            this.SendButton.TabIndex = 23;
            this.SendButton.Text = "Send Answers";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(78, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "What about encapsulation?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(93, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "What mean polymorphism?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "What mean inheritance?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(146, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Test2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Test2OOPCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(893, 700);
            this.Controls.Add(this.Q3Box);
            this.Controls.Add(this.Q2Box);
            this.Controls.Add(this.Q1Box);
            this.Controls.Add(this.Question1Table);
            this.Controls.Add(this.Question2Table);
            this.Controls.Add(this.Question3Table);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test2OOPCourseForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.SendButton, 0);
            this.Controls.SetChildIndex(this.Question3Table, 0);
            this.Controls.SetChildIndex(this.Question2Table, 0);
            this.Controls.SetChildIndex(this.Question1Table, 0);
            this.Controls.SetChildIndex(this.Q1Box, 0);
            this.Controls.SetChildIndex(this.Q2Box, 0);
            this.Controls.SetChildIndex(this.Q3Box, 0);
            this.Q3Box.ResumeLayout(false);
            this.Q3Box.PerformLayout();
            this.Q2Box.ResumeLayout(false);
            this.Q2Box.PerformLayout();
            this.Q1Box.ResumeLayout(false);
            this.Q1Box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Question1Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question2Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question3Table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Q3Box;
        private RadioButton Q3Answer3;
        private RadioButton Q3Answer2;
        private RadioButton Q3Answer1;
        private GroupBox Q2Box;
        private RadioButton Q2Answer3;
        private RadioButton Q2Answer2;
        private RadioButton Q2Answer1;
        private GroupBox Q1Box;
        private RadioButton Q1Answer3;
        private RadioButton Q1Answer1;
        private RadioButton Q1Answer2;
        private DataGridView Question1Table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView Question2Table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView Question3Table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button SendButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
