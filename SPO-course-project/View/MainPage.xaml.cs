using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using SPO_course_project.Logic;
using SPO_course_project.Model;
using SPO_course_project.Controller;
using SPO_course_project.View;

namespace SPO_course_project.View
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        IArOperation Interface = new ImplementationClass();

        public MainPage()
        {
            ProcessData.EventHandler = new ProcessData.MyEvent(toDataGrid);
            SoftData.EventHandler = new SoftData.MyEvent(toDataGrid);
            DrivesData.EventHandler = new DrivesData.MyEvent(toDataGrid);
            GraphicData.EventHandler = new GraphicData.MyEvent(toDataGrid);
            MemoryData.EventHandler = new MemoryData.MyEvent(toDataGrid);
            CPUData.EventHandler = new CPUData.MyEvent(toDataGrid);
            OSData.EventHandler = new OSData.MyEvent(toDataGrid);
            SoundData.EventHandler = new SoundData.MyEvent(toDataGrid);

            InitializeComponent();
        }


        private void graphics_click(object sender, RoutedEventArgs e)
        {
            Interface.getGraphicsInfo();
        }

        private void cpuButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getProcessorInfo();
        }

        private void drivesButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getDrivesInfo();
        }

        private void memoryButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getMemoryInfo();
        }

        private void osButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getOSInfo();
        }

        private void processesButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getProcessList();
        }

        private void softButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getSoftInfo();
        }

        //-----------------------------------------------------//

        public void toDataGrid(Processes myList)
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
        }

        public void toDataGrid(SoundAdapters myList)
        {
            dataGrid1.ItemsSource = myList.adptersList;
        }

        private void soundButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getSoundInfo();
        }
    }

}
