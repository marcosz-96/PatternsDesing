using System;
using Clases;
using Interfaces;
using ClasesDecorator;
using InterfacesDecorator;

namespace Patrones_de_Diseño
{
    class Program
    {
        static void Main()
        {
            ImpresoraTermicaVieja termicaVieja = new ImpresoraTermicaVieja();
            IImpresora impresora = new AdaptadorTermica(termicaVieja);

            impresora.Imprimir("EJERCICIO 1!");

            Console.WriteLine("=================================================================================");

            IMensaje mensajeSimple = new MensajeSimple();
            mensajeSimple = new MensajeEncriptado(mensajeSimple);
            mensajeSimple = new MensajeConEmoji(mensajeSimple, ";)");

            mensajeSimple.Enviar("hola mundo");

        }
    }
}
