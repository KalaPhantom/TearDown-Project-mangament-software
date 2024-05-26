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
            components = new System.ComponentModel.Container();
            main_panel = new Panel();
            statusStrip1 = new StatusStrip();
            current_status_onb = new ToolStripStatusLabel();
            panel2 = new Panel();
            logo_button = new Button();
            notes_btn = new Button();
            whiteboard_btn = new Button();
            dashboard_btn = new Button();
            Kanban_list_btn = new Button();
            deadline_checker = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.AutoSize = true;
            main_panel.BackColor = Color.FromArgb(24, 0, 0);
            main_panel.Dock = DockStyle.Bottom;
            main_panel.Location = new Point(0, 847);
            main_panel.Margin = new Padding(3, 4, 3, 4);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1565, 0);
            main_panel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(104, 93, 121);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { current_status_onb });
            statusStrip1.Location = new Point(0, 825);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.Size = new Size(1565, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // current_status_onb
            // 
            current_status_onb.ForeColor = Color.FromArgb(252, 187, 109);
            current_status_onb.Name = "current_status_onb";
            current_status_onb.Size = new Size(0, 16);
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 187, 109);
            panel2.Controls.Add(logo_button);
            panel2.Controls.Add(notes_btn);
            panel2.Controls.Add(whiteboard_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(Kanban_list_btn);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(117, 825);
            panel2.TabIndex = 0;
            // 
            // logo_button
            // 
            logo_button.BackgroundImage = Properties.Resources.icons8_bullseye_50___W;
            logo_button.BackgroundImageLayout = ImageLayout.Center;
            logo_button.FlatAppearance.BorderSize = 0;
            logo_button.FlatStyle = FlatStyle.Flat;
            logo_button.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logo_button.ForeColor = SystemColors.ControlLightLight;
            logo_button.Location = new Point(0, 16);
            logo_button.Margin = new Padding(3, 4, 3, 4);
            logo_button.Name = "logo_button";
            logo_button.Size = new Size(110, 112);
            logo_button.TabIndex = 4;
            logo_button.TextAlign = ContentAlignment.BottomCenter;
            logo_button.UseVisualStyleBackColor = true;
            // 
            // notes_btn
            // 
            notes_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            notes_btn.BackgroundImage = Properties.Resources.icons8_notes_50;
            notes_btn.BackgroundImageLayout = ImageLayout.Center;
            notes_btn.FlatStyle = FlatStyle.Flat;
            notes_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notes_btn.ForeColor = SystemColors.ControlLightLight;
            notes_btn.Location = new Point(3, 679);
            notes_btn.Margin = new Padding(3, 4, 3, 4);
            notes_btn.Name = "notes_btn";
            notes_btn.Size = new Size(110, 121);
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
            whiteboard_btn.Location = new Point(3, 559);
            whiteboard_btn.Margin = new Padding(3, 4, 3, 4);
            whiteboard_btn.Name = "whiteboard_btn";
            whiteboard_btn.Size = new Size(110, 112);
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
            dashboard_btn.Location = new Point(3, 319);
            dashboard_btn.Margin = new Padding(3, 4, 3, 4);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(110, 112);
            dashboard_btn.TabIndex = 1;
            dashboard_btn.TextAlign = ContentAlignment.BottomCenter;
            dashboard_btn.UseVisualStyleBackColor = true;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // Kanban_list_btn
            // 
            Kanban_list_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Kanban_list_btn.BackgroundImage = Properties.Resources.icons8_kanban_48;
            Kanban_list_btn.BackgroundImageLayout = ImageLayout.Center;
            Kanban_list_btn.FlatStyle = FlatStyle.Flat;
            Kanban_list_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Kanban_list_btn.ForeColor = SystemColors.ControlLightLight;
            Kanban_list_btn.Location = new Point(3, 439);
            Kanban_list_btn.Margin = new Padding(3, 4, 3, 4);
            Kanban_list_btn.Name = "Kanban_list_btn";
            Kanban_list_btn.Size = new Size(110, 112);
            Kanban_list_btn.TabIndex = 0;
            Kanban_list_btn.TextAlign = ContentAlignment.BottomCenter;
            Kanban_list_btn.UseVisualStyleBackColor = true;
            Kanban_list_btn.Click += Kanban_list_btn_Click;
            // 
            // deadline_checker
            // 
            deadline_checker.Interval = 60000;
            deadline_checker.Tick += deadline_checker_Tick;
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 847);
            Controls.Add(panel2);
            Controls.Add(statusStrip1);
            Controls.Add(main_panel);
            IsMdiContainer = true;
            Name = "Main_form";
            Text = "Tear Down";
            FormClosing += Main_form_FormClosing;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel main_panel;
        private StatusStrip statusStrip1;
        private Panel panel2;
        private Button Kanban_list_btn;
        private Button notes_btn;
        private Button whiteboard_btn;
        private Button dashboard_btn;
        private Button logo_button;
        public ToolStripStatusLabel current_status_onb;
        private System.Windows.Forms.Timer deadline_checker;
    }
}
