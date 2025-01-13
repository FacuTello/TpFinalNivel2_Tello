using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Dominio
{
    public class Articulo
    {

        public string Nombre { get; set; }

        public string codigoArticulo { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
        public decimal Precio { get; set; }

        public Categoria Categoria { get; set; }

        public Marca Marca { get; set; }

        public int Id { get; set; }
    }
}      

