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
using System.Collections;
using TearDown_Project_mangament_software.Classes_dex;

namespace TearDown_Project_mangament_software.Forms
{
    public partial class KanbanList_form : Form
    {
        public KanbanList_form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// data Containers temporary
        /// </summary>
        /// 

        private int IndexOfColumn = 0;

        private const string DataPath = "KanbanColumn_data.json";
        private void KanbanList_form_Load(object sender, EventArgs e)
        {

        }


        #region Add
        private void Add_table_btn_Click(object sender, EventArgs e)
        {
            Canban_Column canbanColumn = new Canban_Column();
            taskColumn_flowlayoutpanel.Controls.Add(canbanColumn);
            canbanColumn.Kanban_index++;
        }
        #endregion

       


    }
}
