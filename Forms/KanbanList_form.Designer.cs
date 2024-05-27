namespace TearDown_Project_mangament_software.Forms
{
    partial class KanbanList_form
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
            components = new System.ComponentModel.Container();
            taskColumn_flowlayoutpanel = new FlowLayoutPanel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Alert_notif = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // taskColumn_flowlayoutpanel
            // 
            taskColumn_flowlayoutpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskColumn_flowlayoutpanel.AutoScroll = true;
            taskColumn_flowlayoutpanel.AutoSize = true;
            taskColumn_flowlayoutpanel.BackColor = Color.FromArgb(71, 92, 122);
            taskColumn_flowlayoutpanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taskColumn_flowlayoutpanel.Location = new Point(-1, 73);
            taskColumn_flowlayoutpanel.Margin = new Padding(3, 4, 3, 4);
            taskColumn_flowlayoutpanel.Name = "taskColumn_flowlayoutpanel";
            taskColumn_flowlayoutpanel.Size = new Size(1566, 768);
            taskColumn_flowlayoutpanel.TabIndex = 0;
            taskColumn_flowlayoutpanel.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(79, 20);
            label1.Name = "label1";
            label1.Size = new Size(233, 40);
            label1.TabIndex = 1;
            label1.Text = "Kanban Board";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_bullseye_50;
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 48);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Alert_notif
            // 
            Alert_notif.Text = "notifyIcon1";
            Alert_notif.Visible = true;
            // 
            // KanbanList_form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(1565, 847);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(taskColumn_flowlayoutpanel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "KanbanList_form";
            Text = "KanbanList_form";
            Load += KanbanList_form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel taskColumn_flowlayoutpanel;
        private Label label1;
        private PictureBox pictureBox1;
        private NotifyIcon Alert_notif;
    }
}