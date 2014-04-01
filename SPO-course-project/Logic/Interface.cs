using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Management;

namespace SPO_course_project.Logic
{
    public interface IArOperation
    {
        ManagementObjectSearcher getProcessList();
    }

    class GetPrpcessInfo : IArOperation
    {
        public virtual ManagementObjectSearcher getProcessList()
        {
        ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2","Select Name, CommandLine From Win32_Process");
        return searcher;
    }

            /*foreach (ManagementObject instance in searcher.Get())
            {
                Console.WriteLine("{0}", instance["Name"]);
            }
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);*/
       
    }
}
