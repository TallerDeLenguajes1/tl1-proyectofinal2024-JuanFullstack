using ProyectoFinalv2.ControlUsurios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalv2
{
    
    public partial class Principal : Form
    {
        public string ventana = "Inicio";

        public Principal()
        {
            InitializeComponent();
           
            MostrarControlDeUsuario(ventana);
        }


        



        public void MostrarControlDeUsuario(string nombreControl)
        {
            UserControl control = null;

            switch (nombreControl)
            {
                case "Registro":
                    control = new Registro();
                    ((Registro)control).MainForm = this; 
                    break;

                case "Categoria":
                    control = new Categoria();
                    ((Categoria)control).MainForm = this; 
                    break;

                case "Juego":
                    control = new Juego();
                    ((Juego)control).MainForm = this; 
                    break;

                   case "CrearCategoria":
                    control = new CrearCategoria();
                    ((CrearCategoria)control).MainForm = this; 
                    break;

                case "Puntaje":
                    control = new Puntaje();
                    ((Puntaje)control).MainForm = this; 
                    break;

                case "Perdiste":
                    control = new Perdiste();
                    ((Perdiste)control).MainForm = this; // Asignar el formulario principal
                    break;


                case "Inicio":
                    control = new Inicio();
                    ((Inicio)control).MainForm = this; // Asignar el formulario principal
                    break;

               

                default:
                    MessageBox.Show("Control de usuario no encontrado");
                    return;
            }

            control.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(control);
        }







    }
}
