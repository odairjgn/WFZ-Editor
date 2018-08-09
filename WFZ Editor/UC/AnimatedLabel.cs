using System;
using System.Drawing;
using System.Windows.Forms;

namespace WFZ_Editor.UC
{
    public enum AnimateStyle
    {
        Static,
        RigthToLeft,
        LeftToRigth,
        DownToUp,
        UpToDown
    }

    public partial class AnimatedLabel : UserControl
    {
        public event EventHandler AnimateStyleChaged;

        public AnimatedLabel()
        {
            InitializeComponent();
        }

        private AnimateStyle _animateStyle = AnimateStyle.RigthToLeft;

        public AnimateStyle AnimateStyle
        {
            get { return _animateStyle; }
            set
            {
                _resetAnimation = value != _animateStyle;
                _animateStyle = value;
                ApplyChangesProps();
                OnAnimateStyleChaged();
            }
        }

        public int Interval
        {
            get => tianimation.Interval;
            set
            {
                tianimation.Interval = value;
                ApplyChangesProps();
            }
        }

        private float _speed = 1f;
        public float Speed
        {
            get => _speed;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Valor deve ser maior que 0");

                _speed = value;
            }
        }

        private void ApplyChangesProps()
        {
            if (AnimateStyle == AnimateStyle.Static)
            {
                tianimation.Enabled = false;
                Invalidate();
            }
            else
            {
                if (!tianimation.Enabled)
                    tianimation.Enabled = true;
            }
        }

        private RectangleF _lastRec;
        private bool _resetAnimation;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawAnimation(e.Graphics);
        }

        public string Texto
        {
            get => _texto;
            set
            {
                _texto = value;
                _resetAnimation = true;
            }
        }

        private void DrawAnimation(Graphics g)
        {
            switch (AnimateStyle)
            {
                case AnimateStyle.Static:
                    AnimateStatic(g);
                    break;
                case AnimateStyle.RigthToLeft:
                    AnimateRigthToLeft(g);
                    break;
                case AnimateStyle.LeftToRigth:
                    AnimateLeftToRigth(g);
                    break;
                case AnimateStyle.DownToUp:
                    AnimateDownToUp(g);
                    break;
                case AnimateStyle.UpToDown:
                    AnimateUpToDown(g);
                    break;
            }
        }

        private void AnimateUpToDown(Graphics g)
        {
            if (_resetAnimation)
            {
                var size = TextRenderer.MeasureText(Texto, Font, Size);
                _lastRec = new RectangleF(0, size.Height*-1, size.Width, size.Height);
                _resetAnimation = false;
            }

            g.DrawString(Texto, Font, new SolidBrush(ForeColor), _lastRec, _format);
            _lastRec = new RectangleF(_lastRec.X, _lastRec.Y + Speed, _lastRec.Width, _lastRec.Height);

            if (_lastRec.Y > Height) _resetAnimation = true;
        }

        private void AnimateDownToUp(Graphics g)
        {
            if (_resetAnimation)
            {
                var size = TextRenderer.MeasureText(Texto, Font, Size);
                _lastRec = new RectangleF(0, Height+1, size.Width, size.Height);
                _resetAnimation = false;
            }

            g.DrawString(Texto, Font, new SolidBrush(ForeColor), _lastRec, _format);
            _lastRec = new RectangleF(_lastRec.X, _lastRec.Y-Speed, _lastRec.Width, _lastRec.Height);

            if (_lastRec.Bottom < 0) _resetAnimation = true;
        }

        private void AnimateLeftToRigth(Graphics g)
        {
            if (_resetAnimation)
            {
                var size = TextRenderer.MeasureText(Texto, Font);
                _lastRec = new RectangleF(Size.Width * -1, 0, size.Width, size.Height);
                _resetAnimation = false;
            }

            g.DrawString(Texto, Font, new SolidBrush(ForeColor), _lastRec, _format);

            _lastRec = new RectangleF(_lastRec.X + Speed, 0, _lastRec.Width, _lastRec.Height);

            if (_lastRec.X > Width) _resetAnimation = true;
        }

        private void AnimateRigthToLeft(Graphics g)
        {
            if (_resetAnimation)
            {
                var size = TextRenderer.MeasureText(Texto, Font);
                _lastRec = new RectangleF(Size.Width + 1, 0, size.Width, size.Height);
                _resetAnimation = false;
            }

            g.DrawString(Texto, Font, new SolidBrush(ForeColor), _lastRec, _format);

            _lastRec = new RectangleF(_lastRec.X - Speed, 0, _lastRec.Width, _lastRec.Height);

            if (_lastRec.Right < 0) _resetAnimation = true;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            _resetAnimation = true;
        }


        private StringFormat _format = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
        private string _texto = "Text";

        public StringAlignment Alignment
        {
            get => _format.Alignment;
            set
            {
                _format.Alignment = value;
                Invalidate();
            }
        }
        public StringAlignment LineAlignment
        {
            get => _format.LineAlignment;
            set
            {
                _format.LineAlignment = value;
                Invalidate();
            }
        }

        private void AnimateStatic(Graphics g)
        {
            if (_resetAnimation)
            {
                _lastRec = new RectangleF(PointF.Empty, Size);
                _resetAnimation = false;
            }

            g.DrawString(Texto, Font, new SolidBrush(ForeColor), _lastRec, _format);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            _resetAnimation = true;
            base.OnSizeChanged(e);
        }

        protected virtual void OnAnimateStyleChaged()
        {
            AnimateStyleChaged?.Invoke(this, EventArgs.Empty);
        }

        private void tianimation_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
