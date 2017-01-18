using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class Clase_Jugador
    {
        string Nombre_Juga; // variables globales de estrellas, punteo y nombre
        int punteo;
        int estrellas;
        public void guardardatos(string inombre)  // se rerlaiza un metodo donde se devolvera el nombre e igualo la variable string dentro del mismo a la variable global 

        {
            Nombre_Juga = inombre; 
            punteo = 0; // punto tendra un valor inciail 0 
            estrellas = 0; // estrellas tendran un valor iniciarl tambien de 0 

        }
        // retorno los valores anteriores 
        public string get_nombre()
        {
            return Nombre_Juga;
        }

        public int get_punteo()
        {
            return punteo;
        }

        public int get_estrellas()
        {
            return estrellas;
        }
    }
}
