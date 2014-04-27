using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPO_course_project.View
{
    class NavigationController
    {
        private static NavigationController pagelist = null;

        private MainPage pag1;

        private NavigationController()
        {
            pag1 = new MainPage();
        }

        public static NavigationController GetInstance()
        {
            if (pagelist == null)
                pagelist = new NavigationController();
            return pagelist;
        }
        public MainPage page1
        {
            get { return pag1; }
        }

    }
}
