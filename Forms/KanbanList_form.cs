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
        private int Kanban_board_count = 0;

        private int IndexOfColumn = 0;

        private const string DataPath = "KanbanColumn_data.json";
        private void KanbanList_form_Load(object sender, EventArgs e)
        {

        }


        #region Add
        private void Add_table_btn_Click(object sender, EventArgs e)
        {

            //Canban_Column_1 canbanColumn = new Canban_Column_1();
            //taskColumn_flowlayoutpanel.Controls.Add(canbanColumn);
            Kanban_board_count++;
            switch (Kanban_board_count)
            {
                case 1:
                    Canban_Column_1 canban_Column_1 = new Canban_Column_1();  
                    taskColumn_flowlayoutpanel.Controls.Add(canban_Column_1);
                    break;

                case 2:
                    Canban_Column_2 canban_Column_2 = new Canban_Column_2();
                    taskColumn_flowlayoutpanel.Controls.Add(canban_Column_2);
                    break;

                case 3: 
                    Canban_Column_3 canban_Column_3 = new Canban_Column_3();
                    taskColumn_flowlayoutpanel.Controls.Add(canban_Column_3);
                    break;

                case 4: 
                    Canban_Column_4 canban_Column_4 = new Canban_Column_4();
                    taskColumn_flowlayoutpanel.Controls.Add(canban_Column_4);
                    break;


                default:
                    // Temporary message
                    MessageBox.Show("You exceed the board limit");
                    break;
            }
            
        }
        #endregion

       


    }
}
