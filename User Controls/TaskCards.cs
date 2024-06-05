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

        // gets and sets the column number that the control is belong
        public int ColumnNumber { get; set; }

        // gets and sets the value of a specific label
        public string TaskName
        {
            get { return taskcard_name_lbl.Text; }
            set { taskcard_name_lbl.Text = value; }
        }

        // get and sets the color of a picture box color property (Color header of the task card)
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

        // get and set wheather the user missed the deadline
        public bool missedDeadline { get; set; }


        // The priority level property uses a string to assign the priority level (top,mid,none)
        public string prioritylevel { get; set; }

        // get and set the date time (due) of a specific task - an attribute of a specific task cards 
        public DateTime dateTime { get; set; }

        // gets and sets the task description of a task card
        public string taskDescription { get; set; }

        // A Bool condition that represents wheather the user wants to delete the task card (control)
        public bool DeleteCard
        {
            get; set;
        }

        // an automatic property that get and set the task state of the task cards
        // wheather a task is accomplished
        public string TaskState { get; set; }

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


        #region TaskCards - On Load
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


            // Checks a specific object property (type of string) to present weather the user already done a specific task and its priority level
            // Once a certain condition is met, it will set a picture box containing an icon visibility to true - displaying a marker

            priority_icon_pb.Visible = prioritylevel == "top" ? true : false;
            priority_icon_pb.BackColor = taskColor;

            check_icon_pb.Visible = TaskState == "done" ? true : false;
            check_icon_pb.BackColor = taskColor;
        }
        #endregion


        #region Set as - button function
        /// <summary>
        ///  Invoked when the user clicks the set-as button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void set_as_btn_Click(object sender, EventArgs e)
        {

            // initialize the component of the "set_as_form" to access all of its properties
            // The properties will then be initialized with the property values from the task card
            using (Set_as_ set_as_form = new Set_as_())
            {
                set_as_form.Delete_card = this.DeleteCard;
                set_as_form.Priority_level = this.prioritylevel;
                set_as_form.Ignore_Deadline = this.ignoreDeadline;
                set_as_form.Mark_as = this.TaskState;

                // Condition to check wheather the processing in the another form is executed properly
                if (set_as_form.ShowDialog() == DialogResult.OK)
                {

                    // sets new data to the property of the task cards
                    this.DeleteCard = set_as_form.Delete_card;
                    this.prioritylevel = set_as_form.Priority_level;
                    this.ignoreDeadline = set_as_form.Ignore_Deadline;
                    this.TaskState = set_as_form.Mark_as;

                    if (this.TaskState == "done")
                    {
                        // set the a check box icon to visible
                        check_icon_pb.BackColor = this.taskColor;
                        check_icon_pb.Visible = true;
                    }
                    else if (this.TaskState == "done_del")
                    {
                        // Delete the control in the layout
                        this.Parent.Controls.Remove(this);
                    }
                    else
                    {
                        // Hide the check icon
                        check_icon_pb.BackColor = this.taskColor;
                        check_icon_pb.Visible = false;
                    }

                    // Recieves a Boolean value to validate whether the user clicks the delete button
                    if (set_as_form.Delete_card == true)
                    {
                        this.Parent.Controls.Remove(this);
                    }

                    // Set and display the priority level of the task card control
                    if (this.prioritylevel == "top")
                    {
                        priority_icon_pb.Visible = true;
                    }
                    else
                    {
                        priority_icon_pb.Visible = false;
                    }
                }
            }
        }
        #endregion

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

        #region Mouse event
        private void taskcard_name_lbl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(this, DragDropEffects.Move);
            }
        }

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
        #endregion

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

        #region selection effects
        private void task_condition_panel_Click(object sender, EventArgs e)
        {
            selection_indicator.Visible = true;
        }


        private void task_condition_panel_Leave(object sender, EventArgs e)
        {
            selection_indicator.Visible = false;
        }
        #endregion
    }
}
