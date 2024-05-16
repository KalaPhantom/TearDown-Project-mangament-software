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
            taskColumn_flowlayoutpanel = new FlowLayoutPanel();
            Add_table_btn = new Button();
            SuspendLayout();
            // 
            // taskColumn_flowlayoutpanel
            // 
            taskColumn_flowlayoutpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskColumn_flowlayoutpanel.AutoScroll = true;
            taskColumn_flowlayoutpanel.AutoSize = true;
            taskColumn_flowlayoutpanel.BackColor = Color.FromArgb(71, 92, 122);
            taskColumn_flowlayoutpanel.Location = new Point(-1, 55);
            taskColumn_flowlayoutpanel.Name = "taskColumn_flowlayoutpanel";
            taskColumn_flowlayoutpanel.Size = new Size(1370, 576);
            taskColumn_flowlayoutpanel.TabIndex = 0;
            taskColumn_flowlayoutpanel.WrapContents = false;
            // 
            // Add_table_btn
            // 
            Add_table_btn.BackgroundImageLayout = ImageLayout.Center;
            Add_table_btn.FlatAppearance.BorderSize = 0;
            Add_table_btn.FlatStyle = FlatStyle.Flat;
            Add_table_btn.Font = new Font("Cascadia Code", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_table_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_table_btn.Image = Properties.Resources.icons8_add_50;
            Add_table_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Add_table_btn.Location = new Point(39, 1);
            Add_table_btn.Name = "Add_table_btn";
            Add_table_btn.Size = new Size(138, 56);
            Add_table_btn.TabIndex = 1;
            Add_table_btn.Text = "Add Board";
            Add_table_btn.TextAlign = ContentAlignment.MiddleRight;
            Add_table_btn.UseVisualStyleBackColor = true;
            Add_table_btn.Click += Add_table_btn_Click;
            // 
            // KanbanList_form
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(1369, 635);
            Controls.Add(Add_table_btn);
            Controls.Add(taskColumn_flowlayoutpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KanbanList_form";
            Text = "KanbanList_form";
            Load += KanbanList_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel taskColumn_flowlayoutpanel;
        private Button Add_table_btn;
    }
}