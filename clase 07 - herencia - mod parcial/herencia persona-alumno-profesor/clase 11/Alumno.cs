using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_11
{
    class Alumno:Persona
    {
        //atributos
        //private string _nombre;
        //private string _apellido;
        //private int _dni;
        private string _curso;
        private List<Single> _notas;

        //propiedades
        //public string Nombre
        //{
        //    get{ return this._nombre;}
        //    set{ this._nombre = value;}
        //}
        //public string Apellido
        //{
        //    get { return this._apellido; }
        //    set { this._apellido = value; }
        //}
        //public int DNI
        //{
        //    get { return this._dni; }
        //    set { this._dni = value;}
        //}
        public string Curso
        {
            get { return this._curso; }
            set { this._curso = value; }
        }
        public List<Single> Notas
        {
            get { return this._notas; }
            set { this._notas = value; }
        }
        
        //constructor
        public Alumno(string nombre, string apellido, int dni):
            base(nombre, apellido, dni)
        {
            this._notas = new List<Single>();
        }

        public Alumno(string nombre, string apellido, int dni, string curso)
            : this(nombre, apellido, dni)
        {
            this._curso = curso;
        }

        //metodos
        public string MostrarAlumno()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarPersona());
            sb.AppendLine(this._curso);

            return sb.ToString();        

        }
    }
}
