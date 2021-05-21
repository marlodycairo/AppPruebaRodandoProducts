using AppPruebaRodandoProducts.Api.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPruebaRodandoProducts.Api.ApplicationService
{
    public class ApplicationServiceCliente : IApplicationCliente
    {
        public string EnviarMensaje()
        {
            return "Test.";
        }
    }
}
