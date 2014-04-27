using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

namespace SPO_course_project.Model
{
    public class Sound
    {
        public string Caption { get; set; }

        public Sound(ManagementObject queryObj)
        {
            this.Caption = queryObj["Caption"].ToString();
        }
    }

    public class SoundAdapters
    {
        public List<Sound> adptersList;

        public SoundAdapters()
        {
            adptersList = new List<Sound>();
        }
    }

    public static class SoundData
    {
        public delegate void MyEvent(SoundAdapters myList);
        public static MyEvent EventHandler;
    }
}
