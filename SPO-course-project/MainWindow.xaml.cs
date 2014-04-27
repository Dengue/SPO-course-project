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
        }
    }
}
