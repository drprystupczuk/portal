using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pryPortales
{
    public partial class frmEnfrentamiento : Form
    {
        public frmEnfrentamiento()
        {
            InitializeComponent();
        }
        static public int ancho;
        static public int alto;
        int carga = 0;
        Random r = new Random();
        int enemigo = 0;
        int maxAcciones = 3;
        int i = 0;
        static public int varPuntosPJ = 1;

        int varPuntosPNJ = 0;


        
        ClaseCola EDCola = new ClaseCola();
        ClaseCola ColaEnemigo = new ClaseCola();

        private void frmEnfrentamiento_Load(object sender, EventArgs e)
        {
            
            #region CODIGO EN COMENTARIO PARA PROBAR COSAS QUE QUERIA SABER
            /*
            ancho = Screen.PrimaryScreen.Bounds.Width;
            alto = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
             * 
            this.Height = alto;
            this.Width = ancho;
             * */

            #endregion

            #region Carga Cola Acciones Enemigo
            while (maxAcciones>0)
            {
                enemigo = r.Next(1, 4);
                switch (enemigo)
                {
                    case 1:
                        ColaEnemigo.Crear("Ataque 1");
                        break;
                    case 2:
                        ColaEnemigo.Crear("Ataque 2");
                        break;
                    case 3:
                        ColaEnemigo.Crear("Defensa");
                        break;
                    default:
                        break;
                }
                maxAcciones--;

            }
            #endregion
            
            this.Height = 400;
            this.Width = 400;
            this.CenterToScreen();

            #region Carga del personaje
            if (frmPrincipal.personaje == 1)
            {
                picPersonaje.Image = Properties.Resources.chell;
            }
            else if (frmPrincipal.personaje == 2)
            {
                picPersonaje.Image = Properties.Resources.wheatley;
            }
            #endregion
            varPuntosPJ = 1;

        }

        #region ATAQUE 1
        private void cmdAtaque_Click_1(object sender, EventArgs e)
        {
            carga++;
            varPuntosPJ = 0;
            EDCola.Crear(cmdAtaque.Text);
            if (carga == 3)
            {
                cmdAtaque.Enabled = false;
                cmdDefensa.Enabled = false;
                cmdAtaque2.Enabled = false;
                cmdEnfrentamiento.Enabled = true;
            }
        }
        #endregion

        #region DEFENSA
        private void cmdDefensa_Click(object sender, EventArgs e)
        {
            varPuntosPJ = 0;
            carga++;
            EDCola.Crear(cmdDefensa.Text);
            if (carga == 3)
            {
                cmdAtaque.Enabled = false;
                cmdDefensa.Enabled = false;
                cmdAtaque2.Enabled = false;
                cmdEnfrentamiento.Enabled = true;
            }
        }
        #endregion

        #region ATAQUE 2
        private void cmdAtaque2_Click(object sender, EventArgs e)
        {
            varPuntosPJ = 0;
            carga++;
            EDCola.Crear(cmdAtaque2.Text);
            

            if (carga == 3)
            {
                cmdAtaque.Enabled = false;
                cmdDefensa.Enabled = false;
                cmdAtaque2.Enabled = false;
                cmdEnfrentamiento.Enabled = true;
            }
        }
        #endregion

        #region INICIAR ENFRENTAMIENTO
        private void cmdEnfrentamiento_Click(object sender, EventArgs e)
        {
            carga = 0;
            lstPJ.Items.Clear();
            lstPNJ.Items.Clear();
            EDCola.Listar(lstPJ);
            ColaEnemigo.Listar(lstPNJ);

            Comparar(lstPJ, lstPNJ);


        }
        #endregion

        public void Comparar(ListBox PJ, ListBox PNJ)
        {
            while (i<3)
            {
                switch (PJ.Items[i].ToString())
                {
                    #region Ataque 1
                    case "Ataque":
                        switch (PNJ.Items[i].ToString())
                        {

                            case "Ataque 2":
                                varPuntosPJ++;
                                i++;
                                break;
                            case "Defensa":
                                varPuntosPNJ++;
                                i++;
                                break;
                            default:
                                i++;
                                break;
                        }
                        break;
                    #endregion
                    #region Ataque 2
                    case "Ataque 2":
                        switch (PNJ.Items[i].ToString())
                        {
                            case "Ataque":
                                varPuntosPNJ++;
                                i++;
                                break;
                            case "Defensa":
                                varPuntosPJ++;
                                i++;
                                break;
                            default:
                                break;
                        }
                        break;
                    #endregion
                    #region Defensa
                    case "Defensa":
                        switch (PNJ.Items[i].ToString())
                        {
                            case "Ataque":
                                varPuntosPJ++;
                                i++;
                                break;
                            case "Ataque 2":
                                varPuntosPNJ++;
                                i++;
                                break;
                            default:
                                i++;
                                break;
                        }
                        break;
                    #endregion
                    default:
                        break;
                }
                i++;
            }

               
            

            if (varPuntosPJ>varPuntosPNJ)
            {
                MessageBox.Show("Ganaste");
                this.Close();
                
                
            }
            else if (varPuntosPJ == varPuntosPNJ)
            {
                MessageBox.Show("Empate");
                this.Close();
            }
            else
            {
                MessageBox.Show("Perdiste");
                this.Close();
                frmPantalla.ActiveForm.Close();
                
            }


        }
    }
}
