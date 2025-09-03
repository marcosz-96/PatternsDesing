using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDecorator;


namespace ClasesDecorator
{
    public abstract class MensajeDecorator : IMensaje
    {
        protected readonly IMensaje _mensaje;

        protected MensajeDecorator(IMensaje mensaje)
        {
            _mensaje = mensaje;
        }

        public virtual void Enviar(string text)
        {
            _mensaje.Enviar(text);
        }
    }
}
