namespace TearDown_Project_mangament_software.floating_dialogues
{
    partial class Confirmation_for_column_deletion
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
            label1 = new Label();
            panel1 = new Panel();
            Yes_btn = new Button();
            No_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(22, 48);
            label1.Name = "label1";
            label1.Size = new Size(545, 74);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you wanted to delete\r\nthis column?";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 187, 109);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 30);
            panel1.TabIndex = 1;
            // 
            // Yes_btn
            // 
            Yes_btn.FlatAppearance.BorderColor = Color.Red;
            Yes_btn.FlatStyle = FlatStyle.Flat;
            Yes_btn.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Yes_btn.ForeColor = Color.Red;
            Yes_btn.Location = new Point(89, 163);
            Yes_btn.Name = "Yes_btn";
            Yes_btn.Size = new Size(137, 36);
            Yes_btn.TabIndex = 2;
            Yes_btn.Text = "Yes";
            Yes_btn.UseVisualStyleBackColor = true;
            Yes_btn.Click += Yes_btn_Click;
            // 
            // No_btn
            // 
            No_btn.FlatAppearance.BorderColor = Color.FromArgb(252, 187, 109);
            No_btn.FlatStyle = FlatStyle.Flat;
            No_btn.Font = new Font("Cascadia Code", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            No_btn.ForeColor = Color.FromArgb(252, 187, 109);
            No_btn.Location = new Point(341, 163);
            No_btn.Name = "No_btn";
            No_btn.Size = new Size(137, 36);
            No_btn.TabIndex = 3;
            No_btn.Text = "No";
            No_btn.UseVisualStyleBackColor = true;
            No_btn.Click += No_btn_Click;
            // 
            // Confirmation_for_column_deletion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(579, 229);
            Controls.Add(No_btn);
            Controls.Add(Yes_btn);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Confirmation_for_column_deletion";
            Text = "Confirmation_for_column_deletion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button Yes_btn;
        private Button No_btn;
    }
}