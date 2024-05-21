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
        public TaskCard_modify_form()
        {
            InitializeComponent();
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
            Fld_DateandTimePicker timePicker = new Fld_DateandTimePicker();
            timePicker.ShowDialog();
        }
        #endregion
    }
}
