namespace TearDown_Project_mangament_software
{
    partial class Main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            main_panel = new Panel();
            panel1 = new Panel();
            Main_panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel2 = new Panel();
            Kanban_list_btn = new Button();
            statusStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.AutoSize = true;
            main_panel.BackColor = Color.FromArgb(24, 0, 0);
            main_panel.Dock = DockStyle.Bottom;
            main_panel.Location = new Point(0, 635);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1369, 0);
            main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 225, 198);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1369, 25);
            panel1.TabIndex = 1;
            // 
            // Main_panel2
            // 
            Main_panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main_panel2.BackColor = Color.FromArgb(4, 34, 34);
            Main_panel2.Location = new Point(99, 22);
            Main_panel2.Name = "Main_panel2";
            Main_panel2.Size = new Size(1270, 601);
            Main_panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(0, 99, 100);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 613);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1369, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 208, 211);
            panel2.Controls.Add(Kanban_list_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(105, 588);
            panel2.TabIndex = 0;
            // 
            // Kanban_list_btn
            // 
            Kanban_list_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Kanban_list_btn.AutoSize = true;
            Kanban_list_btn.Location = new Point(12, 119);
            Kanban_list_btn.Name = "Kanban_list_btn";
            Kanban_list_btn.Size = new Size(75, 65);
            Kanban_list_btn.TabIndex = 0;
            Kanban_list_btn.Text = "kanban list";
            Kanban_list_btn.UseVisualStyleBackColor = true;
            Kanban_list_btn.Click += Kanban_list_btn_Click;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 635);
            Controls.Add(panel2);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(main_panel);
            Controls.Add(Main_panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_form";
            Text = "Tear Down";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel main_panel;
        private Panel panel1;
        private Panel Main_panel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel2;
        private Button Kanban_list_btn;
    }
}
