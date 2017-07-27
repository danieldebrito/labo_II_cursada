using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace ProveedorClassLibrary
{
    [Serializable]
    public class Proveedor
    {
        private int _id;
        private string _razonSocial;
        private string _cuit;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string CUIT
        {
            get { return _cuit; }
            set { _cuit = value; }
        }
        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        public Proveedor() { }
        public Proveedor(int id, string rz, string cuit)
        {
            this.ID = id;
            this.RazonSocial = rz;
            this.CUIT = cuit;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Proveedor p = (Proveedor)obj;
            return (CUIT == p.CUIT);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("ID : {0} PROVEEDOR : {1} \n", this.ID,this.RazonSocial);
            sb.AppendLine("CUIT :" + this.CUIT);
  
            return sb.ToString();
        }
    }
}
