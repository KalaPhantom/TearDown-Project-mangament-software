using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.Forms;

namespace TearDown_Project_mangament_software.Setting_Form
{
    public partial class Reminder_settngs : Form
    {


        public int Reminder_Interval { get; set; }
        public Reminder_settngs()
        {
            InitializeComponent();
        }

        #region Button modify 
        private void rdb_30_min_CheckedChanged(object sender, EventArgs e)
        {
            Reminder_Interval = 1800000;
            Dashboard._thread_interval = Reminder_Interval;
        }
        #endregion

        private void rdb_1hr_CheckedChanged(object sender, EventArgs e)
        {
            Reminder_Interval = 3600000;
            Dashboard._thread_interval = Reminder_Interval;
        }

        private void rdb_2hr_CheckedChanged(object sender, EventArgs e)
        {
            Reminder_Interval = 7200000;
            Dashboard._thread_interval = Reminder_Interval;
        }

        private void rdb_3hr_CheckedChanged(object sender, EventArgs e)
        {
            Reminder_Interval = 10800000;
            Dashboard._thread_interval = Reminder_Interval;
        }

        private void rdb_4hr_CheckedChanged(object sender, EventArgs e)
        {
            Reminder_Interval = 14400000;
            Dashboard._thread_interval = Reminder_Interval;
        }

        private void rdb_5hr_CheckedChanged(object sender, EventArgs e)
        {
            Reminder_Interval = 18000000;
            Dashboard._thread_interval = Reminder_Interval;
        }
    }
}
