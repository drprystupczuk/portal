using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pryPortales
{
    class ClaseNodo
    {
        
        public string Ataque;
        
        public ClaseNodo posicionSiguiente; //posición de memoria del siguiente nodo

        public ClaseNodo() //inicializa cualquier objeto que se crea de la clase
        {
            Ataque = "";
            posicionSiguiente = null;
            
        }
    }
}
