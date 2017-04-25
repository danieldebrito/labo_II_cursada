using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaderoLibreria
{
    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        public List<Vehiculo> Vehiculos
        {
            get { return this._vehiculos;}
        }
       
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public Lavadero(float PAuto, float PCamion, float PMoto)
            : this()
        {
            this._precioAuto = PAuto;
            this._precioCamion = PCamion;
            this._precioMoto = PMoto;
        }

        public string LavaderoInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("====================Precios Vigentes======================");
                sb.AppendLine("Auto: " + this._precioAuto.ToString());
                sb.AppendLine("Moto: " + this._precioMoto.ToString());
                sb.AppendLine("Camion: " + this._precioCamion.ToString());
                sb.AppendLine("==========================================================");
                
                sb.AppendLine("================Listado de Vehiculos======================");
                
                foreach (Vehiculo v in this.Vehiculos)
                {
                    if (v is Auto)
                        sb.AppendLine(((Auto)v).MostrarAuto());
                    if (v is Moto)
                        sb.AppendLine(((Moto)v).MostrarMoto());
                    if (v is Camion)
                        sb.AppendLine(((Camion)v).MostrarCamion());
                }
                
                sb.AppendLine("==========================================================");
                return sb.ToString();
            }
        }

        public double MostrarTotalFacturado(EVehiculos ev)
        { 
            double acum = 0;

            foreach (Vehiculo c in this.Vehiculos)
            {
                if (c is Auto && (EVehiculos)ev == EVehiculos.auto)
                    acum += this._precioAuto;
                if (c is Camion && (EVehiculos)ev == EVehiculos.camion)
                    acum += this._precioCamion;
                if (c is Moto && (EVehiculos)ev == EVehiculos.moto)
                    acum += this._precioMoto;
            }
            return acum;
        }

        public static bool operator == (Lavadero l, Vehiculo v)
        {
            if (!Object.Equals(l, null) && !Object.Equals(v, null))
            {
                foreach (Vehiculo vaux in l.Vehiculos)
                {
                    if (vaux == v)
                        return true;
                }
            }
            return false;
        }
        public static bool operator != (Lavadero l, Vehiculo v)
        {
            return !(l == v);
        }

        public static Lavadero operator + (Lavadero l, Vehiculo v)
        {
            if (l == v)
                return l;
            
            l.Vehiculos.Add(v);
            return l;
        }
        public static Lavadero operator - (Lavadero l, Vehiculo v)
        {
            if (l != v)
                return l;

            l.Vehiculos.Remove(v);
            return l;
        }

        public static int OrdenarVehiculosPorPatente (Vehiculo v1, Vehiculo v2)
        {
            if (v1.Patente == v2.Patente)
                return 0;

            if (1 == String.Compare(v1.Patente, v2.Patente))
                return 1;
            else
                return -1;
        }
        public int OrdenarVehiculosPorMarca (Vehiculo v1, Vehiculo v2)
        {
            if (v1.Marca == v2.Marca)
                return 0;
            if (1 == String.Compare(v1.Marca.ToString(),v2.Marca.ToString()))
                return 1;
            else
                return -1;
        }
    }
}