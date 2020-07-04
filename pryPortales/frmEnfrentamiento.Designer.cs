namespace pryPortales
{
    partial class frmEnfrentamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdAtaque = new System.Windows.Forms.Button();
            this.cmdDefensa = new System.Windows.Forms.Button();
            this.cmdAtaque2 = new System.Windows.Forms.Button();
            this.lstPJ = new System.Windows.Forms.ListBox();
            this.cmdEnfrentamiento = new System.Windows.Forms.Button();
            this.picInformacion = new System.Windows.Forms.PictureBox();
            this.picEnemigo = new System.Windows.Forms.PictureBox();
            this.picPersonaje = new System.Windows.Forms.PictureBox();
            this.lstPNJ = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonaje)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAtaque
            // 
            this.cmdAtaque.Location = new System.Drawing.Point(12, 117);
            this.cmdAtaque.Name = "cmdAtaque";
            this.cmdAtaque.Size = new System.Drawing.Size(75, 23);
            this.cmdAtaque.TabIndex = 0;
            this.cmdAtaque.Text = "Ataque";
            this.cmdAtaque.UseVisualStyleBackColor = true;
            this.cmdAtaque.Click += new System.EventHandler(this.cmdAtaque_Click_1);
            // 
            // cmdDefensa
            // 
            this.cmdDefensa.Location = new System.Drawing.Point(12, 155);
            this.cmdDefensa.Name = "cmdDefensa";
            this.cmdDefensa.Size = new System.Drawing.Size(75, 23);
            this.cmdDefensa.TabIndex = 1;
            this.cmdDefensa.Text = "Defensa";
            this.cmdDefensa.UseVisualStyleBackColor = true;
            this.cmdDefensa.Click += new System.EventHandler(this.cmdDefensa_Click);
            // 
            // cmdAtaque2
            // 
            this.cmdAtaque2.Location = new System.Drawing.Point(12, 195);
            this.cmdAtaque2.Name = "cmdAtaque2";
            this.cmdAtaque2.Size = new System.Drawing.Size(75, 23);
            this.cmdAtaque2.TabIndex = 2;
            this.cmdAtaque2.Text = "Ataque 2";
            this.cmdAtaque2.UseVisualStyleBackColor = true;
            this.cmdAtaque2.Click += new System.EventHandler(this.cmdAtaque2_Click);
            // 
            // lstPJ
            // 
            this.lstPJ.FormattingEnabled = true;
            this.lstPJ.Location = new System.Drawing.Point(10, 233);
            this.lstPJ.Name = "lstPJ";
            this.lstPJ.Size = new System.Drawing.Size(77, 95);
            this.lstPJ.TabIndex = 5;
            // 
            // cmdEnfrentamiento
            // 
            this.cmdEnfrentamiento.Enabled = false;
            this.cmdEnfrentamiento.Location = new System.Drawing.Point(118, 275);
            this.cmdEnfrentamiento.Name = "cmdEnfrentamiento";
            this.cmdEnfrentamiento.Size = new System.Drawing.Size(127, 23);
            this.cmdEnfrentamiento.TabIndex = 6;
            this.cmdEnfrentamiento.Text = "Enfrentamiento";
            this.cmdEnfrentamiento.UseVisualStyleBackColor = true;
            this.cmdEnfrentamiento.Click += new System.EventHandler(this.cmdEnfrentamiento_Click);
            // 
            // picInformacion
            // 
            this.picInformacion.Image = global::pryPortales.Properties.Resources.Informacion__2_;
            this.picInformacion.Location = new System.Drawing.Point(93, 93);
            this.picInformacion.Name = "picInformacion";
            this.picInformacion.Size = new System.Drawing.Size(200, 163);
            this.picInformacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInformacion.TabIndex = 7;
            this.picInformacion.TabStop = false;
            // 
            // picEnemigo
            // 
            this.picEnemigo.Image = global::pryPortales.Properties.Resources.turret;
            this.picEnemigo.Location = new System.Drawing.Point(314, 23);
            this.picEnemigo.Name = "picEnemigo";
            this.picEnemigo.Size = new System.Drawing.Size(58, 71);
            this.picEnemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEnemigo.TabIndex = 4;
            this.picEnemigo.TabStop = false;
            // 
            // picPersonaje
            // 
            this.picPersonaje.Location = new System.Drawing.Point(12, 23);
            this.picPersonaje.Name = "picPersonaje";
            this.picPersonaje.Size = new System.Drawing.Size(75, 71);
            this.picPersonaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPersonaje.TabIndex = 3;
            this.picPersonaje.TabStop = false;
            // 
            // lstPNJ
            // 
            this.lstPNJ.FormattingEnabled = true;
            this.lstPNJ.Location = new System.Drawing.Point(299, 233);
            this.lstPNJ.Name = "lstPNJ";
            this.lstPNJ.Size = new System.Drawing.Size(77, 95);
            this.lstPNJ.TabIndex = 8;
            // 
            // frmEnfrentamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.lstPNJ);
            this.Controls.Add(this.picInformacion);
            this.Controls.Add(this.cmdEnfrentamiento);
            this.Controls.Add(this.lstPJ);
            this.Controls.Add(this.picEnemigo);
            this.Controls.Add(this.picPersonaje);
            this.Controls.Add(this.cmdAtaque2);
            this.Controls.Add(this.cmdDefensa);
            this.Controls.Add(this.cmdAtaque);
            this.Name = "frmEnfrentamiento";
            this.Text = "frmEnfrentamiento";
            this.Load += new System.EventHandler(this.frmEnfrentamiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInformacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAtaque;
        private System.Windows.Forms.Button cmdDefensa;
        private System.Windows.Forms.Button cmdAtaque2;
        private System.Windows.Forms.PictureBox picPersonaje;
        private System.Windows.Forms.PictureBox picEnemigo;
        private System.Windows.Forms.ListBox lstPJ;
        private System.Windows.Forms.Button cmdEnfrentamiento;
        private System.Windows.Forms.PictureBox picInformacion;
        private System.Windows.Forms.ListBox lstPNJ;
    }
}