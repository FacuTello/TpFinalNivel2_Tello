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
                datos.setearConsulta("Select a.Id as idArticulo, Codigo, Nombre, a.Descripcion, idMarca, m.Descripcion as Marca, idCategoria, c.Descripcion as Categoria, ImagenUrl, Precio from Articulos a, marcas m, categorias c where a.IdMarca = m.id and a.IdCategoria = c.id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Id = (int)datos.Lector["idArticulo"];
                    auxiliar.codigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.Marca = new Marca();
                    auxiliar.Marca.Id = (int)datos.Lector["idMarca"];
                    auxiliar.Marca.Descripcion = (string)datos.Lector["Marca"];
                    auxiliar.Categoria = new Categoria();
                    auxiliar.Categoria.Id = (int)datos.Lector["idCategoria"];
                    auxiliar.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["imagenUrl"] is DBNull))
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
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo, @nombre, @descripcion, @marca, @categoria, @imagen, @precio)");
                datos.setearParametro("@codigo", nuevo.codigoArticulo);
                datos.setearParametro("@nombre", nuevo.Nombre);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@marca", nuevo.Marca.Id);
                datos.setearParametro("@categoria", nuevo.Categoria.Id);
                datos.setearParametro("@imagen", nuevo.Imagen);
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

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagen, Precio = @precio Where id = @id");
                datos.setearParametro("@codigo", modificar.codigoArticulo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("idMarca", modificar.Marca.Id);
                datos.setearParametro("idCategoria", modificar.Categoria.Id);
                datos.setearParametro("@imagen", modificar.Imagen);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);

                datos.ejecutarAccion();

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

        public void eliminar(int id)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from articulos where id = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
}
