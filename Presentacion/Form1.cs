using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        private List<Articulo> ListaArticulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormSecundario ventanaSecundaria = new FormSecundario();
            ventanaSecundaria.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormSecundario modificar = new FormSecundario();
            modificar.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio nuevoNegocio = new ArticuloNegocio();
            ListaArticulo = nuevoNegocio.listar();
            grillaArticulos.DataSource = ListaArticulo;
            cargarImagen(ListaArticulo[0].Imagen);
            
        }

        private void grillaArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)grillaArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen);
            
        }

        private void cargarImagen(string imagen)
        {
            try
            {
               pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {

                pbImagen.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
