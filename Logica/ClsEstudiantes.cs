using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Library;

namespace Logica
{
    public class ClsEstudiantes : clsLibrary
    {
        private List<TextBox> ListTexBox { get; }
        public ClsEstudiantes(List<TextBox> listTexBox)
        {
            ListTexBox = listTexBox;
        }



        public ClsEstudiantes()
        {
        }
    }
}
