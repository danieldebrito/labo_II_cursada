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
    public partial class ver : Form
    {
        public ver()
        {
            InitializeComponent();
        }

        public void modificar(string mensaje)
        {
            try
            {
                label2.Text = mensaje;
            }
            catch (Exception e)
            { throw new Exception("Error ala hora de modificar"); }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
