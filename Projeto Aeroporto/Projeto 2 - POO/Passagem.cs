using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Passagem:Voo
    {
        protected int codigoP { get; set; }
        protected string assento { get; set; }
        protected string cpfPassageiro { get; set; }
        protected string nomePassageiro { get; set; }
        protected double preco { get; set; }  
        private Voo voo { get; set; }

        public void constroi(int codigo, string assento, string cpf, string nome, double preco)
        {
            this.codigo = codigo;
            this.assento = assento;
            this.cpfPassageiro = cpf;
            this.nomePassageiro = nome;
            this.preco = preco;
        }
    }
}
