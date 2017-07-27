using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using estante;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private List<Producto> _productos;
        private Form1 ff;
        
        public List<Producto> GetListaForm1 { get { return this._productos; } }
        public Form1 GetForm1 { get { return this.ff; } }

        public string MostrarLista(List<Producto> _producto)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto p in this.GetListaForm1)
            {
                sb.AppendLine(((Jugo)p).MostrarJugo());
            }
            return sb.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            this._productos = new List<Producto>();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void jugoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormJugo fj = new FormJugo();
            fj.MdiParent = this;
            fj.StartPosition = FormStartPosition.CenterParent;
            fj.Show();
            
            Form1 f = new Form1();
            this.ff = f;
            Jugo j = fj.GetSetJugo;
            
            f._productos.Add(j);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMostrarLista fml = new FormMostrarLista();
            fml.MdiParent = this;
            fml.StartPosition = FormStartPosition.CenterParent;
            fml.Show();
        }
    }
}
