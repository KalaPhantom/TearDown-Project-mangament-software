using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TearDown_Project_mangament_software.floating_dialogues
{





    public partial class TaskCard_modify_form : Form
    {
        #region Properties

        public string taskName { get; set; }
        public int cardIndex { get; set; }
        public Color Task_Color
        {
            get { return taskcard_color.BackColor; }
            set { taskcard_color.BackColor = value; }
        }

        public DateTime Date_Time { get; set; }

        public string Task_Description
        {
            get { return task_description_tbx.Text; }
            set { task_description_tbx.Text = value; }
        }

        public bool IgnoreDeadline { get; set; }    

        public bool missedDeadline { get; set; }

        #endregion


        public TaskCard_modify_form()
        {
            InitializeComponent();
            Task_Color = Color.FromArgb(252, 187, 109);
        }


        #region Description
        private void add_description_btn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region load
        private void TaskCard_modify_form_Load(object sender, EventArgs e)
        {

        }
        #endregion 

        #region Set Date and time
        private void pick_due_btn_Click(object sender, EventArgs e)
        {
            //Fld_DateandTimePicker timePicker = new Fld_DateandTimePicker();
            //timePicker.ShowDialog();

            using (Fld_DateandTimePicker timePicker = new Fld_DateandTimePicker())
            {
                timePicker.dateTime = this.Date_Time;
                timePicker.taskIndex = this.cardIndex;
                timePicker.taskName = this.taskName;
                timePicker.ignoreDeadline = this.IgnoreDeadline;
                timePicker.missedTask = this.missedDeadline;

                if(timePicker.ShowDialog() == DialogResult.OK)
                {
                    this.Date_Time = timePicker.dateTime;
                    this.Duedate_display_txt.Text = timePicker.dateTime.ToString();
                    this.IgnoreDeadline = timePicker.ignoreDeadline;
                    this.missedDeadline = timePicker.missedTask;
                }
            }


        }
        #endregion

        private void task_description_tbx_TextChanged(object sender, EventArgs e)
        {

        }


        #region Colors

        private void color1_btn_Click(object sender, EventArgs e)
        {
            //252, 187, 109
            Task_Color = Color.FromArgb(252, 187, 109);
        }

        private void color2_btn_Click(object sender, EventArgs e)
        {
            //216, 115, 127
            Task_Color = Color.FromArgb(216, 115, 127);
        }

        private void color3_btn_Click(object sender, EventArgs e)
        {
            //171, 108, 130
            Task_Color = Color.FromArgb(171, 108, 130);
        }

        private void color4_btn_Click(object sender, EventArgs e)
        {
            //71, 92, 122
            Task_Color = Color.FromArgb(71, 92, 122);
        }

        private void color5_btn_Click(object sender, EventArgs e)
        {
            //241, 140, 142
            Task_Color = Color.FromArgb(241, 140, 142);
        }

        private void color6_btn_Click(object sender, EventArgs e)
        {
            //240, 183, 164
            Task_Color = Color.FromArgb(240, 183, 164);
        }

        private void color7_btn_Click(object sender, EventArgs e)
        {
            //86, 142, 166
            Task_Color = Color.FromArgb(86, 142, 166);
        }

        private void color8_btn_Click(object sender, EventArgs e)
        {
            //48, 95, 114
            Task_Color = Color.FromArgb(48, 95, 114);
        }
        #endregion

        private void Save_info_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
