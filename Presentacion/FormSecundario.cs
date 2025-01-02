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

        }
    }
}
