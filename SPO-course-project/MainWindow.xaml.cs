using System.Management;
using System.Windows;
using System.Windows.Navigation;

using SPO_course_project.Logic;
using SPO_course_project.Model;
using SPO_course_project.Controller;
using SPO_course_project.View;

namespace SPO_course_project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.page1);

            /*ProcessData.EventHandler = new ProcessData.MyEvent(toDataGrid);
            SoftData.EventHandler = new SoftData.MyEvent(toDataGrid);
            DrivesData.EventHandler = new DrivesData.MyEvent(toDataGrid);
            GraphicData.EventHandler = new GraphicData.MyEvent(toDataGrid);
            MemoryData.EventHandler = new MemoryData.MyEvent(toDataGrid);
            CPUData.EventHandler = new CPUData.MyEvent(toDataGrid);
            OSData.EventHandler = new OSData.MyEvent(toDataGrid);

            InitializeComponent();

            Processes myList = new Processes();
            IArOperation Interface = new ImplementationClass();
            //Interface.getProcessList();
            //Interface.getSoftInfo();
            //Interface.getDrivesInfo();
            //Interface.getGraphicsInfo();
            //Interface.getMemoryInfo();
            //Interface.getProcessorInfo();
            Interface.getOSInfo();*/

        }


        /*public void toDataGrid(Processes myList)
        {            
            dataGrid1.ItemsSource = myList.processList;
        }

        public void toDataGrid(Soft myList)
        {
            dataGrid1.ItemsSource = myList.softList;
        }

        public void toDataGrid(Drives myList)
        {
            dataGrid1.ItemsSource = myList.drivesList;
        }

        public void toDataGrid(GraphicAdapters myList)
        {
            dataGrid1.ItemsSource = myList.adptersList;
        }

        public void toDataGrid(MemoryBanks myList)
        {
            dataGrid1.ItemsSource = myList.banksList;
        }

        public void toDataGrid(CPUList myList)
        {
            dataGrid1.ItemsSource = myList.cpuList;
        }

        public void toDataGrid(OSList myList)
        {
            dataGrid1.ItemsSource = myList.osList;
        }*/
    }
}
