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
            panel1 = new Panel();
            taskcard_name_lbl = new Label();
            modify_taskcard_btn = new Button();
            due_lbl = new Label();
            taskDescription_lbl = new Label();
            taskDescription_txbx = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(104, 93, 121);
            panel1.Controls.Add(modify_taskcard_btn);
            panel1.Controls.Add(due_lbl);
            panel1.Controls.Add(taskcard_name_lbl);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 92);
            panel1.TabIndex = 0;
            // 
            // taskcard_name_lbl
            // 
            taskcard_name_lbl.AutoSize = true;
            taskcard_name_lbl.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskcard_name_lbl.ForeColor = SystemColors.ButtonHighlight;
            taskcard_name_lbl.Location = new Point(14, 17);
            taskcard_name_lbl.Name = "taskcard_name_lbl";
            taskcard_name_lbl.Size = new Size(56, 18);
            taskcard_name_lbl.TabIndex = 0;
            taskcard_name_lbl.Text = "label1";
            // 
            // modify_taskcard_btn
            // 
            modify_taskcard_btn.FlatAppearance.BorderSize = 0;
            modify_taskcard_btn.FlatStyle = FlatStyle.Flat;
            modify_taskcard_btn.Image = Properties.Resources.icons8_modify_24;
            modify_taskcard_btn.Location = new Point(279, 5);
            modify_taskcard_btn.Name = "modify_taskcard_btn";
            modify_taskcard_btn.Size = new Size(56, 45);
            modify_taskcard_btn.TabIndex = 1;
            modify_taskcard_btn.UseVisualStyleBackColor = true;
            modify_taskcard_btn.Click += modify_taskcard_btn_Click;
            // 
            // due_lbl
            // 
            due_lbl.AutoSize = true;
            due_lbl.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            due_lbl.ForeColor = SystemColors.ButtonHighlight;
            due_lbl.Location = new Point(14, 45);
            due_lbl.Name = "due_lbl";
            due_lbl.Size = new Size(48, 18);
            due_lbl.TabIndex = 2;
            due_lbl.Text = "Due: ";
            // 
            // taskDescription_lbl
            // 
            taskDescription_lbl.AutoSize = true;
            taskDescription_lbl.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            taskDescription_lbl.ForeColor = SystemColors.ButtonHighlight;
            taskDescription_lbl.Location = new Point(14, 95);
            taskDescription_lbl.Name = "taskDescription_lbl";
            taskDescription_lbl.Size = new Size(136, 18);
            taskDescription_lbl.TabIndex = 3;
            taskDescription_lbl.Text = "task description";
            // 
            // taskDescription_txbx
            // 
            taskDescription_txbx.BackColor = Color.FromArgb(104, 93, 121);
            taskDescription_txbx.BorderStyle = BorderStyle.None;
            taskDescription_txbx.ForeColor = SystemColors.HighlightText;
            taskDescription_txbx.Location = new Point(14, 116);
            taskDescription_txbx.Multiline = true;
            taskDescription_txbx.Name = "taskDescription_txbx";
            taskDescription_txbx.Size = new Size(307, 105);
            taskDescription_txbx.TabIndex = 4;
            // 
            // TaskCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 71, 92, 122);
            Controls.Add(taskDescription_txbx);
            Controls.Add(panel1);
            Controls.Add(taskDescription_lbl);
            Name = "TaskCards";
            Size = new Size(338, 234);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button modify_taskcard_btn;
        private Label taskcard_name_lbl;
        private Label due_lbl;
        private Label taskDescription_lbl;
        private TextBox taskDescription_txbx;
    }
}
