using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FormsColeccion
{
    public partial class Form1 : Form
    {
        private ArrayList clientes;
        public Form1()
        {
            InitializeComponent();
            clientes = new ArrayList();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clientes.Add(new Cliente(txtbNombre.Text,txtbTelefono.Text,txtbEdad.Text,txtbDireccion.Text ));
            txtbNombre.Clear();
            txtbTelefono.Clear();
            txtbEdad.Clear();
            txtbDireccion.Clear();
        }

        int i = 0;
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Cliente miCliente =(Cliente)clientes[i++];
            txtbNombre.Text = miCliente.Nombre;
        }
    }
}
