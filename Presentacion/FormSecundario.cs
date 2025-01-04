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
        public FormSecundario()
        {
            InitializeComponent();
        }

        private void btnCancelarSecundario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptarSecundario_Click(object sender, EventArgs e)
        {

            Articulo agregado = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                agregado.Nombre = txtNombre.Text;
                agregado.Descripcion = txtDescripcion.Text;
                agregado.Precio = int.Parse(txtPrecio.Text);
                agregado.Categoria = (Categoria)cbCategoria.SelectedItem;
                agregado.Marca = (Categoria)cbMarca.SelectedItem;
                negocio.agregar(agregado);
                MessageBox.Show("Se ha agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormSecundario_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                cbCategoria.DataSource = negocio.listarCategoria();
                cbMarca.DataSource = negocio.listarMarca();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
