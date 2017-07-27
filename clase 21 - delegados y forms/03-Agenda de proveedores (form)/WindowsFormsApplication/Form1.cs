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
    public delegate void delegateCarga(Proveedor p);

    public partial class Form1 : Form
    {

        public delegateCarga miDelegate;

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carga formularioCarga = new carga();
           // formularioCarga.MdiParent = this;
           // formularioCarga.StartPosition = FormStartPosition.CenterParent;  // antes poner en los atributos del form isMdiContainer en true 
           formularioCarga.Show(this);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mostrar formularioMostrar = new Mostrar();
            //formularioMostrar.MdiParent = this;
            //formularioMostrar.StartPosition = FormStartPosition.CenterParent;  // antes poner en los atributos del form isMdiContainer en true 
            this.miDelegate += formularioMostrar.mostrarProveedor;
            formularioMostrar.Show(this);
        }
    }
}
