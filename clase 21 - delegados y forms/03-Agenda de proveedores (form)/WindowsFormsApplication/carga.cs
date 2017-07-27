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
    public partial class carga : Form
    {
        public carga()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor(int.Parse(IDtextBox1.Text),RZtextBox2.Text,CUITtextBox3.Text);
            ((Form1)this.Owner).miDelegate(p);
        }

        
        
        
        
        // al pedo, pifie y le clik al label
        private void label1_Click(object sender, EventArgs e){}
    }
}
