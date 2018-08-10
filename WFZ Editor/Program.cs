using System;
using System.Windows.Forms;
using WFZ_Editor.Forms;
using WFZ_Editor.Forms.Test;

namespace WFZ_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if false
            Application.Run(new TestF());
#else
            Application.Run(new MainWindow());
#endif
        }
    }
}
