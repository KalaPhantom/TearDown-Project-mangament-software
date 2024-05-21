using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TearDown_Project_mangament_software.Classes_dex;
using TearDown_Project_mangament_software.floating_dialogues;


namespace TearDown_Project_mangament_software.User_Controls
{
    public partial class Canban_Column : UserControl
    {

        // Data model
        public int Kanban_index = 0;
        public string kanban_column_name = "HHA";
        public Color kanbanColor = Color.FromArgb(252,187,109);
        private const string DataPath = "KanbanColumn_data.json";

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
            modify.ShowDialog();
       

            
        }
        #endregion

        


        #region Canban_column load
        private void Canban_Column_Load(object sender, EventArgs e)
        {
        

        }
        #endregion


    


        // Validates user inputs
        #region Save,Load and validate data

        private void validate_and_Save_LocalData(string taskname, Color color, int index)
        {
            DataStates data = new DataStates();
            if (data.ColumName.Contains(taskname))
            {
                MessageBox.Show("The name already exist on the list... Please insert another one");
            }
            else
            {
                index++;
                data.ColumName.Add(taskname);
                data.ColumnIndex.Add(index);
                data.ColumnColor.Add(color);
            }
        }
        private void modifyLocaldata()
        {

        }

        private void Savedata()
        {
            DataStates data = new DataStates
            {
                ColumName = new List<string>(),
                ColumnColor = new List<Color>(),
                ColumnIndex = new List<int>()
            };

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions {WriteIndented = true } );
            File.WriteAllText(DataPath, json);
           
        }

        private void LoadData()
        {
            if (File.Exists(DataPath))
            {
                string json = File.ReadAllText(DataPath);

                // Deserialize the JSON string into a KanbanData object.
                DataStates data = JsonSerializer.Deserialize<DataStates>(json);

                if(data != null)
                {
                    // Populate the whole thing
                }
            }
        }

        #endregion
    }
}
