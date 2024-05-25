using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TearDown_Project_mangament_software.floating_dialogues
{
    public partial class Fld_DateandTimePicker : Form
    {


        public DateTime dateTime { get; set; }
        public DateOnly dateOnly { get; set; }
        public TimeOnly timeOnly { get; set; }



        public Fld_DateandTimePicker()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            date_display.Text = monthCalendar1.SelectionRange.ToString();
            dateTimePicker1.Value = e.Start;
            dateTime = monthCalendar1.SelectionRange.Start;
            

         
        }

        private void date_display_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTime = dateTimePicker1.Value;
            //monthCalendar1.SelectionStart = dateTimePicker1.Value;
            date_display.Text = monthCalendar1.SelectionRange.ToString();
           
        }
    }
}
