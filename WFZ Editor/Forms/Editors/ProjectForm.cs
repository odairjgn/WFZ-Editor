using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFZ_Engine.ValueObjects.Project;

namespace WFZ_Editor.Forms.Editors
{
    public partial class ProjectForm : Form
    {
        Project _project = new Project();

        public ProjectForm()
        {
            InitializeComponent();
        }

        private void tvProject_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Tag?.ToString())
            {
                case "PROJECT":
                    pgPropriedades.SelectedObject = _project;
                    break;
                case "RESOURCES":
                    pgPropriedades.SelectedObject = null;
                    break;
                default:
                    pgPropriedades.SelectedObject = null;
                    break;
            }
        }
    }
}
