using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinalv2.Backend;
using System.Runtime.InteropServices;

namespace ProyectoFinalv2.ControlUsurios
{
    public partial class CrearCategoria : UserControl
    {
        public Principal MainForm { get; set; }
        ManejoDatos dBApi = new ManejoDatos();
        private Juego Juego { get; set; }

        private static readonly Random random = new Random();
        private static readonly string chars = "abcdefghijklmnopqrstuvwxyz0123456789";

        public CrearCategoria()
        {
            InitializeComponent();
            labelMensaje.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.ventana = "Inicio";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }
        }

        private void richTextBoxCargaDatos_TextChanged(object sender, EventArgs e)
        {

        }


        public void Consulta()
        {
            dynamic respuesta = dBApi.Get("https://the-trivia-api.com/v2/questions/");
            List<FormatoApi> formatoApis = new List<FormatoApi>();
            dBApi.GenerarJSON(respuesta, formatoApis, "respuesta desde API.json");


        }




        public void GenerarJSONDesdeString(string contenido, string nombreArchivoJson)
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json");

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            // Asegurarse de que el archivo tenga la extensión .json
            if (!nombreArchivoJson.EndsWith(".json"))
            {
                nombreArchivoJson += ".json";
            }

            string rutaArchivoJson = Path.Combine(rutaCarpeta, nombreArchivoJson);

            List<FormatoApi> preguntas = new List<FormatoApi>();

            // Leer el contenido del string
            var objetos = contenido.Split(new[] { '+' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var objeto in objetos)
            {
                var elementos = objeto.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                if (elementos.Length == 5)
                {
                    FormatoApi objetoFormatoApi = new FormatoApi
                    {
                        Question = new Question
                        {
                            Text = elementos[0].Trim()
                        },
                        CorrectAnswer = elementos[1].Trim(),
                        IncorrectAnswers = new List<string>
                {
                    elementos[2].Trim(),
                    elementos[3].Trim(),
                    elementos[4].Trim()
                },
                        Category = "DefaultCategory", // Placeholder value
                        Id = Guid.NewGuid().ToString("N"),
                        Tags = new List<string>(), // Placeholder value, can be populated if needed
                        Type = "DefaultType", // Placeholder value
                        Difficulty = "DefaultDifficulty", // Placeholder value
                        Regions = new List<string>(), // Placeholder value, can be populated if needed
                        IsNiche = false // Placeholder value
                    };

                    preguntas.Add(objetoFormatoApi);
                }
            }

            JsonSerializerSettings opciones = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            string jsonString = JsonConvert.SerializeObject(preguntas, opciones);

            // Guardar el JSON en el archivo
            File.WriteAllText(rutaArchivoJson, jsonString);
        }



        private void buttonCargar_Click(object sender, EventArgs e)
        {
            try
            {

                string contenido = richTextBoxCargaDatos.Text;
                GenerarJSONDesdeString(contenido, textBoxNombreCateoria.Text);

                // Mostrar mensaje de éxito
                labelMensaje.Text = "Se cargó correctamente";
                labelMensaje.BackColor = Color.Green;
                labelMensaje.Visible = true;
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                labelMensaje.Text = "Problema de carga";
                labelMensaje.BackColor = Color.Red;
                labelMensaje.Visible = true;
            }

            richTextBoxCargaDatos.Clear();
        }

        private void labelMensaje_Click(object sender, EventArgs e)
        {

        }

        private void ConsultaAPI_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void CrearCategoria_Load(object sender, EventArgs e)
        {

        }



        private void CrearCategoria_Load_1(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.ventana = "Categoria";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }
        }
    }








}
































