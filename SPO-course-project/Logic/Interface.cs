using System.Management;

namespace SPO_course_project.Logic
{
    interface IArOperation
    {
        ManagementObjectSearcher getProcessList();
        ManagementObjectSearcher getSoftInfo();
        ManagementObjectSearcher getServiceInfo();
        ManagementObjectSearcher getOSInfo();
        ManagementObjectSearcher getDrivesInfo();
        ManagementObjectSearcher getNetworkInfo();
        ManagementObjectSearcher getGraphicsInfo();
        ManagementObjectSearcher getProcessorInfo();
        ManagementObjectSearcher getMemoryInfo();
    }

    class ImplementationClass : IArOperation
    {
        ManagementObjectSearcher IArOperation.getProcessList()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","Select Name, CommandLine From Win32_Process");
            return searcher;
        }       

        ManagementObjectSearcher IArOperation.getSoftInfo()
        {
            ManagementObjectSearcher searcher_soft = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Product");
            return searcher_soft;
        }

        ManagementObjectSearcher IArOperation.getServiceInfo()
        {
            ManagementObjectSearcher searcher_service = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Service");
            return searcher_service;
        }

        ManagementObjectSearcher IArOperation.getOSInfo()
        {
            ManagementObjectSearcher searcher_OS = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_OperatingSystem");
            return searcher_OS;
        }

        ManagementObjectSearcher IArOperation.getDrivesInfo()
        {
            ManagementObjectSearcher searcher_Drives = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Volume");
            return searcher_Drives;
        }

        ManagementObjectSearcher IArOperation.getNetworkInfo()
        {
            ManagementObjectSearcher searcher_NET = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapterConfiguration");
            return searcher_NET;
        }

        ManagementObjectSearcher IArOperation.getGraphicsInfo()
        {
            ManagementObjectSearcher searcher_Graphics = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            return searcher_Graphics;
        }

        ManagementObjectSearcher IArOperation.getProcessorInfo()
        {
            ManagementObjectSearcher searcher_Processor = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            return searcher_Processor;
        }

        ManagementObjectSearcher IArOperation.getMemoryInfo()
        {
            ManagementObjectSearcher searcher_Memory = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PhysicalMemory");
            return searcher_Memory;
        }
    }

}
