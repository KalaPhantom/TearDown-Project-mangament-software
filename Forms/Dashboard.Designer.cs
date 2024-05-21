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
            Panel sp_panel_1;
            db_panel = new Panel();
            Greeting_lbl = new Label();
            Title_lbl = new Label();
            pictureBox1 = new PictureBox();
            upcomingTask_panel = new Panel();
            properties_label = new Label();
            upcoming_task_db_fLp = new FlowLayoutPanel();
            panel4 = new Panel();
            upcoming_task_lbl = new Label();
            splitContainer1 = new SplitContainer();
            dashc_board_panel = new Panel();
            sp_panel_1 = new Panel();
            sp_panel_1.SuspendLayout();
            db_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upcomingTask_panel.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // sp_panel_1
            // 
            sp_panel_1.BackColor = Color.FromArgb(90, 30, 92, 122);
            sp_panel_1.BorderStyle = BorderStyle.FixedSingle;
            sp_panel_1.Controls.Add(db_panel);
            sp_panel_1.Controls.Add(Title_lbl);
            sp_panel_1.Controls.Add(pictureBox1);
            sp_panel_1.Dock = DockStyle.Fill;
            sp_panel_1.Location = new Point(0, 0);
            sp_panel_1.Name = "sp_panel_1";
            sp_panel_1.Size = new Size(425, 623);
            sp_panel_1.TabIndex = 0;
            // 
            // db_panel
            // 
            db_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            db_panel.AutoSize = true;
            db_panel.BackColor = Color.FromArgb(90, 30, 92, 122);
            db_panel.Controls.Add(Greeting_lbl);
            db_panel.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            db_panel.ForeColor = Color.FromArgb(252, 187, 109);
            db_panel.Location = new Point(-1, 129);
            db_panel.Name = "db_panel";
            db_panel.Size = new Size(423, 756);
            db_panel.TabIndex = 2;
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
            // Title_lbl
            // 
            Title_lbl.AutoSize = true;
            Title_lbl.BackColor = Color.Transparent;
            Title_lbl.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Title_lbl.Location = new Point(127, 30);
            Title_lbl.Name = "Title_lbl";
            Title_lbl.Size = new Size(171, 43);
            Title_lbl.TabIndex = 1;
            Title_lbl.Text = "Teardown";
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
            // upcomingTask_panel
            // 
            upcomingTask_panel.AutoSize = true;
            upcomingTask_panel.BackColor = Color.FromArgb(71, 92, 122);
            upcomingTask_panel.Controls.Add(dashc_board_panel);
            upcomingTask_panel.Controls.Add(properties_label);
            upcomingTask_panel.Controls.Add(upcoming_task_db_fLp);
            upcomingTask_panel.Controls.Add(panel4);
            upcomingTask_panel.Dock = DockStyle.Fill;
            upcomingTask_panel.Location = new Point(0, 0);
            upcomingTask_panel.Name = "upcomingTask_panel";
            upcomingTask_panel.Size = new Size(846, 623);
            upcomingTask_panel.TabIndex = 0;
            upcomingTask_panel.Paint += upcomingTask_panel_Paint;
            // 
            // properties_label
            // 
            properties_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            properties_label.AutoSize = true;
            properties_label.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            properties_label.ForeColor = SystemColors.ButtonHighlight;
            properties_label.Location = new Point(570, 13);
            properties_label.Name = "properties_label";
            properties_label.Size = new Size(99, 20);
            properties_label.TabIndex = 2;
            properties_label.Text = "Properties";
            // 
            // upcoming_task_db_fLp
            // 
            upcoming_task_db_fLp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            upcoming_task_db_fLp.AutoSize = true;
            upcoming_task_db_fLp.BackColor = Color.FromArgb(200, 252, 187, 109);
            upcoming_task_db_fLp.Location = new Point(3, 54);
            upcoming_task_db_fLp.Name = "upcoming_task_db_fLp";
            upcoming_task_db_fLp.Size = new Size(373, 562);
            upcoming_task_db_fLp.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(252, 187, 109);
            panel4.Controls.Add(upcoming_task_lbl);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 48);
            panel4.TabIndex = 0;
            // 
            // upcoming_task_lbl
            // 
            upcoming_task_lbl.AutoSize = true;
            upcoming_task_lbl.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upcoming_task_lbl.ForeColor = SystemColors.ButtonHighlight;
            upcoming_task_lbl.Location = new Point(16, 16);
            upcoming_task_lbl.Name = "upcoming_task_lbl";
            upcoming_task_lbl.Size = new Size(126, 20);
            upcoming_task_lbl.TabIndex = 1;
            upcoming_task_lbl.Text = "Upcoming Task";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(sp_panel_1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(upcomingTask_panel);
            splitContainer1.Size = new Size(1275, 623);
            splitContainer1.SplitterDistance = 425;
            splitContainer1.TabIndex = 2;
            // 
            // dashc_board_panel
            // 
            dashc_board_panel.BackColor = Color.FromArgb(71, 92, 130);
            dashc_board_panel.Location = new Point(398, 57);
            dashc_board_panel.Name = "dashc_board_panel";
            dashc_board_panel.Size = new Size(436, 530);
            dashc_board_panel.TabIndex = 3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1275, 623);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            sp_panel_1.ResumeLayout(false);
            sp_panel_1.PerformLayout();
            db_panel.ResumeLayout(false);
            db_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upcomingTask_panel.ResumeLayout(false);
            upcomingTask_panel.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sp_panel_1;
        private Label Title_lbl;
        private PictureBox pictureBox1;
        private Panel db_panel;
        private Panel upcomingTask_panel;
        private Panel panel4;
        private Label upcoming_task_lbl;
        private Label Greeting_lbl;
        private FlowLayoutPanel upcoming_task_db_fLp;
        private Label properties_label;
        private SplitContainer splitContainer1;
        private Panel dashc_board_panel;
    }
}