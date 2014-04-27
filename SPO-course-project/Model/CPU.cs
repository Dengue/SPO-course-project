using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SPO_course_project.Model
{
    public class CPU
    {
        public string Name { get; set; }
        public string NumberOfCores { get; set; }
        public string ProcessorId { get; set; }

        public CPU(ManagementObject queryObj)
        {
            this.Name = queryObj["Name"].ToString();
            this.NumberOfCores = queryObj["NumberOfCores"].ToString();
            this.ProcessorId = queryObj["ProcessorId"].ToString();
        }
    }

    public class CPUList
    {
        public List<CPU> cpuList;

        public CPUList()
        {
            cpuList = new List<CPU>();
        }
    }

    public static class CPUData
    {
        public delegate void MyEvent(CPUList myList);
        public static MyEvent EventHandler;
    }
}

