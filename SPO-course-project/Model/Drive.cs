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
                this.Capacity = Math.Round(System.Convert.ToDouble(queryObj["Capacity"]) / 1024 / 1024 / 1024).ToString() + " Gb";
                this.Caption = queryObj["Caption"].ToString();
                this.DriveLetter = queryObj["DriveLetter"].ToString();
                this.DriveType = queryObj["DriveType"].ToString();
                this.FileSystem = queryObj["FileSystem"].ToString();
                this.FreeSpace = Math.Round(System.Convert.ToDouble(queryObj["FreeSpace"]) / 1024 / 1024 / 1024).ToString() + " Gb";
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
