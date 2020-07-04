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
    public class ClaseNivelExtra
    {
        public PictureBox[,] matEscenario;
        int vFila = 0;
        int vColumna = 0;
        public String ADExtra;
        int mouseX;
        int mouseY;
        
        
        //CONSTRUCTOR
        public ClaseNivelExtra()
        {
            matEscenario = null;
            
        }

        //DESTRUCTOR
        ~ClaseNivelExtra()
        {
        }

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
                            matEscenario[vFila, vColumna].Image = Properties.Resources.Portal_orange;
                            matEscenario[vFila, vColumna].Tag = "Portal Naranja";
                            break;
                        case 3:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.cubodecompañia;
                            matEscenario[vFila, vColumna].Tag = "Cubo de Compañía";
                            break;
                        case 5:
                            matEscenario[vFila, vColumna].Image = Properties.Resources.turret;                            
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
                            matEscenario[vFila, vColumna].Tag.ToString();

                            break;
                    }
                    matEscenario[vFila, vColumna].Tag.ToString();
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
            vFila = 0;
        vColumna = 0;
        while (vFila<3)
        {
            while (vColumna <3)
            {
                if (mouseX > matEscenario[vFila, vColumna].Location.X - 50 && mouseX < matEscenario[vFila, vColumna].Location.X+50
                    && mouseY > matEscenario[vFila, vColumna].Location.Y - 50 && mouseY < matEscenario[vFila, vColumna].Location.Y + 50)
                {
                   matEscenario[vFila, vColumna].Visible = true; 
                }
                
                vColumna++;
            }
            vFila++;
            vColumna = 0;
        }
            
        
    }

        public void OcultarPic()
        {
            vFila = 0;
        vColumna = 0;
        while (vFila<3)
        {
            while (vColumna <3)
            {
                if (matEscenario[vFila, vColumna].Visible == true)
                    // AQUI FALTA QUE COMPARE LOS TAG DE LAS IMAGENES VISIBLES Y EN CASO DE QUE SEAN IGUALES LAS DEJA VISIBLE SINO LAS OCULTA
                {
                   matEscenario[vFila, vColumna].Visible = false; 
                }
                
                vColumna++;
            }
            vFila++;
            vColumna = 0;
        }
        
    }
           
        }



    }
