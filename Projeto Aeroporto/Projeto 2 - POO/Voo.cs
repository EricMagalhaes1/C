using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Voo:Aeroporto
    {
        protected int codigoVoo { get; set; }
        protected string dataHora { get; set; }
         Aeroporto destino { get; set; }
         Aeroporto origem { get; set; }
         Aeronave aeronave { get; set; }
        private Piloto piloto { get; set; }

        public void constroi(int codigo,string dataHora, Aeroporto ori)
        {
            this.codigo = codigo;
            this.dataHora = dataHora;
            this.origem = ori;
        }

    }
}
