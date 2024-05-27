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

namespace TearDown_Project_mangament_software.floating_dialogues
{
    public partial class KanbanColumn_modify_form : Form
    {
        public KanbanColumn_modify_form()
        {
            InitializeComponent();
        }

        // Public fields
        //public string Column_name;
        //public Color color_up = Color.FromArgb(252, 187, 109); // Header
        //public Color color_center = Color.FromArgb(70, 252, 187, 109); // Form container

        #region properties
        public string Column_name
        {
            get { return modify_column_tbx.Text; }
            set { modify_column_tbx.Text = value; }
        }

        public Color color_up
        {
            get { return Column_color_pb.BackColor; }
            set {  Column_color_pb.BackColor = value;}

        }
        public Color color_center { get; set; }

        public bool missedTask { get; set; }
        #endregion



        private void Save_btn_Click(object sender, EventArgs e)
        {
            Column_name = modify_column_tbx.Text;

            // Invoke the previous instance of the class
            //Canban_Column_1.kanban_column_name = Column_name;
            DialogResult = DialogResult.OK;
            Close();
        }

        #region Color modification
        private void color1_btn_Click(object sender, EventArgs e)
        {
            color_up = Color.FromArgb(252, 107, 109);
            color_center = Color.FromArgb(70, 252, 187, 109);
        }

        private void color2_btn_Click(object sender, EventArgs e)
        {
            color_up = Color.FromArgb(216, 115, 127);
            color_center = Color.FromArgb(70, 216, 115, 127);
        }

        private void color3_btn_Click(object sender, EventArgs e)
        {
            color_up = Color.FromArgb(171, 108, 130);
            color_center = Color.FromArgb(70, 171, 108, 130);
        }

        private void color4_btn_Click(object sender, EventArgs e)
        {
            //71, 92, 122
            color_up = Color.FromArgb(71, 92, 122);
            color_center = Color.FromArgb(70, 71, 92, 122);
        }

        private void color5_btn_Click(object sender, EventArgs e)
        {
            //241, 140, 142
            color_up = Color.FromArgb(241, 140, 142);
            color_center = Color.FromArgb(70, 241, 140, 142);
        }

        private void color6_btn_Click(object sender, EventArgs e)
        {
            //240, 183, 164
            color_up = Color.FromArgb(240, 183, 164);
            color_center = Color.FromArgb(70, 240, 183, 164);
        }

        private void color7_btn_Click(object sender, EventArgs e)
        {
            //86, 142, 166
            color_up = Color.FromArgb(86, 142, 166);
            color_center = Color.FromArgb(70, 86, 142, 166);
        }

        private void color8_btn_Click(object sender, EventArgs e)
        {
            //48, 95, 114
            color_up = Color.FromArgb(48, 95, 114);
            color_center = Color.FromArgb(48, 95, 114);
        }
        #endregion
    }
}
