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
    public partial class FormSecundario : Form
    {
        private Articulo articulo = null;
        public FormSecundario()
        {
            InitializeComponent();
        }

        public FormSecundario(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelarSecundario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSecundario_Load(object sender, EventArgs e)
            {   
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                cbCategoria.DataSource = negocio.listarCategoria();
                cbMarca.DataSource = negocio.listarMarca();

                if (articulo != null)
                {
                    txtNombre.Text = articulo.Nombre;
                    txtCodigoArticulo.Text = articulo.codigoArticulo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.Imagen;
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarSecundario_Click(object sender, EventArgs e)
        {

            Articulo agregado = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                agregado.Nombre = txtNombre.Text;
                agregado.codigoArticulo = txtCodigoArticulo.Text;
                agregado.Descripcion = txtDescripcion.Text;
                agregado.Imagen = txtImagen.Text;
                agregado.Marca = (Marca)cbMarca.SelectedItem;
                agregado.Categoria = (Categoria)cbCategoria.SelectedItem;
                agregado.Precio = int.Parse(txtPrecio.Text);
                negocio.agregar(agregado);
                MessageBox.Show("Se ha agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbSecundario.Load(imagen);
            }
            catch (Exception ex)
            {

                pbSecundario.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
