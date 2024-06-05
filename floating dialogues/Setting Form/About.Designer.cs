namespace TearDown_Project_mangament_software.Setting_Form
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(138, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(104, 93, 121);
            label1.Location = new Point(250, 84);
            label1.Name = "label1";
            label1.Size = new Size(251, 62);
            label1.TabIndex = 1;
            label1.Text = "Teardown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(104, 93, 121);
            label2.Location = new Point(270, 146);
            label2.Name = "label2";
            label2.Size = new Size(204, 27);
            label2.TabIndex = 2;
            label2.Text = "Version 0.1 Beta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(104, 93, 121);
            label3.Location = new Point(33, 252);
            label3.Name = "label3";
            label3.Size = new Size(612, 54);
            label3.TabIndex = 3;
            label3.Text = "A Personal Task Management Win-Forms Based Project\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(104, 93, 121);
            label4.Location = new Point(250, 333);
            label4.Name = "label4";
            label4.Size = new Size(180, 135);
            label4.TabIndex = 4;
            label4.Text = "Created By:\r\nA. Lerado\r\nR. Gahuman\r\nE.D. Dela Rosa\r\n\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 187, 109);
            ClientSize = new Size(685, 486);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "About";
            Text = "About";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}