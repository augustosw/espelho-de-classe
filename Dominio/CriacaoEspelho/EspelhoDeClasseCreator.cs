using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public class EspelhoDeClasseCreator
    {
        private const int QuantidadeEmbaralhamentos = 50000;

        public List<Espelho> ObterMelhoresEspelhos(string[] alunos, List<string[]> historicoDeEspelhos, Func<string[], bool> filtroCasosEspeciais)
        {
            var historico = new Historico(alunos, historicoDeEspelhos);

            var espelhosEmbaralhados = GeraEspelhosRandomicamenteEmbaralhados(alunos, QuantidadeEmbaralhamentos);

            var espelhosQueAtendemFiltro = EliminaEspelhosQueNaoAtendemCasosEspeciais(espelhosEmbaralhados, filtroCasosEspeciais);
            var espelhosOrdenadosPorMelhorScore = OrdenarEspelhosPorScoreDeRepeticao(historico, espelhosQueAtendemFiltro);
            
            return espelhosOrdenadosPorMelhorScore;
        }

        private static List<string[]> GeraEspelhosRandomicamenteEmbaralhados(string[] alunos, int quantidadeEmbaralhamentos)
        {
            var espelhosEmbaralhados = new List<string[]>();
            for (int i = 0; i < quantidadeEmbaralhamentos; i++)
            {
                FisherYatesShuffle.Suffle(alunos);
                espelhosEmbaralhados.Add((string[])alunos.Clone());
            }

            return espelhosEmbaralhados;
        }

        private List<string[]> EliminaEspelhosQueNaoAtendemCasosEspeciais(List<string[]> listaDeEspelhos, Func<string[], bool> filtroCasosEspeciais = null)
        {
            if (filtroCasosEspeciais == null)
                return listaDeEspelhos;

            return listaDeEspelhos.Where(filtroCasosEspeciais).ToList();
        }
        
        /// <summary>
        /// Esse é o método que ordena quais são os melhores espelhos.
        /// O score é calculado com base nas repetições dos mesmos colegas. Quanto menos repetições,
        /// melhor o score.
        /// </summary>
        /// <param name="historico"></param>
        /// <param name="arraysEmbaralhados"></param>
        /// <returns></returns>
        private List<Espelho> OrdenarEspelhosPorScoreDeRepeticao(Historico historico, List<string[]> arraysEmbaralhados)
        {
            List<Espelho> espelhos = new List<Espelho>();

            foreach (var arrayEmbaralhado in arraysEmbaralhados)
            {
                var projecao = historico.ObterHistoricoProjetadoComNovoEmbaralhamento(arrayEmbaralhado);
                var score = new Espelho(projecao, arrayEmbaralhado);
                espelhos.Add(score);
            }            
            
            var espelhosOrdenadosPorScore = espelhos.OrderBy(x => x.ValorScore);

            return espelhosOrdenadosPorScore.ToList();
        }
    }
}
