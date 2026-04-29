using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pryPortales
{
    public class ClaseNivel
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

        public ClaseNivel()
        {
            matEscenario = null;
        }

        //DESTRUCTOR
        ~ClaseNivel()
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
                            matEscenario[vFila, vColumna].BackgroundImage = null;
                            matEscenario[vFila, vColumna].Tag = "Piso";
                            break;

                        case 1:
                            matEscenario[vFila, vColumna].BackgroundImage = Properties.Resources.portalblue;
                            matEscenario[vFila, vColumna].BackgroundImageLayout = ImageLayout.Stretch;
                            matEscenario[vFila, vColumna].Tag = "Portal Azul";
                            break;
                        case 2:
                            matEscenario[vFila, vColumna].BackgroundImage = Properties.Resources.Portal_orange;
                            matEscenario[vFila, vColumna].BackgroundImageLayout = ImageLayout.Stretch;
                            matEscenario[vFila, vColumna].Tag = "Portal Naranja";
                            break;
                        case 3:
                            matEscenario[vFila, vColumna].BackgroundImage = Properties.Resources.cubodecompañia;
                            matEscenario[vFila, vColumna].BackgroundImageLayout = ImageLayout.Stretch;
                            matEscenario[vFila, vColumna].Tag = "Cubo de Compañía";
                            break;
                        case 4:
                            matEscenario[vFila, vColumna].BackgroundImage = Properties.Resources.GLaDOS_Potato;
                            matEscenario[vFila, vColumna].BackgroundImageLayout = ImageLayout.Stretch;
                            matEscenario[vFila, vColumna].Tag = "Glados";
                            break;
                        case 5:
                            matEscenario[vFila, vColumna].BackgroundImage = Properties.Resources.turret;
                            matEscenario[vFila, vColumna].BackgroundImageLayout = ImageLayout.Stretch;
                            matEscenario[vFila, vColumna].Tag = "Torreta";
                            break;
                        case 9:
                            if (frmPrincipal.personaje == 1)
                            {
                                matEscenario[vFila, vColumna].Image = Properties.Resources.chell;
                            }
                            else if (frmPrincipal.personaje == 2)
                            {
                                matEscenario[vFila, vColumna].Image = Properties.Resources.wheatley;
                            }
                            matEscenario[vFila, vColumna].Tag = "Piso";
                            matEscenario[vFila, vColumna].BringToFront();
                            break;
                        default:
                            matEscenario[vFila, vColumna].Image = null;
                            matEscenario[vFila, vColumna].BackgroundImage = null;
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
                    varPPortalAFila = 0;
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
            switch (e.KeyCode)
            {
                case Keys.Up:
                    TryMove(varPJFila - 1, varPJColumna);
                    break;
                case Keys.Down:
                    TryMove(varPJFila + 1, varPJColumna);
                    break;
                case Keys.Right:
                    TryMove(varPJFila, varPJColumna + 1);
                    break;
                case Keys.Left:
                    TryMove(varPJFila, varPJColumna - 1);
                    break;
                default:
                    break;
            }
        }

        int MaxRowIndex()
        {
            switch (Dificultad)
            {
                case 1: return 3;
                case 2: return 7;
                case 3: return 9;
                default: return 3;
            }
        }

        int MaxColIndex()
        {
            switch (Dificultad)
            {
                case 1: return 3;
                case 2: return 7;
                case 3: return 9;
                default: return 3;
            }
        }

        bool IsWithinBounds(int row, int col)
        {
            return row >= 0 && col >= 0 && row <= MaxRowIndex() && col <= MaxColIndex();
        }

        void TryMove(int targetRow, int targetCol)
        {
            if (!IsWithinBounds(targetRow, targetCol))
            {
                MessageBox.Show("¿A donde queres ir?");
                return;
            }

            string tag = matEscenario[targetRow, targetCol].Tag?.ToString();
            switch (tag)
            {
                case "Piso":
                    MovePlayerToCell(targetRow, targetCol);
                    break;
                case "Portal Azul":
                    TeleportPlayer(varPPortalNFila, varPPortalNColumna);
                    break;
                case "Portal Naranja":
                    TeleportPlayer(varPPortalAFila, varPPortalAColumna);
                    break;
                case "Cubo de Compañía":
                    MessageBox.Show("Aquí hay un cubo de compañia, intenta avanzar por otro sector");
                    break;
                case "Glados":
                    MessageBox.Show("¡Ganaste!");
                    frmPrincipal.ActiveForm.Close();
                    break;
                case "Torreta":
                    HandleTurretEncounter(targetRow, targetCol);
                    break;
                default:
                    break;
            }
        }

        void MovePlayerToCell(int destRow, int destCol)
        {
            int originRow = varPJFila;
            int originCol = varPJColumna;

            matEscenario[destRow, destCol].Image = matEscenario[originRow, originCol].Image;
            matEscenario[originRow, originCol].Image = null;

            varPJFila = destRow;
            varPJColumna = destCol;
            vFila = varPJFila;
            vColumna = varPJColumna;
            matEscenario[varPJFila, varPJColumna].BringToFront();

            RestoreCellBackground(originRow, originCol);
            RestoreCellBackground(destRow, destCol);
        }

        void TeleportPlayer(int destRow, int destCol)
        {
            int originRow = varPJFila;
            int originCol = varPJColumna;

            matEscenario[destRow, destCol].Image = matEscenario[originRow, originCol].Image;
            matEscenario[originRow, originCol].Image = null;

            varPJFila = destRow;
            varPJColumna = destCol;
            vFila = destRow;
            vColumna = destCol;
            matEscenario[varPJFila, varPJColumna].BringToFront();

            RestoreCellBackground(originRow, originCol);
            RestoreCellBackground(destRow, destCol);
        }

        void HandleTurretEncounter(int targetRow, int targetCol)
        {
            frmEnfrentamiento enfrentamiento = new frmEnfrentamiento();
            enfrentamiento.Show();

            if (frmEnfrentamiento.varPuntosPJ > 0)
            {
                int originRow = varPJFila;
                int originCol = varPJColumna;
                MovePlayerToCell(targetRow, targetCol);
                matEscenario[originRow, originCol].Tag = "Piso";
                matEscenario[varPJFila, varPJColumna].Tag = "Piso";
                RestoreCellBackground(originRow, originCol);
                RestoreCellBackground(varPJFila, varPJColumna);
            }
            frmEnfrentamiento.varPuntosPJ = 0;
        }

        void RestoreCellBackground(int row, int col)
        {
            if (row < 0 || col < 0 || row > matEscenario.GetUpperBound(0) || col > matEscenario.GetUpperBound(1))
                return;

            var cell = matEscenario[row, col];
            string tag = cell.Tag?.ToString();
            switch (tag)
            {
                case "Portal Azul":
                    cell.BackgroundImage = Properties.Resources.portalblue;
                    cell.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Portal Naranja":
                    cell.BackgroundImage = Properties.Resources.Portal_orange;
                    cell.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Cubo de Compañía":
                    cell.BackgroundImage = Properties.Resources.cubodecompañia;
                    cell.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Glados":
                    cell.BackgroundImage = Properties.Resources.GLaDOS_Potato;
                    cell.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Torreta":
                    cell.BackgroundImage = Properties.Resources.turret;
                    cell.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "Piso":
                default:
                    cell.BackgroundImage = null;
                    break;
            }
        }
        #endregion
    }
}
