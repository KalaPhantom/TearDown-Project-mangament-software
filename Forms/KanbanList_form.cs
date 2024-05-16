using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.User_Controls;

namespace TearDown_Project_mangament_software.Forms
{
    public partial class KanbanList_form : Form
    {
        public KanbanList_form()
        {
            InitializeComponent();
        }

        private void KanbanList_form_Load(object sender, EventArgs e)
        {

        }

        private void Add_table_btn_Click(object sender, EventArgs e)
        {
            Canban_Column canbanColumn = new Canban_Column();
            taskColumn_flowlayoutpanel.Controls.Add(canbanColumn);  
        }
    }
}
