using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class EvaluardorCompuesto : IEvaluador
    {

        private IList<IEvaluador> iEvaluadores;

        public EvaluardorCompuesto()
        {
            this.iEvaluadores = new List<IEvaluador>();
        }

        public bool EsValida()
        {
            IEnumerator<IEvaluador> enumerador = this.iEvaluadores.GetEnumerator();

            bool esValida = true;

            while (esValida && enumerador.MoveNext())
            {
                esValida = enumerador.Current.EsValida();
            }

            return esValida;
        }

        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            this.iEvaluadores.Add(pEvaluador);
        }
    }
}
