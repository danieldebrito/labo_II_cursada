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

        public Form1()
        {
            InitializeComponent();

            this._productos = new List<Producto>();       

            foreach (EMarcaProducto marca in Enum.GetValues(typeof(EMarcaProducto)))
                this.comboBoxMarca.Items.Add(marca);

            foreach (ESaborJugo sabor in Enum.GetValues(typeof(ESaborJugo)))
                this.comboBoxSabor.Items.Add(sabor);

            foreach (ETipoProducto tipo in Enum.GetValues(typeof(ETipoProducto)))
                this.comboBoxTipo.Items.Add(tipo);
        }

        public string MostrarLista()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto p in this._productos)
            {
                if (p is Jugo)
                    sb.AppendLine(((Jugo)p).MostrarJugo());
                if (p is Galletita)
                    sb.AppendLine(Galletita.MostrarGalletita((Galletita)p));
                if (p is Gaseosa)
                    sb.AppendLine(((Gaseosa)p).MostrarGaseosa());
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((ETipoProducto)comboBoxSabor.SelectedItem == ETipoProducto.Jugo)
            {
                Jugo j = new Jugo(int.Parse(textBoxCode.Text), (EMarcaProducto)comboBoxMarca.SelectedItem,
                    float.Parse(textBoxPrecio.Text), (ESaborJugo)comboBoxSabor.SelectedItem);
                this._productos.Add(j);
            }

            if ((ETipoProducto)comboBoxSabor.SelectedItem == ETipoProducto.Galletita)
            {
                Galletita Gt = new Galletita(int.Parse(textBoxCode.Text), (EMarcaProducto)comboBoxMarca.SelectedItem,
                    float.Parse(textBoxPrecio.Text),float.Parse(textBoxLitroPeso.Text));
                comboBoxSabor.Text = "NO CARGAR";
                this._productos.Add(Gt);
            }
            if ((ETipoProducto)comboBoxSabor.SelectedItem == ETipoProducto.Gaseosa)
            {
                Gaseosa Gs = new Gaseosa(int.Parse(textBoxCode.Text), (EMarcaProducto)comboBoxMarca.SelectedItem,
                    float.Parse(textBoxPrecio.Text), float.Parse(textBoxLitroPeso.Text));
                comboBoxSabor.Text = "NO CARGAR";
                this._productos.Add(Gs);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox.Text = this.MostrarLista();
        }
    }
}
