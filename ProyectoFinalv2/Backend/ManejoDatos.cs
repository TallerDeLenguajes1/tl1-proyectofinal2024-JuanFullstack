using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace ProyectoFinalv2.Backend
{

    public class ManejoDatos
    {


        public dynamic Get(string url)
        {
            HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
            //myWebRequest.CookieContainer = myCookie;
            myWebRequest.Credentials = CredentialCache.DefaultCredentials;
            myWebRequest.Proxy = null;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
            Stream myStream = myHttpWebResponse.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myStream);
            //Leemos los datos
            string Datos = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());

            dynamic data = JsonConvert.DeserializeObject(Datos);

            return data;
        }

        public void GenerarJSON(dynamic data, List<FormatoApi> preguntas, string nombreArchivo)
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json");

            // Crear la carpeta si no existe
            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

            // Si el archivo ya existe, cargar las preguntas existentes
            if (File.Exists(rutaArchivo))
            {
                preguntas = TraerDeJson(rutaArchivo);
            }

            // Agregar las nuevas preguntas del dynamic data
            for (int i = 0; i < data.Count; i++)
            {
                FormatoApi objetoFormatoApi = new FormatoApi
                {
                    Category = data[i].category.ToString(),
                    Id = data[i].id.ToString(),
                    CorrectAnswer = data[i].correctAnswer.ToString(),
                    IncorrectAnswers = new List<string>
            {
                data[i].incorrectAnswers[0].ToString(),
                data[i].incorrectAnswers[1].ToString(),
                data[i].incorrectAnswers[2].ToString()
            },
                    Question = new Question
                    {
                        Text = data[i].question.ToString()
                    }
                };

                preguntas.Add(objetoFormatoApi);
            }

            JsonSerializerSettings opciones = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented
            };

            string jsonString = JsonConvert.SerializeObject(preguntas, opciones);

            // Guardar el JSON en el archivo
            File.WriteAllText(rutaArchivo, jsonString);
        }

        public List<FormatoApi> TraerDeJson(string nombreArchivo)
        {
            string rutaCarpeta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json");
            string rutaArchivo = Path.Combine(rutaCarpeta, nombreArchivo);

            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    Console.WriteLine("No existen ganadores todavía");
                    return new List<FormatoApi>();
                }

                string jsonString = File.ReadAllText(rutaArchivo);
                List<FormatoApi> traidoDeJson = JsonConvert.DeserializeObject<List<FormatoApi>>(jsonString);
                return traidoDeJson;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al traer los datos del archivo JSON: {ex.Message}");
                return new List<FormatoApi>();
            }
        }

        public static void GuardarDatosEnJson(string ruta, string nombreArchivo)
        {
            var nuevoDato = new
            {
                nombreJugador = ControlDeVida.nombreJugador,
                puntaje = ControlDeVida.puntaje
            };

            // Crear la ruta si no existe
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }

            string rutaCompleta = Path.Combine(ruta, nombreArchivo);
            List<dynamic> listaDatos;

            // Leer el archivo existente y deserializar los datos si el archivo ya existe
            if (File.Exists(rutaCompleta))
            {
                string jsonExistente = File.ReadAllText(rutaCompleta);
                listaDatos = JsonConvert.DeserializeObject<List<dynamic>>(jsonExistente) ?? new List<dynamic>();
            }
            else
            {
                listaDatos = new List<dynamic>();
            }

            // Agregar el nuevo dato a la lista
            listaDatos.Add(nuevoDato);

            // Serializar la lista actualizada y escribirla en el archivo
            string json = JsonConvert.SerializeObject(listaDatos, Formatting.Indented);
            File.WriteAllText(rutaCompleta, json);
        }



    }

}