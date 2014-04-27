using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

namespace SPO_course_project.Model
{
    public class Adapter
    {
        public string AdapterRAM { get; set; }
        public string Caption { get; set; }
        public string Description { get; set; }
        public string VideoProcessor { get; set; }

        public Adapter(ManagementObject queryObj)
        {
                this.AdapterRAM = queryObj["AdapterRAM"].ToString();
                this.Caption = queryObj["Caption"].ToString();
                this.Description = queryObj["Description"].ToString();
                this.VideoProcessor = queryObj["VideoProcessor"].ToString();
                MessageBox.Show(AdapterRAM);
        }
    }

    public class GraphicAdapters
    {
        public List<Adapter> adptersList;

        public GraphicAdapters()
        {
            adptersList = new List<Adapter>();
        }
    }

    public static class GraphicData
    {
        public delegate void MyEvent(GraphicAdapters myList);
        public static MyEvent EventHandler;
    }
}
