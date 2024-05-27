using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.Forms;

namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class DashboardContentCard : UserControl
    {

        public string TaskName
        {
            get { return this.Task_name_lbl.Text; }
            set { Task_name_lbl.Text = value; }

        }
        public Color TaskColor
        {
            get { return this.ColorDisplay_pb.BackColor; }
            set { this.ColorDisplay_pb.BackColor = value; }
        }

        public string PriortyLevel
        {
            get { return this.Priority_lvl_lbl.Text; }
            set { Priority_lvl_lbl.Text = "Priority Level: " + value; }
        }

        public DateTime dateTime { get; set; }

        public string Description { get; set; }


        public bool IgnorDeadline { get; set; }



        public DashboardContentCard()
        {
            InitializeComponent();
            Due_lbl.Text = this.dateTime.ToString();
        }

        private void Timer_ticker_l_Tick(object sender, EventArgs e)
        {

        }

        #region Time Attribute update 
        private void task_atr_timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = this.dateTime - DateTime.Now;

            if (this.IgnorDeadline == true)
            {
                Status_color_pb.BackColor = Color.YellowGreen;

            }
            else
            {
                if (timeSpan.TotalSeconds <= 0)
                {
                    Status_color_pb.BackColor = Color.Red;


                }
                else if (timeSpan.TotalDays >= 1)
                {
                    Status_color_pb.BackColor = Color.Orange;


                }
                else
                {
                    Status_color_pb.BackColor = Color.Green;


                }
            }
        }

        #endregion

        private void DashboardContentCard_Click(object sender, EventArgs e)
        {
            Dashboard.Description_box.Text = Environment.NewLine + Description;
        }
    }
}
