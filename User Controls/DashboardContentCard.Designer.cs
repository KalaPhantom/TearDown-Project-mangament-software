namespace TearDown_Project_mangament_software.User_Controls
{
    partial class DashboardContentCard
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
            components = new System.ComponentModel.Container();
            ColorDisplay_pb = new PictureBox();
            Task_name_lbl = new Label();
            Due_lbl = new Label();
            Priority_lvl_lbl = new Label();
            Status_color_pb = new PictureBox();
            Timer_ticker_l = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ColorDisplay_pb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Status_color_pb).BeginInit();
            SuspendLayout();
            // 
            // ColorDisplay_pb
            // 
            ColorDisplay_pb.BackColor = Color.FromArgb(252, 187, 109);
            ColorDisplay_pb.Dock = DockStyle.Left;
            ColorDisplay_pb.Location = new Point(0, 0);
            ColorDisplay_pb.Name = "ColorDisplay_pb";
            ColorDisplay_pb.Size = new Size(18, 154);
            ColorDisplay_pb.TabIndex = 0;
            ColorDisplay_pb.TabStop = false;
            // 
            // Task_name_lbl
            // 
            Task_name_lbl.AutoSize = true;
            Task_name_lbl.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Task_name_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Task_name_lbl.Location = new Point(36, 37);
            Task_name_lbl.Name = "Task_name_lbl";
            Task_name_lbl.Size = new Size(120, 24);
            Task_name_lbl.TabIndex = 1;
            Task_name_lbl.Text = "Task Name ";
            // 
            // Due_lbl
            // 
            Due_lbl.AutoSize = true;
            Due_lbl.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Due_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Due_lbl.Location = new Point(36, 71);
            Due_lbl.Name = "Due_lbl";
            Due_lbl.Size = new Size(65, 24);
            Due_lbl.TabIndex = 2;
            Due_lbl.Text = "Due: ";
            // 
            // Priority_lvl_lbl
            // 
            Priority_lvl_lbl.AutoSize = true;
            Priority_lvl_lbl.Font = new Font("Cascadia Code SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Priority_lvl_lbl.ForeColor = Color.FromArgb(252, 187, 109);
            Priority_lvl_lbl.Location = new Point(36, 104);
            Priority_lvl_lbl.Name = "Priority_lvl_lbl";
            Priority_lvl_lbl.Size = new Size(186, 24);
            Priority_lvl_lbl.TabIndex = 3;
            Priority_lvl_lbl.Text = "Priority Level: ";
            // 
            // Status_color_pb
            // 
            Status_color_pb.BackColor = Color.FromArgb(255, 255, 192);
            Status_color_pb.Location = new Point(299, 0);
            Status_color_pb.Name = "Status_color_pb";
            Status_color_pb.Size = new Size(201, 26);
            Status_color_pb.TabIndex = 4;
            Status_color_pb.TabStop = false;
            // 
            // Timer_ticker_l
            // 
            Timer_ticker_l.Interval = 1000;
            Timer_ticker_l.Tick += Timer_ticker_l_Tick;
            // 
            // DashboardContentCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(71, 92, 122);
            Controls.Add(Status_color_pb);
            Controls.Add(Priority_lvl_lbl);
            Controls.Add(Due_lbl);
            Controls.Add(Task_name_lbl);
            Controls.Add(ColorDisplay_pb);
            Name = "DashboardContentCard";
            Size = new Size(500, 154);
            Click += DashboardContentCard_Click;
            ((System.ComponentModel.ISupportInitialize)ColorDisplay_pb).EndInit();
            ((System.ComponentModel.ISupportInitialize)Status_color_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ColorDisplay_pb;
        private Label Task_name_lbl;
        private Label Due_lbl;
        private Label Priority_lvl_lbl;
        private System.Windows.Forms.Timer Timer_ticker_l;
        public PictureBox Status_color_pb;
    }
}
