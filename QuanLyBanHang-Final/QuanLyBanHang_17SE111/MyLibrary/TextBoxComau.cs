using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MyLibrary
{
    public class TextBoxComau:TextBox
    {
        public Color backGroundEnter = Color.Aqua;
        public Color backGroundLeave = Color.White;

        protected override void OnEnter(EventArgs e)
        {
            this.BackColor = backGroundEnter;
            base.OnEnter(e);
        }
        protected override void OnLeave(EventArgs e)
        {
            this.BackColor = backGroundLeave;
            base.OnLeave(e);
        }
    }
}
