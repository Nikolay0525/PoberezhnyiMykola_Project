namespace Project.Forms
{
    partial class CybersecurityCourseEnvironmentForm
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
            this.Exam1Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exam1Button
            // 
            this.Exam1Button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exam1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exam1Button.Location = new System.Drawing.Point(6, 311);
            this.Exam1Button.Name = "Exam1Button";
            this.Exam1Button.Size = new System.Drawing.Size(362, 84);
            this.Exam1Button.TabIndex = 3;
            this.Exam1Button.Text = "Exam №1";
            this.Exam1Button.UseVisualStyleBackColor = false;
            this.Exam1Button.Click += new System.EventHandler(this.Exam1Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Project.Properties.Resources.Cybersecurity;
            this.pictureBox1.Location = new System.Drawing.Point(6, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CybersecurityCourseEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exam1Button);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "CybersecurityCourseEnvironmentForm";
            this.Controls.SetChildIndex(this.Exam1Button, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Exam1Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
