using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TearDown_Project_mangament_software.User_Controls;

namespace TearDown_Project_mangament_software.Systems
{
    class Notification_Sytsem
    {

        public UserControl[] CardContainer1; // for first column
        public TaskCards[] taskCardsContainer_1;

        public static void Store_Container_obj()
        {
            Canban_Column_1 canban_Column_1 = new Canban_Column_1();

        }
        public static void Notification_Alert_Provider(DateTime date_due)
        {
            if (date_due >= DateTime.Now)
            {

            }
        }






    }
}
