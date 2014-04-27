using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

using SPO_course_project.Model;

namespace SPO_course_project.Controller
{
    public class Parser
    {
        public static void processParser(ManagementObjectSearcher searcher)
        {
            Processes myList = new Processes();

            foreach (ManagementObject instance in searcher.Get())
            {
                Process currentItem = new Process(instance["Name"].ToString());
                myList.processList.Add(currentItem);              
            }
            Data.EventHandler(myList);
        }
    }
}
