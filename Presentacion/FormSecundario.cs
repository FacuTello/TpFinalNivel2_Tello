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
            Text = "Añadir Articulo";
        }

        public FormSecundario(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
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
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
                cbMarca.DataSource = negocio.listarMarca();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtNombre.Text = articulo.Nombre;
                    txtCodigoArticulo.Text = articulo.codigoArticulo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.Imagen;
                    cargarImagen(articulo.Imagen);
                    cbCategoria.SelectedValue = articulo.Categoria.Id;
                    cbMarca.SelectedValue = articulo.Marca.Id;
                    txtPrecio.Text = articulo.Precio.ToString();
                    

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarSecundario_Click(object sender, EventArgs e)
        {

            
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                
                    articulo = new Articulo();
                
                articulo.Nombre = txtNombre.Text;
                articulo.codigoArticulo = txtCodigoArticulo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Imagen = txtImagen.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Precio = int.Parse(txtPrecio.Text);

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Se ha modificado correctamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Se ha agregado exitosamente");
                }
                
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
