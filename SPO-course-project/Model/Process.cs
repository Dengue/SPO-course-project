using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPO_course_project.Model
{
    public class Process
    {
        public string ProcessName { get; set; }

        public Process(string name)
        {
            this.ProcessName = name;
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

    public static class Data
    {
        public delegate void MyEvent(Processes myList);
        public static MyEvent EventHandler;
    }


}
