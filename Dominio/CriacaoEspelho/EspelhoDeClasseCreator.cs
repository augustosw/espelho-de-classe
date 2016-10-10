using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public class EspelhoDeClasseCreator
    {        
        public List<Espelho> ObterMelhoresEspelhos(string[] alunos, List<string[]> historicoDeEspelhos, Func<string[], bool> filtroCasosEspeciais)
        {
            var historico = new Historico(alunos, historicoDeEspelhos);

            var espelhosEmbaralhados = GeraEspelhosEmbaralhados(alunos, 30000);

            var espelhosQueAtendemFiltro = FiltraEspelhosQueNaoAtendemCasosEspeciais(espelhosEmbaralhados, filtroCasosEspeciais);
            var espelhosOrdenadosPorMelhorScore = OrdenarEspelhosPorScore(historico, espelhosQueAtendemFiltro);

            //gambiarra: adiciona no final o historico antigo a mérito de comparação
            //espelhosOrdenadosPorMelhorScore.Add(new Espelho(historico.historicoVizinhos, new string[] { "Histórico antigo" }));

            return espelhosOrdenadosPorMelhorScore;
        }

        private static List<string[]> GeraEspelhosEmbaralhados(string[] alunos, int quantidadeEmbaralhamentos)
        {
            var espelhosEmbaralhados = new List<string[]>();
            for (int i = 0; i < quantidadeEmbaralhamentos; i++)
            {
                FisherYatesShuffle.Suffle(alunos);
                espelhosEmbaralhados.Add((string[])alunos.Clone());
            }

            return espelhosEmbaralhados;
        }

        private List<string[]> FiltraEspelhosQueNaoAtendemCasosEspeciais(List<string[]> listaDeEspelhos, Func<string[], bool> filtroCasosEspeciais = null)
        {
            if (filtroCasosEspeciais == null)
                return listaDeEspelhos;

            return listaDeEspelhos.Where(filtroCasosEspeciais).ToList();
        }
        
        private List<Espelho> OrdenarEspelhosPorScore(Historico historico, List<string[]> arraysEmbaralhados)
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
