using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARBOL
{
    public partial class Form1 : Form
    {
        Arbol arbol = new Arbol();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Nodo nuevo = new Nodo(Convert.ToInt16(txtElemento.Text));
            arbol.Agregar(nuevo);
            txtElemento.Clear();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
           txtOrden.Text=arbol.PreOrden();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            txtOrden.Text = arbol.InOrden();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            txtOrden.Text = arbol.PostOrden();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (arbol.Buscar(Convert.ToInt16(txtBuscar.Text)).ToString() == null)
                txtOrden.Text = "No se encontro elemento";
            else
                txtOrden.Text = arbol.Buscar(Convert.ToInt16(txtBuscar.Text)).ToString();
            txtBuscar.Clear();
        }
    }
}
