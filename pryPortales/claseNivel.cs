using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace pryPortales
{
    public class claseNivel
    {

        public PictureBox[,] matEscenario;
        int vFila = 0;
        int vColumna = 0;
        public int varPJFila;
        public int varPJColumna;
        public int varPPortalAFila;
        public int varPPortalAColumna;
        public int varPPortalNFila;
        public int varPPortalNColumna;
        public int Dificultad;
        public String ADTamaño;
        public int intDirección;

        

        //CONSTRUCTOR
        public claseNivel()
        {
            matEscenario = null;
            
        }

        //DESTRUCTOR
        ~claseNivel()
        {
        }

        #region CARGAR ESCENARIO

        
        public void CrearEscenarioAlmacenado(Form PantallaDeJuego)
        {
            Dificultad = frmPrincipal.dificultad;
            ADTamaño = frmPrincipal.ADTamaño;

            #region LEER EL ARCHIVO DE DATOS
            List<List<string>> matriz = new List<List<string>>();
            string[] strLineas = File.ReadAllLines(ADTamaño);
            string[] campos;

            foreach (string linea in strLineas)
            {
                List<string> lineaMatriz = new List<string>();
                campos = linea.Split(",".ToCharArray());
                lineaMatriz.AddRange(campos.ToList());
                matriz.Add(lineaMatriz);
            }
            #endregion

            #region RECORRER LA MATRIZ Y CARGAR LOS ESCENARIOS NECESARIOS.

            matEscenario = new PictureBox[matriz.Count, matriz[0].Count];

            vFila = 0;
            vColumna = 0;
            while (vFila <= matEscenario.GetUpperBound(0))
            {
                while (vColumna <= matEscenario.GetUpperBound(1))
                {
                    matEscenario[vFila, vColumna] = new PictureBox();
                    matEscenario[vFila, vColumna].Tag = "";
                    #region Carga de Imagenes y Tags
                    switch (Convert.ToInt16(matriz[vFila][vColumna]))
                    {
                        case 0:
                            matEscenario[vFila, vColumna].Image = null;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag = "Piso";
                            matEscenario[vFila, vColumna].Tag.ToString();
                            break;

                        case 1:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.portalblue;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag = "Portal Azul";
                            matEscenario[vFila, vColumna].Tag.ToString();
                            break;
                        case 2:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.Portal_orange;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag = "Portal Naranja";
                            matEscenario[vFila, vColumna].Tag.ToString();
                            break;
                        case 3:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.cubodecompañia;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag = "Cubo de Compañía";
                            matEscenario[vFila, vColumna].Tag.ToString();
                            break;
                        case 4:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.GLaDOS_Potato;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag = "Glados";
                            matEscenario[vFila, vColumna].Tag.ToString();
                            break;
                        case 5:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.turret;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag = "Torreta";
                            matEscenario[vFila, vColumna].Tag.ToString();
                            break;
                        case 9:
                            #region Selecciona Personaje
                            if (frmPrincipal.personaje == 1)
                            {
                                matEscenario[vFila, vColumna].Image = Properties.Resources.chell;

                            }
                            else
                            {
                                if (frmPrincipal.personaje == 2)
                                {
                                    matEscenario[vFila, vColumna].Image = Properties.Resources.wheatley;

                                }

                            }
                            #endregion
                            matEscenario[vFila, vColumna].Tag = "Piso"; //El personaje esta sobre el piso por eso el tag
                            matEscenario[vFila, vColumna].BringToFront();
                            break;
                        default:
                            matEscenario[vFila, vColumna].Image = null;
                            matEscenario[vFila, vColumna].SendToBack();
                            matEscenario[vFila, vColumna].Tag.ToString();
                            
                            break;
                    }
                    #endregion

                    #region Establecer tamaño y otras propiedades de la imagen segun nivel
                    switch (Dificultad)
                    {
                        case 1:
                            matEscenario[vFila, vColumna].Size = new System.Drawing.Size(100, 100);
                            matEscenario[vFila, vColumna].SizeMode = PictureBoxSizeMode.StretchImage;
                            matEscenario[vFila, vColumna].Location = new Point(100 * vColumna, 100 * vFila);
                            PantallaDeJuego.Controls.Add(matEscenario[vFila, vColumna]);
                            matEscenario[vFila, vColumna].BackColor = Color.LightGray;
                            vColumna++;
                            break;
                        case 2:
                            matEscenario[vFila, vColumna].Size = new System.Drawing.Size(80, 80);
                            matEscenario[vFila, vColumna].SizeMode = PictureBoxSizeMode.StretchImage;
                            matEscenario[vFila, vColumna].Location = new Point(80 * vColumna, 80 * vFila);
                            PantallaDeJuego.Controls.Add(matEscenario[vFila, vColumna]);
                            matEscenario[vFila, vColumna].BackColor = Color.LightGray;
                            vColumna++;
                            break;
                        case 3:
                            matEscenario[vFila, vColumna].Size = new System.Drawing.Size(60, 60);
                            matEscenario[vFila, vColumna].SizeMode = PictureBoxSizeMode.StretchImage;
                            matEscenario[vFila, vColumna].Location = new Point(60 * vColumna, 60 * vFila);
                            PantallaDeJuego.Controls.Add(matEscenario[vFila, vColumna]);
                            matEscenario[vFila, vColumna].BackColor = Color.LightGray;
                            vColumna++;
                            break;
                        default:
                            break;
                    }
                    #endregion
                }
                vFila++;
                vColumna = 0;
            }
            #endregion

            #region Carga posicion jugador y Portales
            switch (Dificultad)
            {
                case 1:
                    //POSICION PERSONAJE JUGADOR
                    varPJFila = 0;
                    varPJColumna = 3;
                    vFila = 0;
                    vColumna = 3;
                    //POSICION PORTAL AZUL
                    varPPortalAColumna = 0;
                    varPPortalAFila = 0;
                    //POSICION PORTAL NARANJA
                    varPPortalNColumna = 3;
                    varPPortalNFila = 3;
                    break;
                case 2:
                    //POSICION PERSONAJE JUGADOR
                    varPJFila = 0;
                    varPJColumna = 0;
                    vFila = 0;
                    vColumna = 0;
                    //POSICION PORTAL AZUL
                     varPPortalAColumna = 5;
                    varPPortalAFila = 3;
                    //POSICION PORTAL NARANJA
                    varPPortalNColumna = 4;
                    varPPortalNFila = 7;
                    break;
                case 3:
                    //POSICION PERSONAJE JUGADOR
                    varPJFila = 0;
                    varPJColumna = 1;
                    vFila = 0;
                    vColumna = 1;
                    //POSICION PORTAL AZUL
                    varPPortalAColumna = 9;
                    varPPortalAFila =0;
                    //POSICION PORTAL NARANJA
                    varPPortalNColumna = 0;
                    varPPortalNFila = 7;
                    break;
                default:
                    break;
            }
            #endregion
        }
            
        #endregion

        #region MovimientoPJ

        public void MovimientoPJ(KeyEventArgs e)
        {
            
            
            #region Pregunta tecla presionada por el usuario
            switch (e.KeyCode)
            {
                #region UP
                case Keys.Up:
                    
                //Mientras la Fila sea mayor a 0 podrá seguir subiendo
                    if (vFila > 0)
                    {
                        vFila -= 1;
                        #region Pregunto que hay en la siguiente posición y hago el procedimiento correspondiente
                        switch (matEscenario[vFila, vColumna].Tag.ToString())
                        {
                            #region Piso
                            case "Piso":
                                matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                matEscenario[varPJFila, varPJColumna].Image = null;
                                varPJFila = vFila;
                                matEscenario[varPJFila, varPJColumna].BringToFront();

                                break;
                            #endregion

                            #region Portal Azul
                            case "Portal Azul":
                                
                                matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image; //esto esta bien
                                matEscenario[varPJFila, varPJColumna].Image = null;
                                varPJFila = varPPortalNFila;
                                varPJColumna = varPPortalNColumna;
                                vFila = varPPortalNFila;
                                vColumna = varPPortalNColumna;
                                 
                                matEscenario[varPJFila, varPJColumna].BringToFront();

                                break;
                            #endregion

                            #region Portal Naranja
                            case "Portal Naranja":
                                       matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                break;
                            #endregion

                            #region Cubo de Compañía
                            case "Cubo de Compañía":
                                MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                break;
                            #endregion

                            #region Glados
                            case "Glados":
                                MessageBox.Show("¡Ganaste!");
                                frmPrincipal.ActiveForm.Close();
                                break;
                            #endregion

                            #region Torreta
                            case "Torreta":
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;
                                break;
                            #endregion

                            default:
                                break;
                        }
                        #endregion
                        vFila = varPJFila;   
                    }
                    else
                    {
                        MessageBox.Show("¿A donde queres ir?");
                    }
                   break;
                #endregion

                #region DOWN
                case Keys.Down:
                   
                    switch (Dificultad)
                    {
                        #region NIVEL 1
                            //Mientras la fila sea menor a la cantidad de filas de la matriz (contando desde "0") podrá seguir bajando
                        case 1:
                            if (vFila < 3)
                            {
                                vFila += 1;
                                #region Pregunto que hay en la siguiente posición y hago el procedimiento correspondiente
                                switch (matEscenario[vFila, vColumna].Tag.ToString())
                                {
                                    #region Piso
                                    case "Piso":
                                        //matEscenario[varPJFila, varPJColumna].Location = new Point(matEscenario[varPJFila, varPJColumna].Location.X, matEscenario[vFila, vColumna].Location.Y);
                                        
                                        matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJFila = vFila;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();
                                        

                                        break;
                                    #endregion

                                    #region Portal Azul
                                    case "Portal Azul":
                                        matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJFila = varPPortalNFila;
                                        varPJColumna = varPPortalNColumna;
                                        vFila = varPPortalNFila;
                                        vColumna = varPPortalNColumna;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();
                                        break;
                                    #endregion

                                    #region Portal Naranja
                                    case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                        break;
                                    #endregion

                                    #region Cubo de Compañía
                                    case "Cubo de Compañía":
                                        MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                        break;
                                    #endregion

                                    #region Glados
                                    case "Glados":
                                        MessageBox.Show("¡Ganaste!");
                                        frmPrincipal.ActiveForm.Close();
                                        break;
                                    #endregion

                                    #region Torreta
                                    case "Torreta":
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;
                                        break;
                                    #endregion

                                    default:
                                        break;
                                }
                                #endregion
                                vFila = varPJFila;
                            }

                            else
                            {
                                MessageBox.Show("¿A donde queres ir?");
                            }
                            break;
                        #endregion

                        #region NIVEL 2
                        case 2:
                            //Mientras la fila sea menor a la cantidad de filas de la matriz (contando desde "0") podrá seguir bajando
                            if (vFila < 7)
                           {
                                vFila += 1;
                                #region Pregunto que hay en la siguiente posición y hago el procedimiento correspondiente
                                switch (matEscenario[vFila, vColumna].Tag.ToString())
                                {
                                    #region Piso
                                    case "Piso":
                                        //matEscenario[varPJFila, varPJColumna].Location = new Point(matEscenario[varPJFila, varPJColumna].Location.X, matEscenario[vFila, vColumna].Location.Y);
                                        matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJFila = vFila;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();
                                        
                                        break;
                                    #endregion

                                    #region Portal Azul
                                    case "Portal Azul":
                                        matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJFila = varPPortalNFila;
                                        varPJColumna = varPPortalNColumna;
                                        vFila = varPPortalNFila;
                                        vColumna = varPPortalNColumna;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();
                                        break;
                                    #endregion

                                    #region Portal Naranja
                                    case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                        break;
                                    #endregion

                                    #region Cubo de Compañía
                                    case "Cubo de Compañía":
                                        MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                        break;
                                    #endregion

                                    #region Glados
                                    case "Glados":
                                        MessageBox.Show("¡Ganaste!");
                                        frmPrincipal.ActiveForm.Close();
                                        break;
                                    #endregion

                                    #region Torreta
                                    case "Torreta":
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;
                                        break;
                                    #endregion

                                    default:
                                        break;
                                }
                                #endregion
                                vFila = varPJFila;
                            }
                            else
                            {
                                MessageBox.Show("¿A donde queres ir?");
                            }
                            break;
                           
                        #endregion

                        #region NIVEL 3

                        case 3:
                            //Mientras la fila sea menor a la cantidad de filas de la matriz (contando desde "0") podrá seguir bajando
                           if (vFila < 9)
                           {
                               vFila += 1;
                               #region Pregunto que hay en la siguiente posición y hago el procedimiento correspondiente
                               switch (matEscenario[vFila, vColumna].Tag.ToString())
                               {
                                   #region Piso
                                   case "Piso":
                                       
                                        matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJFila = vFila;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();
                                       

                                       break;
                                   #endregion

                                   #region Portal Azul
                                   case "Portal Azul":
                                       matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalNFila;
                                       varPJColumna = varPPortalNColumna;
                                       vFila = varPPortalNFila;
                                       vColumna = varPPortalNColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();
                                       break;
                                   #endregion

                                   #region Portal Naranja
                                   case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                       break;
                                   #endregion

                                   #region Cubo de Compañía
                                   case "Cubo de Compañía":
                                       MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                       break;
                                   #endregion

                                   #region Glados
                                   case "Glados":
                                       MessageBox.Show("¡Ganaste!");
                                       frmPrincipal.ActiveForm.Close();
                                       break;
                                   #endregion

                                   #region Torreta
                                   case "Torreta":
                                       frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;


                                        break;
                                   #endregion

                                   default:
                                       break;
                               }
                               #endregion
                               vFila = varPJFila;
                           }
                           else
                           {
                               MessageBox.Show("¿A donde queres ir?");
                           }
                           break;
                            
                        #endregion

                        default:
                               break;
                    }
                    
                    break;
                #endregion

                #region RIGHT
                case Keys.Right:
                    
                    switch (Dificultad)
                    {
                        #region NIVEL 1
                        case 1:
                            if (vColumna < 3)
                            {
                                vColumna += 1;
                                switch (matEscenario[vFila, vColumna].Tag.ToString())
                                {
                                    #region Piso
                                    case "Piso":
                                        matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJColumna = vColumna;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();

                                        break;
                                    #endregion

                                    #region Portal Azul
                                    case "Portal Azul":
                                       matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalNFila;
                                       varPJColumna = varPPortalNColumna;
                                        vFila = varPPortalNFila;
                                        vColumna = varPPortalNColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();
                                        break;
                                    #endregion

                                    #region Portal Naranja
                                    case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                        break;
                                    #endregion

                                    #region Cubo de Compañía
                                    case "Cubo de Compañía":
                                        MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                        break;
                                    #endregion

                                    #region Glados
                                    case "Glados":
                                        MessageBox.Show("¡Ganaste!");
                                        frmPrincipal.ActiveForm.Close();
                                        break;
                                    #endregion

                                    #region Torreta
                                    case "Torreta":
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;
                                        break;
                                    #endregion

                                    default:
                                        break;
                                }
                                vColumna = varPJColumna;
                            }
                            else
                            {
                                MessageBox.Show("¿A donde queres ir?");
                            }
                            break;
                        #endregion

                        #region NIVEL 2
                        case 2:
                            if (vColumna < 7)
                            {
                                vColumna += 1;
                                switch (matEscenario[vFila, vColumna].Tag.ToString())
                                {
                                    #region Piso
                                    case "Piso":
                                        matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJColumna = vColumna;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();

                                        break;
                                    #endregion

                                    #region Portal Azul
                                    case "Portal Azul":
                                       matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalNFila;
                                       varPJColumna = varPPortalNColumna;
                                        vFila = varPPortalNFila;
                                        vColumna = varPPortalNColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();
                                        break;
                                    #endregion

                                    #region Portal Naranja
                                    case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                        break;
                                    #endregion

                                    #region Cubo de Compañía
                                    case "Cubo de Compañía":
                                        MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                        break;
                                    #endregion

                                    #region Glados
                                    case "Glados":
                                        MessageBox.Show("¡Ganaste!");
                                        frmPrincipal.ActiveForm.Close();
                                        break;
                                    #endregion

                                    #region Torreta
                                    case "Torreta":
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;

                                        break;
                                    #endregion

                                    default:
                                        break;
                                }
                                vColumna = varPJColumna;
                            }
                            else
                            {
                                MessageBox.Show("¿A donde queres ir?");
                            }
                            break;
                        #endregion

                        #region NIVEL 3
                        case 3:
                            if (vColumna < 9)
                            {
                                vColumna += 1;
                                switch (matEscenario[vFila, vColumna].Tag.ToString())
                                {
                                    #region Piso
                                    case "Piso":
                                        matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                        matEscenario[varPJFila, varPJColumna].Image = null;
                                        varPJColumna = vColumna;
                                        matEscenario[varPJFila, varPJColumna].BringToFront();

                                        break;
                                    #endregion

                                    #region Portal Azul
                                    case "Portal Azul":
                                       matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalNFila;
                                       varPJColumna = varPPortalNColumna;
                                        vFila = varPPortalNFila;
                                        vColumna = varPPortalNColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();
                                        break;
                                    #endregion

                                    #region Portal Naranja
                                    case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                        break;
                                    #endregion

                                    #region Cubo de Compañía
                                    case "Cubo de Compañía":
                                        MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                        break;
                                    #endregion

                                    #region Glados
                                    case "Glados":
                                        MessageBox.Show("¡Ganaste!");
                                        frmPrincipal.ActiveForm.Close();
                                        break;
                                    #endregion

                                    #region Torreta
                                    case "Torreta":
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();


                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }
                                frmEnfrentamiento.varPuntosPJ = 0;
                                        break;
                                    #endregion
                                    default:
                                        break;
                                }
                                vColumna = varPJColumna;
                            }
                            else
                            {
                                MessageBox.Show("¿A donde queres ir?");
                            }
                            break;
                        #endregion
                        default:
                            break;
                    }
                    break;
                #endregion

                #region LEFT
                case Keys.Left:
                    
                    //Si la columna es mayor a 0
                    if (vColumna > 0)
                    {
                        vColumna -= 1;
                        #region Pregunto que hay en la siguiente posición y hago el procedimiento correspondiente
                        switch (matEscenario[vFila, vColumna].Tag.ToString())
                        {
                            #region Piso
                            case "Piso":
                                matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                matEscenario[varPJFila, varPJColumna].Image = null;
                                varPJColumna = vColumna;
                                matEscenario[varPJFila, varPJColumna].BringToFront();

                                break;
                            #endregion

                            #region Portal Azul
                            case "Portal Azul":
                                matEscenario[varPPortalNFila, varPPortalNColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                matEscenario[varPJFila, varPJColumna].Image = null;
                                varPJFila = varPPortalNFila;
                                varPJColumna = varPPortalNColumna;
                                vFila = varPPortalNFila;
                                vColumna = varPPortalNColumna;
                                matEscenario[varPJFila, varPJColumna].BringToFront();
                                break;
                            #endregion

                            #region Portal Naranja
                            case "Portal Naranja":
                                        matEscenario[varPPortalAFila, varPPortalAColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                       matEscenario[varPJFila, varPJColumna].Image = null;
                                       varPJFila = varPPortalAFila;
                                       varPJColumna = varPPortalAColumna;
                                       vFila = varPPortalAFila;
                                       vColumna = varPPortalAColumna;
                                       matEscenario[varPJFila, varPJColumna].BringToFront();;
                                break;
                            #endregion

                            #region Cubo de Compañía
                            case "Cubo de Compañía":
                                MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                                break;
                            #endregion

                            #region Glados
                            case "Glados":
                                MessageBox.Show("¡Ganaste!");
                                frmPrincipal.ActiveForm.Close();
                                break;
                            #endregion

                            #region Torreta
                            case "Torreta":
                                
                                frmEnfrentamiento Enfrentamiento = new frmEnfrentamiento();
                                Enfrentamiento.Show();

                                
                                if (frmEnfrentamiento.varPuntosPJ > 0)
                                {
                                    matEscenario[vFila, vColumna].Image = matEscenario[varPJFila, varPJColumna].Image;
                                    matEscenario[varPJFila, varPJColumna].Image = null;
                                    matEscenario[vFila, vColumna].Tag = "Piso";
                                    matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                                    varPJFila = vFila;
                                    varPJColumna = vColumna;
                                    matEscenario[varPJFila, varPJColumna].BringToFront();
                                }

                                frmEnfrentamiento.varPuntosPJ = 0;
                                
                                break;
                            #endregion

                            default:
                                break;
                        }
                        #endregion
                        vColumna = varPJColumna;
                    }
                    else
                    {
                        MessageBox.Show("¿A donde queres ir?");
                    }
                   
                    break;
                #endregion

                default:
                    break;
            }
            #endregion
        }
        #endregion


        
    }
       

       
}
                  