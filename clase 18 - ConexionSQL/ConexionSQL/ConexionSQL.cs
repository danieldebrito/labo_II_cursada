using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace ConexionSQLLibrary
{
    public static class ConexionSQL
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        static ConexionSQL()
        {
            // CREO UN OBJETO SQLCONECTION
            _conexion = new SqlConnection(Properties.Settings.Default.ConectionString);
            // CREO UN OBJETO SQLCOMMAND
            _comando = new SqlCommand();
            // INDICO EL TIPO DE COMANDO
            _comando.CommandType = System.Data.CommandType.Text;
            // ESTABLEZCO LA CONEXION
            _comando.Connection = ConexionSQL._conexion;
        }

        public static bool TestConetion()
        {
            try
            {
                _conexion.Open();
                _conexion.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public static string traerInfo()
        {
            _comando.Connection = _conexion;
            _comando.CommandType = CommandType.Text;
            _comando.CommandText = "SELECT * FROM personas ORDER BY apellido, nombre";
            _conexion.Open();

            SqlDataReader Odr = _comando.ExecuteReader();

            StringBuilder sb = new StringBuilder();

            while (Odr.Read())
            {
                sb.AppendLine(Odr["nombre"].ToString() + " " + Odr["apellido"].ToString());
            }

            Odr.Close();
            _conexion.Close();

            return sb.ToString();
        }
        public static Lista<Persona> getLista()
        {
            _comando.Connection = _conexion;
            _comando.CommandType = CommandType.Text;
            _comando.CommandText = "SELECT * FROM personas ORDER BY apellido, nombre";
            _conexion.Open();
            SqlDataReader dr = _comando.ExecuteReader();
            Lista<Persona> lista = new Lista<Persona>(1000);

            while (dr.Read())
            {
                Persona p = new Persona(int.Parse(dr[0].ToString()), dr[1].ToString(), dr[2].ToString(), int.Parse(dr[3].ToString()));
                lista.Agregar(p);
            }
            dr.Close();
            _conexion.Close();

            return lista;
        }
        public static bool agregarPersona(Persona p)
        {
            try
            {
                _comando.Connection = _conexion;
                _comando.CommandType = CommandType.Text;
                _comando.CommandText = "INSERT  INTO Personas (nombre, apellido, edad) VALUES ('" + p._nombre + "','" + p._apellido + "','" + p._edad + "' )";
                _conexion.Open();
                if (_comando.ExecuteNonQuery() > 0)
                {
                    _conexion.Close();
                    return true;
                }
                else
                    _conexion.Close();
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                _conexion.Close();
                return false;
            }
        }
        public static Persona ObtenerPersonaPorID(int id)
        {
            bool TodoOk = false;
            Persona p = null;

            try
            {
                // LE PASO LA INSTRUCCION SQL
                _comando.CommandText = "SELECT * FROM Personas WHERE id = " + id.ToString();
                // ESTABLESCO LA CONEXION
                _comando.Connection = _conexion;

                // ABRO LA CONEXION A LA BD
                _conexion.Open();

                // EJECUTO EL COMMAND                 
                SqlDataReader dr = _comando.ExecuteReader();

                // SI HAY REGISTROS...               
                if (dr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    p = new Persona(int.Parse(dr["id"].ToString()), dr["apellido"].ToString(),
                        dr["nombre"].ToString(), int.Parse(dr["edad"].ToString()));
                }
                //CIERRO EL DATAREADER
                dr.Close();

                TodoOk = true;
            }

            catch (Exception)
            {
                TodoOk = false;
            }
            finally
            {

                if (TodoOk)
                    _conexion.Close();

            }

            return p;
        }
        public static bool ModificarPersona(Persona p)
        {
            bool checkOK = false;

            //reparto en dos partes el string ya que es muy largo
            string InstruccionSQL = "UPDATE Personas SET nombre = '" + p.Nombre + "', apellido = '";
            InstruccionSQL = InstruccionSQL + p.Apellido + "', edad = " + p.Edad.ToString() + " WHERE id = " + p.ID.ToString();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                _comando.CommandText = InstruccionSQL;

                // ABRO LA CONEXION A LA BD
                _conexion.Open();

                // EJECUTO EL COMMAND
                _comando.ExecuteNonQuery();

                checkOK = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                checkOK = false;
            }
            finally
            {
                //if (checkOK)
                    _conexion.Close();
            }
            return checkOK;
        }
        public static bool DeletePersona(Persona p)
        {
            bool checkOK = false;

            
            string InstruccionSQL = "DELETE FROM Personas WHERE id = " + p.ID.ToString();

            try
            {
                // LE PASO LA INSTRUCCION SQL
                _comando.CommandText = InstruccionSQL;

                // ABRO LA CONEXION A LA BD
                _conexion.Open();

                // EJECUTO EL COMMAND
                _comando.ExecuteNonQuery();

                checkOK = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                checkOK = false;
            }
            finally
            {
                //if (checkOK)
                _conexion.Close();
            }
            return checkOK;
        }
    }
}

