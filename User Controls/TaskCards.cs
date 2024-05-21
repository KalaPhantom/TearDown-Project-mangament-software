using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.floating_dialogues;

namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class TaskCards : UserControl
    {
        public TaskCards()
        {
            InitializeComponent();
        }



        #region modify
        // TODO: Aadd functionalities such as customization, due for task, task description
        private void modify_taskcard_btn_Click(object sender, EventArgs e)
        {
            TaskCard_modify_form modify_frm = new TaskCard_modify_form();
            modify_frm.ShowDialog();
        }
        #endregion



        #region Change Name of the task
        private void taskcard_name_lbl_Click(object sender, EventArgs e)
        {
            Add_name add_Name = new Add_name();
            add_Name.ShowDialog();
        }
        #endregion
    }
}
