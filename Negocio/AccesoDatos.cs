using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand accion;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }

        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security =true");
            accion = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            accion.CommandType = System.Data.CommandType.Text;
            accion.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            accion.Connection = conexion;

            try
            {
                conexion.Open();
                lector = accion.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ejecutarAccion()
        {

            accion.Connection = conexion;
            try
            {
                conexion.Open();
                accion.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();

            conexion.Close();

        }

    }
}
