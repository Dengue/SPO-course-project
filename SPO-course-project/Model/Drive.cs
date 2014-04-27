using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SPO_course_project.Model
{
    public class Drive
    {
        public string Capacity { get; set; }
        public string Caption { get; set; }
        public string DriveLetter { get; set; }
        public string DriveType { get; set; }
        public string FileSystem { get; set; }
        public string FreeSpace { get; set; }

        public Drive(ManagementObject queryObj)
        {
            if (queryObj["Capacity"] != null)
            {
                this.Capacity = queryObj["Capacity"].ToString();
                this.Caption = queryObj["Caption"].ToString();
                this.DriveLetter = queryObj["DriveLetter"].ToString();
                this.DriveType = queryObj["DriveType"].ToString();
                this.FileSystem = queryObj["FileSystem"].ToString();
                this.FreeSpace = queryObj["FreeSpace"].ToString();
            }
        }
    }

    public class Drives
    {
        public List<Drive> drivesList;

        public Drives()
        {
            drivesList = new List<Drive>();
        }
    }

    public static class DrivesData
    {
        public delegate void MyEvent(Drives myList);
        public static MyEvent EventHandler;
    }
}
