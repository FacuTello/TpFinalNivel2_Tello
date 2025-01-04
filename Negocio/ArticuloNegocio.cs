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
                datos.setearConsulta("Select Codigo, Nombre, Descripcion, m.id as MarcaID, m.Descripcion as marcaDescripcion, c.id as CategoriaID, c.Descripcion as categoriaDescripcion, ImagenUrl, Precio from Articulos, marcas m, categorias c where a.IdMarca = m.id and a.IdCategoria = c.id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.codigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.Marca = new Categoria();
                    auxiliar.Marca.Id = (int)datos.Lector["MarcaID"];
                    auxiliar.Marca.Descripcion = (string)datos.Lector["marcaDescripcion"];
                    auxiliar.Categoria = new Categoria();
                    auxiliar.Categoria.Id = (int)datos.Lector["CategoriaID"];
                    auxiliar.Categoria.Descripcion = (string)datos.Lector["categoriaDescripcion"];
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
                datos.setearConsulta("insert into ARTICULOS (Nombre, Descripcion, Precio) values('" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @Precio)");
                datos.setearParametro("@precio", nuevo.Precio);
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
