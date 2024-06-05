namespace TearDown_Project_mangament_software.Setting_Form
{
    partial class Reminder_settngs
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
            groupBox1 = new GroupBox();
            rdb_5hr = new RadioButton();
            rdb_1hr = new RadioButton();
            rdb_2hr = new RadioButton();
            rdb_3hr = new RadioButton();
            rdb_4hr = new RadioButton();
            rdb_30_min = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(289, 37);
            label1.TabIndex = 2;
            label1.Text = "Reminder Settings";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 187, 109);
            label2.Location = new Point(25, 104);
            label2.Name = "label2";
            label2.Size = new Size(276, 27);
            label2.TabIndex = 3;
            label2.Text = "Remind me Every . . . ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_5hr);
            groupBox1.Controls.Add(rdb_1hr);
            groupBox1.Controls.Add(rdb_2hr);
            groupBox1.Controls.Add(rdb_3hr);
            groupBox1.Controls.Add(rdb_4hr);
            groupBox1.Controls.Add(rdb_30_min);
            groupBox1.Location = new Point(25, 148);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(630, 158);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // rdb_5hr
            // 
            rdb_5hr.AutoSize = true;
            rdb_5hr.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_5hr.ForeColor = Color.FromArgb(252, 187, 109);
            rdb_5hr.Location = new Point(323, 84);
            rdb_5hr.Name = "rdb_5hr";
            rdb_5hr.Size = new Size(105, 31);
            rdb_5hr.TabIndex = 5;
            rdb_5hr.TabStop = true;
            rdb_5hr.Text = "5 hour";
            rdb_5hr.UseVisualStyleBackColor = true;
            rdb_5hr.CheckedChanged += rdb_5hr_CheckedChanged;
            // 
            // rdb_1hr
            // 
            rdb_1hr.AutoSize = true;
            rdb_1hr.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_1hr.ForeColor = Color.FromArgb(252, 187, 109);
            rdb_1hr.Location = new Point(180, 38);
            rdb_1hr.Name = "rdb_1hr";
            rdb_1hr.Size = new Size(105, 31);
            rdb_1hr.TabIndex = 4;
            rdb_1hr.TabStop = true;
            rdb_1hr.Text = "1 hour";
            rdb_1hr.UseVisualStyleBackColor = true;
            rdb_1hr.CheckedChanged += rdb_1hr_CheckedChanged;
            // 
            // rdb_2hr
            // 
            rdb_2hr.AutoSize = true;
            rdb_2hr.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_2hr.ForeColor = Color.FromArgb(252, 187, 109);
            rdb_2hr.Location = new Point(317, 38);
            rdb_2hr.Name = "rdb_2hr";
            rdb_2hr.Size = new Size(117, 31);
            rdb_2hr.TabIndex = 3;
            rdb_2hr.TabStop = true;
            rdb_2hr.Text = "2 hour ";
            rdb_2hr.UseVisualStyleBackColor = true;
            rdb_2hr.CheckedChanged += rdb_2hr_CheckedChanged;
            // 
            // rdb_3hr
            // 
            rdb_3hr.AutoSize = true;
            rdb_3hr.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_3hr.ForeColor = Color.FromArgb(252, 187, 109);
            rdb_3hr.Location = new Point(464, 38);
            rdb_3hr.Name = "rdb_3hr";
            rdb_3hr.Size = new Size(105, 31);
            rdb_3hr.TabIndex = 2;
            rdb_3hr.TabStop = true;
            rdb_3hr.Text = "3 hour";
            rdb_3hr.UseVisualStyleBackColor = true;
            rdb_3hr.CheckedChanged += rdb_3hr_CheckedChanged;
            // 
            // rdb_4hr
            // 
            rdb_4hr.AutoSize = true;
            rdb_4hr.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_4hr.ForeColor = Color.FromArgb(252, 187, 109);
            rdb_4hr.Location = new Point(180, 84);
            rdb_4hr.Name = "rdb_4hr";
            rdb_4hr.Size = new Size(105, 31);
            rdb_4hr.TabIndex = 1;
            rdb_4hr.TabStop = true;
            rdb_4hr.Text = "4 hour";
            rdb_4hr.UseVisualStyleBackColor = true;
            rdb_4hr.CheckedChanged += rdb_4hr_CheckedChanged;
            // 
            // rdb_30_min
            // 
            rdb_30_min.AutoSize = true;
            rdb_30_min.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdb_30_min.ForeColor = Color.FromArgb(252, 187, 109);
            rdb_30_min.Location = new Point(37, 38);
            rdb_30_min.Name = "rdb_30_min";
            rdb_30_min.Size = new Size(105, 31);
            rdb_30_min.TabIndex = 0;
            rdb_30_min.TabStop = true;
            rdb_30_min.Text = "30 min";
            rdb_30_min.UseVisualStyleBackColor = true;
            rdb_30_min.CheckedChanged += rdb_30_min_CheckedChanged;
            // 
            // Reminder_settngs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(685, 486);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reminder_settngs";
            Text = "Reminder_settngs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdb_5hr;
        private RadioButton rdb_1hr;
        private RadioButton rdb_2hr;
        private RadioButton rdb_3hr;
        private RadioButton rdb_4hr;
        private RadioButton rdb_30_min;
    }
}