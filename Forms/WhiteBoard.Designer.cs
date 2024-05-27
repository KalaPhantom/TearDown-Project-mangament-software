namespace WinFormsApp2
{
    partial class WhiteBoard
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
            panel1 = new Panel();
            Eraser_btn = new Button();
            Color_btn = new Button();
            SizeLabel = new Label();
            numBrushSize = new NumericUpDown();
            Clear_btn = new Button();
            Paint_btn = new Button();
            m_pb = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBrushSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)m_pb).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(Eraser_btn);
            panel1.Controls.Add(Color_btn);
            panel1.Controls.Add(SizeLabel);
            panel1.Controls.Add(numBrushSize);
            panel1.Controls.Add(Clear_btn);
            panel1.Controls.Add(Paint_btn);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1421, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(209, 999);
            panel1.TabIndex = 0;
            // 
            // Eraser_btn
            // 
            Eraser_btn.Cursor = Cursors.IBeam;
            Eraser_btn.Location = new Point(112, 84);
            Eraser_btn.Name = "Eraser_btn";
            Eraser_btn.Size = new Size(94, 76);
            Eraser_btn.TabIndex = 5;
            Eraser_btn.TabStop = false;
            Eraser_btn.Text = "Brush";
            Eraser_btn.UseVisualStyleBackColor = true;
            Eraser_btn.Click += Eraser_btn_Click;
            // 
            // Color_btn
            // 
            Color_btn.Cursor = Cursors.IBeam;
            Color_btn.Location = new Point(112, 3);
            Color_btn.Name = "Color_btn";
            Color_btn.Size = new Size(94, 76);
            Color_btn.TabIndex = 4;
            Color_btn.Text = "Color";
            Color_btn.UseVisualStyleBackColor = true;
            Color_btn.Click += Color_btn_Click;
            // 
            // SizeLabel
            // 
            SizeLabel.AllowDrop = true;
            SizeLabel.AutoSize = true;
            SizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SizeLabel.Location = new Point(54, 255);
            SizeLabel.Name = "SizeLabel";
            SizeLabel.Size = new Size(55, 28);
            SizeLabel.TabIndex = 3;
            SizeLabel.Text = "Size:";
            // 
            // numBrushSize
            // 
            numBrushSize.Location = new Point(38, 287);
            numBrushSize.Margin = new Padding(3, 4, 3, 4);
            numBrushSize.Name = "numBrushSize";
            numBrushSize.Size = new Size(107, 27);
            numBrushSize.TabIndex = 2;
            numBrushSize.ValueChanged += numBrushSize_ValueChanged;
            // 
            // Clear_btn
            // 
            Clear_btn.Cursor = Cursors.IBeam;
            Clear_btn.Location = new Point(11, 84);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(94, 76);
            Clear_btn.TabIndex = 1;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = true;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Paint_btn
            // 
            Paint_btn.Cursor = Cursors.IBeam;
            Paint_btn.Location = new Point(11, 3);
            Paint_btn.Name = "Paint_btn";
            Paint_btn.Size = new Size(94, 76);
            Paint_btn.TabIndex = 0;
            Paint_btn.Text = "Paint";
            Paint_btn.UseVisualStyleBackColor = true;
            Paint_btn.Click += Paint_btn_Click;
            // 
            // m_pb
            // 
            m_pb.Location = new Point(12, 12);
            m_pb.Name = "m_pb";
            m_pb.Size = new Size(1403, 975);
            m_pb.SizeMode = PictureBoxSizeMode.Zoom;
            m_pb.TabIndex = 1;
            m_pb.TabStop = false;
            m_pb.Click += m_pb_Click;
            m_pb.MouseDown += m_pb_MouseDown;
            m_pb.MouseMove += m_pb_MouseMove;
            m_pb.MouseUp += m_pb_MouseUp;
            // 
            // WhiteBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1630, 999);
            Controls.Add(panel1);
            Controls.Add(m_pb);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WhiteBoard";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBrushSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)m_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox m_pb;
        private Button Paint_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Clear_btn;
        private NumericUpDown numBrushSize;
        private Label SizeLabel;
        private Button Color_btn;
        private Button Eraser_btn;
    }
}
