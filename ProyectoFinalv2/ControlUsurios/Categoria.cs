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

namespace ProyectoFinalv2.ControlUsurios
{
    public partial class Categoria : UserControl
    {
        public Principal MainForm { get; set; }
        private Juego juego;
        private SoundPlayer soundPlayer;
        ControlSonido ControlSonido=new ControlSonido();

        public Categoria()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.ResumeLayout(false);
            //Juego.NombreArchivo ;
            this.juego = juego;
            CrearRadioButtons();
            soundPlayer = new SoundPlayer(Properties.Resources.clicksimple);


        }

        // Función para crear los RadioButton según los archivos en el directorio "Json"
        private void CrearRadioButtons()
        {
            // Ruta del directorio "Json"
            string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Json");

            // Obtener todos los archivos del directorio
            string[] files = Directory.GetFiles(directoryPath, "*.json");

            // Limpiar los controles anteriores
            flowLayoutPanelCategoria.Controls.Clear();

            // Crear un RadioButton por cada archivo encontrado
            foreach (string file in files)
            {
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file).ToUpper(); // Obtener el nombre del archivo sin extensión y en mayúsculas

                RadioButton radioButton = new RadioButton
                {
                    Text = fileNameWithoutExtension, // Texto en mayúsculas sin la extensión
                    AutoSize = true,
                    Tag = file, // Guardar la ruta del archivo en la propiedad Tag
                    Font = new Font(FontFamily.GenericSansSerif, 9F, FontStyle.Bold), // Texto en negrita y más grande
                    ForeColor = Color.Black // Color inicial negro
                };

                // Suscribir al evento CheckedChanged
                radioButton.CheckedChanged += RadioButton_CheckedChanged;

                // Agregar el RadioButton al FlowLayoutPanel
                flowLayoutPanelCategoria.Controls.Add(radioButton);
            }
        }




        // Evento que se ejecuta cuando se selecciona un RadioButton
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            soundPlayer.Play();
            if (radioButton != null)
            {
                if (radioButton.Checked)
                {
                    // Asignar el nombre del archivo a la variable global
                    Juego.NombreArchivo = radioButton.Tag.ToString();
                    // Cambiar el color del texto a rojo
                    radioButton.ForeColor = Color.Red;
                }
                else
                {
                    // Restaurar el color original del texto
                    radioButton.ForeColor = Color.Black;
                }
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            ControlSonido.click4.Play();
            if (MainForm != null)
            {
                MainForm.ventana = "Juego";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControlSonido.click4.Play();
            if (MainForm != null)
            {
                MainForm.ventana = "CrearCategoria";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }
        }


    

       

        private void buttonIrPuntaje_Click(object sender, EventArgs e)
        {
            ControlSonido.click4.Play();
            if (MainForm != null)
            {
                MainForm.ventana = "Puntaje";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }
        }
    }
}
