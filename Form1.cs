using TearDown_Project_mangament_software.Forms;

namespace TearDown_Project_mangament_software
{
    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            Main_panel2.Controls.Clear();
            KanbanList_form frm = new KanbanList_form();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            Main_panel2.Controls.Add(frm);
            frm.Show();
        }

        #endregion
    }
}
