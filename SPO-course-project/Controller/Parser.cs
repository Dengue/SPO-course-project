using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows;

using SPO_course_project.Model;

namespace SPO_course_project.Controller
{
    public class Parser
    {
        public static void processParser(ManagementObjectSearcher searcher)
        {
            Processes myList = new Processes();

            foreach (ManagementObject instance in searcher.Get())
            {
                Process currentItem = new Process(instance);
                myList.processList.Add(currentItem);              
            }
            ProcessData.EventHandler(myList);
        }


        public static void softParser(ManagementObjectSearcher searcher)
        {
            Soft myList = new Soft();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Item currentItem = new Item(queryObj["Caption"].ToString(), queryObj["InstallDate"].ToString());
                myList.softList.Add(currentItem);
            }
            SoftData.EventHandler(myList);
        }


        public static void driveParser(ManagementObjectSearcher searcher)
        {
            Drives myList = new Drives();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Drive currentItem = new Drive(queryObj);
                myList.drivesList.Add(currentItem);
            }
            DrivesData.EventHandler(myList);
        }

        public static void graphicsParser(ManagementObjectSearcher searcher)
        {
            GraphicAdapters myList = new GraphicAdapters();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Adapter currentItem = new Adapter(queryObj);
                myList.adptersList.Add(currentItem);
            }
            GraphicData.EventHandler(myList);
        }

        public static void memoryParser(ManagementObjectSearcher searcher)
        {
            MemoryBanks myList = new MemoryBanks();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Memory currentItem = new Memory(queryObj);
                myList.banksList.Add(currentItem);
            }
            MemoryData.EventHandler(myList);
        }

        public static void cpuParser(ManagementObjectSearcher searcher)
        {
            CPUList myList = new CPUList();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                CPU currentItem = new CPU(queryObj);
                myList.cpuList.Add(currentItem);
            }
            CPUData.EventHandler(myList);
        }

        public static void osParser(ManagementObjectSearcher searcher)
        {
            OSList myList = new OSList();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                OS currentItem = new OS(queryObj);
                myList.osList.Add(currentItem);
            }
            OSData.EventHandler(myList);
        }

        public static void soundParser(ManagementObjectSearcher searcher)
        {
            SoundAdapters myList = new SoundAdapters();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                Sound currentItem = new Sound(queryObj);
                myList.adptersList.Add(currentItem);
            }
            SoundData.EventHandler(myList);
        }
    }
}
