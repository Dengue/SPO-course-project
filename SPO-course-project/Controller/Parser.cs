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
        public static Processes processParser(ManagementObjectSearcher searcher)
        {
            Processes myList = new Processes();
            Process currentItem = new Process("empty");
            foreach (ManagementObject instance in searcher.Get())
            {
                currentItem.name = instance["Name"].ToString();
                myList.processList.Add(currentItem);
                MessageBox.Show(myList.processList.Last().name);
            }
            return myList;
        }
    }
}
