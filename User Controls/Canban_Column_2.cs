﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.floating_dialogues;
using TearDown_Project_mangament_software.Systems;
using System.Threading;


namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class Canban_Column_2 : UserControl
    {

        public const int Column_number = 2;


        public Canban_Column_2()
        {
            InitializeComponent();
            LoadDatafromColumn2();
            LoadCards();
        }

    
        #region properties
        public FlowLayoutPanel myFlP
        {
            get { return taskCards_flowlayoutPanel; }
        }
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
        #endregion

        #region modify_column 
        private void modify_column_btn_Click_1(object sender, EventArgs e)
        {
            //KanbanColumn_modify_form modify = new KanbanColumn_modify_form();
            //modify.ShowDialog();

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

                    SaveDatafromColumn2();
                }

            }
        }
        #endregion

        #region Add task
        public int cardCount = 0;
        private void add_task_btn_Click_1(object sender, EventArgs e)
        {
            //TaskCards taskCards = new TaskCards();
            //taskCards_flowlayoutPanel.Controls.Add(taskCards);

            TaskCards taskCards = new TaskCards();
            taskCards.ColumnNumber = Column_number;
            taskCards.TaskName = $"Task {cardCount++}";
            taskCards.ignoreDeadline = true;
            taskCards_flowlayoutPanel.Controls.Add(taskCards);
            Temp.taskCardColumn_2.Add(taskCards.TaskName, taskCards.dateTime);
        }
        #endregion


        #region Json Methods
        /// <summary>
        /// 
        /// </summary>
        public static void PassDatafromColumn2()
        {

                // Converts all data from a list to an object
                var columnData = new KanbanColumndata
                {
                    column2 = saveCardData_fromColumn2()
                };

                // The object is then passed here to serialized all files
                string jsonString = JsonConvert.SerializeObject(columnData, Formatting.Indented);
            File.WriteAllText(@"KanbanColumn2_data.json", jsonString);
        }

        private static List<KanbanCardData> saveCardData_fromColumn2()
        {
            List<KanbanCardData> temp = new List<KanbanCardData>();

            foreach (TaskCards cards in taskCards_flowlayoutPanel.Controls)
            {
                var cardsToStore = new KanbanCardData()
                {
                    taskName = cards.TaskName,
                    taskCardColor = cards.taskColor,
                    taskDescription = cards.taskDescription,
                    dueDate = cards.dateTime, // prev name due 
                    taskPriorityLevel = cards.prioritylevel,
                    ignoreDeadline = cards.ignoreDeadline,
                    missedDeadLine = cards.missedDeadline,
                    TaskState = cards.TaskState,
                    
                    
                };

                temp.Add(cardsToStore);
            }

            return temp;
        }

        #endregion

        #region DragDrop event
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

        private void taskCards_flowlayoutPanel_MouseDown(object sender, MouseEventArgs e)
        {
            TaskCards a = sender as TaskCards;
        }

        #endregion

        #region Json Deserializer
        public static void LoadCards()
        {
            if (File.Exists("KanbanColumn2_data.json"))
            {
                string jsonString = File.ReadAllText("KanbanColumn2_data.json");
                var boardData = JsonConvert.DeserializeObject<KanbanColumndata>(jsonString);

                LoadCards_to_flp(taskCards_flowlayoutPanel, boardData.column2);
                Thread.Sleep(500);
            }
            //Thread.Sleep(500);

        }

        private static void LoadCards_to_flp(FlowLayoutPanel flp, List<KanbanCardData> taskCards)
        {
            foreach (var obj in taskCards)
            {
                AddCardToPanel(flp, obj.taskName, obj.taskDescription, obj.taskPriorityLevel, obj.dueDate, obj.taskCardColor, obj.ignoreDeadline, obj.missedDeadLine, obj.TaskState);
            }
        }

        private static void AddCardToPanel(FlowLayoutPanel panelHolder, string taskName, string taskDescription, string priorityLevel, DateTime timeAndDate, Color task_Color, bool ignoreDeadline, bool missed_Deadline, string taskState)
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
                missedDeadline = missed_Deadline,
                TaskState = taskState,

            };
            panelHolder.Controls.Add(card);
        }
        #endregion

        #region Column Data Serializer and Deserializer

        private void SaveDatafromColumn2()
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
            File.WriteAllText(@"Column2_data.json", json);
        }

        private void LoadDatafromColumn2()
        {
            if (File.Exists(@"Column2_data.json"))
            {
                string jsonString = File.ReadAllText(@"Column2_data.json");
                var boardData = JsonConvert.DeserializeObject<Column_data_ref>(jsonString);
                this.kanban_column_name = boardData.Name;
                this.Column_color_top = boardData.color_top;
                this.Column_color_bottom = boardData.color_bottom;
                this.BackColor = boardData.color_bottom;
                taskCards_flowlayoutPanel.BackColor = boardData.color_bottom;
            }
        }
        #endregion

    }
}
