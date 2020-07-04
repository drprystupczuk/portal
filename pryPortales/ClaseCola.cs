using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace pryPortales
{
    class ClaseCola
    {
        ClaseNodo posicionPrimero; //posición de memoria

        ClaseNodo posicionUltimo;
        
        ClaseNodo posicionNuevo;



        public ClaseCola()
        {

        }



        #region CREAR COLA
        public void Crear(string Ataque)
        {
            //si el primero es igual a nulo, quiere decir que es el primero elemento de la estructura COLA
            if (posicionPrimero == null)
            {
                posicionNuevo = new ClaseNodo();

                if (posicionNuevo != null)
                {
                    //registrar los valores que enviamos desde la interfaz o aleatoriamente

                    //envío parametros desde la interfaz
                    posicionNuevo.Ataque = Ataque;//envío parametros desde la interfaz
                    posicionNuevo.posicionSiguiente = null;

                    posicionPrimero = posicionNuevo;
                    posicionUltimo = posicionNuevo;
                }
                else
                {
                    //no hay espacio en memoria
                }

            }
            else
            {
                //llama a insertar
                Insertar(Ataque);
            }
        }
        #endregion

        #region INSERTAR EN COLA
        public void Insertar(string Ataque)
        {
            //es el único elemento de la estructura COLA?? es el único nodo en la estructura?
            if (posicionPrimero.posicionSiguiente == null)
            {
                posicionNuevo = new ClaseNodo();
                if (posicionNuevo != null)
                {
                    //registrar los valores que enviamos desde la interfaz o aleatoriamente

                    
                    posicionNuevo.Ataque = Ataque;//envío parametros desde la interfaz

                    posicionPrimero.posicionSiguiente = posicionNuevo;

                    posicionUltimo = posicionNuevo;
                }
            }
            else
            {
                //ya existen nodos, y se va a agregar un elemento.
                posicionNuevo = new ClaseNodo();
                if (posicionNuevo != null)
                {
                   

                    
                    posicionNuevo.Ataque = Ataque;

                    posicionUltimo.posicionSiguiente = posicionNuevo;

                    posicionUltimo = posicionNuevo;
                    

                }
                else
                {
                    //mensaje no hay espacio en memoria
                }
            }
        }

        #endregion

        #region LISTAR
        public void Listar(ListBox Lista)
        {
            ClaseNodo pAuxiliar = new ClaseNodo();

            if (posicionPrimero != null)
            {
                pAuxiliar = posicionPrimero;

                while (pAuxiliar != null)
                {
                    
                    Lista.Items.Add(pAuxiliar.Ataque);

                    pAuxiliar = pAuxiliar.posicionSiguiente; 
                }

            }
            else
            {
                //no hay elementos
            }
        }
        #endregion
  
    }
}
