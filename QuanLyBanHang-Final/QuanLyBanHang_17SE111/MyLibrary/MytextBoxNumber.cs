using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MytextBoxNumber:TextBoxComau
    {
        private int iValue;
        private long lValue;

        public long LValue
        {
            get { return Convert.ToInt64(this.Text); }
            set { lValue = value; }
        }
        private double dValuel;

        public double DValuel
        {
            get { return Convert.ToDouble(this.Text); }
            set { dValuel = value; }
        }
        public int IValue
        {
          get { return Convert.ToInt32(this.Text.Replace(",","")); }
          set { iValue = value; }
        }
       
        protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
    }
}
