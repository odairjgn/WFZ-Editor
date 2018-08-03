using System.Windows.Forms;

namespace WFZ_Editor.UC
{
    public class checkBoxChar : CheckBox
    {
        private char _char;
        public char Char
        {
            get => _char;
            set
            {
                _char = value;
                Text = _char.ToString();
            }
        }
    }
}
