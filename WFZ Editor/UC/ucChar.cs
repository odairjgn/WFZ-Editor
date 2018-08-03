using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFZ_Editor.UC
{
    public partial class ucChar : UserControl
    {
        private char _char;

        public ucChar()
        {
            InitializeComponent();
        }

        private void LoadControls()
        {
            lbChar.Text = Char.ToString();
            lbHex.Text = ((int)Char).ToString("X4");
        }

        public char Char
        {
            get => _char;
            set
            {
                _char = value;
                LoadControls();
            }
        }

        public Image Image
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        private void btOpc_Click(object sender, EventArgs e)
        {
            if(ofdImage.ShowDialog() != DialogResult.OK) return;

            pictureBox1.Image = Image.FromFile(ofdImage.FileName);
        }
    }
}
