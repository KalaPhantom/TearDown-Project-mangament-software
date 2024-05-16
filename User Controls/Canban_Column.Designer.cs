namespace TearDown_Project_mangament_software.User_Controls
{
    partial class Canban_Column
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
            Task_name_label = new Label();
            panel1 = new Panel();
            add_task_btn = new Button();
            modify_column_btn = new Button();
            taskCards_flowlayoutPanel = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Task_name_label
            // 
            Task_name_label.AutoSize = true;
            Task_name_label.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Task_name_label.ForeColor = SystemColors.ButtonFace;
            Task_name_label.Location = new Point(16, 17);
            Task_name_label.Name = "Task_name_label";
            Task_name_label.Size = new Size(217, 21);
            Task_name_label.TabIndex = 0;
            Task_name_label.Text = "Tap to Modify the Name \r\n";
            Task_name_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 187, 109);
            panel1.Controls.Add(add_task_btn);
            panel1.Controls.Add(modify_column_btn);
            panel1.Controls.Add(Task_name_label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 87);
            panel1.TabIndex = 1;
            // 
            // add_task_btn
            // 
            add_task_btn.FlatAppearance.BorderSize = 0;
            add_task_btn.FlatStyle = FlatStyle.Flat;
            add_task_btn.ForeColor = SystemColors.ButtonFace;
            add_task_btn.Image = Properties.Resources.icons8_add_24;
            add_task_btn.Location = new Point(16, 41);
            add_task_btn.Name = "add_task_btn";
            add_task_btn.Size = new Size(88, 45);
            add_task_btn.TabIndex = 2;
            add_task_btn.Text = "Add Task";
            add_task_btn.TextAlign = ContentAlignment.MiddleRight;
            add_task_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_task_btn.UseVisualStyleBackColor = true;
            add_task_btn.Click += add_task_btn_Click;
            // 
            // modify_column_btn
            // 
            modify_column_btn.FlatAppearance.BorderSize = 0;
            modify_column_btn.FlatStyle = FlatStyle.Flat;
            modify_column_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modify_column_btn.ForeColor = SystemColors.ButtonHighlight;
            modify_column_btn.Image = Properties.Resources.icons8_modify_24;
            modify_column_btn.Location = new Point(264, 41);
            modify_column_btn.Name = "modify_column_btn";
            modify_column_btn.Size = new Size(123, 45);
            modify_column_btn.TabIndex = 1;
            modify_column_btn.Text = "Modify Column";
            modify_column_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_column_btn.UseVisualStyleBackColor = true;
            modify_column_btn.Click += modify_column_btn_Click;
            // 
            // taskCards_flowlayoutPanel
            // 
            taskCards_flowlayoutPanel.AutoScroll = true;
            taskCards_flowlayoutPanel.FlowDirection = FlowDirection.TopDown;
            taskCards_flowlayoutPanel.Location = new Point(3, 92);
            taskCards_flowlayoutPanel.Name = "taskCards_flowlayoutPanel";
            taskCards_flowlayoutPanel.Size = new Size(393, 571);
            taskCards_flowlayoutPanel.TabIndex = 2;
            taskCards_flowlayoutPanel.WrapContents = false;
            // 
            // Canban_Column
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 252, 187, 109);
            Controls.Add(taskCards_flowlayoutPanel);
            Controls.Add(panel1);
            Name = "Canban_Column";
            Size = new Size(399, 666);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label Task_name_label;
        private Panel panel1;
        private Button add_task_btn;
        private Button modify_column_btn;
        private FlowLayoutPanel taskCards_flowlayoutPanel;
    }
}
