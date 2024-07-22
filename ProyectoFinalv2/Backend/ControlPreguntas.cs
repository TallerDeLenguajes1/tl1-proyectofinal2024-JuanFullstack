using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2.Backend
{
    public class ControlPreguntas
    {
        private List<FormatoApi> preguntas;
        private int indiceActual;


        public ControlPreguntas(string nombreArchivoJson)
        {
            CargarPreguntasDesdeArchivo(nombreArchivoJson);
            indiceActual = 0;
        }

        private void CargarPreguntasDesdeArchivo(string nombreArchivoJson)
        {
            string rutaArchivoJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "recursos", nombreArchivoJson);

            if (File.Exists(rutaArchivoJson))
            {
                preguntas = JsonConvert.DeserializeObject<List<FormatoApi>>(File.ReadAllText(rutaArchivoJson));
            }
            else
            {
                throw new FileNotFoundException("El archivo JSON no existe en la ubicación especificada.");
            }
        }

        public List<FormatoApi> ObtenerPreguntas()
        {
            return preguntas;
        }



    }














}
