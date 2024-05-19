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
    public partial class Canban_Column : UserControl
    {
        public Canban_Column()
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
            KanbanColumn_modify_form modify = new KanbanColumn_modify_form();
            modify.Show();
        }
        #endregion

        #region temporary data containers;

        // Implement a permanent storage
        private string task_name { get;set; }
        #endregion


        #region Canban_column load
        private void Canban_Column_Load(object sender, EventArgs e)
        {
            task_name = Task_name_label.Text;
        }
        #endregion
    }
}
