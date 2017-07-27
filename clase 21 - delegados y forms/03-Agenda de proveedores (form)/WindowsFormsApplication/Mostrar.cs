using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProveedorClassLibrary;

namespace WindowsFormsApplication
{
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        public void mostrarProveedor(Proveedor p)
        {
            richTextBox1.Text = p.ToString();
        }

        
        
        
        // al pedo, hice un click de mas
        private void richTextBox1_TextChanged(object sender, EventArgs e){}
    }
}
