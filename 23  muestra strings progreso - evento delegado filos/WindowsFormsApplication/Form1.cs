using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // para hilos
using Entidades; // mi biblioteca

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            trabajo t = new trabajo();
            t.EventoWonrking += recopilaAndMostrar;  // asocio el metodo recopilaAndMostrar con la misma firma que el delegado
            Thread hilo = new Thread(t.LanzaEventosTrabajando);  // trabajando genera eventos con el parametro string
            hilo.Start();
        }

        private void recopilaAndMostrar(string str) // carga estring al listBox
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(str);

            if(InvokeRequired) // carga en el listBox1
                Invoke(new Action(() => listBox1.Items.Add(sb.ToString())));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
    }
}
