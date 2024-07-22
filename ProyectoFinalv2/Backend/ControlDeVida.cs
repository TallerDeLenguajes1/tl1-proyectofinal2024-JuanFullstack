using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2.Backend
{

    
    public class ControlDeVida
    {
        ControlSonido ControlSonido = new ControlSonido();
        public static string nombreJugador;
        public static int vidas;
        public static int puntaje;
      
       
          public static void EstablecerNombre(string nombre)
         {
            nombreJugador = nombre;
         }


        private FlowLayoutPanel flowLayoutPanelCorazon;
        private Image imagenCorazon;

        // Constructor
        public ControlDeVida(string nombre, FlowLayoutPanel flowLayoutPanel)
        {
            nombreJugador = nombre;
            vidas = 3;
            flowLayoutPanelCorazon = flowLayoutPanel;
            imagenCorazon = Image.FromFile("recursos/corazon.gif"); // Asegúrate de que la imagen esté en Resources
            InicializarVidas();
           
           
        }

        // Inicializa las vidas con imágenes de corazones
        private void InicializarVidas()
        {
            for (int i = 0; i < vidas; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = imagenCorazon,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                flowLayoutPanelCorazon.Controls.Add(pictureBox);
            }
        }

        // Método para restar una vida
        public async void RestarVida()
        {
            if (vidas > 0)
            {
                
                PictureBox pictureBox = (PictureBox)flowLayoutPanelCorazon.Controls[0];
                await ParpadearImagen(pictureBox);
                flowLayoutPanelCorazon.Controls.RemoveAt(0);
                vidas--;
                
            }
            
        }

        // Método para hacer parpadear una imagen
        private async Task ParpadearImagen(PictureBox pictureBox)
        {
            await Task.Delay(2000);
            ControlSonido.lostHeart.Play();
            for (int i = 0; i < 7; i++)
            {
                pictureBox.Visible = !pictureBox.Visible;
                await Task.Delay(200);
            }
            pictureBox.Visible = false;
        }

        // Método para obtener el nombre del jugador
        public string GetNombreJugador()
        {
            return nombreJugador;
        }

        // Método para obtener las vidas restantes
        public  int GetVidas()
        {
            return vidas;
        }


        public void ActualizarPuntaje(bool respuestaCorrecta)
        {    
                if (respuestaCorrecta)
                {
                    puntaje += 100; // Ajusta el valor según tus necesidades
                    
                }
                else
                {
                    puntaje -= 50; // Ajusta el valor según tus necesidades
                    
                  
                }
        }


        









    }

}
