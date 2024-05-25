using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.Classes_dex;
using TearDown_Project_mangament_software.floating_dialogues;
using System.Collections;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using TearDown_Project_mangament_software.Systems;


namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class Canban_Column_1 : UserControl
    {

        // Default data models
        //public static int Kanban_index = 0;
        //public static string kanban_column_name = "Add name using the modify button";
        //public static Color kanbanColorTop = Color.FromArgb(252, 187, 109);
        //public static Color kanbanColorBottom = Color.FromArgb(252, 187, 109);

        #region properties


        public const int Columnn_number = 1;
        public string kanban_column_name
        {
            get { return Task_name_label.Text; }
            set { Task_name_label.Text = value; }
        }
        public Color Column_color_top
        {
            get { return panel1.BackColor; }
            set { panel1.BackColor = value; }
        }

        public Color Column_color_bottom
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        private int cardCount = 0;

        #endregion



        public Canban_Column_1()
        {
            InitializeComponent();
        }

        #region Add task button event
        private void add_task_btn_Click(object sender, EventArgs e)
        { 
            TaskCards taskCards = new TaskCards();
            taskCards.ColumnNumber = Columnn_number;
            taskCards.TaskName = $"Click here to add name {cardCount++}";
            taskCards_flowlayoutPanel.Controls.Add(taskCards);
            Temp.taskCardColumn_1.Add(taskCards.TaskName, taskCards.dateTime);
        }
        #endregion

        #region modify button event
        private void modify_column_btn_Click(object sender, EventArgs e)
        {
            using (KanbanColumn_modify_form kanban_modify = new KanbanColumn_modify_form())
            {
                kanban_modify.Column_name = this.kanban_column_name;
                kanban_modify.color_up = this.Column_color_top;
                kanban_modify.color_center = this.Column_color_bottom;


                if (kanban_modify.ShowDialog() == DialogResult.OK)
                {
                    this.kanban_column_name = kanban_modify.Column_name;
                    this.Column_color_top = kanban_modify.color_up;
                    this.Column_color_top = kanban_modify.color_center;
                    this.BackColor = kanban_modify.color_center;
                    taskCards_flowlayoutPanel.BackColor = kanban_modify.color_center;
                }

            }
        }

        #endregion


        #region Canban_column load
        private void Canban_Column_Load(object sender, EventArgs e)
        {

        }
        #endregion

      

        private void Canban_Column_Enter(object sender, EventArgs e)
        {
           
        }



        #region Json Methods

        // This methods includes all interconnections between the JsonSerializer.cs Class to ensure modularity
        
        public void PassDatafromColumn1()
        {
            // Passes all components extracted from all cards in the flowlayout panel from the form 

            // Converts all data from a list to an object
            var columnData = new KanbanColumndata
            {
                column1 = saveCardData_fromColumn1()
            };

            // The object is then passed here to serialized all files
            string jsonString = JsonConvert.SerializeObject(columnData, Formatting.Indented);
            File.WriteAllText("kanbanBoardData.json", jsonString);
          

        }

        public  List<KanbanCardData> saveCardData_fromColumn1()
        {
            List<KanbanCardData> temp = new List<KanbanCardData>();

            foreach (TaskCards cards in taskCards_flowlayoutPanel.Controls)
            {
                var cardsToStore = new KanbanCardData()
                {
                    taskName = cards.TaskName,
                    taskCardColor = cards.taskColor,
                    taskDescription = cards.taskDescription,
                    dueDate = cards.due,
                    taskPriorityLevel = cards.prioritylevel,
                    ignoreDeadline = cards.ignoreDeadline
                };
                temp.Add(cardsToStore);
            }

            return temp;
        }

   
        #endregion
    }
}
