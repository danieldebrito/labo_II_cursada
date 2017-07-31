using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace sistemaGestionSanatorio
{
    public partial class frmFinal : Form
    {
        private MEspecialista medicoEspecialista;
        private MGeneral medicoGeneral;
        private Thread mocker;
        private Queue<Paciente> pacientesEnEspera;
        
        public frmFinal()
        {
            InitializeComponent();
            
            this.medicoGeneral = new MGeneral("Luis", "Salinas");
            this.medicoEspecialista = new MEspecialista("Jorge", "Iglesias",EEspecialidad.Traumatologo);
            
            this.pacientesEnEspera = new Queue<Paciente>();

            this.medicoGeneral.AtencionFinalizada += this.FinAtencionPaciente;
            this.medicoEspecialista.AtencionFinalizada += this.FinAtencionPaciente;
        }

        private void MockPacientes()
        {
            this.pacientesEnEspera.Enqueue(new Paciente("Joey", "Ramone"));
            this.pacientesEnEspera.Enqueue(new Paciente("johnny", "Ramone"));
            Thread.Sleep(5000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.mocker = new Thread(this.MockPacientes);
            this.mocker.Start();
        }

        private void frmFinal_FormClosing(object sender, EventArgs e)
        {
            if (this.mocker.IsAlive)
                this.mocker.Abort();
        }

        private void AtenderPacientes(IMedico imedico)
        {
            if (this.pacientesEnEspera.Count == 0)
                MessageBox.Show("no hay mas pacientes");
            if (this.pacientesEnEspera.Count > 0 && imedico is MEspecialista)
                ((MEspecialista)imedico).IniciarAtencion(this.pacientesEnEspera.Dequeue());
            if (this.pacientesEnEspera.Count > 0 && imedico is MGeneral)
                ((MGeneral)imedico).IniciarAtencion(this.pacientesEnEspera.Dequeue());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoGeneral);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.AtenderPacientes(this.medicoEspecialista);
        }

        private void FinAtencionPaciente(Paciente p, Medico m)
        {
            MessageBox.Show(string.Format("Finalizó la atención de {0} por {1}", p.ToString(), m.ToString()));
        }
    }
}
