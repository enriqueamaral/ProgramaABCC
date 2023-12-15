using ProgramaABCC.Models;
using System.Threading.Tasks;

namespace ProgramaABCC
{
    public partial class Form1 : Form
    {
        private readonly Servicios _servicios;

        public Form1(Servicios servicios)
        {
            InitializeComponent(); 

            _servicios = servicios;
            buttonAlta.Enabled = false;
            buttonActualizar.Enabled = false;
            buttonBorrar.Enabled = false;
            comboBoxDepartamento.Enabled = false;
            checkBoxDescontinuado.Enabled = false;
            textBoxArticulo.Enabled = false;
            textBoxMarca.Enabled = false;
            textBoxModelo.Enabled = false;
            textBoxStock.Enabled = false;
            textBoxCantidad.Enabled = false;
            comboBoxClase.Enabled = false;
            comboBoxFamilia.Enabled = false;
            dateTimePickerFechaAlta.Enabled = false;
            dateTimePickerFechaBaja.Enabled = false;
            dateTimePickerFechaAlta.Text = string.Empty;
            dateTimePickerFechaBaja.Text = string.Empty;
            ObtenerDepartamentos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            if (textBoxSku.Text != null && textBoxSku.Text.Length > 0)
            {
                var sku = Convert.ToInt32(textBoxSku.Text);
                Articulo articulo = new Articulo();
                articulo = _servicios.Consultar(sku);
                if (articulo != null)
                {
                    textBoxArticulo.Text = articulo.Articulo1;
                    textBoxMarca.Text = articulo.Marca;
                    textBoxModelo.Text = articulo.Modelo;
                    comboBoxDepartamento.Text = articulo.Departamento.ToString();
                    comboBoxClase.Text = articulo.Clase.ToString();
                    comboBoxFamilia.Text = articulo.Familia.ToString();
                    textBoxStock.Text = articulo.Stock.ToString();
                    textBoxCantidad.Text = articulo.Cantidad.ToString();
                    dateTimePickerFechaAlta.Text = articulo.FechaAlta.ToString();
                    dateTimePickerFechaBaja.Text = articulo.FechaBaja.ToString();

                    buttonActualizar.Enabled = true;
                    buttonBorrar.Enabled = true;
                    comboBoxDepartamento.Enabled = true;
                    checkBoxDescontinuado.Enabled = true;
                    textBoxArticulo.Enabled = true;
                    textBoxMarca.Enabled = true;
                    textBoxModelo.Enabled = true;
                    textBoxStock.Enabled = true;
                    textBoxCantidad.Enabled = true;


                }
                else
                {
                    textBoxArticulo.Text = string.Empty;
                    textBoxMarca.Text = string.Empty;
                    textBoxModelo.Text = string.Empty;
                    comboBoxDepartamento.Text = string.Empty;
                    comboBoxClase.Text = string.Empty;
                    comboBoxFamilia.Text = string.Empty;
                    textBoxStock.Text = string.Empty;
                    textBoxCantidad.Text = string.Empty;
                    dateTimePickerFechaAlta.Text = string.Empty;
                    dateTimePickerFechaBaja.Text = string.Empty;
                    checkBoxDescontinuado.Checked = false;

                    comboBoxDepartamento.Enabled = true;
                    buttonAlta.Enabled = true;
                    buttonActualizar.Enabled = false;
                    buttonBorrar.Enabled = false;
                    comboBoxClase.Enabled = false;
                    comboBoxFamilia.Enabled = false;
                    checkBoxDescontinuado.Enabled = false;

                    textBoxArticulo.Enabled = true;
                    textBoxMarca.Enabled = true;
                    textBoxModelo.Enabled = true;
                    textBoxStock.Enabled = true;
                    textBoxCantidad.Enabled = true;

                }
            }
        }

