using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class GestorPrestamos
    {

        private IDictionary<TipoCliente, IEvaluador> iEvaluadoresPorCliente;

        public GestorPrestamos()
        {
            this.iEvaluadoresPorCliente = new Dictionary<TipoCliente, IEvaluador>();

            //this.iEvaluadoresPorCliente.Add(TipoCliente.Cliente, new EvaluardorCompuesto());
            this.iEvaluadoresPorCliente[TipoCliente.Cliente] = new EvaluardorCompuesto();
        }

        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            return this.iEvaluadoresPorCliente[pSolicitudPrestamo.TipoCliente].EsValida();
        }

    }
}
