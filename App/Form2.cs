using Dominio;
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
using System.IO;
using System.Configuration;

namespace App
{
    public partial class Form2 : Form
    {
        private Articulo _Articulo = null;
        private OpenFileDialog archivo = null; 
        public Form2()
        {
            InitializeComponent();
            Text = "Agregar Articulo";
        }
        public Form2(Articulo Articulo)
        {
            InitializeComponent();
            _Articulo = Articulo;
            Text = "Modificar Articulo";
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            MarcaManager MarcManager = new MarcaManager();
            CategoriaManager CatManager = new CategoriaManager();
            try
            {
                ComboBoxMarca.DataSource = MarcManager.listar();
                ComboBoxMarca.ValueMember = "id";
                ComboBoxMarca.DisplayMember = "Descripcion";
                comboBoxCategoria.DataSource = CatManager.listar();
                comboBoxCategoria.ValueMember = "id";
                comboBoxCategoria.DisplayMember = "Descripcion";

                if (_Articulo != null) //pregunto si se toco modificar (!=)
                {
                    textBoxCodigo.Text = _Articulo.Codigo;
                    textBoxNombre.Text = _Articulo.Nombre;
                    textBoxDescripcion.Text = _Articulo.Descripcion;
                    textBoxUrlImagen.Text = _Articulo.ImagenUrl;
                    CargarImagen(_Articulo.ImagenUrl);
                    ComboBoxMarca.SelectedValue = _Articulo.TipoMarca.Id;
                    comboBoxCategoria.SelectedValue = _Articulo.TipoCategoria.Id;
                    textBoxPrecio.Text = _Articulo.Precio.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFiltro()
        {
            bool todoValido = true;
            decimal precio;

            // Validacion textBoxCodigo
            if (string.IsNullOrEmpty(textBoxCodigo.Text))
            {
                labelCodigo.ForeColor = Color.Red;
                labelCodigo.Text = "Codigo*";
                todoValido = false;
            }
            else
            {
                labelCodigo.ForeColor = Color.Black;
                labelCodigo.Text = "Codigo";
            }

            // Validacion textBoxNombre
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                labelNombre.ForeColor = Color.Red;
                labelNombre.Text = "Nombre*";
                todoValido = false;
            }
            else if (soloNumeros(textBoxNombre.Text))
            {
                labelNombre.ForeColor = Color.Red;
                labelNombre.Text = "Nombre*";
                MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                todoValido = false;
            }
            else
            {
                labelNombre.ForeColor = Color.Black;
                labelNombre.Text = "Nombre";
            }

            // Validacion textBoxDescripcion
            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                labelDescripcion.ForeColor = Color.Red;
                labelDescripcion.Text = "Descripcion*";
                todoValido = false;
            }
            else if (soloNumeros(textBoxDescripcion.Text))
            {
                labelDescripcion.ForeColor = Color.Red;
                labelDescripcion.Text = "Descripcion*";
                MessageBox.Show("Solo letras para filtrar por un campo de texto...");
                todoValido = false;
            }
            else
            {
                labelDescripcion.ForeColor = Color.Black;
                labelDescripcion.Text = "Descripcion";
            }

            // Validacion textBoxPrecio
            if (string.IsNullOrEmpty(textBoxPrecio.Text))
            {
                labelPrecio.ForeColor = Color.Red;
                labelPrecio.Text = "Precio*";
                todoValido = false;
            }
            else if (!decimal.TryParse(textBoxPrecio.Text, out precio))
            {
                labelPrecio.ForeColor = Color.Red;
                labelPrecio.Text = "Precio*";
                MessageBox.Show("Precio invalido. Por favor ingrese un numero valido");
                todoValido = false;
            }

            return todoValido;
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

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            // Primero se validan los campos del formulario
            if (!validarFiltro())
            {
                return; // Si la validación falla, se detiene la ejecución
            }

            ArticuloManager ArtiManager = new ArticuloManager();

            try
            {
                if (_Articulo == null) // Pregunta si se apretó agregar
                    _Articulo = new Articulo();

                _Articulo.Codigo = textBoxCodigo.Text;
                _Articulo.Nombre = textBoxNombre.Text;
                _Articulo.Descripcion = textBoxDescripcion.Text;
                _Articulo.ImagenUrl = textBoxUrlImagen.Text;
                _Articulo.TipoMarca = (Marca)ComboBoxMarca.SelectedItem;
                _Articulo.TipoCategoria = (Categoria)comboBoxCategoria.SelectedItem;
                decimal precioDecimal;
                if (decimal.TryParse(textBoxPrecio.Text, out precioDecimal)) // Convertir de string a decimal
                {
                    _Articulo.Precio = precioDecimal;
                }


                if (_Articulo.Id != 0) // Si el id es diferente de 0 significa que es para modificar
                {
                    ArtiManager.modificar(_Articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    ArtiManager.Agregar(_Articulo);
                    MessageBox.Show("Agregado exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(textBoxUrlImagen.Text);
        }

        private void CargarImagen(string img)
        {
            try
            {
                pictureBoxImg.Load(img);
            }
            catch
            {
                pictureBoxImg.Load("https://mexicana.cultura.gob.mx/work/models/repositorio/img/empty.jpg");

            }
        }

        private void BotonAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";

            if (archivo.ShowDialog() == DialogResult.OK)
            {
                textBoxUrlImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);

                //guarda la img en la carpeta
                File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
