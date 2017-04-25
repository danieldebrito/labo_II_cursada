using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaletaLibreria;

namespace PaletaForm
{
    public partial class FormTempera : Form
    {
        public FormTempera()
        {
            InitializeComponent();

            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                this.comboBoxColor.Items.Add(color);
        }

        private Tempera t;
        public Tempera Tempera { get { return this.t; } set { this.t = value; } } 

        private void Agregar_Click(object sender, EventArgs e)
        {
            Tempera t1 = new Tempera((ConsoleColor)this.comboBoxColor.SelectedItem, 
                this.textBoxMarca.Text, int.Parse(this.textBoxTamaño.Text));
            
            this.Tempera = t1;          
            
        }
    }
}
