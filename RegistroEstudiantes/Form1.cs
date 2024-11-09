using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiantes
{
    public partial class Form1 : Form
    {
        
        private ClsEstudiantes objEstudiante = new ClsEstudiantes();
        public Form1()
        {
            InitializeComponent();
            var listTexBox = new List<TextBox>();
            listTexBox.Add(tbxNit);
            listTexBox.Add(tbxNombre);
            listTexBox.Add(tbxApellido);
            listTexBox.Add(tbxEmail);
            objEstudiante = new ClsEstudiantes(listTexBox);
        }

         

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            objEstudiante.uploadImage.CargarImagen(pictureBoxImg) ;
        }

        private void tbxNit_TextChanged(object sender, EventArgs e)
        {
            if (tbxNit.Text.Equals(""))
            {
                lblNit.ForeColor = Color.LightGray;
            }
            else
            {
                lblNit.ForeColor = Color.Green;
                lblNit.Text = "Nit";
            }
         }

        private void tbxNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            objEstudiante.texBoxEvent.numberKeyPress(e);
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            objEstudiante.texBoxEvent.textKeyPress(e);
        }

        private void tbxApellido_TextChanged(object sender, EventArgs e)
        {
            if (tbxApellido.Text.Equals(""))
            {
                lblApellido.ForeColor = Color.LightGray;
            }
            else
                lblApellido.ForeColor = Color.Green;
            lblApellido.Text = "Apellido";
        }

        private void tbxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            objEstudiante.texBoxEvent.textKeyPress(e);
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            
            if (tbxEmail.Text.Equals(""))
            {
                lblEmail.ForeColor = Color.LightGray;
            }
            else
            {
                lblEmail.ForeColor = Color.Green;
                lblEmail.Text = "Email";
            }
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            objEstudiante.texBoxEvent.textKeyPress(e);
        }
    }
}
