using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SPO_course_project.Model
{
    public class OS
    {
        public string Name { get; set; }
        public string BuildNumber { get; set; }
        public string Caption { get; set; }
        public string FreePhysicalMemory { get; set; }
        public string FreeVirtualMemory { get; set; }
        public string OSType { get; set; }
        public string RegisteredUser { get; set; }
        public string SerialNumber { get; set; }
        public string ServicePackMajorVersion { get; set; }
        public string ServicePackMinorVersion { get; set; }
        public string SystemDevice { get; set; }
        public string SystemDirectory { get; set; }
        public string SystemDrive { get; set; }
        public string Version { get; set; }
        public string WindowsDirectory { get; set; }

        public OS(ManagementObject queryObj)
        {
            this.Name = queryObj["Name"].ToString();
            this.BuildNumber = queryObj["BuildNumber"].ToString();
            this.Caption = queryObj["Caption"].ToString();
            this.FreePhysicalMemory = queryObj["FreePhysicalMemory"].ToString();
            this.FreeVirtualMemory = queryObj["FreeVirtualMemory"].ToString();
            this.OSType = queryObj["OSType"].ToString();
            this.RegisteredUser = queryObj["RegisteredUser"].ToString();
            this.SerialNumber = queryObj["SerialNumber"].ToString();
            this.ServicePackMajorVersion = queryObj["ServicePackMajorVersion"].ToString();
            this.ServicePackMinorVersion = queryObj["ServicePackMinorVersion"].ToString();
            this.SystemDevice = queryObj["SystemDevice"].ToString();
            this.SystemDirectory = queryObj["SystemDirectory"].ToString();
            this.SystemDrive = queryObj["SystemDrive"].ToString();
            this.Version = queryObj["Version"].ToString();
            this.WindowsDirectory = queryObj["WindowsDirectory"].ToString();
        }
    }

    public class OSList
    {
        public List<OS> osList;

        public OSList()
        {
            osList = new List<OS>();
        }
    }

    public static class OSData
    {
        public delegate void MyEvent(OSList myList);
        public static MyEvent EventHandler;
    }
}
