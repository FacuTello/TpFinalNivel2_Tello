using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Detalle : Form
    {
        private Articulo articulo;
        public Detalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Ver Detalle";
        }


        private void Detalle_Load(object sender, EventArgs e)
        {
            try
            {
                codigoDetalle.Text = articulo.codigoArticulo;
                nombreDetalle.Text = articulo.Nombre;
                descripcionDetalle.Text = articulo.Descripcion;
                precioDetalle.Text = articulo.Precio.ToString("F2");
                marcaDetalle.Text = articulo.Marca.Descripcion;
                categoriaDetalle.Text = articulo.Categoria.Descripcion;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAceptarDetalle_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
