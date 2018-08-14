using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WFZ_Editor.UC
{
    [DefaultEvent("ColorChanged")]
    public partial class custom8cColorPicker : UserControl
    {
        public event EventHandler ColorChanged;

        private Color _color = Color.Black;
        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                btColor.BackColor = value;
                txtColor.Text = $"{value.R:X2}{value.G:X2}{value.B:X2}{value.A:X2}";
                OnColorChanged();
                Invalidate();
            }
        }

        public bool SolidColorOnly
        {
            get => dialog.SolidColorOnly;
            set => dialog.SolidColorOnly = value;
        }

        public custom8cColorPicker()
        {
            InitializeComponent();
        }

        private void btColor_Click(object sender, EventArgs e)
        {
            if(dialog.ShowDialog() != DialogResult.OK) return;
            Color = dialog.Color;
        }

        protected virtual void OnColorChanged()
        {
            ColorChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
