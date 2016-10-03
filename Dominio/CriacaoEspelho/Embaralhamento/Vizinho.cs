using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public class Vizinho
    {
        public string Nome { get; private set; }
        //Quantidade de vezes que esse aluno já foi meu vizinho
        public int QuantidadeRepeticoes { get; private set; }

        public Vizinho(string nome)
        {
            Nome = nome;
            QuantidadeRepeticoes = 1;
        }

        public void IncrementaRepeticao()
        {
            QuantidadeRepeticoes++;
        }

        public Vizinho Clone()
        {                        
            return (Vizinho)this.MemberwiseClone();
        }
    }
}
