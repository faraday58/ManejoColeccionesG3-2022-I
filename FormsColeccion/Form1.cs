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
        private int indice;

        public int Indice { 
            get => indice;
            set
            {
                if (value < 0 )
                {
                    indice = clientes.Count - 1;
                }
                else if(value >= clientes.Count   )
                {
                    indice = 0;
                }
                else
                {
                    indice = value;
                }
                    
            }
        }

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

        

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente miCliente = (Cliente)clientes[Indice++];
                
                if(miCliente.Nombre == ""  )
                {
                    throw new ApplicationException("Se debe guardar un nombre para el cliente");
                }
                txtbNombre.Text = miCliente.Nombre;
                txtbTelefono.Text = miCliente.Telefono;
                txtbEdad.Text = miCliente.Edad;
                txtbDireccion.Text = miCliente.Direccion;
            }
            catch(ApplicationException error  )
            {
                MessageBox.Show(error.Message);
                 clientes.RemoveAt(--Indice);
            }
            catch(ArgumentOutOfRangeException error )
            {
                MessageBox.Show("Se debe agregar un cliente \n" + error.Message);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Cliente miCliente = (Cliente)clientes[Indice--];
            txtbNombre.Text = miCliente.Nombre;
            txtbTelefono.Text = miCliente.Telefono;
            txtbEdad.Text = miCliente.Edad;
            txtbDireccion.Text = miCliente.Direccion;
        }
    }
}
