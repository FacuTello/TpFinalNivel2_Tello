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
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Nombre, Descripcion, ImagenUrl, Precio from ARTICULOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.Imagen = (string)datos.Lector["ImagenUrl"];
                    auxiliar.Precio = (decimal)datos.Lector["Precio"];

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
                datos.cerrarConexion();
            }
            

        }

        public void agregar(Articulo nuevo)
        {

            AccesoDatos datos = new AccesoDatos();



            try
            {
                datos.setearConsulta("insert into ARTICULOS (Nombre, Descripcion, Precio) values('" + nuevo.Nombre + "', '" + nuevo.Descripcion + "'," + nuevo.Precio + ")");
                datos.ejecutarAccion();


            }
            catch (Exception ex )
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
