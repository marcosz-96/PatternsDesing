using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;


namespace Clases
{
    public static class UsingAdapter
    {
        public static void Print()
        {
            IImpresora print = new AdaptadorTermica(new ImpresoraTermicaVieja());
            print.Imprimir("Imprimiendo ....");
                
        }
    }
}
