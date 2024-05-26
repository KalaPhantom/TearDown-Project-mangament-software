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

        //public static int Current_selected_column;

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

        //public static void NameValidator(string name, string prevName, DateTime date)
        //{
        //    int indexToRemove;
        //    if (taskCardColumn_1.ContainsKey(name))
        //    {
        //        MessageBox.Show($"A task with the name of {name} already exist");
                
        //    }
        //    else
        //    {
        //        switch (Current_selected_column){

        //            case 1:
        //                indexToRemove = taskCardColumn_1.IndexOfKey(prevName);
        //                taskCardColumn_1.RemoveAt(indexToRemove);
        //                taskCardColumn_1.Add(name, date);
        //                break;

        //            case 2:
        //                indexToRemove = taskCardColumn_2.IndexOfKey(prevName);
        //                taskCardColumn_2.RemoveAt(indexToRemove);
        //                taskCardColumn_2.Add(name, date);
        //                break;

        //            case 3:
        //                indexToRemove = taskCardColumn_3.IndexOfKey(prevName);
        //                taskCardColumn_3.RemoveAt(indexToRemove);
        //                taskCardColumn_4.Add(name, date);
        //                break;

        //            case 4:
        //                indexToRemove = taskCardColumn_4.IndexOfKey(prevName);
        //                taskCardColumn_4.RemoveAt(indexToRemove);
        //                taskCardColumn_4.Add(name, date);
        //                break;
        //        }
        //        //int indexToRemove = taskCardColumn_1.IndexOfKey(prevName);
        //        //taskCardColumn_1.RemoveAt(indexToRemove);
        //        //taskCardColumn_1.Add(name, date);
        //    }
        //}

        

        
        public static void UpdateDate(string taskName, DateTime due, int index)
        {
            int indexToRemove;

            switch (index)
            {
                case 1:
                    indexToRemove = taskCardColumn_1.IndexOfKey(taskName);
                    taskCardColumn_1.RemoveAt(indexToRemove);
                    taskCardColumn_1.Add(taskName, due);
                    break;

                case 2:
                    indexToRemove = taskCardColumn_2.IndexOfKey(taskName);
                    taskCardColumn_2.RemoveAt(indexToRemove);
                    taskCardColumn_2.Add(taskName, due);
                    break;

                case 3:
                    indexToRemove = taskCardColumn_3.IndexOfKey(taskName);
                    taskCardColumn_3.RemoveAt(indexToRemove);
                    taskCardColumn_3.Add(taskName, due);
                    break;

                case 4:
                    indexToRemove = taskCardColumn_4.IndexOfKey(taskName);
                    taskCardColumn_4.RemoveAt(indexToRemove);
                    taskCardColumn_4.Add(taskName, due);
                    break;
            }
             
        }


     

    }
}
