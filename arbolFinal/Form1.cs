using System;
using System.Windows.Forms;

namespace arbolFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArmar_Click(object sender, EventArgs e)
        {
            Arbol arbol = new Arbol();
            txtResultado.Text = "";
            txtResultado.Text += "Ecuación original " + arbol.leer(txtEcuación.Text) + "\r\n";
            arbol.recorrido();
            txtResultado.Text += "PreOrden:  " + arbol.preOrden(arbol.Raiz) + "\r\n";
            txtResultado.Text += "PostOrden:  " + arbol.postOrden(arbol.Raiz) + "\r\n";
            txtResultado.Text += "Calculo por PreOrden:  " + Convert.ToString(arbol.calculoPreOrden()) + "\r\n";
            txtResultado.Text += "Calculo por PostOrden:  " + Convert.ToString(arbol.calculoPostOrden()) + "\r\n";

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }


}