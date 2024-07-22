using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ProyectoFinalv2.Backend
{

    public class ControlSonido
    {
        private SoundPlayer player;

        public  SoundPlayer ckick4,
                                  lostLife,
                                  dinamica,
                                  correcto2,
                                  incorrecto,
                                  garras,
                                  lostHeart,
                                  gameOver,
                                  click1,
                                  click2,
                                  click3,
                                  click4;
        private System.Timers.Timer loopTimer;
        private System.Timers.Timer volumeTimer;
        private float currentVolume;
        private float targetVolume;
        private float volumeIncrement;

        public ControlSonido()
        {
            player = new SoundPlayer();
            loopTimer = new System.Timers.Timer();
            volumeTimer = new System.Timers.Timer();
            loopTimer.Elapsed += LoopTimerElapsed;
            volumeTimer.Elapsed += VolumeTimerElapsed;
            dinamica = new SoundPlayer(Properties.Resources.dinamica);
            correcto2 = new SoundPlayer(Properties.Resources.correcto2);
            incorrecto= new SoundPlayer(Properties.Resources.incorrecto);
            garras = new SoundPlayer(Properties.Resources.garrassonido);
            gameOver = new SoundPlayer(Properties.Resources.game_over);
            lostHeart = new SoundPlayer(Properties.Resources.lostheart3);
            click1 = new SoundPlayer(Properties.Resources.click1);
            click2 = new SoundPlayer(Properties.Resources.click2);
            click4 = new SoundPlayer(Properties.Resources.click4);
        }



        public void ReproducirSonido(string nombreArchivo)
        {
            string rutaSonido = Path.Combine("recursos", nombreArchivo);

            // Verificar si el archivo existe antes de reproducirlo
            if (File.Exists(rutaSonido))
            {
                player.SoundLocation = rutaSonido;
                player.Play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no existe.");
            }
        }

       
        public void ReproducirSonidoRecurso(string nombreRecurso)
        {
            // Obtener el recurso de sonido desde el archivo .resx
            var sonidoRecurso = Properties.Resources.ResourceManager.GetObject(nombreRecurso);

            if (sonidoRecurso != null && sonidoRecurso is UnmanagedMemoryStream)
            {
                UnmanagedMemoryStream sonidoStream = (UnmanagedMemoryStream)sonidoRecurso;
                player.Stream = sonidoStream;
                player.Play();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no existe en los recursos.");
            }
        }



        public void GenerarLoop(string nombreArchivo)
        {
            string rutaSonido = Path.Combine("recursos", nombreArchivo);

            // Verificar si el archivo existe antes de reproducirlo
            if (File.Exists(rutaSonido))
            {
                player.SoundLocation = rutaSonido;
                player.PlayLooping();
            }
            else
            {
                MessageBox.Show("El archivo de sonido no existe.");
            }
        }

        public void DetenerSonido()
        {
            player.Stop();
        }

        public void GenerarLoop(int intervaloMilisegundos)
        {
            loopTimer.Interval = intervaloMilisegundos;
            loopTimer.Start();
        }

        public void DetenerLoop()
        {
            loopTimer.Stop();
        }

        public void AumentarVolumenConTiempo(float volumenInicial, float volumenFinal, int duracionMilisegundos)
        {
            currentVolume = volumenInicial;
            targetVolume = volumenFinal;
            volumeIncrement = (targetVolume - currentVolume) / (duracionMilisegundos / 100);
            volumeTimer.Interval = 100;
            volumeTimer.Start();
        }

        private void LoopTimerElapsed(object sender, ElapsedEventArgs e)
        {
            player.Play();
        }

        private void VolumeTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (currentVolume < targetVolume)
            {
                currentVolume += volumeIncrement;
                SetVolume(currentVolume);
            }
            else
            {
                volumeTimer.Stop();
            }
        }

        private void SetVolume(float volume)
        {
            // Aquí necesitarás una implementación específica para cambiar el volumen
            // de la reproducción de audio, ya que SoundPlayer no lo soporta directamente.
            // Puedes considerar usar una librería diferente como NAudio.
        }
    }




}
