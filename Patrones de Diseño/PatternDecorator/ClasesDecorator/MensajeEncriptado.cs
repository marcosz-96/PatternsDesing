﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesDecorator;

namespace ClasesDecorator
{
    public class MensajeEncriptado : MensajeDecorator
    {
        public MensajeEncriptado(IMensaje mensaje) : base(mensaje) { }

        public override void Enviar(string text)
        {
            text = text.ToUpper();
            base.Enviar(text);
        }
    }
}
