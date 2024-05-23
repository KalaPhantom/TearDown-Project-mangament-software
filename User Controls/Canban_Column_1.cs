using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.Classes_dex;
using TearDown_Project_mangament_software.floating_dialogues;


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


        public Canban_Column_1()
        {
            InitializeComponent();
        }

        #region Add task button event
        private void add_task_btn_Click(object sender, EventArgs e)
        {
            TaskCards taskCards = new TaskCards();
            taskCards_flowlayoutPanel.Controls.Add(taskCards);
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





        // Validates user inputs - Unimplemented codes starts here
        #region Save,Load and validate data

       

      

        // Unimplemented Data structure
        // TODO: Improve all codes from here
     

       


        #endregion

        private void Canban_Column_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
