namespace pryPortales
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.cmdIniciar = new System.Windows.Forms.Button();
            this.gpbDificultad = new System.Windows.Forms.GroupBox();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.lblResolucion = new System.Windows.Forms.Label();
            this.gpbPersonaje = new System.Windows.Forms.GroupBox();
            this.picPersonaje = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdExtra = new System.Windows.Forms.Button();
            this.gpbDificultad.SuspendLayout();
            this.gpbPersonaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.ForeColor = System.Drawing.Color.Black;
            this.cmdIniciar.Location = new System.Drawing.Point(504, 594);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(183, 41);
            this.cmdIniciar.TabIndex = 0;
            this.cmdIniciar.Text = "INICIAR";
            this.cmdIniciar.UseVisualStyleBackColor = false;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // gpbDificultad
            // 
            this.gpbDificultad.Controls.Add(this.lblDificultad);
            this.gpbDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDificultad.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbDificultad.Location = new System.Drawing.Point(689, 270);
            this.gpbDificultad.Name = "gpbDificultad";
            this.gpbDificultad.Size = new System.Drawing.Size(336, 271);
            this.gpbDificultad.TabIndex = 1;
            this.gpbDificultad.TabStop = false;
            this.gpbDificultad.Text = "Dificultad";
            // 
            // lblDificultad
            // 
            this.lblDificultad.BackColor = System.Drawing.Color.Transparent;
            this.lblDificultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblDificultad.Location = new System.Drawing.Point(61, 120);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(204, 62);
            this.lblDificultad.TabIndex = 0;
            this.lblDificultad.Text = "Fácil";
            this.lblDificultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDificultad.Click += new System.EventHandler(this.lblDificultad_Click);
            // 
            // lblResolucion
            // 
            this.lblResolucion.Location = new System.Drawing.Point(29, 631);
            this.lblResolucion.Name = "lblResolucion";
            this.lblResolucion.Size = new System.Drawing.Size(67, 30);
            this.lblResolucion.TabIndex = 2;
            this.lblResolucion.Text = "label1";
            // 
            // gpbPersonaje
            // 
            this.gpbPersonaje.BackColor = System.Drawing.Color.Transparent;
            this.gpbPersonaje.Controls.Add(this.picPersonaje);
            this.gpbPersonaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPersonaje.ForeColor = System.Drawing.SystemColors.Control;
            this.gpbPersonaje.Location = new System.Drawing.Point(162, 270);
            this.gpbPersonaje.Name = "gpbPersonaje";
            this.gpbPersonaje.Size = new System.Drawing.Size(330, 271);
            this.gpbPersonaje.TabIndex = 4;
            this.gpbPersonaje.TabStop = false;
            this.gpbPersonaje.Text = "Personaje";
            this.gpbPersonaje.Enter += new System.EventHandler(this.gpbPersonaje_Enter);
            // 
            // picPersonaje
            // 
            this.picPersonaje.Image = global::pryPortales.Properties.Resources.chell;
            this.picPersonaje.Location = new System.Drawing.Point(72, 73);
            this.picPersonaje.Name = "picPersonaje";
            this.picPersonaje.Size = new System.Drawing.Size(177, 169);
            this.picPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonaje.TabIndex = 0;
            this.picPersonaje.TabStop = false;
            this.picPersonaje.Click += new System.EventHandler(this.picPersonaje_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryPortales.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(209, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cmdExtra
            // 
            this.cmdExtra.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.cmdExtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExtra.ForeColor = System.Drawing.Color.Black;
            this.cmdExtra.Location = new System.Drawing.Point(842, 594);
            this.cmdExtra.Name = "cmdExtra";
            this.cmdExtra.Size = new System.Drawing.Size(183, 41);
            this.cmdExtra.TabIndex = 5;
            this.cmdExtra.Text = "Extra";
            this.cmdExtra.UseVisualStyleBackColor = false;
            this.cmdExtra.Click += new System.EventHandler(this.cmdExtra_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.cmdExtra);
            this.Controls.Add(this.gpbPersonaje);
            this.Controls.Add(this.lblResolucion);
            this.Controls.Add(this.gpbDificultad);
            this.Controls.Add(this.cmdIniciar);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("PMingLiU", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Portal ";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gpbDificultad.ResumeLayout(false);
            this.gpbPersonaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdIniciar;
        private System.Windows.Forms.GroupBox gpbDificultad;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.Label lblResolucion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gpbPersonaje;
        private System.Windows.Forms.PictureBox picPersonaje;
        private System.Windows.Forms.Button cmdExtra;
    }
}

