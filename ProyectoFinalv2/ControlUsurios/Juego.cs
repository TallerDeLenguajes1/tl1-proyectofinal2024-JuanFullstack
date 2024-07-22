using ProyectoFinalv2.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinalv2.ControlUsurios
{
    public partial class Juego : UserControl
    {
        public Principal MainForm { get; set; }
        ManejoDatos dBApi = new ManejoDatos();
        private ControlDeVida controlDeVida;
        private TransicionEfecto transicionEfecto;
        private ControlPreguntas controlPreguntas;
        private bool controbarra = true;
        private bool controlHabilitado= true;
        private bool respondio =true ;
        private string respuestaGral;
        public static string NombreArchivo = "juego de tronos";
        private PictureBox pictureBox;
        public string respuesta;
        private List<FormatoApi> elementos;
        private List<FormatoApi> elementosRestantes;
        private Random rand;
        ControlSonido ControlSonido=new ControlSonido();
        



        public Juego()
        {
            InitializeComponent();
            ResetearBotones();
            pictureBox1.Visible = false;
            controlDeVida = new ControlDeVida(ControlDeVida.nombreJugador, flowLayoutPanelCorazon);
            elementos = cargarPregunta(NombreArchivo);
            SelectorAleatorio(elementos);
            PreguntaListaMostrar();
            InitializeTimerAndProgressBar();
            DatosGral();
            ActualizarNombreJugador();
            ControlSonido.dinamica.Play();
            transicionEfecto = new TransicionEfecto(this);
           



        }



        private async Task controlVida()
        {
            

            if (controlDeVida.GetVidas() == 1)
            {
                await Task.Delay(3000);
                if (MainForm != null)
                {
                    MainForm.ventana = "Perdiste";
                    MainForm.MostrarControlDeUsuario(MainForm.ventana);
                }
            }

        }


        private async Task MostrarTransicionAsync()
        {
            await transicionEfecto.MostrarTransicion(Properties.Resources.garra2, 900);

        }



        public void ActualizarNombreJugador()
        {
            labelNombrejugador.Text = ControlDeVida.nombreJugador;
        }

        private void DatosGral()
        {
            
            labelPuntaje.Text = ControlDeVida.puntaje.ToString();

        }
        private void InitializeTimerAndProgressBar()
        {
            // Inicializar y configurar la ProgressBar
            progressBarTimer.Maximum = 100;
            progressBarTimer.Value = 0;
            barraControl();

        }



        private async void barraControl()
        {
            await demora();

            if (progressBarTimer.Value == 100 && controbarra )
            {
                await Task.Delay(2000);
              
               if(respondio)
                {
                    ControlSonido.incorrecto.Play();
                    controlDeVida.RestarVida();
                    controlVida();
                    controlDeVida.ActualizarPuntaje(false);
                    DatosGral();
                    EvaluarRespuesta(null);
                }
               

            }
        }





        private async Task demora()
        {
            while (progressBarTimer.Value < 100 && controbarra)
            {
                await Task.Delay(350);

                if (progressBarTimer.Value + 5 <= progressBarTimer.Maximum)
                {
                    progressBarTimer.Value += 5;
                }
                else
                {
                    progressBarTimer.Value = progressBarTimer.Maximum;
                }

                if (progressBarTimer.Value > 65)
                {
                    
                    progressBarTimer.Visible = !progressBarTimer.Visible;
                }
            }

            progressBarTimer.Visible = true;
        }








        // traigo el Json segun categoria
        private List<FormatoApi> cargarPregunta(string nombreArchivo)
        {
            List<FormatoApi> NuevaLista = new List<FormatoApi>();
            NuevaLista = dBApi.TraerDeJson(nombreArchivo);
            return NuevaLista;

        }

        private void SelectorAleatorio(List<FormatoApi> elementos)
        {
            this.elementos = new List<FormatoApi>(elementos);
            this.elementosRestantes = new List<FormatoApi>(elementos);
            this.rand = new Random();
        }

        private FormatoApi ObtenerElementoAleatorio()
        {
            if (elementosRestantes.Count == 0)
            {
                // Resetear la lista de elementos restantes si todos han sido devueltos
                elementosRestantes = new List<FormatoApi>(elementos);
            }

            int indice = rand.Next(elementosRestantes.Count);
            FormatoApi elementoSeleccionado = elementosRestantes[indice];
            elementosRestantes.RemoveAt(indice);

            return elementoSeleccionado;
        }

        private void AsignarCamposAleatoriamente(FormatoApi preguntaSeleccionada)
        {
            Random rand = new Random();
            List<string> opciones = new List<string>(preguntaSeleccionada.IncorrectAnswers);
            opciones.Insert(rand.Next(opciones.Count + 1), preguntaSeleccionada.CorrectAnswer);

            buttonOpcion1.Text = opciones[0];
            buttonOpcion2.Text = opciones[1];
            buttonOpcion3.Text = opciones[2];
            buttonOpcion4.Text = opciones[3];

            labelMostrar.Text = ExtraerPregunta(preguntaSeleccionada.Question.Text) + "\n Respuesta : " + preguntaSeleccionada.CorrectAnswer;
            respuestaGral = preguntaSeleccionada.CorrectAnswer;
        }


        public static string ExtraerPregunta(string input)
        {
            // Elimina los paréntesis y el texto "text": usando manipulación de strings
            string sinParentesis = input.Trim('{', '}').Trim();
            string sinTexto = sinParentesis.Replace("\"text\":", "").Trim();
            string pregunta = sinTexto.Trim('\"');

            return pregunta;
        }

        private void PreguntaListaMostrar()
        {

            AsignarCamposAleatoriamente(ObtenerElementoAleatorio());
        }


        private void EvaluarRespuesta(Button botonSeleccionado)
        {
            
            // Array con los botones
            Button[] botones = { buttonOpcion1, buttonOpcion2, buttonOpcion3, buttonOpcion4 };

            // Recorre todos los botones
            foreach (Button boton in botones)
            {
                bool esSeleccionado = boton == botonSeleccionado;
                bool esCorrecto = boton.Text == respuestaGral;

                if (esSeleccionado && esCorrecto)
                {
                    boton.Font = new Font(boton.Font.FontFamily, 11, FontStyle.Bold);
                    boton.BackgroundImage = Properties.Resources._2;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.Width = 200;
                    boton.Height = 120;
                    ControlSonido.correcto2.Play();
                    controlDeVida.ActualizarPuntaje(true);
                    controbarra = false;
                    respondio = false;
                    DatosGral();
                }
                else if (!esSeleccionado && esCorrecto)
                {
                    boton.Font = new Font(boton.Font.FontFamily, 11, FontStyle.Bold);
                    boton.ForeColor = Color.Gray;
                    boton.BackgroundImage = Properties.Resources._4;
                    boton.TextAlign = ContentAlignment.MiddleCenter;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.Width = 200;
                    boton.Height = 120;
                   
                }
                else if (esSeleccionado && !esCorrecto)
                {
                    boton.Font = new Font(boton.Font.FontFamily, 11, FontStyle.Bold);
                    boton.ForeColor = Color.Black;
                    boton.BackgroundImage = Properties.Resources._3;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.TextAlign = ContentAlignment.MiddleCenter;
                    boton.Width = 200;
                    boton.Height = 120;
                    controbarra = false;
                    respondio = false;
                    // Llama al método para mostrar la transición (puedes ajustar la imagen y duración según necesites)
                    _ = MostrarTransicionAsync();
                    ControlSonido.garras.Play();
                    controlDeVida.RestarVida();
                    controlVida();
                    controlDeVida.ActualizarPuntaje(false);
                    DatosGral();
                }
                else if (!esSeleccionado  && !esCorrecto)
                {
                    boton.Font = new Font(boton.Font.FontFamily, 11, FontStyle.Regular);
                    boton.ForeColor = Color.Gray;
                    boton.BackgroundImage = Properties.Resources._5;
                    boton.TextAlign = ContentAlignment.MiddleCenter;
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.Width = 200;
                    boton.Height = 120;

                }

               
            }

            if (botonSeleccionado == null)
            {
               
            }

            controlHabilitado =false;
            buttonSiguiente.Enabled = true;
            buttonSiguiente.BackgroundImage = Properties.Resources.flecha2;
            buttonSiguiente.FlatStyle = FlatStyle.Flat;
            buttonSiguiente.FlatAppearance.BorderSize = 0;
            buttonSiguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSiguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSiguiente.Width = 130;
            buttonSiguiente.Height = 70;
        }















        private void ResetearBotones()
        {
            // Array con los botones
            Button[] botones = { buttonOpcion1, buttonOpcion2, buttonOpcion3, buttonOpcion4 };

            // Recorre todos los botones y los reinicia al estado por defecto
            foreach (Button boton in botones)
            {
                // Restablece las características del botón
                boton.Font = new Font(boton.Font.FontFamily, 11, FontStyle.Regular);
                boton.ForeColor = Color.Black;
                boton.Width = 200; // Ajusta estos valores según sea necesario
                boton.Height = 120; // Ajusta estos valores según sea necesario
                boton.TextAlign = ContentAlignment.MiddleCenter;
                boton.BackgroundImage = Properties.Resources._1;
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;

            }

            // Restablece el estado del botón siguiente
            controlHabilitado=true;
            buttonSiguiente.Enabled = false;
            buttonSiguiente.BackgroundImage = Properties.Resources.flecha1;
            buttonSiguiente.FlatStyle = FlatStyle.Flat;
            buttonSiguiente.FlatAppearance.BorderSize = 0;
            buttonSiguiente.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonSiguiente.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonSiguiente.Width = 130;
            buttonSiguiente.Height = 70;
        }




     










       







        private void buttonOpcion1_Click(object sender, EventArgs e)
        {
            if (controlHabilitado)
            {
                EvaluarRespuesta(buttonOpcion1);
            }
           
        }

        private void buttonOpcion2_Click(object sender, EventArgs e)
        {
            if (controlHabilitado)
            {
                EvaluarRespuesta(buttonOpcion2);
            }
        }

        private void buttonOpcion3_Click(object sender, EventArgs e)
        {
            if (controlHabilitado)
            {
                EvaluarRespuesta(buttonOpcion3);
            }
        }

        private void buttonOpcion4_Click(object sender, EventArgs e)
        {
            if (controlHabilitado)
            {
                EvaluarRespuesta(buttonOpcion4);
            }
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            ResetearBotones();
            controbarra = true;
            respondio = true;
            progressBarTimer.Maximum = 100;
            progressBarTimer.Value = 0;
            PreguntaListaMostrar();
            barraControl();
            ControlSonido.dinamica.Play();

        }

       
    }
}
