namespace TearDown_Project_mangament_software.User_Controls
{
    partial class TaskCards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            task_condition_panel = new Panel();
            selection_indicator = new PictureBox();
            priority_icon_pb = new PictureBox();
            check_icon_pb = new PictureBox();
            Task_color = new PictureBox();
            due_lbl = new Label();
            taskcard_name_lbl = new Label();
            changeName_btn = new Button();
            modify_taskcard_btn = new Button();
            set_as_btn = new Button();
            color_atb_pb = new PictureBox();
            task_atr_timer = new System.Windows.Forms.Timer(components);
            Alert_icon = new NotifyIcon(components);
            task_condition_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selection_indicator).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priority_icon_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)check_icon_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Task_color).BeginInit();
            ((System.ComponentModel.ISupportInitialize)color_atb_pb).BeginInit();
            SuspendLayout();
            // 
            // task_condition_panel
            // 
            task_condition_panel.BackColor = Color.FromArgb(104, 93, 121);
            task_condition_panel.Controls.Add(selection_indicator);
            task_condition_panel.Controls.Add(priority_icon_pb);
            task_condition_panel.Controls.Add(check_icon_pb);
            task_condition_panel.Controls.Add(Task_color);
            task_condition_panel.Controls.Add(due_lbl);
            task_condition_panel.Controls.Add(taskcard_name_lbl);
            task_condition_panel.Location = new Point(0, 0);
            task_condition_panel.Margin = new Padding(3, 4, 3, 4);
            task_condition_panel.Name = "task_condition_panel";
            task_condition_panel.Size = new Size(386, 123);
            task_condition_panel.TabIndex = 0;
            task_condition_panel.Click += task_condition_panel_Click;
            task_condition_panel.Leave += task_condition_panel_Leave;
            task_condition_panel.MouseDown += task_condition_panel_MouseDown;
            // 
            // selection_indicator
            // 
            selection_indicator.BackColor = Color.White;
            selection_indicator.Location = new Point(0, 0);
            selection_indicator.Name = "selection_indicator";
            selection_indicator.Size = new Size(244, 10);
            selection_indicator.TabIndex = 7;
            selection_indicator.TabStop = false;
            selection_indicator.Visible = false;
            // 
            // priority_icon_pb
            // 
            priority_icon_pb.BackColor = Color.FromArgb(252, 187, 109);
            priority_icon_pb.BackgroundImageLayout = ImageLayout.Center;
            priority_icon_pb.Image = Properties.Resources.icons8_star_24;
            priority_icon_pb.Location = new Point(316, 0);
            priority_icon_pb.Name = "priority_icon_pb";
            priority_icon_pb.Size = new Size(32, 30);
            priority_icon_pb.TabIndex = 6;
            priority_icon_pb.TabStop = false;
            priority_icon_pb.Visible = false;
            // 
            // check_icon_pb
            // 
            check_icon_pb.BackColor = Color.FromArgb(252, 187, 109);
            check_icon_pb.Image = Properties.Resources.icons8_check_241;
            check_icon_pb.Location = new Point(354, 3);
            check_icon_pb.Name = "check_icon_pb";
            check_icon_pb.Size = new Size(29, 30);
            check_icon_pb.TabIndex = 5;
            check_icon_pb.TabStop = false;
            check_icon_pb.Visible = false;
            // 
            // Task_color
            // 
            Task_color.BackColor = Color.FromArgb(252, 187, 109);
            Task_color.Dock = DockStyle.Top;
            Task_color.Location = new Point(0, 0);
            Task_color.Margin = new Padding(3, 4, 3, 4);
            Task_color.Name = "Task_color";
            Task_color.Size = new Size(386, 33);
            Task_color.TabIndex = 4;
            Task_color.TabStop = false;
            Task_color.MouseDown += Task_color_MouseDown;
            // 
            // due_lbl
            // 
            due_lbl.AutoSize = true;
            due_lbl.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            due_lbl.ForeColor = SystemColors.ButtonHighlight;
            due_lbl.Location = new Point(8, 86);
            due_lbl.Name = "due_lbl";
            due_lbl.Size = new Size(60, 22);
            due_lbl.TabIndex = 2;
            due_lbl.Text = "Due: ";
            // 
            // taskcard_name_lbl
            // 
            taskcard_name_lbl.AutoSize = true;
            taskcard_name_lbl.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskcard_name_lbl.ForeColor = SystemColors.ButtonHighlight;
            taskcard_name_lbl.Location = new Point(8, 48);
            taskcard_name_lbl.Name = "taskcard_name_lbl";
            taskcard_name_lbl.Size = new Size(180, 22);
            taskcard_name_lbl.TabIndex = 0;
            taskcard_name_lbl.Text = "click to add name";
            taskcard_name_lbl.Click += taskcard_name_lbl_Click;
            taskcard_name_lbl.MouseDown += taskcard_name_lbl_MouseDown;
            // 
            // changeName_btn
            // 
            changeName_btn.FlatAppearance.BorderSize = 0;
            changeName_btn.FlatStyle = FlatStyle.Flat;
            changeName_btn.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            changeName_btn.ForeColor = Color.FromArgb(252, 187, 109);
            changeName_btn.Location = new Point(126, 128);
            changeName_btn.Margin = new Padding(3, 4, 3, 4);
            changeName_btn.Name = "changeName_btn";
            changeName_btn.Size = new Size(107, 31);
            changeName_btn.TabIndex = 6;
            changeName_btn.Text = "Edit Name";
            changeName_btn.UseVisualStyleBackColor = true;
            changeName_btn.Click += changeName_btn_Click;
            // 
            // modify_taskcard_btn
            // 
            modify_taskcard_btn.FlatAppearance.BorderSize = 0;
            modify_taskcard_btn.FlatStyle = FlatStyle.Flat;
            modify_taskcard_btn.Image = Properties.Resources.icons8_modify_24;
            modify_taskcard_btn.Location = new Point(74, 121);
            modify_taskcard_btn.Margin = new Padding(3, 4, 3, 4);
            modify_taskcard_btn.Name = "modify_taskcard_btn";
            modify_taskcard_btn.Size = new Size(64, 37);
            modify_taskcard_btn.TabIndex = 1;
            modify_taskcard_btn.UseVisualStyleBackColor = true;
            modify_taskcard_btn.Click += modify_taskcard_btn_Click;
            // 
            // set_as_btn
            // 
            set_as_btn.FlatAppearance.BorderSize = 0;
            set_as_btn.FlatStyle = FlatStyle.Flat;
            set_as_btn.Image = Properties.Resources.icons8_compass_eye_24;
            set_as_btn.Location = new Point(4, 121);
            set_as_btn.Margin = new Padding(3, 4, 3, 4);
            set_as_btn.Name = "set_as_btn";
            set_as_btn.Size = new Size(64, 38);
            set_as_btn.TabIndex = 5;
            set_as_btn.UseVisualStyleBackColor = true;
            set_as_btn.Click += set_as_btn_Click;
            // 
            // color_atb_pb
            // 
            color_atb_pb.Location = new Point(239, 144);
            color_atb_pb.Name = "color_atb_pb";
            color_atb_pb.Size = new Size(144, 13);
            color_atb_pb.TabIndex = 7;
            color_atb_pb.TabStop = false;
            // 
            // task_atr_timer
            // 
            task_atr_timer.Interval = 1000;
            task_atr_timer.Tick += task_atr_timer_Tick;
            // 
            // Alert_icon
            // 
            Alert_icon.Text = "notifyIcon1";
            Alert_icon.Visible = true;
            // 
            // TaskCards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(71, 92, 122);
            Controls.Add(color_atb_pb);
            Controls.Add(task_condition_panel);
            Controls.Add(set_as_btn);
            Controls.Add(modify_taskcard_btn);
            Controls.Add(changeName_btn);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskCards";
            Size = new Size(386, 157);
            Load += TaskCards_Load;
            Enter += TaskCards_Enter;
            Leave += TaskCards_Leave;
            MouseDown += TaskCards_MouseDown;
            Validated += TaskCards_Validated;
            task_condition_panel.ResumeLayout(false);
            task_condition_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selection_indicator).EndInit();
            ((System.ComponentModel.ISupportInitialize)priority_icon_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)check_icon_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Task_color).EndInit();
            ((System.ComponentModel.ISupportInitialize)color_atb_pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel task_condition_panel;
        private Button modify_taskcard_btn;
        private Label taskcard_name_lbl;
        private Label due_lbl;
        private PictureBox Task_color;
        private Button set_as_btn;
        private Button changeName_btn;
        private System.Windows.Forms.Timer task_atr_timer;
        private NotifyIcon Alert_icon;
        public PictureBox color_atb_pb;
        private PictureBox priority_icon_pb;
        private PictureBox check_icon_pb;
        private PictureBox selection_indicator;
    }
}
