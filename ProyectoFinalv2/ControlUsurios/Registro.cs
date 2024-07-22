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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinalv2.ControlUsurios
{
    public partial class Registro : UserControl
    {
        public Principal MainForm { get; set; }
        private SoundPlayer SoundPlayer , tap;
        ControladorImagen ControladorImagen;
        private PictureBox transicion;
        ControlSonido ControlSonido = new ControlSonido();
        private TransicionEfecto transicionEfecto;

        public Registro()
        {
            InitializeComponent();
          

            button1.Enabled = false;
            button1.ForeColor = System.Drawing.Color.Gray;
            button1.BackColor = System.Drawing.Color.LightGray;
            textBox1.TextChanged += new EventHandler(TextBox1_TextChanged);
            SoundPlayer = new SoundPlayer(Properties.Resources.click4);
            tap = new SoundPlayer(Properties.Resources.tap);
            transicionEfecto = new TransicionEfecto(this);
            // Llama al método para mostrar la transición (puedes ajustar la imagen y duración según necesites)
            _ = MostrarTransicionAsync();



        }


        private async Task MostrarTransicionAsync()
        {
            await transicionEfecto.MostrarTransicion(Properties.Resources.transicion, 1500);
            
        }








        public void RegistrarNombre(string nombre)
        {
            ControlDeVida.EstablecerNombre(nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer.Play();



            RegistrarNombre(textBox1.Text);
            if (MainForm != null)
            {
                MainForm.ventana = "Categoria";
                MainForm.MostrarControlDeUsuario(MainForm.ventana);
            }
        }


        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            tap.Play();
            DeshabilitarBoton();
        }

        private void DeshabilitarBoton()
        {
            if (textBox1.Text.Length < 3)
            {
                button1.Enabled = false;
                button1.ForeColor = System.Drawing.Color.Gray;
                button1.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                button1.Enabled = true;
                button1.ForeColor = System.Drawing.Color.Black;
                button1.BackColor = System.Drawing.Color.GreenYellow;
            }
        }


    }
}
