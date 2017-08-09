using EspelhoDeClasse.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EspelhoDeClasse.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var alunosAtivos = new string[]
            {
                "Alana Weiss",
                "Alexia Pereira",
                "Bruno Aguiar",
                "Camila Batista",
                "Christopher Michel",
                //"Claudia Moura",
                "Deordines Tomazi",
                "Diandra Rocha",
                "Jabel Fontoura",
                "Joao Silva",
                "Jomar Cardoso",
                "Leonardo Alves",
                "Leonardo Morais",
                "Lucas Damaceno",
                "Lucas Gaspar",
                "Lucas Muller",
                //"Luis Robinson",
                //"Maico Kley",
                "Mateus Silva",
                "Mathias Ody",
                "Mirela Adam",
                "Rafael Barizon",
                "Rafael Barreto",
                "Tais Silva",
                "William Goncalves",
            };

            var listaEspelhosPassados = new List<string[]>();

            //Angular
            listaEspelhosPassados.Add(new string[] { "Joao Silva", "Luis Robinson", "Diandra Rocha", "Tais Silva", "Jomar Cardoso", "Deordines Tomazi", "William Goncalves", "Alana Weiss", "Mirela Adam", "Leonardo Alves", "Rafael Barizon", "Leonardo Morais", "Camila Batista", "Lucas Damaceno", "Lucas Gaspar", "Mateus Silva", "Jabel Fontoura", "Bruno Aguiar", "Christopher Michel", "Lucas Muller", "Mathias Ody", "Maico Kley", "Claudia Moura", "Rafael Barreto", "Alexia Pereira" });
            //.NET
            listaEspelhosPassados.Add(new string[] { "Joao Silva", "Luis Robinson", "William Goncalves", "Diandra Rocha", "Camila Batista", "Maico Kley", "Alexia Pereira", "Alana Weiss", "Mirela Adam", "Leonardo Alves", "Jomar Cardoso", "Leonardo Morais", "Tais Silva", "Lucas Damaceno", "Lucas Gaspar", "Mathias Ody", "Jabel Fontoura", "Bruno Aguiar", "Christopher Michel", "Lucas Muller", "Mateus Silva", "Deordines Tomazi", "Rafael Barreto", "Claudia Moura", "Rafael Barizon" });
            //Banco II
            listaEspelhosPassados.Add(new string[] { "Mathias Ody", "Tais Silva", "Bruno Aguiar", "Mateus Silva", "Alana Weiss", "Leonardo Morais", "William Goncalves", "Joao Silva", "Rafael Barreto", "Rafael Barizon", "Alexia Pereira", "Deordines Tomazi", "Lucas Muller", "Jabel Fontoura", "Lucas Gaspar", "Lucas Damaceno", "Mirela Adam", "Camila Batista", "Jomar Cardoso", "Diandra Rocha", "Christopher Michel", "Leonardo Alves" });
            //Java
            listaEspelhosPassados.Add(new string[] { "Tais Silva", "Rafael Barreto", "Jomar Cardoso", "Mirela Adam", "William Goncalves", "Deordines Tomazi", "Joao Silva", "Rafael Barizon", "Mateus Silva", "Alana Weiss", "Alexia Pereira", "Leonardo Morais", "Leonardo Alves", "Camila Batista", "Jabel Fontoura", "Christopher Michel", "Bruno Aguiar", "Mathias Ody", "Lucas Gaspar", "Lucas Muller", "Diandra Rocha", "Lucas Damaceno" });

            var espelhoCreator = new EspelhoDeClasseCreator();
            var melhoresEspelhos = espelhoCreator.ObterMelhoresEspelhos(alunosAtivos, listaEspelhosPassados, FiltroCasosEspeciais);

            return View(melhoresEspelhos);
        }

        private bool FiltroCasosEspeciais(string[] espelho)
        {
            var posicaoAlana = Array.IndexOf(espelho, "Alana Weiss");
            var posicaoTais = Array.IndexOf(espelho, "Tais Silva");
            var posicaoLeonardoMorais = Array.IndexOf(espelho, "Leonardo Morais");
            var posicaoDeordines = Array.IndexOf(espelho, "Deordines Tomazi");
            var posicaoWilliam = Array.IndexOf(espelho, "William Goncalves");
            var posicaoJoao = Array.IndexOf(espelho, "Joao Silva");
            var posicaoBarizon = Array.IndexOf(espelho, "Rafael Barizon");
            var posicaoCamila = Array.IndexOf(espelho, "Camila Batista");

            var primeiraFileira = 5;
            var segundaFileira = 11;
            var terceiraFileira = 17;

            //Casos que possuem restrições, caso eles fiquem atrás dessas posições 
            //o espelho deve ser descartado
            if (posicaoTais > primeiraFileira)
                return false;

            if (posicaoAlana > segundaFileira ||
                posicaoLeonardoMorais > segundaFileira ||
                posicaoDeordines > segundaFileira ||
                posicaoWilliam > segundaFileira ||
                posicaoJoao > segundaFileira ||
                posicaoBarizon > segundaFileira)
                return false;

            if (posicaoCamila > terceiraFileira)
                return false;

            return true;
        }
    }
}