using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public class Historico
    {
        public Dictionary<string, List<Vizinho>> historicoVizinhos = new Dictionary<string, List<Vizinho>>();

        public Historico(string[]  alunos, List<string[]> listaEspelhosRetroativos)
        {
            //Monta a lista com o primeiro espelho (que tinha todos alunos) 
            //ou com o array de alunos passado caso seja o primeiro
            //Fazemos isso pois o array de alunos pode perder itens no futuro
            var listaTodosAlunosExistentes = listaEspelhosRetroativos.FirstOrDefault() ?? alunos;

            InicializaDictionaryHistoricos(listaTodosAlunosExistentes);

            foreach (var espelho in listaEspelhosRetroativos)
            {
                PopulaDictionaryHistoricos(espelho);
            }
        }

        private void InicializaDictionaryHistoricos(string[] alunos)
        {
            foreach (var aluno in alunos)
            {
                //Inicializa o dictionary de históricos
                historicoVizinhos.Add(aluno, new List<Vizinho>());
            }
        }

        /// <summary>
        /// Gera uma cópia do histórico de vizinhos, adicionando nessa cópia o array de 
        /// alunos embaralhados que foi passado por parâmetro.
        /// </summary>
        public Dictionary<string, List<Vizinho>> ObterHistoricoProjetadoComNovoEmbaralhamento(string[] alunosEmbaralhados)
        {
            var historicoAntigo = historicoVizinhos.Clone();

            PopulaDictionaryHistoricos(alunosEmbaralhados, historicoAntigo);

            return historicoAntigo;
        }

        private void PopulaDictionaryHistoricos(string[] alunos, Dictionary<string, List<Vizinho>> historicoCópia = null)
        {
            var linkedList = new LinkedList<string>(alunos);
            var nodeAtual = linkedList.First;

            do
            {
                var prev = nodeAtual.Previous?.Value;
                var next = nodeAtual.Next?.Value;
                
                //Adiciona os vizinhos na lista
                if (prev != null && !LugarEsquerdoEhEspacoVazio(linkedList, nodeAtual))
                    AdicionaVizinhoDoAluno(nodeAtual.Value, prev, historicoCópia);
                if (next != null && !LugarDireitoEhEspacoVazio(linkedList, nodeAtual))
                    AdicionaVizinhoDoAluno(nodeAtual.Value, next, historicoCópia);

                nodeAtual = nodeAtual.Next;
            }
            while (nodeAtual != null);
        }

        private bool LugarEsquerdoEhEspacoVazio(LinkedList<string> linkedList, LinkedListNode<string> nodeAtual)
        {
            var indiceDoArray = linkedList.IndexOf(nodeAtual.Value);
            var posicoesComLugarVazioAEsquerda = new int[] { 0, 3, 6, 9, 12, 15, 18};

            return posicoesComLugarVazioAEsquerda.Contains(indiceDoArray);
        }

        private bool LugarDireitoEhEspacoVazio(LinkedList<string> linkedList, LinkedListNode<string> nodeAtual)
        {
            var indiceDoArray = linkedList.IndexOf(nodeAtual.Value);
            var posicoesComLugarVazioAEsquerda = new int[] { 2, 5, 8, 11, 14, 17 };

            return posicoesComLugarVazioAEsquerda.Contains(indiceDoArray);
        }

        private void AdicionaVizinhoDoAluno(string aluno, string vizinho, Dictionary<string, List<Vizinho>> historicoVizinhosCópia)
        {
            //Usa o histórico fake (copiado) caso ele seja informado, caso contrário 
            //utiliza o atributo histórico real (membro dessa classe)
            var historico = historicoVizinhosCópia ?? historicoVizinhos;
            var historicoVizinhosDoAluno = historico[aluno];

            var vizinhoRepetido = historicoVizinhosDoAluno.FirstOrDefault(x => x.Nome == vizinho);

            if (vizinhoRepetido == null)
                historicoVizinhosDoAluno.Add(new Vizinho(vizinho));
            else
                vizinhoRepetido.IncrementaRepeticao();
        }
    }
}
