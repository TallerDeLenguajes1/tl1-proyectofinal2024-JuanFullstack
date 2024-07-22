namespace ProyectoFinalv2.ControlUsurios
{
    partial class Puntaje
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
            flowLayoutPanelNombre = new FlowLayoutPanel();
            flowLayoutPanelPuntaje = new FlowLayoutPanel();
            label1 = new Label();
            buttonVolverCategoria = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(292, 368);
            button1.Name = "button1";
            button1.Size = new Size(161, 85);
            button1.TabIndex = 0;
            button1.Text = "Volver inicio ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanelNombre
            // 
            flowLayoutPanelNombre.Location = new Point(243, 68);
            flowLayoutPanelNombre.Name = "flowLayoutPanelNombre";
            flowLayoutPanelNombre.Size = new Size(127, 270);
            flowLayoutPanelNombre.TabIndex = 1;
            // 
            // flowLayoutPanelPuntaje
            // 
            flowLayoutPanelPuntaje.Location = new Point(376, 68);
            flowLayoutPanelPuntaje.Name = "flowLayoutPanelPuntaje";
            flowLayoutPanelPuntaje.Size = new Size(77, 270);
            flowLayoutPanelPuntaje.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(243, 21);
            label1.Name = "label1";
            label1.Size = new Size(153, 32);
            label1.TabIndex = 2;
            label1.Text = "PUNTAJES : ";
            // 
            // buttonVolverCategoria
            // 
            buttonVolverCategoria.Location = new Point(68, 61);
            buttonVolverCategoria.Name = "buttonVolverCategoria";
            buttonVolverCategoria.Size = new Size(110, 38);
            buttonVolverCategoria.TabIndex = 3;
            buttonVolverCategoria.Text = "Volver";
            buttonVolverCategoria.UseVisualStyleBackColor = true;
            buttonVolverCategoria.Click += buttonVolverCategoria_Click;
            // 
            // Puntaje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonVolverCategoria);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelPuntaje);
            Controls.Add(flowLayoutPanelNombre);
            Controls.Add(button1);
            Name = "Puntaje";
            Size = new Size(818, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanelNombre;
        private FlowLayoutPanel flowLayoutPanelPuntaje;
        private Label label1;
        private Button buttonVolverCategoria;
    }
}
