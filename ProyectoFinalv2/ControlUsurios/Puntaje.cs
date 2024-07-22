using Newtonsoft.Json;
using ProyectoFinalv2.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalv2.ControlUsurios
{

    public partial class Puntaje : UserControl
    {
        public Principal MainForm { get; set; }
        public Puntaje()
        {
            InitializeComponent();
            CargarDatosYMostrarEnFlowLayoutPanel("Jugadores", "Jugadores", flowLayoutPanelNombre, flowLayoutPanelPuntaje);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.ventana = "Inicio";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);

            }
        }

        public static void CargarDatosYMostrarEnFlowLayoutPanel(string ruta, string nombreArchivo, FlowLayoutPanel flowLayoutPanelNombre, FlowLayoutPanel flowLayoutPanelPuntaje)
        {
            string rutaCompleta = Path.Combine(ruta, nombreArchivo);

            if (!File.Exists(rutaCompleta))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            string json = File.ReadAllText(rutaCompleta);
            var datosJugadores = JsonConvert.DeserializeObject<List<dynamic>>(json) ?? new List<dynamic>();

            // Ordenar por puntaje de mayor a menor
            var datosOrdenados = datosJugadores.OrderByDescending(d => (int)d.puntaje).ToList();

            // Limpiar los FlowLayoutPanels
            flowLayoutPanelNombre.Controls.Clear();
            flowLayoutPanelPuntaje.Controls.Clear();

            // Agregar los datos ordenados a los FlowLayoutPanels
            foreach (var datos in datosOrdenados)
            {
                Label labelNombre = new Label
                {
                    Text = datos.nombreJugador,
                    ForeColor = Color.Black,
                    AutoSize = true,
                    Font = new Font(Label.DefaultFont.FontFamily, 12)
                };

                Label labelPuntaje = new Label
                {
                    Text = datos.puntaje.ToString(),
                    Font = new Font(Label.DefaultFont.FontFamily, 12, FontStyle.Bold),
                    ForeColor = Color.Red,
                    AutoSize = true
                };

                flowLayoutPanelNombre.Controls.Add(labelNombre);
                flowLayoutPanelPuntaje.Controls.Add(labelPuntaje);

                // Agregar un salto de línea
                flowLayoutPanelNombre.Controls.Add(new Label { AutoSize = true, Text = Environment.NewLine });
                flowLayoutPanelPuntaje.Controls.Add(new Label { AutoSize = true, Text = Environment.NewLine });
            }
        }

        private void buttonVolverCategoria_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.ventana = "Categoria";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }

        }
    }
























}
