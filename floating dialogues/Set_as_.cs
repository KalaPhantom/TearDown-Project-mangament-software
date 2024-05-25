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


        #region Priority Level of the task Cards
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


        #region deadline Ignore
        // When the user wants to ignore the deadline
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Ignore_Deadline = true;
        }

        private void ignoreDealine_false_rdb_CheckedChanged(object sender, EventArgs e)
        {
            Ignore_Deadline = false;
        }
        #endregion
    }
}
