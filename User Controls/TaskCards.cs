using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.floating_dialogues;
using TearDown_Project_mangament_software.Systems;

namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class TaskCards : UserControl
    {

        //Default fields

        public DateTime due;
        //public Color color = Color.FromArgb(252, 187, 109);

        #region Properties

        public int ColumnNumber { get; set; }
        public string TaskName
        {
            get { return taskcard_name_lbl.Text; }
            set { taskcard_name_lbl.Text = value; }

        }

        public Color taskColor
        {
            get { return Task_color.BackColor; }
            set { Task_color.BackColor = value; }
        }

        // Bool property for ignoring the deadline
        public bool ignoreDeadline
        {
            get; set;
        }

        public bool missedDeadline { get; set; }


        // The priority level property uses a string to assign the priority level (top,mid,none)

        public string prioritylevel { get; set; }

        public DateTime dateTime { get; set; }
        public string taskDescription { get; set; }

        public bool DeleteCard
        {
            get; set;
        }

        #endregion


        public TaskCards()
        {
            InitializeComponent();
            task_atr_timer.Start();

        }


        #region modify

        // TODO: Aadd functionalities such as customization, due for task, task description
        private void modify_taskcard_btn_Click(object sender, EventArgs e)
        {
            //taskcard_modify_form modify_frm = new taskcard_modify_form();
            //modify_frm.showdialog();

            using (TaskCard_modify_form modify_form = new TaskCard_modify_form())
            {
                modify_form.Task_Color = this.taskColor;
                modify_form.Date_Time = this.dateTime;
                modify_form.Task_Description = this.taskDescription;
                modify_form.cardIndex = ColumnNumber;
                modify_form.taskName = this.TaskName;
                modify_form.IgnoreDeadline = this.ignoreDeadline;
                modify_form.missedDeadline = this.missedDeadline;


                if (modify_form.ShowDialog() == DialogResult.OK)
                {
                    taskColor = modify_form.Task_Color;
                    dateTime = modify_form.Date_Time;
                    taskDescription = modify_form.Task_Description;
                    due_lbl.Text = String.Concat("Due: ", modify_form.Date_Time.ToString());
                    ignoreDeadline = modify_form.IgnoreDeadline;
                    missedDeadline = modify_form.missedDeadline;
                    //Temp.DataValidator_Remove_and_Replace(TaskName, modify_form.Date_Time);
                    //Temp.UpdateDate(TaskName,dateTime, ColumnNumber);
                }
            }
        }
        #endregion

        #region Change Name of the task
        private void taskcard_name_lbl_Click(object sender, EventArgs e)
        {
            //Add_name add_Name = new Add_name();
            //add_Name.ShowDialog();
            //Add_name.Current_selected_column = ColumnNumber;
            //using (Add_name addName = new Add_name())
            //{
            //    addName.TaskName = TaskName;
            //    addName.dateTime = dateTime;


            //    if (addName.ShowDialog() == DialogResult.OK)
            //    {

            //        //Temp.NameValidator(addName.TaskName,TaskName,dateTime );
            //        TaskName = addName.NewName;

            //    }
            //}

        }
        #endregion

        private void TaskCards_Load(object sender, EventArgs e)
        {
            if (dateTime == new DateTime())
            {
                due_lbl.Text = "Due: None";

            }
            else
            {
                due_lbl.Text = String.Concat("Due: ", dateTime);
            }


        }

        private void set_as_btn_Click(object sender, EventArgs e)
        {
            using (Set_as_ set_as_form = new Set_as_())
            {
                set_as_form.Delete_card = this.DeleteCard;
                set_as_form.Priority_level = this.prioritylevel;
                set_as_form.Ignore_Deadline = this.ignoreDeadline;

                if (set_as_form.ShowDialog() == DialogResult.OK)
                {
                    this.DeleteCard = set_as_form.Delete_card;
                    this.prioritylevel = set_as_form.Priority_level;
                    this.ignoreDeadline = set_as_form.Ignore_Deadline;
                    if (set_as_form.Delete_card == true)
                    {
                        this.Parent.Controls.Remove(this);


                    }
                }
            }
        }

        #region redundant
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskCards_Validated(object sender, EventArgs e)
        {

        }

        private void TaskCards_Leave(object sender, EventArgs e)
        {

        }

        private void TaskCards_Enter(object sender, EventArgs e)
        {

        }
        #endregion


        private void taskcard_name_lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        #region change name
        private void changeName_btn_Click(object sender, EventArgs e)
        {
            Add_name.Current_selected_column = ColumnNumber;
            using (Add_name addName = new Add_name())
            {
                addName.TaskName = TaskName;
                addName.dateTime = dateTime;


                if (addName.ShowDialog() == DialogResult.OK)
                {

                    //Temp.NameValidator(addName.TaskName,TaskName,dateTime );
                    TaskName = addName.NewName;

                }
            }
        }
        #endregion

        #region Color Atribute update
        private void task_atr_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = this.dateTime - DateTime.Now;

            if (ignoreDeadline == true)
            {
                color_atb_pb.BackColor = Color.YellowGreen;
                missedDeadline = false;
            }
            else
            {
                if (timeSpan.TotalSeconds <= 0)
                {
                    color_atb_pb.BackColor = Color.Red;

                    missedDeadline = true;
                }
                else if (timeSpan.TotalSeconds > 0 && timeSpan.TotalHours <= 24)
                {
                    color_atb_pb.BackColor = Color.Orange;

                    missedDeadline = false;
                }
                else if (timeSpan.TotalDays >= 1)
                {
                    color_atb_pb.BackColor = Color.Green;

                    missedDeadline = false;
                }
                else
                {
                    color_atb_pb.BackColor = Color.AliceBlue;
                    missedDeadline = false;
                }
            }
        }
        #endregion

        #region Notif Icon

        #endregion

        private void TaskCards_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        private void task_condition_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

        private void Task_color_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }
    }
}
