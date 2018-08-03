using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFZ_Data.Entity;
using WFZ_Data.Services;
using WFZ_Editor.UC;

namespace WFZ_Editor.Forms.Editors
{
    public partial class FontManager : Form
    {
        public FontManager()
        {
            InitializeComponent();
        }

        private async void FontManager_Load(object sender, EventArgs e)
        {
            await Carregar();
        }

        public async Task Carregar()
        {
            Invoke(new Action(delegate { flpFonts.Controls.Clear(); }));
            var fonts = await WFZ_Data.Respositories.Fonts.SelectAll();
            foreach (var font in fonts)
            {
                var ctr = await Create(font);
                Invoke(new Action(delegate
                {
                    flpFonts.Controls.Add(ctr);
                }));
            }
        }

        public Task<ucFont> Create(FontInfo f)
        {
            return Task.Run(() => new ucFont(f));
        }

        private async void btRefresh_Click(object sender, EventArgs e)
        {
            btRefresh.Enabled = false;
            await Carregar();
            btRefresh.Enabled = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var form = new FontEditor(Refreshaction) { MdiParent = this.MdiParent };
            form.Show();
        }

        private void Refreshaction()
        {
            Invoke(new Action(delegate { btRefresh.PerformClick(); }));
        }
    }
}
