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

namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class Canban_Column_2 : UserControl
    {
        public Canban_Column_2()
        {
            InitializeComponent();
        }

        // Default data models
        //public static int Kanban_index = 0;
        //public static string kanban_column_name = "Add name using the modify button";
        //public static Color kanbanColorTop = Color.FromArgb(252, 187, 109);
        //public static Color kanbanColorBottom = Color.FromArgb(252, 187, 109);

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
                    this.Column_color_top = kanban_modify.color_center;
                    this.BackColor = kanban_modify.color_center;
                    taskCards_flowlayoutPanel.BackColor = kanban_modify.color_center;
                }

            }
        }

        private void add_task_btn_Click_1(object sender, EventArgs e)
        {
            TaskCards taskCards = new TaskCards();
            taskCards_flowlayoutPanel.Controls.Add(taskCards);
        }
    }
}
