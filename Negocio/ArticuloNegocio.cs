using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar() 
        {
            List<Articulo> listado = new List<Articulo>();
            SqlConnection conexion =  new SqlConnection();
            SqlCommand accion = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security =true";
                accion.CommandType = System.Data.CommandType.Text;
                accion.CommandText = "Select Nombre, Descripcion, ImagenUrl, Precio from ARTICULOS";
                accion.Connection = conexion;
                conexion.Open();
                lector = accion.ExecuteReader();

                while (lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Nombre = (string)lector["Nombre"];
                    auxiliar.Descripcion = (string)lector["Descripcion"];
                    auxiliar.Imagen = (string)lector["ImagenUrl"];
                    auxiliar.Precio = (decimal)lector["Precio"];

                    listado.Add(auxiliar);
                }

                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }
    }
}
