using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace WFZ_Editor.Extentions
{
    public static class ExceptionsExtentions
    {
        private static EventLog _eventLog = new EventLog("Application");

        public static void ShowError(this Exception exception)
        {
#if DEBUG
            Debug.WriteLine(exception.Message, "Error");
#else
            _eventLog.WriteEntry(exception.Message, EventLogEntryType.Error);
#endif

            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
