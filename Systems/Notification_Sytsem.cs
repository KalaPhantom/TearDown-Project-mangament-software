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

       
        public static void Notification_Alert_Provider(DateTime date_due)
        {
            if (date_due >= DateTime.Now)
            {

            }
        }

        private void Notify_system()
        {
            while (Main_form.ThreadRun == false)
            {

            }
        }






    }
}
