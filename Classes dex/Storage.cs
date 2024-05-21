using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;

namespace TearDown_Project_mangament_software.Classes_dex
{
    internal class Storage
    {
        public void StoreData()
        {

        }
    }
    /// <summary>
    /// A class for storage model
    /// </summary>
    class DataStates 
    { 
        public List<string> ColumName { get; set; } = new List<string>();
        public List<Color> ColumnColor { get; set; } = new List<Color>();
        public List<int> ColumnIndex { get; set; } = new List<int>();

       
    }

}
