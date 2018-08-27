using System;
using System.Drawing;
using System.Windows.Forms;

namespace SobreCargaFuncionesG5_2019_I
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            // Funciones mifuncion = new Funciones();
            int suma = Funciones.Suma(int.Parse(txtbOperando1.Text), int.Parse(txtbOperando2.Text), int.Parse(txtbOperando3.Text));
            etResultado.Text = suma.ToString();
        }

        private void btnOperar2_Click(object sender, EventArgs e)
        {
            int multi = Funciones.Multiplicar(int.Parse(txtOperando4.Text), int.Parse(txtOperando5.Text), int.Parse(txtOperando6.Text));
            etResultado2.Text = multi.ToString();
        }
    }

  }
