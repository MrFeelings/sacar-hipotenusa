using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pitagorazo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //*** boton que para calcular***
        private void Boton_calcular(object sender, EventArgs e)
        {
            //MOSTRAR NUM EN EL DIBUJO
            a.Text = num1.Text;
            b.Text = num2.Text;

            //PREPARAR DATOS PARA MANDAR
            double Num1, Num2, result;
            Num1 = Convert.ToDouble(num1.Text);
            Num2 = Convert.ToDouble(num2.Text);

            // RECIBIR RESULTADO e imprimir
            result = calcular_hipotenusa(Num1, Num2);
            hipotenusa.Text = Convert.ToString(result);
        }

        // clase para sacar hipotenusa
        public double calcular_hipotenusa(double cateto1, double cateto2)
        {

            return Math.Sqrt(cateto1 * cateto1 + cateto2 * cateto2);

        }
        // boton reiniciar
        private void reiniciar_Click(object sender, EventArgs e)
        {
            a.Text = "a";
            b.Text = "b";
            hipotenusa.Text = "hipotenusa";
            num1.Text = "";
            num2.Text = "";
        }
    }

}
