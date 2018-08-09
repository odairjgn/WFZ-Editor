using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFZ_Editor.UC
{
    public class PicPreview : PictureBox
    {
        private Image ani = Properties.Resources.ANIM;

        public override ImageLayout BackgroundImageLayout
        {
            get => base.BackgroundImageLayout;
            set => base.BackgroundImageLayout = ImageLayout.Tile;
        }

        public override Image BackgroundImage
        {
            get => base.BackgroundImage;
            set => base.BackgroundImage = ani;
        }

        public PicPreview()
        {
            ImageAnimator.Animate(ani, OnFrameChangedHandler);
        }

        private void OnFrameChangedHandler(object sender, EventArgs eventArgs)
        {
            this.BackgroundImage = ani;
            ImageAnimator.UpdateFrames();
            Invalidate();
        }

        ~PicPreview()
        {
            try
            {
                ImageAnimator.StopAnimate(ani, OnFrameChangedHandler);
            }
            catch
            {
            }
        }
    }
}
