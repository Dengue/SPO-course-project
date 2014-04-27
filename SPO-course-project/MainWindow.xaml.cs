using System.Management;
using System.Windows;

using SPO_course_project.Logic;
using SPO_course_project.Model;
using SPO_course_project.Controller;

namespace SPO_course_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IArOperation Interface = new ImplementationClass();
            ManagementObjectSearcher proc;
            proc = Interface.getProcessList();
            Processes myList = Parser.processParser(proc);          
        }
     
    }
}
