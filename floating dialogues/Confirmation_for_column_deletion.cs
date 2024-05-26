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
    public partial class Confirmation_for_column_deletion : Form
    {
        public Confirmation_for_column_deletion()
        {
            InitializeComponent();
        }

        public bool deleteColumn { get; set; }

        private void Yes_btn_Click(object sender, EventArgs e)
        {
            deleteColumn = true;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void No_btn_Click(object sender, EventArgs e)
        {
            deleteColumn = false;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
