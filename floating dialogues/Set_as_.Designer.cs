namespace TearDown_Project_mangament_software.floating_dialogues
{
    partial class Set_as_
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
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            del_btn = new Button();
            Save_btn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 30);
            label1.TabIndex = 0;
            label1.Text = "Set As . . . . ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(252, 187, 109);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 65);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Priority Level";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(292, 26);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "None";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(150, 26);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(57, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mid";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Top";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(252, 187, 109);
            groupBox2.Location = new Point(12, 137);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 65);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ignore Deadline ?";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(150, 26);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(48, 24);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "No";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(24, 26);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(57, 24);
            radioButton6.TabIndex = 0;
            radioButton6.TabStop = true;
            radioButton6.Text = "Yes";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            del_btn.FlatStyle = FlatStyle.Flat;
            del_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            del_btn.ForeColor = Color.Red;
            del_btn.Location = new Point(12, 219);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(475, 55);
            del_btn.TabIndex = 4;
            del_btn.Text = "Delete Card";
            del_btn.UseVisualStyleBackColor = true;
            del_btn.Click += del_btn_Click;
            // 
            // Save_btn
            // 
            Save_btn.FlatStyle = FlatStyle.Flat;
            Save_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save_btn.ForeColor = Color.FromArgb(252, 187, 109);
            Save_btn.Location = new Point(12, 280);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(475, 74);
            Save_btn.TabIndex = 5;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // Set_as_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(499, 366);
            Controls.Add(Save_btn);
            Controls.Add(del_btn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Set_as_";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private GroupBox groupBox2;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private Button del_btn;
        private Button Save_btn;
    }
}