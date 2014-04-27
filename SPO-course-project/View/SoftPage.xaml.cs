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
    /// Логика взаимодействия для SoftPage.xaml
    /// </summary>
    public partial class SoftPage : Page
    {
        IArOperation Interface = new ImplementationClass();

        public SoftPage()
        {
            SoftData.EventHandler = new SoftData.MyEvent(toDataGrid);

            InitializeComponent();
        }

        private void graphics_click(object sender, RoutedEventArgs e)
        {
            Interface.getGraphicsInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.graphicsPage);
        }

        private void cpuButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getProcessorInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.cpuPage);
        }

        private void drivesButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getDrivesInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.volumesPage);
        }

        private void memoryButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getMemoryInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.memoryPage);
        }

        private void osButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getOSInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.osPage);
        }

        private void processesButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getProcessList();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.processesPage);
        }

        private void softButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getSoftInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.softPage);
        }

        private void soundButton_Click(object sender, RoutedEventArgs e)
        {
            Interface.getSoundInfo();
            NavigationController Singleton = NavigationController.GetInstance();
            this.NavigationService.Navigate(Singleton.soundPage);
        }

        public void toDataGrid(Soft myList)
        {
            dataGrid1.ItemsSource = myList.softList;
        }
    }
}
