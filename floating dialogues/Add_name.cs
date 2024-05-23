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

namespace TearDown_Project_mangament_software.floating_dialogues
{
    public partial class Add_name : Form
    {
        public Add_name()
        {
            InitializeComponent();
        }

        public string TaskName
        {
            get { return nameBox.Text; }
            set { nameBox.Text = value; }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBox.Text) || string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Task name should not be empty");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
