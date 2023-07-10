using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_2___POO
{
    public class Empresa
    {
        private int codigo { get; set; }
        protected string nomeEmpresa { get; set; }

        public void constroi(int codigo,string nome)
        {
            this.codigo = codigo;
            this.nomeEmpresa = nome;
        }
    }
}
