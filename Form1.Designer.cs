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
            Main_panel2 = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel2 = new Panel();
            notes_btn = new Button();
            whiteboard_btn = new Button();
            dashboard_btn = new Button();
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
            // Main_panel2
            // 
            Main_panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main_panel2.BackColor = Color.FromArgb(71, 92, 122);
            Main_panel2.Location = new Point(94, 0);
            Main_panel2.Name = "Main_panel2";
            Main_panel2.Size = new Size(1275, 623);
            Main_panel2.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(104, 93, 121);
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
            panel2.BackColor = Color.FromArgb(252, 187, 109);
            panel2.Controls.Add(notes_btn);
            panel2.Controls.Add(whiteboard_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(Kanban_list_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(102, 613);
            panel2.TabIndex = 0;
            // 
            // notes_btn
            // 
            notes_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            notes_btn.BackgroundImage = Properties.Resources.icons8_notes_50;
            notes_btn.BackgroundImageLayout = ImageLayout.Center;
            notes_btn.FlatStyle = FlatStyle.Flat;
            notes_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notes_btn.ForeColor = SystemColors.ControlLightLight;
            notes_btn.Location = new Point(3, 503);
            notes_btn.Name = "notes_btn";
            notes_btn.Size = new Size(96, 91);
            notes_btn.TabIndex = 3;
            notes_btn.TextAlign = ContentAlignment.BottomCenter;
            notes_btn.UseVisualStyleBackColor = true;
            // 
            // whiteboard_btn
            // 
            whiteboard_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            whiteboard_btn.BackgroundImage = Properties.Resources.icons8_whiteboard_50__2_;
            whiteboard_btn.BackgroundImageLayout = ImageLayout.Center;
            whiteboard_btn.FlatStyle = FlatStyle.Flat;
            whiteboard_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            whiteboard_btn.ForeColor = SystemColors.ControlLightLight;
            whiteboard_btn.Location = new Point(3, 413);
            whiteboard_btn.Name = "whiteboard_btn";
            whiteboard_btn.Size = new Size(96, 84);
            whiteboard_btn.TabIndex = 2;
            whiteboard_btn.TextAlign = ContentAlignment.BottomCenter;
            whiteboard_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            dashboard_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dashboard_btn.BackgroundImage = Properties.Resources.icons8_dashboard_50;
            dashboard_btn.BackgroundImageLayout = ImageLayout.Center;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = SystemColors.ControlLightLight;
            dashboard_btn.Location = new Point(3, 233);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(96, 84);
            dashboard_btn.TabIndex = 1;
            dashboard_btn.TextAlign = ContentAlignment.BottomCenter;
            dashboard_btn.UseVisualStyleBackColor = true;
            // 
            // Kanban_list_btn
            // 
            Kanban_list_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Kanban_list_btn.BackgroundImage = Properties.Resources.icons8_kanban_48;
            Kanban_list_btn.BackgroundImageLayout = ImageLayout.Center;
            Kanban_list_btn.FlatStyle = FlatStyle.Flat;
            Kanban_list_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kanban_list_btn.ForeColor = SystemColors.ControlLightLight;
            Kanban_list_btn.Location = new Point(3, 323);
            Kanban_list_btn.Name = "Kanban_list_btn";
            Kanban_list_btn.Size = new Size(96, 84);
            Kanban_list_btn.TabIndex = 0;
            Kanban_list_btn.TextAlign = ContentAlignment.BottomCenter;
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
            Controls.Add(main_panel);
            Controls.Add(Main_panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_form";
            Text = "Tear Down";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel main_panel;
        private Panel Main_panel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panel2;
        private Button Kanban_list_btn;
        private Button notes_btn;
        private Button whiteboard_btn;
        private Button dashboard_btn;
    }
}
