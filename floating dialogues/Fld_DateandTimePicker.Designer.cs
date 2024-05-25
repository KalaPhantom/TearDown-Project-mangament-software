namespace TearDown_Project_mangament_software.floating_dialogues
{
    partial class Fld_DateandTimePicker
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            monthCalendar1 = new MonthCalendar();
            date_display = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(300, 45);
            label1.TabIndex = 0;
            label1.Text = "Date and Time ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 187, 109);
            label2.Location = new Point(22, 100);
            label2.Name = "label2";
            label2.Size = new Size(300, 22);
            label2.TabIndex = 1;
            label2.Text = "Current Deadline . . . . . . ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(252, 187, 109);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(546, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(22, 160);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // date_display
            // 
            date_display.AutoSize = true;
            date_display.Font = new Font("Cascadia Code", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_display.ForeColor = Color.FromArgb(252, 187, 109);
            date_display.Location = new Point(22, 122);
            date_display.Name = "date_display";
            date_display.Size = new Size(54, 24);
            date_display.TabIndex = 5;
            date_display.Text = "null";
            date_display.Click += date_display_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(252, 187, 109);
            button1.Location = new Point(296, 160);
            button1.Name = "button1";
            button1.Size = new Size(238, 246);
            button1.TabIndex = 6;
            button1.Text = "Save Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(22, 379);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(262, 27);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Fld_DateandTimePicker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(546, 447);
            Controls.Add(button1);
            Controls.Add(date_display);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthCalendar1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Fld_DateandTimePicker";
            Text = "Fld_DateandTimePicker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private MonthCalendar monthCalendar1;
        private Label date_display;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}