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
    public partial class frmPantalla : Form
    {
        public frmPantalla()
        {
            InitializeComponent();
        }


        claseNivel objNivel1 = new claseNivel();
        


        private void PantallaDeJuego_Load(object sender, EventArgs e)
        {
            

            #region Cargar Matriz Escenario y Personaje
            //según sea la dificultad, cambia el string tamaño para que abra un u otro nivel
            switch (frmPrincipal.dificultad)
            {
                case 1:
                    frmPrincipal.ADTamaño = "1.txt";
                    frmPrincipal.ADExtra = "Extra.txt";
                    break;
                case 2:
                    frmPrincipal.ADTamaño = "2.txt";
                    frmPrincipal.ADExtra = "Extra.txt";
                    break;
                case 3:
                    frmPrincipal.ADTamaño = "3.txt";
                    frmPrincipal.ADExtra = "Extra.txt";
                    break;
                default:
                    frmPrincipal.ADTamaño = "1.txt";
                    frmPrincipal.ADExtra = "Extra.txt";
                    break;
            }

            //aquí llamamos al procedimiento de nuestra clase para abrir el AD una vez ya 

            objNivel1.CrearEscenarioAlmacenado(this);
            #endregion
            #region Cambiar Tamaño de la ventana
            switch (frmPrincipal.dificultad)
            {
                case 1:
                    	this.Height = 435;	//CAMBIAR ALTURA
                        this.Width = 420;	//CAMBIAR ANCHO
                        
                    break;
                case 2:
                    	this.Height = 680;	
                        this.Width = 660;	
                    break;
                case 3:
                    	this.Height = 640;	
                        this.Width = 620;	
                    break;
                default:
                    break;
            }
            frmEnfrentamiento.alto = this.Height;
            frmEnfrentamiento.ancho = this.Width;
            #endregion
            this.CenterToScreen();

        }
        public void frmPantalla_KeyDown(object sender, KeyEventArgs e)
        {
            
            objNivel1.MovimientoPJ(e);
        }

        
    }

}
