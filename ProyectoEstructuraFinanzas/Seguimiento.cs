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
using System.Windows.Forms.DataVisualization.Charting;
using Newtonsoft.Json;

namespace ProyectoEstructuraFinanzas
{
    public partial class Seguimiento : Form
    {
        private string _userFilePath;
        private UsuarioData _usuarioData;
        public Seguimiento(string userFilePath)
        {
            InitializeComponent();
            _userFilePath = userFilePath;
            CargarDatosUsuario();  // Asegúrate de cargar los datos del usuario aquí
            InicializarChart();
            InicializarFiltros();  // Asegúrate de inicializar los filtros aquí
            ActualizarChart();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Seguimiento_Load(object sender, EventArgs e)
        {

        }
        private void InicializarFiltros()
        {
            cmbFiltro.Items.Add("Todos");
            cmbFiltro.Items.Add("Ingresos");
            cmbFiltro.Items.Add("Gastos");
            cmbFiltro.SelectedIndex = 0;
        }
        private void CargarDatosUsuario()
        {
            if (File.Exists(_userFilePath))
            {
                var jsonData = File.ReadAllText(_userFilePath);
                _usuarioData = JsonConvert.DeserializeObject<UsuarioData>(jsonData);
            }
            else
            {
                _usuarioData = new UsuarioData();
            }
        }
        private void InicializarChart()
        {
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);
        }
        private void ActualizarChart()
        {
            if (_usuarioData == null)
            {
                MessageBox.Show("Datos del usuario no cargados correctamente.");
                return;
            }

            chart1.Series.Clear();
            var series = new Series("Presupuesto");
            series.ChartType = SeriesChartType.Column;

            var registrosFiltrados = FiltrarRegistros();
            var groupedByDate = registrosFiltrados.GroupBy(r => r.Fecha.Date)
                                                  .Select(g => new
                                                  {
                                                      Fecha = g.Key,
                                                      Total = g.Sum(r => r.Monto)
                                                  });

            foreach (var item in groupedByDate)
            {
                series.Points.AddXY(item.Fecha.ToString("dd/MM/yyyy"), item.Total);
            }

            chart1.Series.Add(series);

            MostrarDetallesFiltrados(registrosFiltrados);
        }
        private IEnumerable<Registro> FiltrarRegistros()
        {
            if (_usuarioData?.Registros == null)
            {
                return Enumerable.Empty<Registro>();
            }

            var filtro = cmbFiltro.SelectedItem != null ? cmbFiltro.SelectedItem.ToString() : "Todos";
            switch (filtro)
            {
                case "Ingresos":
                    return _usuarioData.Registros.Where(r => r.Monto > 0);
                case "Gastos":
                    return _usuarioData.Registros.Where(r => r.Monto < 0); // Cambio aquí
                default:
                    return _usuarioData.Registros;
            }
        }

        private void MostrarDetallesFiltrados(IEnumerable<Registro> registrosFiltrados)
        {
            lstDetalles.Items.Clear();
            var filtro = cmbFiltro.SelectedItem != null ? cmbFiltro.SelectedItem.ToString() : "Todos";

            foreach (var registro in registrosFiltrados)
            {
                // Cambia el formato de la cadena de montos para mostrarlo en Quetzales (Q)
                string itemText = $"{registro.Fecha:dd/MM/yyyy} - {registro.Descripcion}: Q{Math.Abs(registro.Monto):N2}";
                lstDetalles.Items.Add(itemText);
            }

            lblTotal.Text = filtro == "Ingresos"
                ? $"Total Ingresos: Q{registrosFiltrados.Sum(r => r.Monto):N2}"
                : filtro == "Gastos"
                ? $"Total Gastos: Q{registrosFiltrados.Sum(r => r.Monto):N2}"
                : $"Total: Q{registrosFiltrados.Sum(r => r.Monto):N2}";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ActualizarChart();

        }

        private void lstDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
