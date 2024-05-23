namespace TearDown_Project_mangament_software.floating_dialogues
{
    partial class TaskCard_modify_form
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Duedate_display_txt = new Label();
            groupBox1 = new GroupBox();
            add_description_btn = new Button();
            label4 = new Label();
            pick_due_btn = new Button();
            label5 = new Label();
            task_description_tbx = new TextBox();
            label6 = new Label();
            taskcard_color = new PictureBox();
            color8_btn = new Button();
            color7_btn = new Button();
            color6_btn = new Button();
            color5_btn = new Button();
            color4_btn = new Button();
            color3_btn = new Button();
            color2_btn = new Button();
            color1_btn = new Button();
            color_picker_btn = new Button();
            groupBox2 = new GroupBox();
            Save_info_btn = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)taskcard_color).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(252, 187, 109);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(708, 31);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 1;
            label1.Text = "Modify Task";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(280, 45);
            label2.TabIndex = 4;
            label2.Text = "DUE DATE . . ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 20);
            label3.Name = "label3";
            label3.Size = new Size(186, 24);
            label3.TabIndex = 5;
            label3.Text = "Current Due Date";
            // 
            // Duedate_display_txt
            // 
            Duedate_display_txt.AutoSize = true;
            Duedate_display_txt.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Duedate_display_txt.Location = new Point(6, 40);
            Duedate_display_txt.Name = "Duedate_display_txt";
            Duedate_display_txt.Size = new Size(52, 30);
            Duedate_display_txt.TabIndex = 6;
            Duedate_display_txt.Text = "Due";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Duedate_display_txt);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 117);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 92);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // add_description_btn
            // 
            add_description_btn.FlatAppearance.BorderColor = Color.FromArgb(252, 187, 109);
            add_description_btn.FlatStyle = FlatStyle.Flat;
            add_description_btn.Location = new Point(332, 453);
            add_description_btn.Name = "add_description_btn";
            add_description_btn.Size = new Size(325, 51);
            add_description_btn.TabIndex = 8;
            add_description_btn.Text = "Save task description";
            add_description_btn.UseVisualStyleBackColor = true;
            add_description_btn.Click += add_description_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(390, 97);
            label4.Name = "label4";
            label4.Size = new Size(175, 24);
            label4.TabIndex = 7;
            label4.Text = "Pick a due date";
            // 
            // pick_due_btn
            // 
            pick_due_btn.FlatAppearance.BorderColor = Color.FromArgb(252, 187, 109);
            pick_due_btn.FlatStyle = FlatStyle.Flat;
            pick_due_btn.Location = new Point(390, 124);
            pick_due_btn.Name = "pick_due_btn";
            pick_due_btn.Size = new Size(272, 85);
            pick_due_btn.TabIndex = 9;
            pick_due_btn.Text = " Set Date and Time ";
            pick_due_btn.UseVisualStyleBackColor = true;
            pick_due_btn.Click += pick_due_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 254);
            label5.Name = "label5";
            label5.Size = new Size(420, 45);
            label5.TabIndex = 10;
            label5.Text = "TASK DESCRIPTION. . ";
            // 
            // task_description_tbx
            // 
            task_description_tbx.Location = new Point(18, 302);
            task_description_tbx.Multiline = true;
            task_description_tbx.Name = "task_description_tbx";
            task_description_tbx.Size = new Size(639, 145);
            task_description_tbx.TabIndex = 11;
            task_description_tbx.TextChanged += task_description_tbx_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 526);
            label6.Name = "label6";
            label6.Size = new Size(320, 45);
            label6.TabIndex = 12;
            label6.Text = "TASK CARD COLOR";
            // 
            // taskcard_color
            // 
            taskcard_color.Location = new Point(18, 574);
            taskcard_color.Name = "taskcard_color";
            taskcard_color.Size = new Size(295, 289);
            taskcard_color.TabIndex = 14;
            taskcard_color.TabStop = false;
            // 
            // color8_btn
            // 
            color8_btn.BackColor = Color.FromArgb(48, 95, 114);
            color8_btn.FlatAppearance.BorderSize = 0;
            color8_btn.FlatStyle = FlatStyle.Flat;
            color8_btn.Location = new Point(192, 78);
            color8_btn.Name = "color8_btn";
            color8_btn.Size = new Size(67, 60);
            color8_btn.TabIndex = 22;
            color8_btn.UseVisualStyleBackColor = false;
            color8_btn.Click += color8_btn_Click;
            // 
            // color7_btn
            // 
            color7_btn.BackColor = Color.FromArgb(86, 142, 166);
            color7_btn.FlatAppearance.BorderSize = 0;
            color7_btn.FlatStyle = FlatStyle.Flat;
            color7_btn.Location = new Point(136, 78);
            color7_btn.Name = "color7_btn";
            color7_btn.Size = new Size(63, 60);
            color7_btn.TabIndex = 21;
            color7_btn.UseVisualStyleBackColor = false;
            color7_btn.Click += color7_btn_Click;
            // 
            // color6_btn
            // 
            color6_btn.BackColor = Color.FromArgb(240, 183, 164);
            color6_btn.FlatAppearance.BorderSize = 0;
            color6_btn.FlatStyle = FlatStyle.Flat;
            color6_btn.Location = new Point(71, 78);
            color6_btn.Name = "color6_btn";
            color6_btn.Size = new Size(67, 60);
            color6_btn.TabIndex = 20;
            color6_btn.UseVisualStyleBackColor = false;
            color6_btn.Click += color6_btn_Click;
            // 
            // color5_btn
            // 
            color5_btn.BackColor = Color.FromArgb(241, 140, 142);
            color5_btn.FlatAppearance.BorderSize = 0;
            color5_btn.FlatStyle = FlatStyle.Flat;
            color5_btn.Location = new Point(6, 78);
            color5_btn.Name = "color5_btn";
            color5_btn.Size = new Size(66, 60);
            color5_btn.TabIndex = 19;
            color5_btn.UseVisualStyleBackColor = false;
            color5_btn.Click += color5_btn_Click;
            // 
            // color4_btn
            // 
            color4_btn.BackColor = Color.FromArgb(71, 92, 122);
            color4_btn.FlatAppearance.BorderSize = 0;
            color4_btn.FlatStyle = FlatStyle.Flat;
            color4_btn.Location = new Point(201, 27);
            color4_btn.Name = "color4_btn";
            color4_btn.Size = new Size(78, 60);
            color4_btn.TabIndex = 18;
            color4_btn.UseVisualStyleBackColor = false;
            color4_btn.Click += color4_btn_Click;
            // 
            // color3_btn
            // 
            color3_btn.BackColor = Color.FromArgb(171, 108, 130);
            color3_btn.FlatAppearance.BorderSize = 0;
            color3_btn.FlatStyle = FlatStyle.Flat;
            color3_btn.Location = new Point(136, 27);
            color3_btn.Name = "color3_btn";
            color3_btn.Size = new Size(78, 60);
            color3_btn.TabIndex = 17;
            color3_btn.UseVisualStyleBackColor = false;
            color3_btn.Click += color3_btn_Click;
            // 
            // color2_btn
            // 
            color2_btn.BackColor = Color.FromArgb(216, 115, 127);
            color2_btn.FlatAppearance.BorderSize = 0;
            color2_btn.FlatStyle = FlatStyle.Flat;
            color2_btn.Location = new Point(71, 27);
            color2_btn.Name = "color2_btn";
            color2_btn.Size = new Size(92, 60);
            color2_btn.TabIndex = 16;
            color2_btn.UseVisualStyleBackColor = false;
            color2_btn.Click += color2_btn_Click;
            // 
            // color1_btn
            // 
            color1_btn.BackColor = Color.FromArgb(252, 187, 109);
            color1_btn.FlatStyle = FlatStyle.Flat;
            color1_btn.Location = new Point(6, 27);
            color1_btn.Name = "color1_btn";
            color1_btn.Size = new Size(92, 60);
            color1_btn.TabIndex = 15;
            color1_btn.UseVisualStyleBackColor = false;
            color1_btn.Click += color1_btn_Click;
            // 
            // color_picker_btn
            // 
            color_picker_btn.ForeColor = Color.Black;
            color_picker_btn.Location = new Point(319, 734);
            color_picker_btn.Name = "color_picker_btn";
            color_picker_btn.Size = new Size(285, 61);
            color_picker_btn.TabIndex = 23;
            color_picker_btn.Text = "Pick a Color";
            color_picker_btn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(color4_btn);
            groupBox2.Controls.Add(color3_btn);
            groupBox2.Controls.Add(color2_btn);
            groupBox2.Controls.Add(color1_btn);
            groupBox2.Controls.Add(color5_btn);
            groupBox2.Controls.Add(color6_btn);
            groupBox2.Controls.Add(color7_btn);
            groupBox2.Controls.Add(color8_btn);
            groupBox2.Location = new Point(319, 574);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 154);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Save_info_btn
            // 
            Save_info_btn.FlatAppearance.BorderColor = Color.FromArgb(252, 187, 109);
            Save_info_btn.FlatStyle = FlatStyle.Flat;
            Save_info_btn.Location = new Point(208, 899);
            Save_info_btn.Name = "Save_info_btn";
            Save_info_btn.Size = new Size(325, 51);
            Save_info_btn.TabIndex = 25;
            Save_info_btn.Text = "Save task description";
            Save_info_btn.UseVisualStyleBackColor = true;
            Save_info_btn.Click += Save_info_btn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 956);
            panel1.Name = "panel1";
            panel1.Size = new Size(707, 125);
            panel1.TabIndex = 26;
            // 
            // TaskCard_modify_form
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(71, 92, 122);
            ClientSize = new Size(729, 532);
            Controls.Add(Save_info_btn);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(color_picker_btn);
            Controls.Add(taskcard_color);
            Controls.Add(label6);
            Controls.Add(task_description_tbx);
            Controls.Add(label5);
            Controls.Add(pick_due_btn);
            Controls.Add(label4);
            Controls.Add(add_description_btn);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(252, 187, 109);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskCard_modify_form";
            Text = "TaskCard_modify_form";
            Load += TaskCard_modify_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)taskcard_color).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Duedate_display_txt;
        private GroupBox groupBox1;
        private Button add_description_btn;
        private Label label4;
        private Button pick_due_btn;
        private Label label5;
        private TextBox task_description_tbx;
        private Label label6;
        private PictureBox taskcard_color;
        private Button color8_btn;
        private Button color7_btn;
        private Button color6_btn;
        private Button color5_btn;
        private Button color4_btn;
        private Button color3_btn;
        private Button color2_btn;
        private Button color1_btn;
        private Button color_picker_btn;
        private GroupBox groupBox2;
        private Button Save_info_btn;
        private Panel panel1;
    }
}