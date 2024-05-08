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
            tool_Panel1 = new User_Controls.Tool_Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            Main_panel2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // main_panel
            // 
            main_panel.AutoSize = true;
            main_panel.BackColor = Color.FromArgb(24, 0, 0);
            main_panel.Dock = DockStyle.Bottom;
            main_panel.Location = new Point(0, 560);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1208, 0);
            main_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(143, 31, 31);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1208, 25);
            panel1.TabIndex = 1;
            // 
            // Main_panel2
            // 
            Main_panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main_panel2.BackColor = Color.FromArgb(24, 0, 0);
            Main_panel2.Controls.Add(tool_Panel1);
            Main_panel2.Location = new Point(0, 22);
            Main_panel2.Name = "Main_panel2";
            Main_panel2.Size = new Size(1208, 526);
            Main_panel2.TabIndex = 2;
            // 
            // tool_Panel1
            // 
            tool_Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tool_Panel1.AutoSize = true;
            tool_Panel1.BackColor = Color.OrangeRed;
            tool_Panel1.Location = new Point(0, 3);
            tool_Panel1.Name = "tool_Panel1";
            tool_Panel1.Size = new Size(249, 634);
            tool_Panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Crimson;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 538);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1208, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Main_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1208, 560);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(main_panel);
            Controls.Add(Main_panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main_form";
            Text = "Tear Down";
            Main_panel2.ResumeLayout(false);
            Main_panel2.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel main_panel;
        private Panel panel1;
        private Panel Main_panel2;
        private User_Controls.Tool_Panel tool_Panel1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
