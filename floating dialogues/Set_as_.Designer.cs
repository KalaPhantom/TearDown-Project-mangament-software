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
            none_rdb = new RadioButton();
            top_rdb = new RadioButton();
            ignoreDeadline_tr_rdb = new GroupBox();
            selected_ignoreDeadline_txt = new Label();
            ignoreDealine_false_rdb = new RadioButton();
            radioButton6 = new RadioButton();
            del_btn = new Button();
            Save_btn = new Button();
            groupBox2 = new GroupBox();
            Doing_rdb = new RadioButton();
            done_del_btn = new RadioButton();
            Done_del_rdb = new RadioButton();
            groupBox1.SuspendLayout();
            ignoreDeadline_tr_rdb.SuspendLayout();
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
            groupBox1.Controls.Add(none_rdb);
            groupBox1.Controls.Add(top_rdb);
            groupBox1.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(252, 187, 109);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(640, 65);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Priority Level";
            // 
            // none_rdb
            // 
            none_rdb.AutoSize = true;
            none_rdb.Location = new Point(117, 26);
            none_rdb.Name = "none_rdb";
            none_rdb.Size = new Size(66, 24);
            none_rdb.TabIndex = 2;
            none_rdb.Text = "None";
            none_rdb.UseVisualStyleBackColor = true;
            none_rdb.CheckedChanged += none_rdb_CheckedChanged;
            // 
            // top_rdb
            // 
            top_rdb.AutoSize = true;
            top_rdb.Location = new Point(24, 26);
            top_rdb.Name = "top_rdb";
            top_rdb.Size = new Size(57, 24);
            top_rdb.TabIndex = 0;
            top_rdb.Text = "Top";
            top_rdb.UseVisualStyleBackColor = true;
            top_rdb.CheckedChanged += top_rdb_CheckedChanged;
            // 
            // ignoreDeadline_tr_rdb
            // 
            ignoreDeadline_tr_rdb.Controls.Add(selected_ignoreDeadline_txt);
            ignoreDeadline_tr_rdb.Controls.Add(ignoreDealine_false_rdb);
            ignoreDeadline_tr_rdb.Controls.Add(radioButton6);
            ignoreDeadline_tr_rdb.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ignoreDeadline_tr_rdb.ForeColor = Color.FromArgb(252, 187, 109);
            ignoreDeadline_tr_rdb.Location = new Point(12, 137);
            ignoreDeadline_tr_rdb.Name = "ignoreDeadline_tr_rdb";
            ignoreDeadline_tr_rdb.Size = new Size(640, 65);
            ignoreDeadline_tr_rdb.TabIndex = 3;
            ignoreDeadline_tr_rdb.TabStop = false;
            ignoreDeadline_tr_rdb.Text = "Ignore Deadline ?";
            // 
            // selected_ignoreDeadline_txt
            // 
            selected_ignoreDeadline_txt.AutoSize = true;
            selected_ignoreDeadline_txt.Location = new Point(403, 26);
            selected_ignoreDeadline_txt.Name = "selected_ignoreDeadline_txt";
            selected_ignoreDeadline_txt.Size = new Size(90, 20);
            selected_ignoreDeadline_txt.TabIndex = 2;
            selected_ignoreDeadline_txt.Text = "Selected:";
            // 
            // ignoreDealine_false_rdb
            // 
            ignoreDealine_false_rdb.AutoSize = true;
            ignoreDealine_false_rdb.Location = new Point(150, 26);
            ignoreDealine_false_rdb.Name = "ignoreDealine_false_rdb";
            ignoreDealine_false_rdb.Size = new Size(48, 24);
            ignoreDealine_false_rdb.TabIndex = 1;
            ignoreDealine_false_rdb.Text = "No";
            ignoreDealine_false_rdb.UseVisualStyleBackColor = true;
            ignoreDealine_false_rdb.CheckedChanged += ignoreDealine_false_rdb_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(24, 26);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(57, 24);
            radioButton6.TabIndex = 0;
            radioButton6.Text = "Yes";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // del_btn
            // 
            del_btn.FlatStyle = FlatStyle.Flat;
            del_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            del_btn.ForeColor = Color.Red;
            del_btn.Location = new Point(12, 293);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(640, 55);
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
            Save_btn.Location = new Point(12, 354);
            Save_btn.Name = "Save_btn";
            Save_btn.Size = new Size(640, 74);
            Save_btn.TabIndex = 5;
            Save_btn.Text = "Save";
            Save_btn.UseVisualStyleBackColor = true;
            Save_btn.Click += Save_btn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Doing_rdb);
            groupBox2.Controls.Add(done_del_btn);
            groupBox2.Controls.Add(Done_del_rdb);
            groupBox2.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(252, 187, 109);
            groupBox2.Location = new Point(12, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(640, 65);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mark As";
            // 
            // Doing_rdb
            // 
            Doing_rdb.AutoSize = true;
            Doing_rdb.Location = new Point(389, 26);
            Doing_rdb.Name = "Doing_rdb";
            Doing_rdb.Size = new Size(75, 24);
            Doing_rdb.TabIndex = 2;
            Doing_rdb.Text = "Doing";
            Doing_rdb.UseVisualStyleBackColor = true;
            Doing_rdb.CheckedChanged += Doing_rdb_CheckedChanged;
            // 
            // done_del_btn
            // 
            done_del_btn.AutoSize = true;
            done_del_btn.Location = new Point(150, 26);
            done_del_btn.Name = "done_del_btn";
            done_del_btn.Size = new Size(174, 24);
            done_del_btn.TabIndex = 1;
            done_del_btn.Text = "Done and Delete ";
            done_del_btn.UseVisualStyleBackColor = true;
            done_del_btn.CheckedChanged += done_del_btn_CheckedChanged;
            // 
            // Done_del_rdb
            // 
            Done_del_rdb.AutoSize = true;
            Done_del_rdb.Location = new Point(24, 26);
            Done_del_rdb.Name = "Done_del_rdb";
            Done_del_rdb.Size = new Size(66, 24);
            Done_del_rdb.TabIndex = 0;
            Done_del_rdb.Text = "Done";
            Done_del_rdb.UseVisualStyleBackColor = false;
            Done_del_rdb.CheckedChanged += Done_del_rdb_CheckedChanged;
            // 
            // Set_as_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 93, 121);
            ClientSize = new Size(664, 440);
            Controls.Add(groupBox2);
            Controls.Add(Save_btn);
            Controls.Add(del_btn);
            Controls.Add(ignoreDeadline_tr_rdb);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Set_as_";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ignoreDeadline_tr_rdb.ResumeLayout(false);
            ignoreDeadline_tr_rdb.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton top_rdb;
        private RadioButton none_rdb;
        private GroupBox ignoreDeadline_tr_rdb;
        private RadioButton ignoreDealine_false_rdb;
        private RadioButton radioButton6;
        private Button del_btn;
        private Button Save_btn;
        private GroupBox groupBox2;
        private RadioButton done_del_btn;
        private RadioButton Done_del_rdb;
        private Label selected_ignoreDeadline_txt;
        private RadioButton Doing_rdb;
    }
}