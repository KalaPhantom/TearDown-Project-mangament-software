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
using System.Threading;
using System.Security.Policy;
using TearDown_Project_mangament_software.Forms;


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

        public bool Del { get; set; }

        #endregion


        public static Thread savePer1;

        public Canban_Column_1()
        {
            InitializeComponent();
           
            LoadCards();
            LoadDatafromColun1();

            
            //savePer1 = new Thread(PassDatafromColumn1);
            //savePer1.Start();

        }

        #region Add task button event
        private void add_task_btn_Click(object sender, EventArgs e)
        {
            TaskCards taskCards = new TaskCards();
            taskCards.ColumnNumber = Columnn_number;
            taskCards.TaskName = $"Task {cardCount++}";
            taskCards.ignoreDeadline = true;
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
                    this.Column_color_bottom = kanban_modify.color_center;
                    this.BackColor = kanban_modify.color_center;
                    taskCards_flowlayoutPanel.BackColor = kanban_modify.color_center;

                    SaveDatafromColumn1();
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

        public static void PassDatafromColumn1()
        {
            // Passes all components extracted from all cards in the flowlayout panel from the form 
            // Converts all data from a list to an object
        var columnData = new KanbanColumndata
        {
            column1 = saveCardData_fromColumn1()
        };

            // The object is then passed here to serialized all files
            string jsonString = JsonConvert.SerializeObject(columnData, Formatting.Indented);
            File.WriteAllText(@"KanbanColumn1_data.json", jsonString);
            Thread.Sleep(500);
        }

        private static List<KanbanCardData> saveCardData_fromColumn1()
        {
            List<KanbanCardData> temp = new List<KanbanCardData>();

            foreach (TaskCards cards in taskCards_flowlayoutPanel.Controls)
            {
                var cardsToStore = new KanbanCardData()
                {
                    taskName = cards.TaskName,
                    taskCardColor = cards.taskColor,
                    taskDescription = cards.taskDescription,
                    dueDate = cards.dateTime,
                    taskPriorityLevel = cards.prioritylevel,
                    ignoreDeadline = cards.ignoreDeadline,
                    missedDeadLine = cards.missedDeadline
                };

                temp.Add(cardsToStore);
            }

            return temp;
        }
        #endregion

        #region leave column event
        private void Canban_Column_1_Leave(object sender, EventArgs e)
        {

        }
        #endregion

        #region Thread trigger function


        public static void Stop_Recording_thread()
        {
            
           
            Main_form.ThreadRun = false;
            

        }

        #endregion

        #region drag and drop event
        private void taskCards_flowlayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskCards)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void taskCards_flowlayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TaskCards)))
            {
                TaskCards taskCards = (TaskCards)e.Data.GetData(typeof(TaskCards));
                FlowLayoutPanel targetPanel = (FlowLayoutPanel)sender;
                targetPanel.Controls.Add(taskCards);
                taskCards.Location = targetPanel.PointToClient(new Point(e.X, e.Y));
            }
        }

        private void taskCards_flowlayoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TaskCards a = sender as TaskCards;
        }
        #endregion


        #region Json Deserializer

        public void PassPrevData_Column1()
        {

        }

        public static void LoadCards()
        {
            if (File.Exists("KanbanColumn1_data.json"))
            {
                string jsonString = File.ReadAllText("KanbanColumn1_data.json");
                var boardData = JsonConvert.DeserializeObject<KanbanColumndata>(jsonString);
               
                LoadCards_to_flp(taskCards_flowlayoutPanel, boardData.column1);
            }

            //Thread.Sleep(500);
            
        }

        public static void LoadCards_to_flp(FlowLayoutPanel flp, List<KanbanCardData> taskCards)
        {
            foreach (var obj in taskCards)
            {
                AddCardToPanel(flp, obj.taskName, obj.taskDescription, obj.taskPriorityLevel, obj.dueDate, obj.taskCardColor, obj.ignoreDeadline,obj.missedDeadLine);

            }
        }

        public static void AddCardToPanel(FlowLayoutPanel panelHolder, string taskName, string taskDescription, string priorityLevel, DateTime timeAndDate, Color task_Color, bool ignoreDeadline, bool missedDeadline)
        {

            if (taskName == "")
            {
                taskName = "Unamedtask";
            }

            TaskCards card = new TaskCards
            {

                TaskName = taskName,
                taskDescription = taskDescription,
                prioritylevel = priorityLevel,
                ignoreDeadline = ignoreDeadline,
                dateTime = timeAndDate,
                taskColor = task_Color,
                missedDeadline = missedDeadline

            };
            panelHolder.Controls.Add(card);
        }


        #endregion


        #region Column Data Serializer and Deserializer

        private void SaveDatafromColumn1()
        {
            string name = this.kanban_column_name;
            Color bottom = this.Column_color_bottom;
            Color top = this.Column_color_top;
            var column = new Column_data_ref()
            {
                Name = name,
                color_top = top,
                color_bottom = bottom
            };

            var settings = new JsonSerializerSettings
            {
                
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(column, settings);
            File.WriteAllText(@"Column1_data.json", json);
        }

        private void LoadDatafromColun1()
        {
            if (File.Exists(@"Column1_data.json"))
            {
                string jsonString = File.ReadAllText(@"Column1_data.json");
                var boardData = JsonConvert.DeserializeObject<Column_data_ref>(jsonString);
                this.kanban_column_name = boardData.Name;
                this.Column_color_top = boardData.color_top;
                this.Column_color_top = boardData.color_bottom;
                this.BackColor = boardData.color_bottom;
                taskCards_flowlayoutPanel.BackColor = boardData.color_bottom;
            }
        }
        #endregion
    }
}