        private void buttonAlta_Click(object sender, EventArgs e)
        {
            int sku = Convert.ToInt32(textBoxSku.Text);
            string articulo1 = textBoxArticulo.Text;
            string marca = textBoxMarca.Text;
            string modelo = textBoxModelo.Text;
            int departamento = Convert.ToInt32(comboBoxDepartamento.Text);
            int clase = Convert.ToInt32(comboBoxClase.Text);
            int familia = Convert.ToInt32(comboBoxFamilia.Text);
            int stock = Convert.ToInt32(textBoxStock.Text);
            int cantidad = Convert.ToInt32(textBoxCantidad.Text);

            _servicios.Alta(sku, articulo1, marca, modelo, departamento, clase, familia, stock, cantidad);            

        }

        private string RecibirNombreClase(int numeroClase, int numeroDepartamento)
        {
            List<Clase> clases = new List<Clase>();
            clases = _servicios.ObtenerClases(numeroDepartamento);
            string nombreClase = "";
            foreach (Clase clase in clases)
            {
                if (clase.NumeroClase == numeroClase)
                {
                    nombreClase = clase.NombreClase;
                }
            }
            comboBoxFamilia.Enabled = true;
            return nombreClase;
        }

        private void ObtenerDepartamentos()
        {
            comboBoxDepartamento.Items.Clear();

            var departamentos = _servicios.ObtenerDepartamentos();

            foreach (var departamento in departamentos)
            {
                comboBoxDepartamento.Items.Add(departamento.NumeroDepartamento);
            }
        }

        private void ObtenerClases(int numeroDepartamento)
        {
            comboBoxClase.Items.Clear();

            var clases = _servicios.ObtenerClases(numeroDepartamento);

            foreach (var clase in clases)
            {
                comboBoxClase.Items.Add(clase.NumeroClase);
            }
        }

        private void ObtenerFamilias(string nombreClase)
        {
            comboBoxFamilia.Items.Clear();

            var familias = _servicios.ObtenerFamilias(nombreClase);

            foreach (var familia in familias)
            {
                comboBoxFamilia.Items.Add(familia.NumeroFamilia);
            }
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroDepartamento = Convert.ToInt32(comboBoxDepartamento.SelectedItem);

            // Cargar las clases basadas en el departamento seleccionado
            ObtenerClases(numeroDepartamento);
            comboBoxClase.Enabled = true;
        }

        private void comboBoxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numeroDepartamento = Convert.ToInt32(comboBoxDepartamento.SelectedItem);
            int numeroClase = Convert.ToInt32(comboBoxClase.SelectedItem);

            ObtenerFamilias(RecibirNombreClase(numeroClase, numeroDepartamento));
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var confirmar = MessageBox.Show("¿Confirma la actualización del artículo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {

                int sku = Convert.ToInt32(textBoxSku.Text);
                string articulo1 = textBoxArticulo.Text;
                string marca = textBoxMarca.Text;
                string modelo = textBoxModelo.Text;
                int departamento = Convert.ToInt32(comboBoxDepartamento.Text);
                int clase = Convert.ToInt32(comboBoxClase.Text);
                int familia = Convert.ToInt32(comboBoxFamilia.Text);
                int stock = Convert.ToInt32(textBoxStock.Text);
                int cantidad = Convert.ToInt32(textBoxCantidad.Text);
                int descontinuado = Convert.ToInt32(checkBoxDescontinuado.Checked);

                _servicios.Actualizar(sku, articulo1, marca, modelo, departamento, clase, familia, stock, cantidad, descontinuado);
            }

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            var sku = Convert.ToInt32(textBoxSku.Text);

            var confirmar = MessageBox.Show("¿Confirma la eliminación del artículo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {

                _servicios.Borrar(sku);

                textBoxArticulo.Text = string.Empty;
                textBoxMarca.Text = string.Empty;
                textBoxModelo.Text = string.Empty;
                comboBoxDepartamento.Text = string.Empty;
                comboBoxClase.Text = string.Empty;
                comboBoxFamilia.Text = string.Empty;
                textBoxStock.Text = string.Empty;
                textBoxCantidad.Text = string.Empty;
                dateTimePickerFechaAlta.Text = string.Empty;
                dateTimePickerFechaBaja.Text = string.Empty;
                checkBoxDescontinuado.Checked = false;

                MessageBox.Show("Articulo Eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            

        }
    }
}
