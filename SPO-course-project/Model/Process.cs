using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPO_course_project.Model
{
    public class Process
    {
        public string name { get; set; }
        public Process(string name)
        {
            this.name = name;
        }
    }

    public class Processes
    {
        public List<Process> processList { get; set; }

        public Processes()
        {
            processList = new List<Process>();
        }
    }


}
