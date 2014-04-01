using System.Management;

namespace SPO_course_project.Logic
{
    public interface IArOperation
    {
        ManagementObjectSearcher getProcessList();
        ManagementObjectSearcher getSoftInfo();
    }

    class GetPropcessInfo : IArOperation
    {
        public virtual ManagementObjectSearcher getProcessList()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","Select Name, CommandLine From Win32_Process");
            return searcher;
        }       
    }

    class GetSoftInfo : IArOperation
    {
        public virtual ManagementObjectSearcher getSoftInfo()
        {
            ManagementObjectSearcher searcher_soft = new ManagementObjectSearcher("root\\CIMV2","SELECT * FROM Win32_Product");
            return searcher_soft;
        }
    }

}
