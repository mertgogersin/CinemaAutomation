using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    class ClearControl
    {
        public static void ClearControls(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if(item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Text = string.Empty;
                }
                if(item is MaskedTextBox)
                {
                    MaskedTextBox mTxt = (MaskedTextBox)item;
                    mTxt.Text = string.Empty;
                }
            }
        }
    }
}
