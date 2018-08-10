using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WFZ_Editor.Forms.Test
{
    public class Class1 : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, System.IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            //Foo foo = value as Foo;
            //if (svc != null && foo != null)
            //{
            //    using (FooForm form = new FooForm())
            //    {
            //        form.Value = foo.Bar;
            //        if (svc.ShowDialog(form) == DialogResult.OK)
            //        {
            //            foo.Bar = form.Value; // update object
            //        }
            //    }
            //}
            return value; // can also replace the wrapper object here
        }
    }
}
