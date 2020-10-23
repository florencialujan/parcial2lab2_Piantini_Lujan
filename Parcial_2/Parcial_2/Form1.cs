using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rCamisa_CheckedChanged(object sender, EventArgs e)
        {
            cBermuda.Enabled = false;
            cMangaCorta.Enabled = true;
        }

        private void rPantalon_CheckedChanged(object sender, EventArgs e)
        {
            cMangaCorta.Enabled = false;
            cBermuda.Enabled = true;
        }

        private void compruebaSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            bool isPremium=false;
            double precioFinal;

            if(premium.Checked == true)
            {
                isPremium = true;
            }

            if (precio.Text!=("") && cantidad.Text != (""))
            {
                if(rPantalon.Checked == true)
                {
                    bool isBermuda = false;
                    if(cBermuda.Checked == true)
                    {
                        isBermuda = true;
                    }
                    // public Pantalones(double precioBase, int cantidadDePrendas, bool esPremium, bool esBermuda) 
                    Pantalones cliente1 = new Pantalones(Convert.ToDouble(precio.Text), Convert.ToInt32(cantidad.Text), isPremium, isBermuda);
                    precioFinal = cliente1.precioFinal();

                    MessageBox.Show("El precio final calculado es:"+precioFinal, "PRECIO FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if(rCamisa.Checked == true)
                {
                    bool isMangaCorta = false;
                    if(cMangaCorta.Checked == true)
                    {
                        isMangaCorta = true;
                    }
                    Camisas cliente2 = new Camisas(isMangaCorta,Convert.ToDouble(precio.Text),Convert.ToInt32(cantidad.Text),isPremium);
                    precioFinal = cliente2.precioFinal();

                    MessageBox.Show("El precio final calculado es: $" + precioFinal, "PRECIO FINAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Por favor complete todos los campos necesarios para realizar el cálculo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
