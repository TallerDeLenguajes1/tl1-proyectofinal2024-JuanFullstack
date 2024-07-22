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
    public partial class Perdiste : UserControl
    {
        public Principal MainForm { get; set; }
        ControlSonido ControlSonido = new ControlSonido();
        public Perdiste()
        {
            InitializeComponent();
            ControlSonido.gameOver.Play();
            pictureBox1.Image = Image.FromFile("recursos/gameOver.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            labelNombrejugador.Text = ControlDeVida.nombreJugador;
            labelPuntaje.Text = ControlDeVida.puntaje.ToString();
            ManejoDatos.GuardarDatosEnJson("Jugadores", "Jugadores");

        }

        private void labelPuntaje_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlDeVida.vidas = 3;
            ControlDeVida.puntaje = 0;

            if (MainForm != null)
            {
                MainForm.ventana = "Juego";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }

        }

        private void VerPuntaje_Click(object sender, EventArgs e)
        {
            if (MainForm != null)
            {
                MainForm.ventana = "Puntaje";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
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
