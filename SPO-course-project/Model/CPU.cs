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
        public string AddressWidth { get; set; }
        public string Architecture { get; set; }
        public string Availability { get; set; }
        public string Caption { get; set; }
        public string CpuStatus { get; set; }
        public string CreationClassName { get; set; }
        public string CurrentClockSpeed { get; set; }
        public string CurrentVoltage { get; set; }
        public string ErrorCleared { get; set; }
        public string ExtClock { get; set; }
        public string Family { get; set; }
        public string L2CacheSize { get; set; }
        public string L2CacheSpeed { get; set; }
        public string L3CacheSize { get; set; }
        public string L3CacheSpeed { get; set; }
        public string LoadPercentage { get; set; }
        public string Manufacturer { get; set; }
        public string MaxClockSpeed { get; set; }
        public string NumberOfLogicalProcessors { get; set; }

        public CPU(ManagementObject queryObj)
        {
            this.Name = queryObj["Name"].ToString();
            this.NumberOfCores = queryObj["NumberOfCores"].ToString();
            this.ProcessorId = queryObj["ProcessorId"].ToString();
            this.AddressWidth = queryObj["AddressWidth"].ToString();
            this.Architecture = queryObj["Architecture"].ToString();
            this.Caption = queryObj["Caption"].ToString();
            this.CpuStatus = queryObj["CpuStatus"].ToString();
            this.CreationClassName = queryObj["CreationClassName"].ToString();
            this.CurrentClockSpeed = queryObj["CurrentClockSpeed"].ToString();
            this.CurrentVoltage = queryObj["CurrentVoltage"].ToString();
            this.ExtClock = queryObj["ExtClock"].ToString();
            this.L2CacheSize = queryObj["L2CacheSize"].ToString();
            this.L3CacheSize = queryObj["L3CacheSize"].ToString();
            this.LoadPercentage = queryObj["LoadPercentage"].ToString();
            this.Manufacturer = queryObj["Manufacturer"].ToString();
            this.MaxClockSpeed = queryObj["MaxClockSpeed"].ToString();
            this.NumberOfLogicalProcessors = queryObj["NumberOfLogicalProcessors"].ToString();
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

