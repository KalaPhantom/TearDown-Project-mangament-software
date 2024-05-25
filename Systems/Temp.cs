using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearDown_Project_mangament_software.Systems
{
    class Temp
    {

        #region Temporary Storage 
        public static SortedList taskCardColumn_1 = new SortedList();
        public static SortedList taskCardColumn_2 = new SortedList();
        public static SortedList taskCardColumn_3 = new SortedList();
        public static SortedList taskCardColumn_4 = new SortedList();
        #endregion


        /// <summary>
        /// This methods will be invoked when a new data is modified from the Cards
        /// </summary
        /// 

        public static void NameValidator(string name, string prevName, DateTime date)
        {
            if (taskCardColumn_1.ContainsKey(name))
            {
                MessageBox.Show($"A task with the name of {name} already exist");
            }
            else
            {
                int indexToRemove = taskCardColumn_1.IndexOfKey(prevName);
                taskCardColumn_1.RemoveAt(indexToRemove);
                taskCardColumn_1.Add(name, date);
            }
        }

        

        
        public static void UpdateDate(string taskName, DateTime due)
        { 
                int indexToRemove = taskCardColumn_1.IndexOfKey(taskName);
                taskCardColumn_1.RemoveAt(indexToRemove);
            taskCardColumn_1.Add(taskName, due);
        }


     

    }
}
