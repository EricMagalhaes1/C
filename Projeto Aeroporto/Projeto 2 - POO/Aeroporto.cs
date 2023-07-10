using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Aeroporto
    {
        protected int codigo { get; set; }
        protected string nome { get; set; }
        protected string cidade { get; set; }
        protected string estado { get; set; }
        protected string pais { get; set; }


        public void constroi(int codigo,string nome,string cidade,string estado,string pais)
        {
             this.codigo = codigo;
            this.nome = nome;
            this.cidade = cidade;
            this.estado = estado;
            this.pais = pais;
        }
    }
}
