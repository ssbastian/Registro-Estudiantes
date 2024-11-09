using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Library
{
    public class clsTexBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //ingresar datos solo tipo texto
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                //no dar salto de linea con enter
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                //
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
                //negar cualquir otro tipo de dato
            }else if (char.IsSeparator(e.KeyChar)) { 
                e.Handled= true;
            }
        }

        public void numberKeyPress(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                //no dar salto de linea con enter
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                //
            }else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //negar cualquir otro tipo de dato
            }

        }
    }
}
