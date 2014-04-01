using System.Management;
using System.Windows;

using SPO_course_project.Logic;

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
            GetPropcessInfo processInterface = new GetPropcessInfo();
            ManagementObjectSearcher proc;
            proc = processInterface.getProcessList();
            foreach (ManagementObject instance in proc.Get())
            {
                Text.Text += instance["Name"];
                Text.Text += "\n";
            }
        }
     
    }
}
