using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Clases
{
    public class AdaptadorTermica : IImpresora
    {
        private readonly ImpresoraTermicaVieja _impresoraLegacy;

        public AdaptadorTermica(ImpresoraTermicaVieja impresoraLegacy)
        {
            _impresoraLegacy = impresoraLegacy;
        }

        public void Imprimir(string data)
        {
            if (data.Length <= 100)
            {
                Console.WriteLine("Texto valido... Imprimiendo:");
                _impresoraLegacy.PrintTicket(data);
            }
            else
            {
                Console.WriteLine("[ERROR!] El texto supera los 100 caracteres");
                Console.ReadKey();
            }
            
        }
    }
}
