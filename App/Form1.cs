using Manager;
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



namespace App
{
    public partial class form1 : Form
    {
        private List<Articulo> ListaArticulos;
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            // Cargar los datos
            Cargar();
            ComboBoxCampo.Items.Add("precio");
            ComboBoxCampo.Items.Add("nombre");
            ComboBoxCampo.Items.Add("categoría");
        }

        private void Cargar()
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            ListaArticulos = ArtiManager.listar();
            DgvArticulos.DataSource = ListaArticulos;
            ocultarColumnas();
        }

        private void ocultarColumnas()
        {
            DgvArticulos.Columns["ImagenUrl"].Visible = false;
            DgvArticulos.Columns["Id"].Visible = false;
            DgvArticulos.Columns["Codigo"].Visible = false;
            DgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void DgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void CargarImagen(string img)
        {
            try
            {
                pictureBoxArticulos.Load(img);
            }
            catch
            {
                pictureBoxArticulos.Load("https://mexicana.cultura.gob.mx/work/models/repositorio/img/empty.jpg");

            }
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            Form2 alta = new Form2();
            alta.ShowDialog();//traigo el otro formulario de agregar poke al hacer click 
            Cargar();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;

            //uso la sobrecarga del constructor del formulario
            Form2 _form2 = new Form2(seleccionado);
            _form2.ShowDialog();
            Cargar();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            Articulo ArtiSeleccionado = new Articulo();

            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    ArtiSeleccionado = (Articulo)DgvArticulos.CurrentRow.DataBoundItem;
                    ArtiManager.eliminarLogico(ArtiSeleccionado.Id);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        private void TextBoxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = TextBoxFiltroRapido.Text;

            if (filtro.Length >= 3) //aca indico que busque a partir de 3 caracteres
            {
                listaFiltrada = ListaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.TipoCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.TipoMarca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = ListaArticulos;
            }

            DgvArticulos.DataSource = null;
            DgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void ComboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = ComboBoxCampo.SelectedItem.ToString(); //capturo la seleccion
            if (opcion == "precio")
            {
                ComboBoxCriterio.Items.Clear();
                ComboBoxCriterio.Items.Add("Mayor a");
                ComboBoxCriterio.Items.Add("Menor a");
                ComboBoxCriterio.Items.Add("Igual a");
            }
            else
            {
                ComboBoxCriterio.Items.Clear();
                ComboBoxCriterio.Items.Add("Comienza con");
                ComboBoxCriterio.Items.Add("Termina con");
                ComboBoxCriterio.Items.Add("Contiene");
            }

        }

        private bool validarFiltro()
        {
            if (ComboBoxCampo.SelectedIndex < 0) //pregunto si campo no tiene nada seleccionado
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (ComboBoxCriterio.SelectedIndex < 0) //pregunto si criterio no tiene nada seleccionado
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            if (ComboBoxCampo.SelectedItem.ToString() == "precio")//pregunto si campo es precio
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))//si el filtro esta vacio o null
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if (!(soloNumeros(textBoxFiltroAvanzado.Text))) //por q esta en op numumerico
                {
                    MessageBox.Show("Solo nros para filtrar por un campo numerico...");
                    return true;
                }
            }
            if (ComboBoxCampo.SelectedItem.ToString() == "nombre" || ComboBoxCampo.SelectedItem.ToString() == "categoría")
            {
                if (string.IsNullOrEmpty(textBoxFiltroAvanzado.Text))//si el filtro esta vacio o null
                {
                    MessageBox.Show("Debes cargar el filtro...");
                    return true;
                }
                if ((soloNumeros(textBoxFiltroAvanzado.Text))) //por q esta en op text
                {
                    MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void BotonFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloManager ArtiManager = new ArticuloManager();
            try
            {
                if (validarFiltro()) //si hay q validar corta la ejecucion
                    return;

                string campo = ComboBoxCampo.SelectedItem.ToString();
                string criterio = ComboBoxCriterio.SelectedItem.ToString();
                string filtro = textBoxFiltroAvanzado.Text;
                DgvArticulos.DataSource = ArtiManager.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
