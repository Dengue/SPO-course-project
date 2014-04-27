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
            Data.EventHandler = new Data.MyEvent(toDataGrid);   

            InitializeComponent();
            Processes myList = new Processes();
            IArOperation Interface = new ImplementationClass();
            Interface.getProcessList();
        }


        public void toDataGrid(Processes myList)
        {            
            dataGrid1.ItemsSource = myList.processList;
        }
    }
}
