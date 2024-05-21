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
            task_condition_panel = new Panel();
            pictureBox1 = new PictureBox();
            modify_taskcard_btn = new Button();
            due_lbl = new Label();
            taskcard_name_lbl = new Label();
            task_condition_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // task_condition_panel
            // 
            task_condition_panel.BackColor = Color.FromArgb(104, 93, 121);
            task_condition_panel.Controls.Add(pictureBox1);
            task_condition_panel.Controls.Add(modify_taskcard_btn);
            task_condition_panel.Controls.Add(due_lbl);
            task_condition_panel.Controls.Add(taskcard_name_lbl);
            task_condition_panel.Location = new Point(0, 0);
            task_condition_panel.Margin = new Padding(3, 4, 3, 4);
            task_condition_panel.Name = "task_condition_panel";
            task_condition_panel.Size = new Size(386, 123);
            task_condition_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(252, 187, 109);
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 33);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // modify_taskcard_btn
            // 
            modify_taskcard_btn.FlatAppearance.BorderSize = 0;
            modify_taskcard_btn.FlatStyle = FlatStyle.Flat;
            modify_taskcard_btn.Image = Properties.Resources.icons8_modify_24;
            modify_taskcard_btn.Location = new Point(322, 48);
            modify_taskcard_btn.Margin = new Padding(3, 4, 3, 4);
            modify_taskcard_btn.Name = "modify_taskcard_btn";
            modify_taskcard_btn.Size = new Size(64, 60);
            modify_taskcard_btn.TabIndex = 1;
            modify_taskcard_btn.UseVisualStyleBackColor = true;
            modify_taskcard_btn.Click += modify_taskcard_btn_Click;
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
            // 
            // TaskCards
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(71, 92, 122);
            Controls.Add(task_condition_panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TaskCards";
            Size = new Size(386, 150);
            task_condition_panel.ResumeLayout(false);
            task_condition_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel task_condition_panel;
        private Button modify_taskcard_btn;
        private Label taskcard_name_lbl;
        private Label due_lbl;
        private PictureBox pictureBox1;
    }
}
