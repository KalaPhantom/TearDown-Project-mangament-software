using Notes3;
using TearDown_Project_mangament_software.floating_dialogues;
using TearDown_Project_mangament_software.Forms;
using TearDown_Project_mangament_software.User_Controls;
using WinFormsApp2;

namespace TearDown_Project_mangament_software
{
    public partial class Main_form : Form
    {


        public Main_form()
        {
            InitializeComponent();

            // Initialize all of the components of the Kanban List form
            kanbanlist_form = new KanbanList_form();
            kanbanlist_form.MdiParent = this;
            kanbanlist_form.Show();
            kanbanlist_form.Dock = DockStyle.Fill;

            // Shows the first dashboard form to initialize all of its components
            dashboard = new Dashboard();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
            current_status_onb.Text = "Welcome User";

            deadline_checker.Start();
        }

        #region Application Properties
        public static bool ThreadRun = true;

       


        #endregion


        /// Initialization of all forms
        KanbanList_form kanbanlist_form;
        Dashboard dashboard;
        WhiteBoard whiteboard;
        Notes_ notes;
        Kanban_icon_form icon_form;


        #region Split Container
        /// <summary>
        /// 
        /// </summary>>
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolPanel21_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Button Navigations

        /// <summary>
        /// Button Navigations
        /// </summary>

        private void Kanban_list_btn_Click(object sender, EventArgs e)
        {


            if (kanbanlist_form == null)
            {
                kanbanlist_form = new KanbanList_form();
                kanbanlist_form.FormClosed += Kanbanlist_form_FormClosed;
                kanbanlist_form.MdiParent = this;
                kanbanlist_form.Show();
                kanbanlist_form.Dock = DockStyle.Fill;
            }
            else
            {
                kanbanlist_form.Activate();
            }
        }

        // Occurs when the kanban list form is closed
        private void Kanbanlist_form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            kanbanlist_form = null;
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {

            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
                dashboard.Dock = DockStyle.None;
            }
            else
            {
                dashboard.Activate();
            }

        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            dashboard = null;
        }

        private void whiteboard_btn_Click(object sender, EventArgs e)
        {
            if (whiteboard == null)
            {
                whiteboard = new WhiteBoard();
                whiteboard.FormClosed += Whiteboard_FormClosed;
                whiteboard.MdiParent = this;
                whiteboard.Show();
                whiteboard.Dock = DockStyle.Fill;

            }
            else
            {
                whiteboard.Activate();
            }
        }

        private void Whiteboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            whiteboard = null;
        }

        private void notes_btn_Click(object sender, EventArgs e)
        {
            if (notes == null)
            {
                notes = new Notes_();
                notes.FormClosed += Notes_FormClosed;
                notes.MdiParent = this;
                notes.Show();
                notes.Dock = DockStyle.Fill;

            }
            else
            {
                notes.Activate();
            }
        }

        private void Notes_FormClosed(object? sender, FormClosedEventArgs e)
        {
            notes = null;
        }

        private void logo_button_Click(object sender, EventArgs e)
        {
            using (icon_form = new Kanban_icon_form())
            {
                if (icon_form.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void Icon_form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            icon_form = null;
        }

        #endregion

        #region Paint
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion


        #region Closing
        /// <summary>
        /// triggers when the user prompts the form for closing
        /// this is integral when saving all data across all components
        /// </summary>

        private void Main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            current_status_onb.Text = "Saving Changes . . . . . ";
            //Canban_Column_1.Stop_Recording_thread();
            Canban_Column_1.PassDatafromColumn1();
            Canban_Column_2.PassDatafromColumn2();
            Canban_Column_3.PassDatafromColumn3();
            Canban_Column_4.PassDatafromColumn4();

            Thread.Sleep(2000);
        }
        #endregion

        #region Timer 

        private void deadline_checker_Tick(object sender, EventArgs e)
        {

        }
        #endregion

        #region Bg worker
        /// <summary>
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Run_bg_processes_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
        #endregion


        
    }
}
