using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

namespace SPO_course_project.Model
{
    public class Memory
    {
        public string BankLabel { get; set; }
        public string Capacity { get; set; }
        public string Speed { get; set; }

        public Memory(ManagementObject queryObj)
        {
            this.BankLabel = queryObj["BankLabel"].ToString();
            this.Capacity = Math.Round( System.Convert.ToDouble(queryObj["Capacity"])/1024/1024/1024).ToString() + " Gb";
            this.Speed = queryObj["Speed"].ToString();
        }
    }

    public class MemoryBanks
    {
        public List<Memory> banksList;

        public MemoryBanks()
        {
            banksList = new List<Memory>();
        }
    }

    public static class MemoryData
    {
        public delegate void MyEvent(MemoryBanks myList);
        public static MyEvent EventHandler;
    }
}
