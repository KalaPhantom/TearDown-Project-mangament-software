using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
        #endregion



        #region Change Name of the task
        private void taskcard_name_lbl_Click(object sender, EventArgs e)
        {
            change_task_name_txbx.Visible = true;
            taskcard_name_lbl.Text = change_task_name_txbx.Text;
            change_task_name_txbx.Visible = false;
        }
        #endregion
    }
}
