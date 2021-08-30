using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4Guia2_MM200149
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtarreglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtarreglo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                listboxarreglos.Items.Add(txtarreglo.Text);
                txtarreglo.Clear();
                txtarreglo.Focus();
            }
        }


        

        private void btncalcular_Click(object sender, EventArgs e)
        {

            //Evento para calcular el mayor de los pares negativos

            int mayorneg = -1000;

            for (int i = 0; i < listboxarreglos.Items.Count; i++) 
            {
                string valor = listboxarreglos.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero < 0 && numero % 2 == 0) 
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        txtparnegativo.Text = mayorneg.ToString();
                    }
                }

                else
                {
                    txtparnegativo.Text = "No hay numeros negativos pares";
                }

            }

            //Evento para calcular porcentaje de ceros

            double cantidadnumeros = listboxarreglos.Items.Count;

            double cantidadceros = 0; 
            double porcentaje = 0;
            

            for (int i = 0; i < listboxarreglos.Items.Count; i++)
            {
                string valor = listboxarreglos.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;

                }
            }

            porcentaje = cantidadceros / cantidadnumeros * 100;
            txtcerosarreglos.Text = porcentaje.ToString() + "%";

            //Evento para obtener el promedio de impares positivos

            double prom;
            double cantidadimpares = 0;
            double suma = 0;

            for (int i = 0; i < listboxarreglos.Items.Count; i++)
            {
                string valor = listboxarreglos.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero > 0 && numero % 2 != 0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }

            }

            prom = suma / cantidadimpares;
            txtimparesmas.Text = prom.ToString();


            //Evento para mayor de pares positivos
            int mayor = 0;

            for ( int i = 0; i < listboxarreglos.Items.Count; i++)
            {
                string valor = listboxarreglos.Items[i].ToString();
                int numero = int.Parse(valor);

                if ( numero > 0 && numero %2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }

            txtmayorparesmas.Text = mayor.ToString();

        }
    }
}
