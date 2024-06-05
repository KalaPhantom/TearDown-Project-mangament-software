namespace TearDown_Project_mangament_software.floating_dialogues
{
    partial class Kanban_icon_form
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
            pictureBox1 = new PictureBox();
            Preferences_btn = new Button();
            About_btn = new Button();
            Picture_bg = new PictureBox();
            button_container_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Picture_bg).BeginInit();
            SuspendLayout();
            // 
            // button_container_panel
            // 
            button_container_panel.BackColor = Color.FromArgb(104, 93, 121);
            button_container_panel.Controls.Add(pictureBox1);
            button_container_panel.Controls.Add(Preferences_btn);
            button_container_panel.Controls.Add(About_btn);
            button_container_panel.Controls.Add(Picture_bg);
            button_container_panel.Dock = DockStyle.Left;
            button_container_panel.Location = new Point(0, 0);
            button_container_panel.Name = "button_container_panel";
            button_container_panel.Size = new Size(246, 549);
            button_container_panel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_bullseye_100;
            pictureBox1.Location = new Point(12, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 106);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Preferences_btn
            // 
            Preferences_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Preferences_btn.Location = new Point(3, 479);
            Preferences_btn.Name = "Preferences_btn";
            Preferences_btn.Size = new Size(235, 58);
            Preferences_btn.TabIndex = 1;
            Preferences_btn.Text = "Reminder Settings";
            Preferences_btn.UseVisualStyleBackColor = true;
            Preferences_btn.Click += Preferences_btn_Click;
            // 
            // About_btn
            // 
            About_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            About_btn.Location = new Point(3, 415);
            About_btn.Name = "About_btn";
            About_btn.Size = new Size(235, 58);
            About_btn.TabIndex = 0;
            About_btn.Text = "About";
            About_btn.UseVisualStyleBackColor = true;
            About_btn.Click += About_btn_Click;
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
            // Kanban_icon_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 187, 109);
            ClientSize = new Size(976, 549);
            Controls.Add(button_container_panel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            IsMdiContainer = true;
            Name = "Kanban_icon_form";
            Text = "Settings";
            button_container_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Picture_bg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel button_container_panel;
        private Button Preferences_btn;
        private Button About_btn;
        private PictureBox Picture_bg;
        private PictureBox pictureBox1;
    }
}