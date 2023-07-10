using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Cliente:Compra
    {
        protected int codigoCliente { get; set; }
        protected string nomeCliente { get; set; }
        protected string cpf { get; set; }
        protected string endereco { get; set; }
       
        public void constroi(int codigo, string nome,string cpf, string endereco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
        }
       // Piloto x = new Piloto();
        public string Mensagem()
        {
            return $"O passageiro {nomeCliente}\n Saiu de {cidade} indo para {cidade} no assento {assento}  com valor {valorTotal} com o piloto ";
        }
    }
}
