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
    public partial class Conversiones : Form
    {

        int numero1;
        int numero2;

        int resultado;

        public Conversiones()
        {
            InitializeComponent();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConvertir_Click(object sender, EventArgs e)
        {
            lbRes.Visible = true;

            numero1 = Convert.ToInt32(txNumero1.Text);
            numero2 = Convert.ToInt32(txNumero2.Text);  

            resultado = numero1 + numero2;

            lbRes.Text = "El resultado es: " + resultado.ToString();


        }

      
    }
}
