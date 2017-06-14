using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbolFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Arbol arbol = new Arbol();

        private void btnArmar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.leer(txtEcuación.Text);
            arbol.recorrido();
            btnArmar.Enabled = false;
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.preOrden(arbol.Raiz);
            btnCalculoPre.Enabled = true;
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            txtResultado.Text = arbol.postOrden(arbol.Raiz);
            btnCalculoPost.Enabled = true;
        }

        private void btnCalculoPre_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(arbol.calculoPreOrden());
            btnCalculoPre.Enabled = false;
        }

        private void btnCalculoPost_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(arbol.calculoPostOrden());
            btnCalculoPost.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }


}
