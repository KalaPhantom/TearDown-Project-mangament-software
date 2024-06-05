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
    public partial class Set_as_ : Form
    {
        public Set_as_()
        {
            InitializeComponent();
            selected_ignoreDeadline_txt.Text = "Selected: No";
            Ignore_Deadline = false;
        }

        #region property

        // this might have some bits of problem
        public bool Delete_card { get; set; }

        // Additional Card properties
        public bool Ignore_Deadline
        {
            get; set;
        }

        public string Priority_level { get; set; }

        public string Mark_as { get; set; }
        #endregion

        private void Save_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            Delete_card = true;
            DialogResult = DialogResult.OK;
            Close();
        }


        #region Priority Level of the task Cards control
        /// <summary>
        /// 
        /// </summary>
        private void top_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Priority_level = "top";
        }

        private void mid_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Priority_level = "mid";
        }

        private void none_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Priority_level = "none";
        }
        #endregion


        #region deadline Ignore control
        // When the user wants to ignore the deadline
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Ignore_Deadline = true;
            selected_ignoreDeadline_txt.Text = "Selected: Yes";
        }

        private void ignoreDealine_false_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Ignore_Deadline = false;
            selected_ignoreDeadline_txt.Text = "Selected: No";
        }
        #endregion


        #region Task State radio button control

        // Mark as done
        private void Done_del_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Mark_as = "done";
        }

        private void done_del_btn_CheckedChanged(object sender, EventArgs e)
        {
            Mark_as = "done_del";
        }

        private void done_and_move_to_arch_rdv_CheckedChanged(object sender, EventArgs e)
        {
            Mark_as = "done_move_arcv";
        }

        private void Doing_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Mark_as = "doing";
        }
        #endregion
    }
}
