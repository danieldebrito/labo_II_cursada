using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* vamos a hacer un evento en caso de que el sueldo supere 9500
 * el evento puede venir de una clase externa, interna o extension
 * el evento lo captura un delegado y lo maneja en otra clase o metodo manejador
 * el delegado trabaja con direcciones de memoria de metodos, 
 * similar a ansi c puntero a funciones, puede manejar una o varios metodos
 * la clase expone el evento y define un delegate apropiado para ese metodo
 * el manejador seria compatible con el delegado y el evento
 * el delegate es accesible, dentro del namespace (fuera de la clase) 
 * y visto por la clases y del evento y la clase del manejador, un ejemplo:
 * delegate = [modificador] delegate tipoRet Nombre([listado de argumentos]);  
 * apunta a metodos con la misma firma exacamente
 */

namespace EmpleadoClassLibrary
{
    // declaro los delegados
    // dentro del namespace, fuera de la clase
    public delegate void DelegadoSueldo();
    // obj "genericamente" para que reciba cualquier cosa y un evenrArgs para obtener informacion del fomulario
    // com los metodos de dicho formulario
    public delegate void DelegadoSueldoMejorado(object obj, EventArgs ev);
    

    public class Empleado
    {
        public string _nombre;
        public string _apellido;
        public int _legajo;
        private double _sueldo;

        // declaro los eventos del tipo de cada delegado
        // cuando le agregas funciones debe tener la misma firma que el delegado

        public event DelegadoSueldo SueldoEvent;
        public event DelegadoSueldoMejorado sueldoMejorado;

        public Empleado(string nombre, string apellido, int legajo) 
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOMBRE: " + this._nombre);
            sb.AppendLine("APELLIDO: " + this._apellido);
            sb.AppendLine("LEGAJO: " + this._legajo.ToString());
            sb.AppendLine("SUELDO: " + this.Sueldo.ToString());
            
            return sb.ToString();
        }

        public double Sueldo
        {
            get {return this._sueldo;}
            set 
            {
                if (value < 0)
                    throw new Exception("el sueldo no puede ser negativo");
                else
                    if (value > 9500)
                    {
                        // ejemplo uno : // lanzo el evento "SueldoEvent()"
                        this.SueldoEvent();
                        
                        //  ejemplo dos: // lanzo el otro evento, le paso el objeto 
                        //  que genero el evento para trabajarlo "this"
                        // cuando capturo el evento en la implementacion
                        // por ejemplo en la implementacion se puede usar el ToString()
                        this.sueldoMejorado(this,new EventArgs());
                    }

                    else
                        this._sueldo = value;
            }
            
        }
    }
}
