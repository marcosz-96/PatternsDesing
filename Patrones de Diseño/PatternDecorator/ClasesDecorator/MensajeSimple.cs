using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDecorator;

namespace ClasesDecorator
{
    class MensajeSimple : IMensaje
    {
        public void Enviar(string text)
        {
            Console.WriteLine(text);
        }
    }
}
