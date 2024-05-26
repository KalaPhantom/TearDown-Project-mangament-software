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
using TearDown_Project_mangament_software.Systems;

namespace TearDown_Project_mangament_software.floating_dialogues
{
    public partial class Add_name : Form
    {
        public Add_name()
        {
            InitializeComponent();
        }

        public static int Current_selected_column;

        public string TaskName {
            get; set;
        }
        

        public string NewName 
        {
            get { return nameBox.Text; }
            set { nameBox.Text = value; }
        }
        
           
        

        public DateTime dateTime { get; set; }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool isNAmeOK = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Task name should not be empty");
                
                return;
            }
            else
            {
                
                NameValidator(NewName, TaskName, dateTime);
                if (isNAmeOK == true)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.No;
                }

            }
            
        }

        public void NameValidator(string name, string prevName, DateTime date)
        {
            
            int indexToRemove;
            if (Temp.taskCardColumn_1.ContainsKey(name) || Temp.taskCardColumn_2.ContainsKey(name) || Temp.taskCardColumn_3.ContainsKey(name) || Temp.taskCardColumn_4.ContainsKey(name))
            {
                MessageBox.Show($"A task with the name of {name} already exist");
                isNAmeOK = false ;

            }
            else
            {
                isNAmeOK = true;
                switch (Current_selected_column)
                {

                    case 1:
                        indexToRemove = Temp.taskCardColumn_1.IndexOfKey(prevName);
                        Temp.taskCardColumn_1.RemoveAt(indexToRemove);
                        Temp.taskCardColumn_1.Add(name, date);
                        break;

                    case 2:
                        indexToRemove = Temp.taskCardColumn_2.IndexOfKey(prevName);
                        Temp.taskCardColumn_2.RemoveAt(indexToRemove);
                        Temp.taskCardColumn_2.Add(name, date);
                        break;

                    case 3:
                        indexToRemove = Temp.taskCardColumn_3.IndexOfKey(prevName);
                        Temp.taskCardColumn_3.RemoveAt(indexToRemove);
                        Temp.taskCardColumn_3.Add(name, date);
                        break;

                    case 4:
                        indexToRemove = Temp.taskCardColumn_4.IndexOfKey(prevName);
                        Temp.taskCardColumn_4.RemoveAt(indexToRemove);
                        Temp.taskCardColumn_4.Add(name, date);
                        break;
                }
                //int indexToRemove = taskCardColumn_1.IndexOfKey(prevName);
                //taskCardColumn_1.RemoveAt(indexToRemove);
                //taskCardColumn_1.Add(name, date);
            }
        }
    }
}
