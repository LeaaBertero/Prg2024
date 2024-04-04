using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrgIni2024
{
    public partial class PrgIni : Form
    {
        public Persona[] Personas = new Persona[2];
        int posicion = 0;

        public PrgIni()
        {
            InitializeComponent();
        }

        private void tSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salimos????  ( ͡❛ ᴥ ͡❛)✌   ");
            Close();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();


            persona.Nombre = TxNombre.Text;
            persona.edad = Convert.ToInt32(Txedad.Text);
            persona.documento = Convert.ToInt64(txDocumento.Text);



            TxNombre.Text = "";
            Txedad.Text = "";
            txDocumento.Text = "";


            Personas[posicion] = persona;
            posicion = posicion + 1;

        }





        private void btMostrar_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Nombre: " + Personas[0].Nombre + "\r\n"
                + "Edad: " + Personas[0].edad + " años" + "\r\n"
                + "Documento: " + Personas[0].documento + "\r\n" + "\r\n"
                + "Nombre: " + Personas[1].Nombre + "\r\n"
                + "Edad: " + Personas[1].edad + " años" + "\r\n"
                + "Documento: " + Personas[1].documento;



            lbLista.Visible = true;
        }

        private void btFormulario_Click(object sender, EventArgs e)
        {
            Form conversiones = new Conversiones();
            conversiones.Show();
        }
    }
}
