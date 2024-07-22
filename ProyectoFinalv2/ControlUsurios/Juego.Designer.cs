namespace ProyectoFinalv2.ControlUsurios
{
    partial class Juego
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
            labelMostrar = new Label();
            buttonOpcion1 = new Button();
            buttonOpcion2 = new Button();
            buttonOpcion3 = new Button();
            buttonOpcion4 = new Button();
            flowLayoutPanelCorazon = new FlowLayoutPanel();
            buttonSiguiente = new Button();
            progressBarTimer = new ProgressBar();
            labelNombrejugador = new Label();
            labelPuntaje = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelMostrar
            // 
            labelMostrar.BackColor = Color.FromArgb(255, 192, 192);
            labelMostrar.BorderStyle = BorderStyle.FixedSingle;
            labelMostrar.Cursor = Cursors.No;
            labelMostrar.FlatStyle = FlatStyle.Flat;
            labelMostrar.Font = new Font("Segoe UI", 13F);
            labelMostrar.Location = new Point(168, 58);
            labelMostrar.Name = "labelMostrar";
            labelMostrar.Size = new Size(502, 158);
            labelMostrar.TabIndex = 0;
            labelMostrar.Text = "-";
            labelMostrar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonOpcion1
            // 
            buttonOpcion1.BackColor = Color.FromArgb(255, 255, 192);
            buttonOpcion1.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpcion1.FlatAppearance.BorderColor = Color.Black;
            buttonOpcion1.FlatAppearance.BorderSize = 4;
            buttonOpcion1.FlatStyle = FlatStyle.Flat;
            buttonOpcion1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonOpcion1.Location = new Point(183, 243);
            buttonOpcion1.Name = "buttonOpcion1";
            buttonOpcion1.Size = new Size(224, 87);
            buttonOpcion1.TabIndex = 1;
            buttonOpcion1.Text = "button1";
            buttonOpcion1.UseVisualStyleBackColor = false;
            buttonOpcion1.Click += buttonOpcion1_Click;
            // 
            // buttonOpcion2
            // 
            buttonOpcion2.BackColor = Color.FromArgb(255, 255, 192);
            buttonOpcion2.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpcion2.FlatAppearance.BorderColor = Color.Black;
            buttonOpcion2.FlatAppearance.BorderSize = 4;
            buttonOpcion2.FlatStyle = FlatStyle.Flat;
            buttonOpcion2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonOpcion2.Location = new Point(426, 243);
            buttonOpcion2.Name = "buttonOpcion2";
            buttonOpcion2.Size = new Size(227, 87);
            buttonOpcion2.TabIndex = 1;
            buttonOpcion2.Text = "button1";
            buttonOpcion2.UseVisualStyleBackColor = false;
            buttonOpcion2.Click += buttonOpcion2_Click;
            // 
            // buttonOpcion3
            // 
            buttonOpcion3.BackColor = Color.FromArgb(255, 255, 192);
            buttonOpcion3.FlatAppearance.BorderColor = Color.Black;
            buttonOpcion3.FlatAppearance.BorderSize = 4;
            buttonOpcion3.FlatStyle = FlatStyle.Flat;
            buttonOpcion3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonOpcion3.Location = new Point(183, 360);
            buttonOpcion3.Name = "buttonOpcion3";
            buttonOpcion3.Size = new Size(224, 89);
            buttonOpcion3.TabIndex = 1;
            buttonOpcion3.Text = "button1";
            buttonOpcion3.UseVisualStyleBackColor = false;
            buttonOpcion3.Click += buttonOpcion3_Click;
            // 
            // buttonOpcion4
            // 
            buttonOpcion4.BackColor = Color.FromArgb(255, 255, 192);
            buttonOpcion4.FlatAppearance.BorderColor = Color.Black;
            buttonOpcion4.FlatAppearance.BorderSize = 4;
            buttonOpcion4.FlatStyle = FlatStyle.Flat;
            buttonOpcion4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            buttonOpcion4.Location = new Point(426, 358);
            buttonOpcion4.Name = "buttonOpcion4";
            buttonOpcion4.Size = new Size(227, 93);
            buttonOpcion4.TabIndex = 1;
            buttonOpcion4.Text = "button1";
            buttonOpcion4.UseVisualStyleBackColor = false;
            buttonOpcion4.Click += buttonOpcion4_Click;
            // 
            // flowLayoutPanelCorazon
            // 
            flowLayoutPanelCorazon.BackColor = Color.Transparent;
            flowLayoutPanelCorazon.BackgroundImageLayout = ImageLayout.Stretch;
            flowLayoutPanelCorazon.Location = new Point(27, 29);
            flowLayoutPanelCorazon.Name = "flowLayoutPanelCorazon";
            flowLayoutPanelCorazon.Size = new Size(135, 290);
            flowLayoutPanelCorazon.TabIndex = 2;
            // 
            // buttonSiguiente
            // 
            buttonSiguiente.BackColor = Color.Transparent;
            buttonSiguiente.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSiguiente.FlatAppearance.BorderSize = 0;
            buttonSiguiente.FlatStyle = FlatStyle.Flat;
            buttonSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Document);
            buttonSiguiente.ForeColor = Color.Transparent;
            buttonSiguiente.Location = new Point(700, 386);
            buttonSiguiente.Name = "buttonSiguiente";
            buttonSiguiente.Size = new Size(151, 96);
            buttonSiguiente.TabIndex = 3;
            buttonSiguiente.UseVisualStyleBackColor = false;
            buttonSiguiente.Click += buttonSiguiente_Click;
            // 
            // progressBarTimer
            // 
            progressBarTimer.BackColor = SystemColors.ControlDarkDark;
            progressBarTimer.Location = new Point(168, 17);
            progressBarTimer.Name = "progressBarTimer";
            progressBarTimer.Size = new Size(502, 44);
            progressBarTimer.Step = 5;
            progressBarTimer.TabIndex = 5;
            // 
            // labelNombrejugador
            // 
            labelNombrejugador.BackColor = Color.Transparent;
            labelNombrejugador.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelNombrejugador.Location = new Point(773, 58);
            labelNombrejugador.Name = "labelNombrejugador";
            labelNombrejugador.Size = new Size(110, 25);
            labelNombrejugador.TabIndex = 6;
            labelNombrejugador.Text = "Francisco";
            // 
            // labelPuntaje
            // 
            labelPuntaje.BackColor = Color.Transparent;
            labelPuntaje.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            labelPuntaje.Location = new Point(785, 138);
            labelPuntaje.Name = "labelPuntaje";
            labelPuntaje.Size = new Size(90, 34);
            labelPuntaje.TabIndex = 6;
            labelPuntaje.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(945, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 149);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImage = Properties.Resources.fondo3;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(buttonOpcion1);
            Controls.Add(labelPuntaje);
            Controls.Add(labelNombrejugador);
            Controls.Add(progressBarTimer);
            Controls.Add(buttonSiguiente);
            Controls.Add(flowLayoutPanelCorazon);
            Controls.Add(buttonOpcion4);
            Controls.Add(buttonOpcion3);
            Controls.Add(buttonOpcion2);
            Controls.Add(labelMostrar);
            Name = "Juego";
            Size = new Size(912, 510);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label labelMostrar;
        private Button buttonOpcion1;
        private Button buttonOpcion2;
        private Button buttonOpcion3;
        private Button buttonOpcion4;
        private FlowLayoutPanel flowLayoutPanelCorazon;
        private Button buttonSiguiente;
        private ProgressBar progressBarTimer;
        private Label labelNombrejugador;
        private Label labelPuntaje;
        private PictureBox pictureBox1;
    }
}
