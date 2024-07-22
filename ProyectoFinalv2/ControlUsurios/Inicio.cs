using Microsoft.VisualBasic.Devices;
using ProyectoFinalv2.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalv2.ControlUsurios
{    
    public partial class Inicio : UserControl
    {
        public Principal MainForm { get; set; }
        ControladorImagen controladorImagen = new ControladorImagen();
        ControlSonido controlSonido = new ControlSonido();
        private SoundPlayer click1;
        public Inicio()
        {
            InitializeComponent();
            ConfigurarBotones();
            controladorImagen.MostrarGif(pictureBox2, "recursos/enerigia.gif");
            controlSonido.GenerarLoop("loop.wav");
            click1 = new SoundPlayer(Properties.Resources.click1);


        }




   
        

        private void ConfigurarEfectoButton(Button boton)
        {
            boton.BackgroundImage = Properties.Resources.inicio;
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            boton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            boton.Width = 130;
            boton.Height = 130;

            // Evento cuando el cursor entra en el botón
            boton.MouseEnter += (sender, e) =>
            {
                boton.Width += 10;
                boton.Height += 10;
            };

            // Evento cuando el cursor sale del botón
            boton.MouseLeave += (sender, e) =>
            {
                boton.Width -= 10;
                boton.Height -= 10;
            };

            // Evento cuando se presiona el botón
            boton.MouseDown += (sender, e) =>
            {
                boton.Width -= 5;
                boton.Height -= 5;
            };

            // Evento cuando se libera el botón
            boton.MouseUp += (sender, e) =>
            {
                boton.Width += 5;
                boton.Height += 5;
            };
        }


       




        // Llama a esta función para cada botón que quieras configurar
        private void ConfigurarBotones()
        {
            ConfigurarEfectoButton(buttonInicioRegistro);
          
        }




        private void buttonInicioRegistro_Click(object sender, EventArgs e)
        {
            controlSonido.DetenerSonido();
            click1.Play();
           

            if (MainForm != null)
            {
                MainForm.ventana = "Registro";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }

        }










    }
}
