using Notes3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.Setting_Form;

namespace TearDown_Project_mangament_software.floating_dialogues
{
    public partial class Kanban_icon_form : Form
    {

        
        public Kanban_icon_form()
        {
            InitializeComponent();


            // Initialize the about as the first heading form
            about = new About();
            about.FormClosed += About_FormClosed;
            about.MdiParent = this;
            about.Show();
            about.Dock = DockStyle.Fill;
        }


        #region Load Instances
        About about;
        Reminder_settngs reminder;
        #endregion

        #region
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void About_btn_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new About();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Show();
                about.Dock = DockStyle.Fill;

            }
            else
            {
                about.Activate();
            }
        }

        private void About_FormClosed(object? sender, FormClosedEventArgs e)
        {
            about = null;
        }

        private void Preferences_btn_Click(object sender, EventArgs e)
        {
            if (reminder == null)
            {
                reminder = new Reminder_settngs();
                reminder.FormClosed += Reminder_FormClosed;
                reminder.MdiParent = this;
                reminder.Show();
                reminder.Dock = DockStyle.Fill;

            }
            else
            {
                reminder.Activate();
            }
        }

        private void Reminder_FormClosed(object? sender, FormClosedEventArgs e)
        {
            reminder = null;
        }
    }
}
