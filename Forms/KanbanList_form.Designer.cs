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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Add_table_btn = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(25, 34, 34);
            flowLayoutPanel1.Location = new Point(0, 84);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1369, 547);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Add_table_btn
            // 
            Add_table_btn.Location = new Point(12, 12);
            Add_table_btn.Name = "Add_table_btn";
            Add_table_btn.Size = new Size(75, 51);
            Add_table_btn.TabIndex = 1;
            Add_table_btn.Text = "button1";
            Add_table_btn.UseVisualStyleBackColor = true;
            // 
            // KanbanList_form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(4, 34, 34);
            ClientSize = new Size(1369, 635);
            Controls.Add(Add_table_btn);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KanbanList_form";
            Text = "KanbanList_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button Add_table_btn;
    }
}