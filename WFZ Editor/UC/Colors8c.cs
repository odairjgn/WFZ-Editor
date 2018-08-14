using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFZ_Engine.Extentions;

namespace WFZ_Editor.UC
{
    [DefaultEvent("ColorChanged")]
    public partial class Colors8c : UserControl
    {
        public event EventHandler ColorChanged;

        private Color _value = Color.Transparent;

        public Color Value
        {
            get => _value;
            private set
            {
                _value = value;
                OnColorChanged();
            }
        }

        public Colors8c()
        {
            InitializeComponent();
            var colors = BitMapExtentions.Palette8C;
            foreach (var color in colors)
            {
                var bt = new Button() { Text = $@"{color.R:X2}{color.G:X2}{color.B:X2}{color.A:X2}", Tag = color, BackColor = color, ForeColor = color.GetBlackOrWhite()};
                bt.Click += Bt_Click;
                flpColors.Controls.Add(bt);
            }

            var colort = Color.Transparent;
            var btt = new Button() { Text = $@"Transp.", Tag = colort, BackColor = colort };
            flpColors.Controls.Add(btt);
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            var bt = sender as Button;
            Value = bt?.Tag is Color c ? c : Color.Transparent;
        }

        protected virtual void OnColorChanged()
        {
            ColorChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
