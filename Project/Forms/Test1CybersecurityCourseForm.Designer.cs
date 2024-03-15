using System.Windows.Forms;
using System;

namespace Project.Forms
{
    partial class Test1CybersecurityCourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Question1Check1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.Question1Check2 = new System.Windows.Forms.CheckBox();
            this.Question1Check3 = new System.Windows.Forms.CheckBox();
            this.Question2Check1 = new System.Windows.Forms.CheckBox();
            this.Question2Check2 = new System.Windows.Forms.CheckBox();
            this.Question2Check3 = new System.Windows.Forms.CheckBox();
            this.Question3Check1 = new System.Windows.Forms.CheckBox();
            this.Question3Check2 = new System.Windows.Forms.CheckBox();
            this.Question3Check3 = new System.Windows.Forms.CheckBox();
            this.Question3Table = new System.Windows.Forms.DataGridView();
            this.Question2Table = new System.Windows.Forms.DataGridView();
            this.Question1Table = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Question3Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question2Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question1Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Test1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Question1Check1
            // 
            this.Question1Check1.AutoSize = true;
            this.Question1Check1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question1Check1.Location = new System.Drawing.Point(165, 182);
            this.Question1Check1.Name = "Question1Check1";
            this.Question1Check1.Size = new System.Drawing.Size(160, 24);
            this.Question1Check1.TabIndex = 2;
            this.Question1Check1.Text = "Windows Defender";
            this.Question1Check1.UseVisualStyleBackColor = false;
            this.Question1Check1.CheckedChanged += new System.EventHandler(this.Question1Check_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is the best free antivirus?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Is using of pirate soft safe?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(77, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Can we trust Answer of ChatGPT?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Location = new System.Drawing.Point(12, 569);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(474, 56);
            this.SendButton.TabIndex = 3;
            this.SendButton.Text = "Send Answer";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Question1Check2
            // 
            this.Question1Check2.AutoSize = true;
            this.Question1Check2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question1Check2.Location = new System.Drawing.Point(205, 212);
            this.Question1Check2.Name = "Question1Check2";
            this.Question1Check2.Size = new System.Drawing.Size(68, 24);
            this.Question1Check2.TabIndex = 2;
            this.Question1Check2.Text = "Avast";
            this.Question1Check2.UseVisualStyleBackColor = false;
            this.Question1Check2.CheckedChanged += new System.EventHandler(this.Question1Check_CheckedChanged);
            // 
            // Question1Check3
            // 
            this.Question1Check3.AutoSize = true;
            this.Question1Check3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question1Check3.Location = new System.Drawing.Point(210, 242);
            this.Question1Check3.Name = "Question1Check3";
            this.Question1Check3.Size = new System.Drawing.Size(59, 24);
            this.Question1Check3.TabIndex = 2;
            this.Question1Check3.Text = "AVG";
            this.Question1Check3.UseVisualStyleBackColor = false;
            this.Question1Check3.CheckedChanged += new System.EventHandler(this.Question1Check_CheckedChanged);
            // 
            // Question2Check1
            // 
            this.Question2Check1.AutoSize = true;
            this.Question2Check1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question2Check1.Location = new System.Drawing.Point(165, 301);
            this.Question2Check1.Name = "Question2Check1";
            this.Question2Check1.Size = new System.Drawing.Size(163, 24);
            this.Question2Check1.TabIndex = 2;
            this.Question2Check1.Text = "Yes, it\'s fully safe!!!";
            this.Question2Check1.UseVisualStyleBackColor = false;
            this.Question2Check1.CheckedChanged += new System.EventHandler(this.Question2Check_CheckedChanged);
            // 
            // Question2Check2
            // 
            this.Question2Check2.AutoSize = true;
            this.Question2Check2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question2Check2.Location = new System.Drawing.Point(101, 331);
            this.Question2Check2.Name = "Question2Check2";
            this.Question2Check2.Size = new System.Drawing.Size(316, 24);
            this.Question2Check2.TabIndex = 2;
            this.Question2Check2.Text = "50/50, some program may be dangerous";
            this.Question2Check2.UseVisualStyleBackColor = false;
            this.Question2Check2.CheckedChanged += new System.EventHandler(this.Question2Check_CheckedChanged);
            // 
            // Question2Check3
            // 
            this.Question2Check3.AutoSize = true;
            this.Question2Check3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question2Check3.Location = new System.Drawing.Point(143, 361);
            this.Question2Check3.Name = "Question2Check3";
            this.Question2Check3.Size = new System.Drawing.Size(201, 24);
            this.Question2Check3.TabIndex = 2;
            this.Question2Check3.Text = "No, much better buy soft";
            this.Question2Check3.UseVisualStyleBackColor = false;
            this.Question2Check3.CheckedChanged += new System.EventHandler(this.Question2Check_CheckedChanged);
            // 
            // Question3Check1
            // 
            this.Question3Check1.AutoSize = true;
            this.Question3Check1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question3Check1.Location = new System.Drawing.Point(165, 420);
            this.Question3Check1.Name = "Question3Check1";
            this.Question3Check1.Size = new System.Drawing.Size(160, 24);
            this.Question3Check1.TabIndex = 2;
            this.Question3Check1.Text = "Yes, he\'s the God!!!";
            this.Question3Check1.UseVisualStyleBackColor = false;
            this.Question3Check1.CheckedChanged += new System.EventHandler(this.Question3Check_CheckedChanged);
            // 
            // Question3Check2
            // 
            this.Question3Check2.AutoSize = true;
            this.Question3Check2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question3Check2.Location = new System.Drawing.Point(101, 450);
            this.Question3Check2.Name = "Question3Check2";
            this.Question3Check2.Size = new System.Drawing.Size(320, 24);
            this.Question3Check2.TabIndex = 2;
            this.Question3Check2.Text = "We should check his Answer before using";
            this.Question3Check2.UseVisualStyleBackColor = false;
            this.Question3Check2.CheckedChanged += new System.EventHandler(this.Question3Check_CheckedChanged);
            // 
            // Question3Check3
            // 
            this.Question3Check3.AutoSize = true;
            this.Question3Check3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Question3Check3.Location = new System.Drawing.Point(137, 480);
            this.Question3Check3.Name = "Question3Check3";
            this.Question3Check3.Size = new System.Drawing.Size(226, 24);
            this.Question3Check3.TabIndex = 2;
            this.Question3Check3.Text = "No, he\'s giving trash Answer";
            this.Question3Check3.UseVisualStyleBackColor = false;
            this.Question3Check3.CheckedChanged += new System.EventHandler(this.Question3Check_CheckedChanged);
            // 
            // Question3Table
            // 
            this.Question3Table.AllowUserToAddRows = false;
            this.Question3Table.AllowUserToDeleteRows = false;
            this.Question3Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question3Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.Question3Table.Location = new System.Drawing.Point(591, 388);
            this.Question3Table.Name = "Question3Table";
            this.Question3Table.ReadOnly = true;
            this.Question3Table.Size = new System.Drawing.Size(273, 117);
            this.Question3Table.TabIndex = 4;
            // 
            // Question2Table
            // 
            this.Question2Table.AllowUserToAddRows = false;
            this.Question2Table.AllowUserToDeleteRows = false;
            this.Question2Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question2Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.Question2Table.Location = new System.Drawing.Point(591, 265);
            this.Question2Table.Name = "Question2Table";
            this.Question2Table.ReadOnly = true;
            this.Question2Table.Size = new System.Drawing.Size(273, 117);
            this.Question2Table.TabIndex = 4;
            // 
            // Question1Table
            // 
            this.Question1Table.AllowUserToAddRows = false;
            this.Question1Table.AllowUserToDeleteRows = false;
            this.Question1Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Question1Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5});
            this.Question1Table.Location = new System.Drawing.Point(591, 150);
            this.Question1Table.Name = "Question1Table";
            this.Question1Table.ReadOnly = true;
            this.Question1Table.Size = new System.Drawing.Size(273, 109);
            this.Question1Table.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Student";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Student";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Student";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // Test1CybersecurityCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(893, 700);
            this.Controls.Add(this.Question1Table);
            this.Controls.Add(this.Question2Table);
            this.Controls.Add(this.Question3Table);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.Question3Check3);
            this.Controls.Add(this.Question2Check3);
            this.Controls.Add(this.Question1Check3);
            this.Controls.Add(this.Question3Check2);
            this.Controls.Add(this.Question2Check2);
            this.Controls.Add(this.Question1Check2);
            this.Controls.Add(this.Question3Check1);
            this.Controls.Add(this.Question2Check1);
            this.Controls.Add(this.Question1Check1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test1CybersecurityCourseForm";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.Question1Check1, 0);
            this.Controls.SetChildIndex(this.Question2Check1, 0);
            this.Controls.SetChildIndex(this.Question3Check1, 0);
            this.Controls.SetChildIndex(this.Question1Check2, 0);
            this.Controls.SetChildIndex(this.Question2Check2, 0);
            this.Controls.SetChildIndex(this.Question3Check2, 0);
            this.Controls.SetChildIndex(this.Question1Check3, 0);
            this.Controls.SetChildIndex(this.Question2Check3, 0);
            this.Controls.SetChildIndex(this.Question3Check3, 0);
            this.Controls.SetChildIndex(this.SendButton, 0);
            this.Controls.SetChildIndex(this.Question3Table, 0);
            this.Controls.SetChildIndex(this.Question2Table, 0);
            this.Controls.SetChildIndex(this.Question1Table, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Question3Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question2Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Question1Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Question1Check1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.CheckBox Question1Check2;
        private System.Windows.Forms.CheckBox Question1Check3;
        private System.Windows.Forms.CheckBox Question2Check1;
        private System.Windows.Forms.CheckBox Question2Check2;
        private System.Windows.Forms.CheckBox Question2Check3;
        private System.Windows.Forms.CheckBox Question3Check1;
        private System.Windows.Forms.CheckBox Question3Check2;
        private System.Windows.Forms.CheckBox Question3Check3;
        private DataGridView Question3Table;
        private DataGridView Question2Table;
        private DataGridView Question1Table;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
