using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPO_course_project.Model
{
    public class Item
    {
        public string ItemName { get; set; }
        public string InstallDate { get; set; }

        public Item(string name, string date)
        {
            this.ItemName = name;
            this.InstallDate = date;
        }
    }

    public class Soft
    {
        public List<Item> softList;

        public Soft()
        {
            softList = new List<Item>();
        }
    }

    public static class SoftData
    {
        public delegate void MyEvent(Soft myList);
        public static MyEvent EventHandler;
    }
}
