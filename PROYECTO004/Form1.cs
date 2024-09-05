using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            string datos = $"Nombres: {nombres}\r\nApellidos: {apellido}\r\nTelefono: {telefono}\r\nEstatura: {estatura}\r\nEdad: {edad}";

            //guaardar en el txtx
            string savefile = "C:/Users/Mansa/OneDrive/Documentos/UNACH/TERCER SEMESTRE/PROGRAMACION AVANZADA/DATOS FORM/DATOS.TXT";
            //verificar si el arhcivo existe
            bool Chekfile = File.Exists(savefile);

            using (StreamWriter writer = new StreamWriter(savefile,true))
            {
                if (Chekfile)
                {
                    writer.WriteLine("+-+-+-+-+-+-+-+-+-+-+");
                }
                writer.WriteLine(datos);
                //TEXT BOX DESPUES DEL GUARDADO
                MessageBox.Show("INFORMACION GUARDADA: \n\n" + datos, "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //TITULO, CADENA, TITULO DE LA VENTANA, BOTON DE OK AUTOGENERADO, ICONO DE LA VENATANA            
            }

        }

        private void bt_Limpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbTelefono.Clear();
            tbEstatura.Clear();
            tbEdad.Clear();
            rB_Femenino.Checked = false;
            rB_Masculino.Checked = false;

        }
    }
}
