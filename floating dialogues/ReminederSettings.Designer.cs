namespace TearDown_Project_mangament_software.floating_dialogues
{
    partial class ReminederSettings
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
            button_container_panel = new Panel();
            About_btn = new Button();
            Preferences_btn = new Button();
            report_a_bug_btn = new Button();
            Picture_bg = new PictureBox();
            button_container_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Picture_bg).BeginInit();
            SuspendLayout();
            // 
            // button_container_panel
            // 
            button_container_panel.BackColor = Color.FromArgb(104, 93, 121);
            button_container_panel.Controls.Add(report_a_bug_btn);
            button_container_panel.Controls.Add(Preferences_btn);
            button_container_panel.Controls.Add(About_btn);
            button_container_panel.Controls.Add(Picture_bg);
            button_container_panel.Dock = DockStyle.Left;
            button_container_panel.Location = new Point(0, 0);
            button_container_panel.Name = "button_container_panel";
            button_container_panel.Size = new Size(246, 549);
            button_container_panel.TabIndex = 0;
            // 
            // About_btn
            // 
            About_btn.Location = new Point(3, 360);
            About_btn.Name = "About_btn";
            About_btn.Size = new Size(235, 58);
            About_btn.TabIndex = 0;
            About_btn.Text = "About";
            About_btn.UseVisualStyleBackColor = true;
            // 
            // Preferences_btn
            // 
            Preferences_btn.Location = new Point(3, 424);
            Preferences_btn.Name = "Preferences_btn";
            Preferences_btn.Size = new Size(235, 58);
            Preferences_btn.TabIndex = 1;
            Preferences_btn.Text = "Preferences";
            Preferences_btn.UseVisualStyleBackColor = true;
            // 
            // report_a_bug_btn
            // 
            report_a_bug_btn.Location = new Point(3, 488);
            report_a_bug_btn.Name = "report_a_bug_btn";
            report_a_bug_btn.Size = new Size(235, 58);
            report_a_bug_btn.TabIndex = 2;
            report_a_bug_btn.Text = "Report a Bug";
            report_a_bug_btn.UseVisualStyleBackColor = true;
            // 
            // Picture_bg
            // 
            Picture_bg.BackgroundImageLayout = ImageLayout.Zoom;
            Picture_bg.Image = Properties.Resources.Sample_Bg;
            Picture_bg.Location = new Point(-120, -9);
            Picture_bg.Name = "Picture_bg";
            Picture_bg.Size = new Size(366, 546);
            Picture_bg.TabIndex = 3;
            Picture_bg.TabStop = false;
            // 
            // ReminederSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 187, 109);
            ClientSize = new Size(976, 549);
            Controls.Add(button_container_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "ReminederSettings";
            Text = "Settings";
            button_container_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Picture_bg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel button_container_panel;
        private Button report_a_bug_btn;
        private Button Preferences_btn;
        private Button About_btn;
        private PictureBox Picture_bg;
    }
}