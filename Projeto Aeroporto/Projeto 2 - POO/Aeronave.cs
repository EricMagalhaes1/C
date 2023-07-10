using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Aeronave:Empresa
    {
        protected int codigo { get; set; }
        protected string nome { get; set; }
        protected int capacidade { get; set; }
        protected int pesoMaximo { get; set; }
        private Empresa empresa { get; set; }

        public void constroi(int codigo, string nome, int pesomaximo,int capacidade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.pesoMaximo = pesomaximo;
            this.capacidade = capacidade;
        }

    }
}
