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

        

        public string codigoArticulo { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Precio de compra")]
        public decimal precio_compra { get; set; }

        [DisplayName("Precio de venta")]
        public decimal precio_venta { get; set; }

        public decimal ganancia { get; set; }

        

        

        public int Id { get; set; }
    }
}      

