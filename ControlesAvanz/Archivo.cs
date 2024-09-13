using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlesAvanz.Clases;

namespace ControlesAvanz
{
    public partial class Archivo : Form
    {
        List<Venta> ventas = new List<Venta>();
        public Archivo()
        {
            InitializeComponent();
            agregarVentas();
            mostrarventas();
            inicializarListBox();
            inicializarComboBoxAnios();
            inicializarComboBoxMeses();
        }

        private void Archivo_Load(object sender, EventArgs e)
        {

        }

        private void agregarVentas()
        {
            ventas.Add(new Venta(2024, 1, "Guatemala", 100000));
            ventas.Add(new Venta(2024, 2, "Guatemala", 80000));
            ventas.Add(new Venta(2024, 3, "Guatemala", 95000));
            ventas.Add(new Venta(2024, 4, "Guatemala", 120000));
            ventas.Add(new Venta(2024, 5, "Guatemala", 100000));
            ventas.Add(new Venta(2024, 6, "Guatemala", 110000));
            ventas.Add(new Venta(2024, 1, "Jutiapa", 50000));
            ventas.Add(new Venta(2024, 2, "Jutiapa", 80000));
            ventas.Add(new Venta(2024, 3, "Jutiapa", 67000));
            ventas.Add(new Venta(2024, 4, "Jutiapa", 55000));
            ventas.Add(new Venta(2024, 5, "Jutiapa", 67000));
            ventas.Add(new Venta(2024, 6, "Jutiapa", 45000));
            ventas.Add(new Venta(2024, 1, "Chiquimula", 43000));
            ventas.Add(new Venta(2024, 2, "Chiquimula", 55000));
            ventas.Add(new Venta(2024, 3, "Chiquimula", 23000));
            ventas.Add(new Venta(2024, 4, "Chiquimula", 34000));
            ventas.Add(new Venta(2024, 5, "Chiquimula", 56000));
            ventas.Add(new Venta(2024, 6, "Chiquimula", 78000));
            ventas.Add(new Venta(2024, 1, "Escuintla", 86000));
            ventas.Add(new Venta(2024, 2, "Escuintla", 75000));
            ventas.Add(new Venta(2024, 3, "Escuintla", 64000));
            ventas.Add(new Venta(2024, 4, "Escuintla", 78000));
            ventas.Add(new Venta(2024, 5, "Escuintla", 79000));
            ventas.Add(new Venta(2024, 6, "Escuintla", 90000));
            ventas.Add(new Venta(2024, 6, "Zacapa", 10000));
        }

        private void mostrarventas()
        {
            listadoVentas.Controls.Clear();
            if (SelectorDepartamento.SelectedItems.Count == 0)
            {
                foreach (Venta venta in ventas)
                {
                    Label labelventa = CrearEtiquetaventa(venta);
                    listadoVentas.Controls.Add(labelventa);
                }
            }
            else
            {
                foreach (Venta venta in ventas)
                {
                    if (SelectorDepartamento.SelectedItems.Contains(venta.Departamentos))
                    {
                        Label labelventa = CrearEtiquetaventa(venta);
                        listadoVentas.Controls.Add(labelventa);
                    }
                }

            }
        }

        private void inicializarComboBoxAnios()
        {
            List<int> anios = new List<int>();
            foreach (Venta venta in ventas)
            {
                if (!anios.Contains(venta.Anio))
                {
                    anios.Add(venta.Anio);
                }
            }
            anios.Insert(0, 0);
            foreach (int anio in anios)
            {
                if (anio == 0)
                {
                    ComboBoxAnios.Items.Add("Todos");
                }
                else
                {
                    ComboBoxAnios.Items.Add(anio.ToString());
                }
            }
            ComboBoxAnios.SelectedIndex = 0;

            ComboBoxAnios.SelectedIndexChanged += (sender, e) => mostrarVentasPorAnio();

            ComboBoxAnios.SelectedItem = "2024";
            mostrarVentasPorAnio();
        }

        private void inicializarComboBoxMeses()
        {
            List<string> meses = new List<string>();
            foreach (Venta venta in ventas)
            {
                string nombreMes = obtenerNombreMesPorNumero(venta.Mes);
                if (!meses.Contains(nombreMes))
                {
                    meses.Add(nombreMes);
                }
            }
            meses.Insert(0, "Todos");
            foreach (string mes in meses)
            {
                ComboBoxMeses.Items.Add(mes);
            }
            ComboBoxMeses.SelectedIndex = 0;

            ComboBoxMeses.SelectedIndexChanged += (sender, e) => mostrarVentasPorMes();

            ComboBoxMeses.SelectedItem = "Enero";
            mostrarVentasPorMes();
        }



        private string obtenerNombreMesPorNumero(int numeroMes)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            return meses[numeroMes - 1];
        }

        private void inicializarListBox()
        {
            List<String> departamentos = new List<String>();
            foreach (Venta venta in ventas)
                if (!departamentos.Contains(venta.Departamentos))
                {
                    departamentos.Add(venta.Departamentos);
                }
            foreach (string departamento in departamentos)
            {
                SelectorDepartamento.Items.Add(departamento);
            }
        }

        private Label CrearEtiquetaventa(Venta venta)
        {
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            Label labelventa = new Label();
            labelventa.Text = $"Año: {venta.Anio} \n Mes: {meses[venta.Mes - 1]} \n Departamento: {venta.Departamentos} \n Ventas: {venta.Ventas:C} ";
            labelventa.Font = new Font("Arial", 12, FontStyle.Bold);
            labelventa.Padding = new Padding(10);
            labelventa.BorderStyle = BorderStyle.FixedSingle;
            labelventa.Margin = new Padding(10);
            labelventa.BackColor = Color.LightGray;
            labelventa.Size = new Size(300, 120);
            listadoVentas.Controls.Add(labelventa);
            return labelventa;
        }


        private void mostrarVentasPorMes()
        {
            listadoVentas.Controls.Clear();
            if (ComboBoxMeses.Text == "Todos")
            {
                foreach (Venta venta in ventas)
                {
                    Label labelventa = CrearEtiquetaventa(venta);
                    listadoVentas.Controls.Add(labelventa);
                }
            }
            else
            {
                string mesSeleccionado = ComboBoxMeses.Text;
                foreach (Venta venta in ventas)
                {
                    if (obtenerNombreMesPorNumero(venta.Mes) == mesSeleccionado)
                    {
                        Label labelventa = CrearEtiquetaventa(venta);
                        listadoVentas.Controls.Add(labelventa);
                    }
                }
            }
        }

        private void mostrarVentasPorAnio()
        {
            listadoVentas.Controls.Clear();
            if (ComboBoxAnios.Text == "Todos")
            {
                foreach (Venta venta in ventas)
                {
                    Label labelventa = CrearEtiquetaventa(venta);
                    listadoVentas.Controls.Add(labelventa);
                }
            }
            else
            {
                int anioSeleccionado = int.Parse(ComboBoxAnios.Text);
                foreach (Venta venta in ventas)
                {
                    if (venta.Anio == anioSeleccionado)
                    {
                        Label labelventa = CrearEtiquetaventa(venta);
                        listadoVentas.Controls.Add(labelventa);
                    }
                }
            }
        }

        private void SelectorDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarventas();
        }

        private void ComboBoxAnios_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarventas();
        }

        private void ComboBoxMeses_SelectedValueChanged(object sender, EventArgs e)
        {
            mostrarventas();
        }
    }
}
