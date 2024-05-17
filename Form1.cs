using TearDown_Project_mangament_software.Forms;

namespace TearDown_Project_mangament_software
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();

            // Shows the first dashboard form
            dashboard = new Dashboard();
            dashboard.FormClosed += Dashboard_FormClosed;
            dashboard.MdiParent = this;
            dashboard.Show();
            dashboard.Dock = DockStyle.Fill;
        }


        /// Initialization of all forms
        KanbanList_form kanbanlist_form;
        Dashboard dashboard;


        /// <summary>
        /// 
        /// </summary>>
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolPanel21_Load(object sender, EventArgs e)
        {

        }

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
            else{
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
            //Main_panel2.Controls.Clear();
            //Dashboard frm = new Dashboard();
            //frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            //Main_panel2.Controls.Add(frm);
            //frm.Show();

            if (dashboard == null)
            {
                dashboard = new Dashboard();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.MdiParent = this;
                dashboard.Show();
                dashboard.Dock = DockStyle.Fill;
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
    }
}
