using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalv2.Backend
{
    /*USOS AL LLAMAR 
     * 
     * // DECLARO
     * private TransicionEfecto transicionEfecto;

          public Registro()
          {
               InitializeComponent();

              // EN EL MAIN DE LA COMPONENTE 
              transicionEfecto = new TransicionEfecto(this);
              _ = MostrarTransicionAsync();
           }
     * 
     * // CREO FUNCION  
     *   private async Task MostrarTransicionAsync()
          {
        await transicionEfecto.MostrarTransicion(Properties.Resources.transicion, 3000);
       
           }
     */



    public class TransicionEfecto
    {
        private PictureBox transicion;

        public TransicionEfecto(Control parentControl)
        {
            transicion = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Fill,
                Visible = false
            };
            parentControl.Controls.Add(transicion);
        }

        public async Task MostrarTransicion(string imagenPath, int duracion)
        {
            transicion.ImageLocation = imagenPath; // Usar imagen desde una ruta del sistema
            transicion.BringToFront();
            transicion.Visible = true;
            await Task.Delay(duracion);
            transicion.Visible = false;
        }

        public async Task MostrarTransicion(Image imagen, int duracion)
        {
            transicion.Image = imagen; // Usar imagen desde los recursos del proyecto
            transicion.BringToFront();
            transicion.Visible = true;
            await Task.Delay(duracion);
            transicion.Visible = false;
        }
    }
}
