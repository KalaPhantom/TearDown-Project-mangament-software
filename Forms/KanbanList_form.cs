using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TearDown_Project_mangament_software.User_Controls;
using System.Collections;
using TearDown_Project_mangament_software.Classes_dex;
using System.Text.Json;
using TearDown_Project_mangament_software.Systems;
using Newtonsoft.Json;

namespace TearDown_Project_mangament_software.Forms
{
    public partial class KanbanList_form : Form
    {
        public KanbanList_form()
        {
            InitializeComponent();

            // Add all boards in the flow layout panel

            Canban_Column_1 canban_Column_1 = new Canban_Column_1();
            taskColumn_flowlayoutpanel.Controls.Add(canban_Column_1);
            

            Canban_Column_2 canban_Column_2 = new Canban_Column_2();
            taskColumn_flowlayoutpanel.Controls.Add(canban_Column_2);
            

            Canban_Column_3 canban_Column_3 = new Canban_Column_3();
            taskColumn_flowlayoutpanel.Controls.Add(canban_Column_3);
      

            Canban_Column_4 canban_Column_4 = new Canban_Column_4();
            taskColumn_flowlayoutpanel.Controls.Add(canban_Column_4);



        }



        /// <summary>
        /// data Containers temporary
        /// </summary>
        /// 
        public static int Kanban_board_count = 0;

        private int IndexOfColumn = 0;

        private const string DataPath = "KanbanColumn_data.json";
        private void KanbanList_form_Load(object sender, EventArgs e)
        {

        }

        #region GetCards from the panel
        
        #endregion

        #region Save the panel data from a Json File
        

        private List<KanbanCardData> GetCardsFromPanel(FlowLayoutPanel flp)
        {
            return flp.Controls.OfType<TaskCards>().Select(card => new KanbanCardData
            {
                taskName = card.TaskName,
                taskDescription = card.taskDescription
            }).ToList();
        }
        #endregion


        #region Json Deserializer

        


        #endregion

    }
}
