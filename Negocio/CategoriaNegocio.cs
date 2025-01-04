using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select id, descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria auxiliar = new Categoria();
                    auxiliar.Id = (int)datos.Lector["id"];
                    auxiliar.Descripcion = (string)datos.Lector["descripcion"];
                    lista.Add(auxiliar);

                }
                    return lista;
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

        public List<Categoria> listarMarca()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select id, descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria auxiliar = new Categoria();
                    auxiliar.Id = (int)datos.Lector["id"];
                    auxiliar.Descripcion = (string)datos.Lector["descripcion"];
                    lista.Add(auxiliar);

                }
                return lista;
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

    }
}
