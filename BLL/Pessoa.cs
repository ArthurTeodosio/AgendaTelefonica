using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pessoa
    {
        public string Nome { get; set;}
        public string Telefone { get; set;}
        
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>() { };

        public void Incluir(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }

        public void Remover(Pessoa pessoa)
        {
            Pessoas.Remove(pessoa);
        }

        public override string ToString()
        {
            return Nome + "-" + Telefone;
        }
    }
}
