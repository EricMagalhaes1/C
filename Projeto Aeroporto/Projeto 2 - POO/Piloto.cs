using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Piloto:Voo
    {
        protected int codigoPiloto { get; set; }
        protected string nomePiloto { get; set; }
        protected string dataAdimicao { get; set; }

        public void constroi(int codigo, string nome,string data)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.dataAdimicao = data;
        }
    }
}
