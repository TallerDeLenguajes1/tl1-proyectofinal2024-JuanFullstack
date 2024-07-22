using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2.Backend
{
    public class ControladorImagen
    {
        private System.Windows.Forms.Timer timerDisappear;
        
        public ControladorImagen()
        {
            // Inicializar el temporizador de desaparición
            timerDisappear = new System.Windows.Forms.Timer();
            timerDisappear.Interval = 800; // 2 segundos
            timerDisappear.Tick += TimerDisappear_Tick;
            
        }

        public void IniciarProceso(PictureBox pictureBox, string imagePath)
        {
            // Configurar el PictureBox
            pictureBox.ImageLocation = imagePath;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Visible = true; // Mostrar el PictureBox

            // Iniciar el temporizador de desaparición
            timerDisappear.Tag = pictureBox; // Usar Tag para almacenar el PictureBox
            timerDisappear.Start();
        }


    
        


        public void MostrarGif(PictureBox pictureBox, string imagePath)
        {
            // Configurar el PictureBox
            pictureBox.ImageLocation = imagePath;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Visible = true; // Mostrar el PictureBox   
           
        }




        private void TimerDisappear_Tick(object sender, EventArgs e)
        {
            // Obtener el PictureBox desde Tag
            PictureBox pictureBox = (PictureBox)timerDisappear.Tag;

            // Ocultar el PictureBox
            pictureBox.Visible = false;

            // Detener el temporizador de desaparición
            timerDisappear.Stop();
        }
    }











}
