using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

namespace SPO_course_project.Model
{
    public class Process
    {
        public string ProcessName { get; set; }

        public Process(ManagementObject queryObj)
        {
            this.ProcessName = queryObj["Name"].ToString();
        }
    }

    public class Processes
    {
        public List<Process> processList;

        public Processes()
        {
            processList = new List<Process>();
        }
    }

    public static class ProcessData
    {
        public delegate void MyEvent(Processes myList);
        public static MyEvent EventHandler;
    }


}
