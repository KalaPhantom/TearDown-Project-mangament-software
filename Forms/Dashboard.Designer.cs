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
            components = new System.ComponentModel.Container();
            Panel sp_panel_1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            missed_Counter_lbl = new Label();
            upcoming_Counter_lbl = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            Title_lbl = new Label();
            Greeting_lbl = new Label();
            pictureBox1 = new PictureBox();
            upcomingTask_panel = new Panel();
            dashc_board_panel = new Panel();
            Description_box = new TextBox();
            properties_label = new Label();
            upcoming_task_db_fLp = new FlowLayoutPanel();
            dashboard_flp = new FlowLayoutPanel();
            panel4 = new Panel();
            button1 = new Button();
            upcoming_task_lbl = new Label();
            splitContainer1 = new SplitContainer();
            Timer_update_1 = new System.Windows.Forms.Timer(components);
            timer_populate_flp = new System.Windows.Forms.Timer(components);
            UpdateElelements_in_bg = new System.ComponentModel.BackgroundWorker();
            notifyIcon = new NotifyIcon(components);
            sp_panel_1 = new Panel();
            sp_panel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            upcomingTask_panel.SuspendLayout();
            dashc_board_panel.SuspendLayout();
            upcoming_task_db_fLp.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // sp_panel_1
            // 
            sp_panel_1.BackColor = Color.FromArgb(104, 93, 121);
            sp_panel_1.BorderStyle = BorderStyle.FixedSingle;
            sp_panel_1.Controls.Add(missed_Counter_lbl);
            sp_panel_1.Controls.Add(upcoming_Counter_lbl);
            sp_panel_1.Controls.Add(label5);
            sp_panel_1.Controls.Add(label4);
            sp_panel_1.Controls.Add(label3);
            sp_panel_1.Controls.Add(label1);
            sp_panel_1.Controls.Add(Title_lbl);
            sp_panel_1.Controls.Add(Greeting_lbl);
            sp_panel_1.Controls.Add(pictureBox1);
            sp_panel_1.Dock = DockStyle.Fill;
            sp_panel_1.Location = new Point(0, 0);
            sp_panel_1.Margin = new Padding(3, 4, 3, 4);
            sp_panel_1.Name = "sp_panel_1";
            sp_panel_1.Size = new Size(485, 831);
            sp_panel_1.TabIndex = 0;
            // 
            // missed_Counter_lbl
            // 
            missed_Counter_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            missed_Counter_lbl.AutoSize = true;
            missed_Counter_lbl.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            missed_Counter_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            missed_Counter_lbl.Location = new Point(192, 607);
            missed_Counter_lbl.Name = "missed_Counter_lbl";
            missed_Counter_lbl.Size = new Size(69, 79);
            missed_Counter_lbl.TabIndex = 6;
            missed_Counter_lbl.Text = "0";
            missed_Counter_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // upcoming_Counter_lbl
            // 
            upcoming_Counter_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            upcoming_Counter_lbl.AutoSize = true;
            upcoming_Counter_lbl.Font = new Font("Cascadia Code", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upcoming_Counter_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            upcoming_Counter_lbl.Location = new Point(192, 385);
            upcoming_Counter_lbl.Name = "upcoming_Counter_lbl";
            upcoming_Counter_lbl.Size = new Size(69, 79);
            upcoming_Counter_lbl.TabIndex = 5;
            upcoming_Counter_lbl.Text = "0";
            upcoming_Counter_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(252, 187, 109);
            label5.Location = new Point(177, 686);
            label5.Name = "label5";
            label5.Size = new Size(84, 27);
            label5.TabIndex = 4;
            label5.Text = "Missed";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(252, 187, 109);
            label4.Location = new Point(168, 475);
            label4.Name = "label4";
            label4.Size = new Size(108, 27);
            label4.TabIndex = 3;
            label4.Text = "Upcoming";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(252, 187, 109);
            label3.Location = new Point(157, 92);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 0;
            label3.Text = "Version 0.1 Beta";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(134, 255);
            label1.Name = "label1";
            label1.Size = new Size(208, 60);
            label1.TabIndex = 1;
            label1.Text = "Your Total Task\r\nToday";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Title_lbl
            // 
            Title_lbl.AutoSize = true;
            Title_lbl.BackColor = Color.Transparent;
            Title_lbl.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Title_lbl.Location = new Point(145, 40);
            Title_lbl.Name = "Title_lbl";
            Title_lbl.Size = new Size(206, 52);
            Title_lbl.TabIndex = 1;
            Title_lbl.Text = "Teardown";
            // 
            // Greeting_lbl
            // 
            Greeting_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Greeting_lbl.AutoSize = true;
            Greeting_lbl.BackColor = Color.Transparent;
            Greeting_lbl.Font = new Font("Cascadia Code SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Greeting_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Greeting_lbl.Location = new Point(45, 197);
            Greeting_lbl.Name = "Greeting_lbl";
            Greeting_lbl.Size = new Size(408, 27);
            Greeting_lbl.TabIndex = 0;
            Greeting_lbl.Text = "Good Morning/ Afternoon/ Evening'";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.icons8_bullseye_100_2;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 148);
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
            upcomingTask_panel.Margin = new Padding(3, 4, 3, 4);
            upcomingTask_panel.Name = "upcomingTask_panel";
            upcomingTask_panel.Size = new Size(967, 831);
            upcomingTask_panel.TabIndex = 0;
            upcomingTask_panel.Paint += upcomingTask_panel_Paint;
            // 
            // dashc_board_panel
            // 
            dashc_board_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashc_board_panel.BackColor = Color.FromArgb(71, 92, 130);
            dashc_board_panel.Controls.Add(Description_box);
            dashc_board_panel.Location = new Point(524, 76);
            dashc_board_panel.Margin = new Padding(3, 4, 3, 4);
            dashc_board_panel.Name = "dashc_board_panel";
            dashc_board_panel.Size = new Size(429, 742);
            dashc_board_panel.TabIndex = 3;
            // 
            // Description_box
            // 
            Description_box.BackColor = Color.MidnightBlue;
            Description_box.Dock = DockStyle.Fill;
            Description_box.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Description_box.ForeColor = Color.FromArgb(200, 252, 187, 109);
            Description_box.Location = new Point(0, 0);
            Description_box.Multiline = true;
            Description_box.Name = "Description_box";
            Description_box.ReadOnly = true;
            Description_box.Size = new Size(429, 742);
            Description_box.TabIndex = 1;
            Description_box.TextAlign = HorizontalAlignment.Center;
            // 
            // properties_label
            // 
            properties_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            properties_label.AutoSize = true;
            properties_label.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            properties_label.ForeColor = SystemColors.ButtonHighlight;
            properties_label.Location = new Point(675, 21);
            properties_label.Name = "properties_label";
            properties_label.Size = new Size(131, 24);
            properties_label.TabIndex = 2;
            properties_label.Text = "Description";
            // 
            // upcoming_task_db_fLp
            // 
            upcoming_task_db_fLp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            upcoming_task_db_fLp.AutoScroll = true;
            upcoming_task_db_fLp.AutoSize = true;
            upcoming_task_db_fLp.BackColor = Color.FromArgb(200, 252, 187, 109);
            upcoming_task_db_fLp.Controls.Add(dashboard_flp);
            upcoming_task_db_fLp.FlowDirection = FlowDirection.TopDown;
            upcoming_task_db_fLp.Location = new Point(0, 64);
            upcoming_task_db_fLp.Margin = new Padding(3, 4, 3, 4);
            upcoming_task_db_fLp.Name = "upcoming_task_db_fLp";
            upcoming_task_db_fLp.Size = new Size(518, 767);
            upcoming_task_db_fLp.TabIndex = 1;
            upcoming_task_db_fLp.WrapContents = false;
            // 
            // dashboard_flp
            // 
            dashboard_flp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboard_flp.AutoSize = true;
            dashboard_flp.FlowDirection = FlowDirection.TopDown;
            dashboard_flp.Location = new Point(3, 3);
            dashboard_flp.Name = "dashboard_flp";
            dashboard_flp.Size = new Size(0, 0);
            dashboard_flp.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.FromArgb(252, 187, 109);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(upcoming_task_lbl);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(518, 64);
            panel4.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(409, 21);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // upcoming_task_lbl
            // 
            upcoming_task_lbl.AutoSize = true;
            upcoming_task_lbl.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            upcoming_task_lbl.ForeColor = SystemColors.ButtonHighlight;
            upcoming_task_lbl.Location = new Point(18, 21);
            upcoming_task_lbl.Name = "upcoming_task_lbl";
            upcoming_task_lbl.Size = new Size(219, 24);
            upcoming_task_lbl.TabIndex = 1;
            upcoming_task_lbl.Text = "Upcoming Task Today";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(sp_panel_1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(upcomingTask_panel);
            splitContainer1.Size = new Size(1457, 831);
            splitContainer1.SplitterDistance = 485;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // Timer_update_1
            // 
            Timer_update_1.Interval = 1000;
            Timer_update_1.Tick += Timer_update_1_Tick;
            // 
            // timer_populate_flp
            // 
            timer_populate_flp.Enabled = true;
            timer_populate_flp.Interval = 4000000;
            timer_populate_flp.Tick += timer_populate_flp_Tick;
            // 
            // UpdateElelements_in_bg
            // 
            UpdateElelements_in_bg.DoWork += UpdateElelements_in_bg_DoWork;
            UpdateElelements_in_bg.RunWorkerCompleted += UpdateElelements_in_bg_RunWorkerCompleted;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "Task Reminder";
            notifyIcon.Visible = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 122);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1457, 831);
            Controls.Add(splitContainer1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            sp_panel_1.ResumeLayout(false);
            sp_panel_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            upcomingTask_panel.ResumeLayout(false);
            upcomingTask_panel.PerformLayout();
            dashc_board_panel.ResumeLayout(false);
            dashc_board_panel.PerformLayout();
            upcoming_task_db_fLp.ResumeLayout(false);
            upcoming_task_db_fLp.PerformLayout();
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
        private Panel upcomingTask_panel;
        private Panel panel4;
        private Label upcoming_task_lbl;
        private Label Greeting_lbl;
        private Label properties_label;
        private SplitContainer splitContainer1;
        private Panel dashc_board_panel;
        private Label label1;
        private FlowLayoutPanel dashboard_flp;
        private Label label3;
        private System.Windows.Forms.Timer Timer_update_1;
        private Label upcoming_Counter_lbl;
        private Label label5;
        private Label label4;
        private Label missed_Counter_lbl;
        private System.Windows.Forms.Timer timer_populate_flp;
        public  System.ComponentModel.BackgroundWorker UpdateElelements_in_bg;
        private Button button1;
        private FlowLayoutPanel upcoming_task_db_fLp;
        private NotifyIcon notifyIcon;
        //
        public static TextBox Description_box;
    }
}