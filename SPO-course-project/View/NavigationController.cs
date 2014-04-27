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
        private CPUPage pag2;
        private GraphicsPage pag3;
        private MemoryPage pag4;
        private OSPage pag5;
        private ProcessesPage pag6;
        private SoftPage pag7;
        private SoundPage pag8;
        private VolumesPage pag9;

        private NavigationController()
        {
            pag1 = new MainPage();
            pag2 = new CPUPage();
            pag3 = new GraphicsPage();
            pag4 = new MemoryPage();
            pag5 = new OSPage();
            pag6 = new ProcessesPage();
            pag7 = new SoftPage();
            pag8 = new SoundPage();
            pag9 = new VolumesPage();

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

        public CPUPage cpuPage
        {
            get { return pag2; }
        }

        public GraphicsPage graphicsPage
        {
            get { return pag3; }
        }

        public MemoryPage memoryPage
        {
            get { return pag4; }
        }

        public OSPage osPage
        {
            get { return pag5; }
        }

        public ProcessesPage processesPage
        {
            get { return pag6; }
        }

        public SoftPage softPage
        {
            get { return pag7; }
        }

        public SoundPage soundPage
        {
            get { return pag8; }
        }

        public VolumesPage volumesPage
        {
            get { return pag9; }
        }
    }
}
