using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Threading;

namespace WindowsFormsApplication
{
    public delegate void CorrenCallback(int avance, Corredor corredor);

    public partial class Form1 : Form
    {
        private List<Persona> _corredores;
        private List<Thread> _corredoresActivos;
        private bool _hayGanador;
        private Button btnCorrer;
        private IContainer components;
        private Label lblCarril1;
        private Label lblCarril2;
        private ProgressBar pgbCarril1;
        private ProgressBar pgbCarril2;

        public Form1()
        {
            InitializeComponent();
            _corredores = new List<Persona>();
            _corredoresActivos = new List<Thread>();
            this._corredores.Add(new Persona("Fernando", 9, ECarril.Carril_1));
            this._corredores.Add(new Persona("Fernando", 15, ECarril.Carril_2));
            this._hayGanador = false;
        }

        

        private void LimpiarCarriles()
        {
            this.progressBar1.Value = 0;
            this.progressBar2.Value = 0;
            this.progressBar1.Maximum = 100;
            this.progressBar2.Maximum = 100;
        }
       
        private void HayGanador(Corredor corredor)
        {
            foreach (Thread i in this._corredoresActivos)
                i.Abort();
            
            MessageBox.Show(corredor.ToString());

            // falta guardar
        }

        private void AnalizarCarrera(ProgressBar carril, int avance, Corredor corredor)
        {

            if (carril.Value >= 100)
                HayGanador(corredor);
            else 
            {
                if (carril.Value + avance >= 100) // si no se pasa de 100 y rompe
                    carril.Value = 100;
                else
                    carril.Value += avance;
            }
        }

        private void correr_Click(object sender, EventArgs e)
        {
            this.LimpiarCarriles();

            Thread h1 = new Thread(_corredores[0].CorrerLanzaEventos);
            Thread h2 = new Thread(_corredores[1].CorrerLanzaEventos);

            _corredoresActivos.Add(h1);
            _corredoresActivos.Add(h2);

            h1.Start();
            h2.Start();
            
            this._corredores[0].EventoCorriendo += this.PersonaCorriendo;
            this._corredores[1].EventoCorriendo += this.PersonaCorriendo;

        }

        private void PersonaCorriendo(int avance, Corredor corredor)
        {
            if (progressBar1.InvokeRequired || progressBar2.InvokeRequired)
            {
                CorrenCallback d = new CorrenCallback(PersonaCorriendo);
                this.Invoke(d, new object[] { avance, corredor });
            }
            else
            {
                if (corredor.CarrilElegido == ECarril.Carril_1)
                    AnalizarCarrera(this.progressBar1, avance, corredor);
                if (corredor.CarrilElegido == ECarril.Carril_2)
                    AnalizarCarrera(this.progressBar2, avance, corredor);
            }
        }
        
        //al pedo
        private void Form1_Load(object sender, EventArgs e){}
    }
}
