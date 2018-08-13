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
            get => picFull.Image;
            set => picFull.Image = value;
        }

        public Image Image8c
        {
            get => pic8c.Image;
            set => pic8c.Image = value;
        }

        private void btOpc_Click(object sender, EventArgs e)
        {
            if(ofdImage.ShowDialog() != DialogResult.OK) return;

            picFull.Image = Image.FromFile(ofdImage.FileName);

            var resp = MessageBox.Show("Convert and set this image to 8c version too?", "Quest", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resp == DialogResult.No) return;
            pic8c.Image = (picFull.Image as Bitmap).To8CPallet();
        }

        private void btOpc8c_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() != DialogResult.OK) return;
            var image = Image.FromFile(ofdImage.FileName) as Bitmap;

            if (!image.AreAllPixels8CColor())
            {
                var resp = MessageBox.Show("This image has no full 8C colors. Continue anyway?", "Warnning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(resp == DialogResult.No) return;
            }

            pic8c.Image = image;
        }
    }
}
