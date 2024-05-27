namespace TearDown_Project_mangament_software.User_Controls
{
    partial class Canban_Column_2
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
            taskCards_flowlayoutPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            add_task_btn = new Button();
            modify_column_btn = new Button();
            Task_name_label = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // taskCards_flowlayoutPanel
            // 
            taskCards_flowlayoutPanel.AllowDrop = true;
            taskCards_flowlayoutPanel.AutoScroll = true;
            taskCards_flowlayoutPanel.FlowDirection = FlowDirection.TopDown;
            taskCards_flowlayoutPanel.Location = new Point(3, 123);
            taskCards_flowlayoutPanel.Margin = new Padding(3, 4, 3, 4);
            taskCards_flowlayoutPanel.Name = "taskCards_flowlayoutPanel";
            taskCards_flowlayoutPanel.Size = new Size(416, 763);
            taskCards_flowlayoutPanel.TabIndex = 4;
            taskCards_flowlayoutPanel.WrapContents = false;
            taskCards_flowlayoutPanel.DragDrop += taskCards_flowlayoutPanel_DragDrop;
            taskCards_flowlayoutPanel.DragEnter += taskCards_flowlayoutPanel_DragEnter;
            taskCards_flowlayoutPanel.MouseDown += taskCards_flowlayoutPanel_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 187, 109);
            panel1.Controls.Add(add_task_btn);
            panel1.Controls.Add(modify_column_btn);
            panel1.Controls.Add(Task_name_label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 115);
            panel1.TabIndex = 3;
            // 
            // add_task_btn
            // 
            add_task_btn.FlatAppearance.BorderSize = 0;
            add_task_btn.FlatStyle = FlatStyle.Flat;
            add_task_btn.ForeColor = SystemColors.ButtonFace;
            add_task_btn.Image = Properties.Resources.icons8_add_24;
            add_task_btn.Location = new Point(18, 51);
            add_task_btn.Margin = new Padding(3, 4, 3, 4);
            add_task_btn.Name = "add_task_btn";
            add_task_btn.Size = new Size(101, 60);
            add_task_btn.TabIndex = 2;
            add_task_btn.Text = "Add Task";
            add_task_btn.TextAlign = ContentAlignment.MiddleRight;
            add_task_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_task_btn.UseVisualStyleBackColor = true;
            add_task_btn.Click += add_task_btn_Click_1;
            // 
            // modify_column_btn
            // 
            modify_column_btn.FlatAppearance.BorderSize = 0;
            modify_column_btn.FlatStyle = FlatStyle.Flat;
            modify_column_btn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            modify_column_btn.ForeColor = SystemColors.ButtonHighlight;
            modify_column_btn.Image = Properties.Resources.icons8_modify_24;
            modify_column_btn.Location = new Point(269, 51);
            modify_column_btn.Margin = new Padding(3, 4, 3, 4);
            modify_column_btn.Name = "modify_column_btn";
            modify_column_btn.Size = new Size(153, 60);
            modify_column_btn.TabIndex = 1;
            modify_column_btn.Text = "Modify Column";
            modify_column_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            modify_column_btn.UseVisualStyleBackColor = true;
            modify_column_btn.Click += modify_column_btn_Click_1;
            // 
            // Task_name_label
            // 
            Task_name_label.AutoSize = true;
            Task_name_label.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Task_name_label.ForeColor = SystemColors.ButtonFace;
            Task_name_label.Location = new Point(18, 23);
            Task_name_label.Name = "Task_name_label";
            Task_name_label.Size = new Size(288, 27);
            Task_name_label.TabIndex = 0;
            Task_name_label.Text = "Tap to Modify the Name \r\n";
            Task_name_label.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Canban_Column_2
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(70, 252, 187, 109);
            Controls.Add(taskCards_flowlayoutPanel);
            Controls.Add(panel1);
            Name = "Canban_Column_2";
            Size = new Size(422, 888);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public static FlowLayoutPanel taskCards_flowlayoutPanel;
        private Panel panel1;
        private Button add_task_btn;
        private Button modify_column_btn;
        private Label Task_name_label;
    }
}
