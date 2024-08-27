using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO004
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void lbl_Nombre_Click(object sender, EventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {

            //obitiene los datos del texto box
            string nombres = tbNombre.Text;
            string apellido = tbApellidos.Text;
            string telefono = tbTelefono.Text;
            string estatura = tbEstatura.Text;
            string edad = tbEdad.Text;

            //selecciond e genero
            string genero = "";
            if (rB_Masculino.Checked)
            {
                genero = "masculino";
            }
            else if (rB_Femenino.Checked)
            {
                genero = "Femenino";
            }
            //creacion de la cadena de datos
            string datos = $"nombres: {nombres}\r\nApellidos:{apellido}";

            //guaardar en el txtx
            string savefile = "C:/Users/Mansa/OneDrive/Documentos/UNACH/TERCER SEMESTRE/PROGRAMACION AVANZADA/DATOS FORM/DATOS.TXT";

        }

        private void bt_Limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
