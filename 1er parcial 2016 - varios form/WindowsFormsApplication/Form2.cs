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
    public partial class FormJugo : Form
    {
        private Jugo jugo;
        public Jugo GetSetJugo { get { return this.jugo; } set { this.jugo = value;} }

        public FormJugo()
        {
            InitializeComponent();

            foreach (EMarcaProducto marca in Enum.GetValues(typeof(EMarcaProducto)))
                this.comboBoxMarcas.Items.Add(marca);

            foreach (ESaborJugo sabor in Enum.GetValues(typeof(ESaborJugo)))
                this.comboBoxSabor.Items.Add(sabor);

            this.textBoxTipo.Text = ETipoProducto.Jugo.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jugo j = new Jugo(int.Parse(textBoxCode.Text), (EMarcaProducto)comboBoxMarcas.ItemHeight,
                float.Parse(textBoxPrecio.Text), (ESaborJugo)comboBoxSabor.ItemHeight);
            this.jugo = j;

            textBoxCode.Text = "";
            comboBoxMarcas.ItemHeight = 10;
            textBoxPrecio.Text = "";
            comboBoxSabor.ItemHeight = 10;

        }
    }
}
