using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public class Espelho
    {
        public string[] espelho;
        public Dictionary<string, List<Vizinho>> projecao;

        public Espelho(Dictionary<string, List<Vizinho>> projecao, string[] espelho)
        {
            this.espelho = espelho;
            this.projecao = projecao;
        }

        /// <summary>
        /// Quanto menos repetições de vizinhos, melhor o score
        /// </summary>
        public int ValorScore
        {
            get
            {
                var valorScore = 0;
            
                foreach (var vizinhos in projecao.Values)
                {
                    foreach (var vizinho in vizinhos)
                    {
                        //Multiplico a quantidade de repetições para que o score aumente exponencialmente
                        valorScore += vizinho.QuantidadeRepeticoes * vizinho.QuantidadeRepeticoes;
                    }
                }

                return valorScore;
            }
        }
    }
}
