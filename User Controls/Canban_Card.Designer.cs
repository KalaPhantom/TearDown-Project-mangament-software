namespace TearDown_Project_mangament_software.User_Controls
{
    partial class Canban_Card
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
            Task_name_label = new Label();
            SuspendLayout();
            // 
            // Task_name_label
            // 
            Task_name_label.AutoSize = true;
            Task_name_label.Location = new Point(13, 12);
            Task_name_label.Name = "Task_name_label";
            Task_name_label.Size = new Size(29, 15);
            Task_name_label.TabIndex = 0;
            Task_name_label.Text = "Task";
            // 
            // Canban_Card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(Task_name_label);
            Name = "Canban_Card";
            Size = new Size(272, 287);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Task_name_label;
    }
}
