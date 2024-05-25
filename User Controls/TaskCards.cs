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
        public Color color = Color.FromArgb(252, 187, 109);

        #region Properties

        public int ColumnNumber { get ; set; }
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


        // The priority level property uses a string to assign the priority level (top,mid,none)

        public string prioritylevel { get;set; }
     

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


                if (modify_form.ShowDialog() == DialogResult.OK)
                {
                    taskColor = modify_form.Task_Color;
                    dateTime = modify_form.Date_Time;
                    taskDescription = modify_form.Task_Description;
                    due_lbl.Text = String.Concat("Due: ", modify_form.Date_Time.ToString());
                    //Temp.DataValidator_Remove_and_Replace(TaskName, modify_form.Date_Time);
                    Temp.UpdateDate(TaskName,dateTime);
                }
            }
        }
        #endregion

        #region Change Name of the task
        private void taskcard_name_lbl_Click(object sender, EventArgs e)
        {
            //Add_name add_Name = new Add_name();
            //add_Name.ShowDialog();

            using (Add_name addName = new Add_name())
            {
                addName.TaskName = TaskName;

                if (addName.ShowDialog() == DialogResult.OK)
                {
                    Temp.NameValidator(addName.TaskName,TaskName,dateTime );
                    TaskName = addName.TaskName;
                }
            }
            
        }
        #endregion

        private void TaskCards_Load(object sender, EventArgs e)
        {
            if (due == null)
            {
                due_lbl.Text = "Due: None";
                Task_color.BackColor = color;
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

        
    }
}
