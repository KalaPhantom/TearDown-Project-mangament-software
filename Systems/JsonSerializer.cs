using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using TearDown_Project_mangament_software.User_Controls;

namespace TearDown_Project_mangament_software.Systems
{
    class JsonSerializer
    {
    }


    // Data model for Kanban Column
    public class KanbanColumndata
    {
        public  List<KanbanCardData> column1 { get ; set; } = new List<KanbanCardData> ();
        public  List<KanbanCardData> column2 { get; set; } = new List<KanbanCardData>();

        public  List<KanbanCardData> column3 { get; set; } = new List<KanbanCardData>();
        public  List<KanbanCardData> column4 { get; set; } = new List<KanbanCardData>();
    } 

    public class KanbanCardData
    {
        // Data model for Kanban Card
        public string taskName { get; set; }
        public string taskDescription { get; set; }
        public string taskPriorityLevel { get; set; }
        public bool ignoreDeadline { get; set; }
        public DateTime dueDate { get; set; }
        public Color taskCardColor { get; set; }

        public bool missedDeadLine { get; set; }
    }
    
}
