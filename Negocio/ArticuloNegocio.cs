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
                datos.setearConsulta("Select id, codigoArticulo, descripcion, precio_compra, precio_venta, ganancia  from articulos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Id = (int)datos.Lector["idArticulo"];
                    auxiliar.codigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.precio_compra = (decimal)datos.Lector["precio_compra"];
                    auxiliar.precio_venta = (decimal)datos.Lector["precio_venta"];
                    auxiliar.ganancia = (decimal)datos.Lector["ganancia"];

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
                
                
                datos.setearConsulta("INSERT INTO articulos (codigoArticulo, descripcion, precio_compra, precio_venta) values (@codigo, @descripcion, @precio:compra, @precio_venta)");
                datos.setearParametro("@codigo", nuevo.codigoArticulo);
                datos.setearParametro("@descripcion", nuevo.Descripcion);
                datos.setearParametro("@precio_compra", nuevo.precio_compra);
                datos.setearParametro("@precio_venta", nuevo.precio_venta);

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
                datos.setearConsulta("update articulos set Codigo = @codigo, Descripcion = @descripcion, precio_compra = @precio_compra, precio_venta = @precio_venta Where id = @id");
                datos.setearParametro("@codigo", modificar.codigoArticulo);
                datos.setearParametro("@descripcion", modificar.Descripcion);
                datos.setearParametro("@precio_compra", modificar.precio_compra);
                datos.setearParametro("@precio_venta", modificar.precio_venta);
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
