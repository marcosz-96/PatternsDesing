using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDecorator;

namespace ClasesDecorator
{
    class MensajeConEmoji : MensajeDecorator
    {
        private readonly string _mensajeEmoji;

        public MensajeConEmoji(IMensaje mensaje, string mensajeEmoji) : base (mensaje)
        {
            _mensajeEmoji = mensajeEmoji;
        }


        public override void Enviar(string text)
        {
            text += _mensajeEmoji;
            base.Enviar(text);
        }
    }
}
