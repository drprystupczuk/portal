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
    public partial class frmExtra : Form
    {
        public frmExtra()
        {
            InitializeComponent();
        }
        static public int mouseX;
        static public int mouseY;
        static public string X;
        static public String Y;
        
        

        ClaseNivelExtra objNivelExtra = new ClaseNivelExtra();
        private void frmExtra_Load(object sender, EventArgs e)
        {
            frmPrincipal.ADExtra = "Extra.txt";
            objNivelExtra.CrearEscenarioAlmacenado(this);
            this.Height = 325;	//CAMBIAR ALTURA
            this.Width = 315;
            this.CenterToScreen();
        }

        private void frmExtra_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void frmExtra_Click(object sender, EventArgs e)
        {
            
        }

        private void frmExtra_MouseClick(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;


            objNivelExtra.MostrarPic();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            objNivelExtra.OcultarPic();
            timer1.Enabled = false;
        }


    }
}
