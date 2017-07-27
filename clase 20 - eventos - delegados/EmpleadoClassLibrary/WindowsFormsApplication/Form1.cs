using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpleadoClassLibrary;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void manejadorEvento()
        {
            MessageBox.Show("sueldo mayor a 9500");
        }

        static void manejadorEventoMejorado(object o, EventArgs ev)
        {
            MessageBox.Show(o.ToString());
            
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado(this.nombre.Text.ToString(), this.apellido.Text.ToString(), int.Parse(this.legajo.Text.ToString()));

            
            emp.SueldoEvent += manejadorEvento;
            emp.sueldoMejorado += manejadorEventoMejorado;
            
            emp.Sueldo = double.Parse(this.sueldo.Text);
        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }






    }
}
