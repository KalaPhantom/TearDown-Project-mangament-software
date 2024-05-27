namespace Notes3
{
    partial class Notes_
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
            TxtBxTitle = new TextBox();
            TxtBxNotes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            previousnotes = new DataGridView();
            LoadBtn = new Button();
            DeleteBtn = new Button();
            NewNotesBtn = new Button();
            SaveBtn = new Button();
            Exitbtn = new Button();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)previousnotes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBxTitle
            // 
            TxtBxTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtBxTitle.BackColor = Color.White;
            TxtBxTitle.Font = new Font("Lucida Sans", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtBxTitle.Location = new Point(458, 150);
            TxtBxTitle.Margin = new Padding(3, 4, 3, 4);
            TxtBxTitle.Name = "TxtBxTitle";
            TxtBxTitle.Size = new Size(765, 30);
            TxtBxTitle.TabIndex = 0;
            // 
            // TxtBxNotes
            // 
            TxtBxNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBxNotes.BackColor = Color.White;
            TxtBxNotes.Location = new Point(458, 222);
            TxtBxNotes.Margin = new Padding(3, 4, 3, 4);
            TxtBxNotes.Multiline = true;
            TxtBxNotes.Name = "TxtBxNotes";
            TxtBxNotes.Size = new Size(765, 486);
            TxtBxNotes.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(252, 187, 109);
            label1.Location = new Point(458, 119);
            label1.Name = "label1";
            label1.Size = new Size(84, 27);
            label1.TabIndex = 2;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(252, 187, 109);
            label2.Location = new Point(458, 184);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 3;
            label2.Text = "Notes:";
            label2.Click += label2_Click;
            // 
            // previousnotes
            // 
            previousnotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            previousnotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            previousnotes.BackgroundColor = Color.White;
            previousnotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            previousnotes.GridColor = Color.Orange;
            previousnotes.Location = new Point(14, 103);
            previousnotes.Margin = new Padding(3, 4, 3, 4);
            previousnotes.Name = "previousnotes";
            previousnotes.RowHeadersWidth = 51;
            previousnotes.Size = new Size(411, 437);
            previousnotes.TabIndex = 4;
            previousnotes.CellContentDoubleClick += previousnotes_CellContentDoubleClick;
            previousnotes.CellDoubleClick += previousnotes_CellDoubleClick;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = Color.FromArgb(71, 92, 122);
            LoadBtn.FlatStyle = FlatStyle.Flat;
            LoadBtn.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadBtn.ForeColor = Color.FromArgb(252, 187, 109);
            LoadBtn.Location = new Point(12, 15);
            LoadBtn.Margin = new Padding(3, 4, 3, 4);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(188, 46);
            LoadBtn.TabIndex = 5;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(71, 92, 122);
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteBtn.ForeColor = Color.FromArgb(252, 187, 109);
            DeleteBtn.Location = new Point(206, 15);
            DeleteBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(188, 46);
            DeleteBtn.TabIndex = 6;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // NewNotesBtn
            // 
            NewNotesBtn.BackColor = Color.FromArgb(71, 92, 122);
            NewNotesBtn.FlatStyle = FlatStyle.Flat;
            NewNotesBtn.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewNotesBtn.ForeColor = Color.FromArgb(252, 187, 109);
            NewNotesBtn.Location = new Point(12, 69);
            NewNotesBtn.Margin = new Padding(3, 4, 3, 4);
            NewNotesBtn.Name = "NewNotesBtn";
            NewNotesBtn.Size = new Size(188, 46);
            NewNotesBtn.TabIndex = 7;
            NewNotesBtn.Text = "New Notes";
            NewNotesBtn.UseVisualStyleBackColor = false;
            NewNotesBtn.Click += NewNotesBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.FromArgb(71, 92, 122);
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Cascadia Code", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = Color.FromArgb(252, 187, 109);
            SaveBtn.Location = new Point(206, 69);
            SaveBtn.Margin = new Padding(3, 4, 3, 4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(188, 46);
            SaveBtn.TabIndex = 8;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.BackColor = Color.Purple;
            Exitbtn.FlatStyle = FlatStyle.Popup;
            Exitbtn.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Exitbtn.Location = new Point(1523, 13);
            Exitbtn.Margin = new Padding(3, 4, 3, 4);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(34, 31);
            Exitbtn.TabIndex = 9;
            Exitbtn.Text = "X";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Visible = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Purple;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Gill Sans Ultra Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(1483, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(34, 31);
            button1.TabIndex = 10;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 187, 109);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1366, 77);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = TearDown_Project_mangament_software.Properties.Resources.note_1;
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 61);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(104, 93, 121);
            label3.Location = new Point(76, 13);
            label3.Name = "label3";
            label3.Size = new Size(132, 49);
            label3.TabIndex = 0;
            label3.Text = "Notes";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(LoadBtn);
            panel2.Controls.Add(DeleteBtn);
            panel2.Controls.Add(SaveBtn);
            panel2.Controls.Add(NewNotesBtn);
            panel2.Location = new Point(14, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(411, 134);
            panel2.TabIndex = 13;
            // 
            // Notes_
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(71, 92, 122);
            ClientSize = new Size(1366, 721);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(Exitbtn);
            Controls.Add(previousnotes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtBxNotes);
            Controls.Add(TxtBxTitle);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Notes_";
            Text = "NoteTaker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)previousnotes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBxTitle;
        private TextBox TxtBxNotes;
        private Label label1;
        private Label label2;
        private DataGridView previousnotes;
        private Button LoadBtn;
        private Button DeleteBtn;
        private Button NewNotesBtn;
        private Button SaveBtn;
        private Button Exitbtn;
        private Button button1;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
