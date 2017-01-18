using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProyecto_King_of_Maths
{
    class Classe_Operaciones_Logicas
    {
        Random rndlvlsOL = new Random(); /*llamo al random de manera global */
        private int a1OL, b1OL, c1OL, d1OL, punteomaxOL1 = 100000; /*coloco las variables a utilizar en este nivel que serán 4 */
        public void generarLvl1()
    {
            // preparo las variables que voy a utilizar en este mundo que seran 4 
        a1OL = rndlvlsOL.Next(1, 16);
        b1OL = rndlvlsOL.Next(1, 16);
        c1OL = rndlvlsOL.Next(1, 16);
        d1OL = rndlvlsOL.Next(1, 16);
            
        // las condiciono para que no me den valores iguales. 
        while ((a1OL == b1OL) || (a1OL == c1OL) || (a1OL == d1OL))
        {
            a1OL = rndlvlsOL.Next(1, 16);
        }
        while ((b1OL == a1OL) || (b1OL == c1OL) || (b1OL == d1OL))
        {
            b1OL = rndlvlsOL.Next(1, 16);
        }
        while ((c1OL == b1OL) || (c1OL == a1OL) || (c1OL == d1OL))
        {
            c1OL = rndlvlsOL.Next(1, 16);
        }
        while ((d1OL == b1OL) || (d1OL == c1OL) || (d1OL == a1OL))
        {
            d1OL = rndlvlsOL.Next(1, 16);
        }
    }
        // retorno las variables y los puntos a restar. 
         public int retornara()
         {
            return a1OL;
         }
        public int retornarb()
         {
            return b1OL;
         }
        public int retornarc()
        {
            return c1OL;
        }
        public int retornard()
        {
            return d1OL;
        }
         public string punteos_SegundosN1OL()
         {
             punteomaxOL1 = punteomaxOL1 - 1667;
             return Convert.ToString(punteomaxOL1);
         }
         public string quitarpuntosN1OL()
         {
             punteomaxOL1 = punteomaxOL1 - 20000;
             return Convert.ToString(punteomaxOL1);
         }
    }
}
