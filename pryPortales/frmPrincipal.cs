using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace pryPortales
{
    public partial class frmPrincipal : Form
    {
        
        //declaracion de variables
        static public int personaje = 1;
        static public int dificultad;
        static public string ADTamaño;
        static public string ADExtra;
       
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ADExtra = "Extra.txt";
             dificultad = 1;
            
        }

        private void lblDificultad_Click(object sender, EventArgs e)
        {
            //aqui el usuario elige la dificultad haciendo clic en la etiqueta de texto


            dificultad++;
            
            #region ElegirDificultad
            switch (dificultad)
            {
                case 1:
                    lblDificultad.Text = "Fácil";
                    lblDificultad.ForeColor = Color.DeepSkyBlue;
                    break;
                case 2:
                    lblDificultad.Text = "Normal";
                    lblDificultad.ForeColor = Color.Orange;
                    break;
                case 3:
                    lblDificultad.Text = "Dificil";
                    lblDificultad.ForeColor = Color.Red;
                    break;
                case 4:
                    dificultad = 1;
                    lblDificultad.Text = "Fácil";
                    lblDificultad.ForeColor = Color.DeepSkyBlue;
                    break;
                default:
                    dificultad = 1;
                    lblDificultad.Text = "Fácil";
                    lblDificultad.ForeColor = Color.DeepSkyBlue;
                    break;
            }
            #endregion
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            //esto nos dirige a la pantalla de juego
            frmPantalla Jugar = new frmPantalla();
            Jugar.Show();
            //cmdIniciar.Enabled = false;
            //lblDificultad.Enabled = false;

            
        }

        private void gpbPersonaje_Enter(object sender, EventArgs e)
        {

        }

        private void picPersonaje_Click(object sender, EventArgs e)
        {
            #region Elegir personaje
            personaje++;
            switch (personaje)
            {
                case 1:
                    picPersonaje.Image = Properties.Resources.chell;
                    break;
                case 2:
                    picPersonaje.Image = Properties.Resources.wheatley;
                    break;
                case 3:
                    personaje = 1;
                    picPersonaje.Image = Properties.Resources.chell;
                    break;
                default:
                    personaje = 1;
                    picPersonaje.Image = Properties.Resources.chell;
                    break;
            }
            #endregion
        }

        private void cmdExtra_Click(object sender, EventArgs e)
        {
            frmExtra Extra = new frmExtra();
            Extra.Show();
        }




    }
}

