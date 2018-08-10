using System.Windows.Forms;
using WFZ_Editor.Forms.Editors;

namespace WFZ_Editor.Forms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fontManagerToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new FontManager() { MdiParent = this };
            form.Show();
        }

        private void fontEditorToolStripMenuItem_Click_1(object sender, System.EventArgs e)
        {
            var form = new FontEditor() { MdiParent = this };
            form.Show();
        }

        private void newProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            var form = new ProjectForm() { MdiParent = this };
            form.Show();
        }
    }
}
