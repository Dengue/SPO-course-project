using System.Management;
using System.Windows;

using SPO_course_project.Controller;

namespace SPO_course_project.Logic
{
    interface IArOperation
    {
        void getProcessList();
        void getSoftInfo();
        ManagementObjectSearcher getServiceInfo();
        void getOSInfo();
        void getDrivesInfo();
        ManagementObjectSearcher getNetworkInfo();
        void getGraphicsInfo();
        void getProcessorInfo();
        void getMemoryInfo();
    }

    class ImplementationClass : IArOperation
    {
        void IArOperation.getProcessList()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","Select Name, CommandLine From Win32_Process");
            Parser.processParser(searcher);
        }       

        void IArOperation.getSoftInfo()
        {
            ManagementObjectSearcher searcher_soft = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Product");
            Parser.softParser(searcher_soft);
        }

        ManagementObjectSearcher IArOperation.getServiceInfo()
        {
            ManagementObjectSearcher searcher_service = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Service");
            return searcher_service;
        }

        void IArOperation.getOSInfo()
        {
            ManagementObjectSearcher searcher_OS = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_OperatingSystem");
            Parser.osParser(searcher_OS);
        }

        void IArOperation.getDrivesInfo()
        {
            ManagementObjectSearcher searcher_Drives = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");
            Parser.driveParser(searcher_Drives);
        }

        ManagementObjectSearcher IArOperation.getNetworkInfo()
        {
            ManagementObjectSearcher searcher_NET = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapterConfiguration");
            return searcher_NET;
        }

        void IArOperation.getGraphicsInfo()
        {
            ManagementObjectSearcher searcher_Graphics = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            Parser.graphicsParser(searcher_Graphics);
        }

        void IArOperation.getProcessorInfo()
        {
            ManagementObjectSearcher searcher_Processor = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            Parser.cpuParser(searcher_Processor);
        }

        void IArOperation.getMemoryInfo()
        {
            ManagementObjectSearcher searcher_Memory = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            Parser.memoryParser(searcher_Memory);
        }
    }

}
