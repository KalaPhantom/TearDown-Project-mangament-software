using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using TearDown_Project_mangament_software.User_Controls;
using System.Threading;
using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TearDown_Project_mangament_software.Forms
{
    public partial class Dashboard : Form
    {

        ConcurrentBag<TaskCards> taskCards = new ConcurrentBag<TaskCards>();

        public int missedTAsk = 0;
        public int upcoming = 0;

        public Dashboard()
        {
            InitializeComponent();
            Timer_update_1.Start();


            UpdateElelements_in_bg.RunWorkerAsync();
            timer_populate_flp.Start();

        }

        public List<TaskCards> Task_cards = new List<TaskCards>();

        private void upcomingTask_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public int missedTask { get; set; }
        public int upcommingTask { get; set; }




        #region Json Deserializer Funtions 


        #endregion

        #region Counter
        private void Counter()
        {


            int missedTask = 0; // Count
            int upcommingTask = 0; // Count

            //this.upcoming = upcoming;
            //this.missedTask = missedTask;

            foreach (TaskCards cards in Canban_Column_1.taskCards_flowlayoutPanel.Controls)
            {


                if (cards.missedDeadline == true)
                {
                    missedTask++;
                }
                else
                {
                    upcommingTask++;
                }

            }

            foreach (TaskCards cards in Canban_Column_2.taskCards_flowlayoutPanel.Controls)
            {


                if (cards.missedDeadline == true)
                {
                    missedTask++;
                }
                else
                {
                    upcommingTask++;
                }

            }

            foreach (TaskCards cards in Canban_Column_3.taskCards_flowlayoutPanel.Controls)
            {

                if (cards.missedDeadline == true)
                {
                    missedTask++;
                }
                else
                {
                    upcommingTask++;
                }

            }

            foreach (TaskCards cards in Canban_Column_4.taskCards_flowlayoutPanel.Controls)
            {

                if (cards.missedDeadline == true)
                {
                    missedTask++;
                }
                else
                {
                    upcommingTask++;
                }

            }

            this.missedTask = missedTask;
            this.upcommingTask = upcommingTask;

        }
        #endregion

        private void Timer_update_1_Tick(object sender, EventArgs e)
        {

            Counter();
            Greeting_lbl.Text = GetTimeOfDay(DateTime.Now);
            upcoming_Counter_lbl.Text = this.upcommingTask.ToString();
            missed_Counter_lbl.Text = this.missedTask.ToString();

        }


        #region Populate the upcoming tasks

        public static bool executionOnce = true;

        public void PopulateTasksOn_flp()
        {


            if (executionOnce)
            {
                executionOnce = false;
                foreach (TaskCards cards in taskCards)
                {
                    TimeSpan tp = cards.dateTime - DateTime.Now;

                    if (tp.TotalSeconds > 0 && tp.TotalHours < 24)
                    {
                        DashboardContentCard newCards = new DashboardContentCard();
                        newCards.TaskName = String.Concat("Name: ", cards.TaskName);
                        newCards.dateTime = cards.dateTime;
                        newCards.TaskColor = cards.taskColor;
                        newCards.Description = cards.taskDescription;
                        newCards.PriortyLevel = cards.prioritylevel;
                        //upcoming_task_db_fLp.Controls.Add(newCards);
                        AddCardsToPanel(newCards);
                    }
                }
            }
            else
            {
                ClearCardsToPanel();

                foreach (TaskCards cards in taskCards)
                {
                    TimeSpan tp = cards.dateTime - DateTime.Now;
                    if (tp.TotalSeconds > 0 && tp.TotalHours < 24)
                    {
                        DashboardContentCard newCards = new DashboardContentCard();
                        newCards.TaskName = String.Concat("Name: ", cards.TaskName);
                        newCards.dateTime = cards.dateTime;
                        newCards.TaskColor = cards.taskColor;
                        newCards.Description = cards.taskDescription;
                        newCards.PriortyLevel = cards.prioritylevel;

                        //upcoming_task_db_fLp.Controls.Add(newCards);
                        AddCardsToPanel(newCards);
                    }
                }


                Thread.Sleep(2000);

            }
        }
        #endregion


        #region
        private void StoreCardData()
        {

            taskCards.Clear();
            foreach (TaskCards column1 in Canban_Column_1.taskCards_flowlayoutPanel.Controls)
            {
                //Task_cards.Add(column1);
                taskCards.Add(column1);
            }

            foreach (TaskCards column2 in Canban_Column_2.taskCards_flowlayoutPanel.Controls)
            {
                //Task_cards.Add(column2);
                taskCards.Add(column2);
            }

            foreach (TaskCards column3 in Canban_Column_3.taskCards_flowlayoutPanel.Controls)
            {
                //Task_cards.Add(column3);
                taskCards.Add(column3);
            }

            foreach (TaskCards column4 in Canban_Column_4.taskCards_flowlayoutPanel.Controls)
            {
                //Task_cards.Add(column4);
                taskCards.Add(column4);

            }
        }
        #endregion


        private void UpdateElelements_in_bg_DoWork(object sender, DoWorkEventArgs e)
        {

            StoreCardData();
            PopulateTasksOn_flp();


        }

        private void UpdateElelements_in_bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Main_form.current_status_onb.Text = "List Updated......";
            Main_form.toolStrip_progress_bar.Visible = false;
        }

        private void AddCardsToPanel(DashboardContentCard cards)
        {

            if (upcoming_task_db_fLp.InvokeRequired)
            {
                upcoming_task_db_fLp.Invoke(new Action<DashboardContentCard>(AddCardsToPanel), cards);
            }
            else
            {
                upcoming_task_db_fLp.Controls.Add(cards);
            }
        }

        private void ClearCardsToPanel()
        {

            if (upcoming_task_db_fLp.InvokeRequired)
            {
                upcoming_task_db_fLp.Invoke(new Action(ClearCardsToPanel));
            }
            else
            {
                upcoming_task_db_fLp.Controls.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                UpdateElelements_in_bg.RunWorkerAsync();
                Main_form.current_status_onb.Text = "Updating........";
                Main_form.toolStrip_progress_bar.Visible = true;
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("The Board is already updating in the background.... \n Pls Wait");
            }

        }

        private string GetTimeOfDay(DateTime dateTime)
        {
            int hour = dateTime.Hour;

            if (hour >= 5 && hour < 12)
            {
                return "Good Morning User";
            }
            else if (hour >= 12 && hour < 17)
            {
                return "Good Afternoon User";
            }
            else if (hour >= 17 && hour < 21)
            {
                return "Good Evening User";
            }
            else
            {
                return "Good Night User";
            }
        }


        // An iterative function that invokes whenever a timer control associated on it ticks (Per Milliseconds)
        private void timer_populate_flp_Tick(object sender, EventArgs e)
        {
            notifyIcon.BalloonTipTitle = $"Reminder you have {missedTask} missed task and {upcommingTask} upcoming task";
            notifyIcon.BalloonTipText = "This is your 4-hour reminder!";
            notifyIcon.ShowBalloonTip(3000);
        }
    }
}
