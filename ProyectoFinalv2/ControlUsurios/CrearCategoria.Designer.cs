namespace ProyectoFinalv2.ControlUsurios
{
    partial class CrearCategoria
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
            richTextBoxCargaDatos = new RichTextBox();
            buttonCargar = new Button();
            labelMensaje = new Label();
            textBoxNombreCateoria = new TextBox();
            label1 = new Label();
            ConsultaAPI = new Button();
            label2 = new Label();
            label3 = new Label();
            buttonVolver = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(595, 337);
            button1.Name = "button1";
            button1.Size = new Size(156, 54);
            button1.TabIndex = 0;
            button1.Text = "Volver  Inicio";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBoxCargaDatos
            // 
            richTextBoxCargaDatos.Location = new Point(122, 191);
            richTextBoxCargaDatos.Name = "richTextBoxCargaDatos";
            richTextBoxCargaDatos.Size = new Size(412, 200);
            richTextBoxCargaDatos.TabIndex = 1;
            richTextBoxCargaDatos.Text = "";
            richTextBoxCargaDatos.TextChanged += richTextBoxCargaDatos_TextChanged;
            // 
            // buttonCargar
            // 
            buttonCargar.Location = new Point(595, 191);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Size = new Size(156, 55);
            buttonCargar.TabIndex = 2;
            buttonCargar.Text = "cargar";
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.Location = new Point(187, 121);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(314, 52);
            labelMensaje.TabIndex = 3;
            labelMensaje.Text = "-";
            labelMensaje.TextAlign = ContentAlignment.MiddleCenter;
            labelMensaje.Click += labelMensaje_Click;
            // 
            // textBoxNombreCateoria
            // 
            textBoxNombreCateoria.Location = new Point(230, 78);
            textBoxNombreCateoria.Name = "textBoxNombreCateoria";
            textBoxNombreCateoria.Size = new Size(227, 27);
            textBoxNombreCateoria.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 34);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre Categoria";
            // 
            // ConsultaAPI
            // 
            ConsultaAPI.Location = new Point(595, 264);
            ConsultaAPI.Name = "ConsultaAPI";
            ConsultaAPI.Size = new Size(156, 52);
            ConsultaAPI.TabIndex = 0;
            ConsultaAPI.Text = "ConsultaApi";
            ConsultaAPI.UseVisualStyleBackColor = true;
            ConsultaAPI.Click += ConsultaAPI_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(112, 433);
            label2.Name = "label2";
            label2.Size = new Size(514, 38);
            label2.TabIndex = 6;
            label2.Text = "Pregunta;Correcta;incorrecta1;incorrecta2;incorrecta3+";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(112, 408);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 7;
            label3.Text = "Formato carga  :";
            // 
            // buttonVolver
            // 
            buttonVolver.Location = new Point(33, 30);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(94, 29);
            buttonVolver.TabIndex = 8;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // CrearCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonVolver);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNombreCateoria);
            Controls.Add(labelMensaje);
            Controls.Add(buttonCargar);
            Controls.Add(richTextBoxCargaDatos);
            Controls.Add(ConsultaAPI);
            Controls.Add(button1);
            Name = "CrearCategoria";
            Size = new Size(912, 510);
            Load += CrearCategoria_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBoxCargaDatos;
        private Button buttonCargar;
        private Label labelMensaje;
        private TextBox textBoxNombreCateoria;
        private Label label1;
        private Button ConsultaAPI;
        private Label label2;
        private Label label3;
        private Button buttonVolver;
    }
}
