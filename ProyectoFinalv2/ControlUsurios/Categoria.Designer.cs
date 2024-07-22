namespace ProyectoFinalv2.ControlUsurios
{
    partial class Categoria
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanelCategoria = new FlowLayoutPanel();
            buttonIrPuntaje = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(520, 156);
            button1.Name = "button1";
            button1.Size = new Size(168, 71);
            button1.TabIndex = 0;
            button1.Text = "Jugar ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button2.Location = new Point(520, 242);
            button2.Name = "button2";
            button2.Size = new Size(168, 71);
            button2.TabIndex = 0;
            button2.Text = "Crear Categoria";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanelCategoria
            // 
            flowLayoutPanelCategoria.BackColor = Color.Transparent;
            flowLayoutPanelCategoria.Location = new Point(144, 114);
            flowLayoutPanelCategoria.Name = "flowLayoutPanelCategoria";
            flowLayoutPanelCategoria.Size = new Size(339, 364);
            flowLayoutPanelCategoria.TabIndex = 1;
            // 
            // buttonIrPuntaje
            // 
            buttonIrPuntaje.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonIrPuntaje.Location = new Point(520, 333);
            buttonIrPuntaje.Name = "buttonIrPuntaje";
            buttonIrPuntaje.Size = new Size(168, 74);
            buttonIrPuntaje.TabIndex = 2;
            buttonIrPuntaje.Text = "Ver Puntajes";
            buttonIrPuntaje.UseVisualStyleBackColor = true;
            buttonIrPuntaje.Click += buttonIrPuntaje_Click;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.categoria2;
            Controls.Add(buttonIrPuntaje);
            Controls.Add(flowLayoutPanelCategoria);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Categoria";
            Size = new Size(912, 510);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanelCategoria;
        private Button buttonIrPuntaje;
    }
}
