using BLL;
using Entity;
using System.Drawing.Text;

namespace UI
{
    public partial class Form1 : Form
    {
        private AplicacionBusiness aplicacionBusiness = new AplicacionBusiness();
        private CategoriaBusiness categoriaBusiness = new CategoriaBusiness();
        private Aplicacion aplicacion;
        private List<Aplicacion> listaAplicacion = new List<Aplicacion>();
        public Form1()
        {
            InitializeComponent();

        }
        private void ObtenerCategoria()
        {
            List<Categoria> listaCategoria = categoriaBusiness.ObtenerCategoria();

            cmbCategoria.DataSource = listaCategoria;
            cmbCategoria.ValueMember = "IdCategoria";
            cmbCategoria.DisplayMember = "Descripcion1";

        }

        private void MostrarAplicaciones()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerCategoria();
            MostrarAplicaciones();
        }
        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                aplicacion = new Aplicacion();
                aplicacion.Titulo1 = txtTitulo.Text;
                aplicacion.Descripcion1 = txtDescripcion.Text;
                aplicacion.Desarrolladora1 = txtDesarrolladora.Text;
                aplicacion.Precio1 = Convert.ToDecimal(txtPrecio.Text);
                Categoria categoria = new Categoria();
                categoria.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                aplicacion.Categoria= categoria;
                listaAplicacion.Add(aplicacion);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                aplicacionBusiness.GuardarAplicacion(listaAplicacion);
                listaAplicacion = new List<Aplicacion>();
                MostrarAplicaciones();
                MessageBox.Show("Aplicacion agregada");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
