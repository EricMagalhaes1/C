using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Compra:Passagem
    {
        protected int codigocompra { get; set; }
        private Passagem passagem { get; set; }
        private Cliente cliente { get; set; }
        protected string pagamento { get; set; }
        protected double valorTotal { get; set; }

        public void constroi(int codigo, string pagamento, double valorTotal)
        {
            this.codigo = codigo;
            this.pagamento = pagamento;
            this.valorTotal = valorTotal;
        }
    }
}
