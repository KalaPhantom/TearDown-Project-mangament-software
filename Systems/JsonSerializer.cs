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
        // This will contain all data properties to be stored in an object when serializing and deserializing all object properties 

        // Name of the task card object
        public string taskName { get; set; }

        // Task Descriptio
        public string taskDescription { get; set; }

        // Object reference for the priority level
        public string taskPriorityLevel { get; set; }

        // Ignore due (referenec)
        public bool ignoreDeadline { get; set; }

        // Due date 
        public DateTime dueDate { get; set; }

        // Task card header color
        public Color taskCardColor { get; set; }

        // A state marker (Bool) wheather the user missed a deadline
        public bool missedDeadLine { get; set; }

        // A property weather the user is done doing a certain task

        public string TaskState { get;set; } 



    }
    
}
