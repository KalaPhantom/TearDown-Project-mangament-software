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
        #endregion

        private void Save_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            Delete_card = true;
            DialogResult= DialogResult.OK;
            Close();
        }
    }
}
