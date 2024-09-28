using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction_to_Custom_Controls
{
    public partial class MyCustomTextBox : TextBox
    {
        public MyCustomTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public bool IsRequired { get; set; }
        public enum InputTypeEnum { TextInpute=0,NumberInpute=1};
        public InputTypeEnum InputType { get; set;}= InputTypeEnum.TextInpute;

        private bool _IsNumeric()
        {
            string s = this.Text.Trim();
            foreach(char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                    return false;
            }
            return true;
        }
        public bool IsValide()
        {
            if(IsRequired)
            {
                if (this.Text.Trim().Length == 0)
                    return false;
            }
            if (InputType == InputTypeEnum.NumberInpute)
                return _IsNumeric();
            
            return true;
        }
    }
}
