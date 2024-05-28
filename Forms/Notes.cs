using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
namespace Notes3
{
    public partial class Notes_ : Form
    {
        private class Data
        {
            public string Title { get; set; }//this set the Title of the note
            public string Notes { get; set; }//Get and set the main notes
        }
        List<Data> rows = new List<Data>();//To list the rows in the datagridview
        public static DataTable notes = new DataTable();//get the title and the notes
        bool editing = false;//for editing the title andf the notes
        public Notes_()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");//Add and set the title to the data table
            notes.Columns.Add("Note");//add and set the notes to the data table

            if (File.Exists("datanotes.json"))//check if the file is existing
            {
                var filejson = File.ReadAllText("datanotes.json");//read the files to deserialize
                var storage = JsonSerializer.Deserialize<List<Data>>(filejson);//deserialize the file 

                if (storage != null)//check if the file is null
                {
                    foreach (var item in storage)//get the variables in the file 
                    {
                        notes.Rows.Add(item.Title, item.Notes);//add the variable to the DataTable to present in the gridview
                    }
                }
            }

            previousnotes.DataSource = notes;//to show the data to the grid view
        }


        /// <summary>
        /// Bossssss, may bug ohhhhhhhhh ___________________________________________________________________________________________________________
        /// </summary>
    
        private void DeleteBtn_Click(object sender, EventArgs e)//delete the value to the gridview
        {
            try
            {
                // TODO: Exception handling here
                notes.Rows[previousnotes.CurrentCell.RowIndex].Delete();//delte the selected item in tthe grid view and the nnotes
            }
            catch (System.NullReferenceException ) { MessageBox.Show("Not a valid note"); }//if there's no notes
        }
        private void LoadBtn_Click(object sender, EventArgs e)//load the btn to the textboxes 
        {
            if (previousnotes.CurrentCell != null)//check if the notes is empty
            {
                TxtBxTitle.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[0].ToString();//load the title to the title text box
                TxtBxNotes.Text = notes.Rows[previousnotes.CurrentCell.RowIndex].ItemArray[1].ToString();//load the notes to the notes text box

                editing = true;//set the editing to true to change the values of the selected variable on the gridview 
            }
        }
        private void NewNotesBtn_Click(object sender, EventArgs e)//set the loaded variable to empty
        {
            //txtbxtitle.text = "";
            //txtbxnotes.text = "";

            //  Save All functions 

            foreach (DataRow row in notes.Rows)//get the values of the rows
            {
                if (row.RowState != DataRowState.Deleted)//check if the row is not empty and the rows are not deleted
                {
                    rows.Add(new Data
                    {
                        Title = row["Title"].ToString(),
                        Notes = row["Note"].ToString()
                    });//set the title and the notes to string and save it to the list
                }
            }

            var option = new JsonSerializerOptions();

            option.WriteIndented = true;//this id the option that make the variables on the json file readable

            string json = JsonSerializer.Serialize(rows, option);//serialize the variables on the row
            File.WriteAllText("datanotes.json", json);//write the variable to the json file
        }

        private void SaveBtn_Click(object sender, EventArgs e)//save the variable to tthe grid view and set it to the notes or the DataTable
        {
            if (editing)//if the editing is true the title and notes will be changed 
            {
                notes.Rows[previousnotes.CurrentCell.RowIndex]["Title"] = TxtBxTitle.Text;
                notes.Rows[previousnotes.CurrentCell.RowIndex]["Note"] = TxtBxNotes.Text;

            }
            else //if the editing is false the title on the textbox and the note will be saved to the DataTable
            {
                notes.Rows.Add(TxtBxTitle.Text, TxtBxNotes.Text);

                

               

            }
            TxtBxTitle.Text = "";//Automatically set the text boxes to blank
            TxtBxNotes.Text = "";
            editing = false;//set the editing to false
        }

        private void previousnotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)//not really needed just accidentally clicked
        {

        }

        private void previousnotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//if the user double clicked the row the selected row will be seen to the text boxes
        {
            if (e.RowIndex >= 0 && e.RowIndex < notes.Rows.Count)
            {
                TxtBxTitle.Text = notes.Rows[e.RowIndex]["Title"].ToString();
                TxtBxNotes.Text = notes.Rows[e.RowIndex]["Note"].ToString();
                editing = true;
            }
        }

        private void Exitbtn_Click(object sender, EventArgs e)//if the user exit the software the rows on data grid will be saved to the json file
        {

            foreach (DataRow row in notes.Rows)//get the values of the rows
            {
                if (row.RowState != DataRowState.Deleted)//check if the row is not empty and the rows are not deleted
                {
                    rows.Add(new Data
                    {
                        Title = row["Title"].ToString(),
                        Notes = row["Note"].ToString()
                    });//set the title and the notes to string and save it to the list
                }
            }

            var option = new JsonSerializerOptions();

            option.WriteIndented = true;//this id the option that make the variables on the json file readable

            string json = JsonSerializer.Serialize(rows, option);//serialize the variables on the row
            File.WriteAllText("datanotes.json", json);//write the variable to the json file

            Environment.Exit(Environment.ExitCode);//exit to the code
        }

        private void button1_Click(object sender, EventArgs e)//Actually wala tong kwenta di ko alam kung bat ko to nilagay
        {
            this.Hide();//hide the form
            this.WindowState = FormWindowState.Normal;//idk
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void DoSaveFunction()
        {
           

           
        }
    }
}
/* This features save the notes of the user. You can set the title of the notes and the main notes to this. You can save, deleta, and set as new note.
 * This feature use a json file that save the existing variaable to it.
 * 
 * Errors encountered:
 * * I set the wrong syntax
 * * set the main code to .net framework
 * *having a big problem on how to save to the json
 * *to many logical error(one time yung column ang na dagdag ehh dapat yung rows)
  */
