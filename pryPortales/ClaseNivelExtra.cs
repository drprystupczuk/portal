using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace pryPortales
{
    public class ClaseNivelExtra
    {
        public PictureBox[,] matEscenario;
        int vFila = 0;
        int vColumna = 0;
        public String ADExtra;
        int mouseX;
        int mouseY;
        string currentVisibleTag = null;


        //CONSTRUCTOR
        public ClaseNivelExtra()
        {
            matEscenario = null;
        }

        //DESTRUCTOR
        ~ClaseNivelExtra() { }

        public void CrearEscenarioAlmacenado(Form Extra)
        {
            ADExtra = frmPrincipal.ADExtra;

            #region LEER EL ARCHIVO DE DATOS
            List<List<string>> matriz = new List<List<string>>();
            string[] strLineas = File.ReadAllLines(ADExtra);
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
                        case 5:
                            matEscenario[vFila, vColumna].BackgroundImage = Properties.Resources.turret;
                            matEscenario[vFila, vColumna].BackgroundImageLayout = ImageLayout.Stretch;
                            matEscenario[vFila, vColumna].Tag = "Torreta";
                            break;
                        case 6:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.chell;
                            matEscenario[vFila, vColumna].Tag = "chell";
                            break;
                        case 7:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.wheatley;
                            matEscenario[vFila, vColumna].Tag = "wheatley";

                            break;

                        default:
                            matEscenario[vFila, vColumna].Image = null;
                            matEscenario[vFila, vColumna].BackgroundImage = null;
                            break;
                    }
                    matEscenario[vFila, vColumna].Visible = false;
                    matEscenario[vFila, vColumna].BringToFront();
                    matEscenario[vFila, vColumna].Size = new System.Drawing.Size(100, 100);
                    matEscenario[vFila, vColumna].SizeMode = PictureBoxSizeMode.StretchImage;
                    matEscenario[vFila, vColumna].Location = new Point(100 * vColumna, 100 * vFila);
                    Extra.Controls.Add(matEscenario[vFila, vColumna]);
                    matEscenario[vFila, vColumna].BackColor = Color.LightGray;

                    vColumna++;
                    #endregion

                }
                vFila++;
                vColumna = 0;
            }
            #endregion
        }
        public void MostrarPic()
        {
            mouseX = frmExtra.mouseX;
            mouseY = frmExtra.mouseY;
            if (matEscenario == null)
                return;

            currentVisibleTag = null;
            for (int r = 0; r < matEscenario.GetLength(0); r++)
            {
                for (int c = 0; c < matEscenario.GetLength(1); c++)
                {
                    var cell = matEscenario[r, c];
                    if (cell == null)
                        continue;

                    int centerX = cell.Location.X + cell.Width / 2;
                    int centerY = cell.Location.Y + cell.Height / 2;
                    bool inside = Math.Abs(mouseX - centerX) <= cell.Width / 2 && Math.Abs(mouseY - centerY) <= cell.Height / 2;
                    if (inside)
                    {
                        var tag = cell.Tag?.ToString();
                        if (!string.IsNullOrEmpty(tag) && tag != "Piso")
                        {
                            cell.Visible = true;
                            currentVisibleTag = tag;
                        }
                    }
                }
            }
        }

        public void OcultarPic()
        {
            if (matEscenario == null)
                return;

            for (int r = 0; r < matEscenario.GetLength(0); r++)
            {
                for (int c = 0; c < matEscenario.GetLength(1); c++)
                {
                    var cell = matEscenario[r, c];
                    if (cell == null)
                        continue;

                    if (cell.Visible)
                    {
                        var tag = cell.Tag?.ToString();
                        if (string.IsNullOrEmpty(currentVisibleTag) || tag != currentVisibleTag)
                            cell.Visible = false;
                    }
                }
            }
            currentVisibleTag = null;
        }

    }
}
