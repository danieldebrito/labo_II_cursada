using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public delegate void DelegadoCarga(string mensaje);

    public partial class Form1 : Form
    {
        public DelegadoCarga miDelegado;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carga formularioCarga = new carga();
            formularioCarga.Show(this);
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ver formularioVer = new ver();
            this.miDelegado += formularioVer.modificar;
            formularioVer.Show(this);
        }
    }
}
