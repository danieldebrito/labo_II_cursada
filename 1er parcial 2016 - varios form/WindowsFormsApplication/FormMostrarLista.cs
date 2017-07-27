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
    public partial class FormMostrarLista : Form
    {
        public FormMostrarLista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fAux = new Form1();

            richTextBox1.Clear();
            if (fAux.GetForm1.GetListaForm1 != null)
                richTextBox1.Text = fAux.MostrarLista(fAux.GetForm1.GetListaForm1);


        }
    }
}
