namespace TearDown_Project_mangament_software.Forms
{
    partial class Dashboard
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
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            Title_lbl = new Label();
            panel3 = new Panel();
            upcomingTask_panel = new Panel();
            task_property_panel = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            task_propeties_lbl = new Label();
            upcoming_task_lbl = new Label();
            Greeting_lbl = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            upcomingTask_panel.SuspendLayout();
            task_property_panel.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(90, 30, 92, 122);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(Title_lbl);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 623);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(20, 71, 92, 122);
            panel2.Controls.Add(task_property_panel);
            panel2.Controls.Add(upcomingTask_panel);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(476, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 623);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.icons8_bullseye_100_2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Title_lbl
            // 
            Title_lbl.AutoSize = true;
            Title_lbl.BackColor = Color.Transparent;
            Title_lbl.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Title_lbl.Location = new Point(124, 46);
            Title_lbl.Name = "Title_lbl";
            Title_lbl.Size = new Size(171, 43);
            Title_lbl.TabIndex = 1;
            Title_lbl.Text = "Teardown";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(252, 187, 109);
            panel3.Controls.Add(Greeting_lbl);
            panel3.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(12, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(440, 482);
            panel3.TabIndex = 2;
            // 
            // upcomingTask_panel
            // 
            upcomingTask_panel.BackColor = Color.FromArgb(71, 92, 122);
            upcomingTask_panel.Controls.Add(flowLayoutPanel1);
            upcomingTask_panel.Controls.Add(panel4);
            upcomingTask_panel.Location = new Point(20, 13);
            upcomingTask_panel.Name = "upcomingTask_panel";
            upcomingTask_panel.Size = new Size(353, 598);
            upcomingTask_panel.TabIndex = 0;
            // 
            // task_property_panel
            // 
            task_property_panel.BackColor = Color.FromArgb(71, 92, 122);
            task_property_panel.Controls.Add(panel5);
            task_property_panel.Location = new Point(404, 15);
            task_property_panel.Name = "task_property_panel";
            task_property_panel.Size = new Size(361, 596);
            task_property_panel.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(252, 187, 109);
            panel4.Controls.Add(upcoming_task_lbl);
            panel4.Location = new Point(0, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(353, 48);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(252, 187, 109);
            panel5.Controls.Add(task_propeties_lbl);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(361, 48);
            panel5.TabIndex = 1;
            // 
            // task_propeties_lbl
            // 
            task_propeties_lbl.AutoSize = true;
            task_propeties_lbl.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            task_propeties_lbl.ForeColor = SystemColors.ButtonHighlight;
            task_propeties_lbl.Location = new Point(56, 16);
            task_propeties_lbl.Name = "task_propeties_lbl";
            task_propeties_lbl.Size = new Size(144, 20);
            task_propeties_lbl.TabIndex = 0;
            task_propeties_lbl.Text = "Task Properties";
            // 
            // upcoming_task_lbl
            // 
            upcoming_task_lbl.AutoSize = true;
            upcoming_task_lbl.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upcoming_task_lbl.ForeColor = SystemColors.ButtonHighlight;
            upcoming_task_lbl.Location = new Point(52, 17);
            upcoming_task_lbl.Name = "upcoming_task_lbl";
            upcoming_task_lbl.Size = new Size(126, 20);
            upcoming_task_lbl.TabIndex = 1;
            upcoming_task_lbl.Text = "Upcoming Task";
            // 
            // Greeting_lbl
            // 
            Greeting_lbl.AutoSize = true;
            Greeting_lbl.Location = new Point(16, 20);
            Greeting_lbl.Name = "Greeting_lbl";
            Greeting_lbl.Size = new Size(307, 21);
            Greeting_lbl.TabIndex = 0;
            Greeting_lbl.Text = "Good Morning/ Afternoon/ Evening'";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(3, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(350, 537);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1275, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            upcomingTask_panel.ResumeLayout(false);
            task_property_panel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label Title_lbl;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel task_property_panel;
        private Panel upcomingTask_panel;
        private Panel panel5;
        private Panel panel4;
        private Label task_propeties_lbl;
        private Label upcoming_task_lbl;
        private Label Greeting_lbl;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}