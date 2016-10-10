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
            var alunos = new string[]
            {
                "Anna Luisa de Oliveira",
                "Arthur Lima de Souza",
                "Cássio Farias Machado",
                "Daniel de Carvalho Figueiredo",
                "Douglas de Freitas",
                "Eduardo Dornel Ribas",
                "Eliseu José Daroit Júnior",
                "Felipe Thomas Vargas de Souza",
                "Gabriel Dias Henz",
                "Gabriel Ferreira da Rosa",
                "Henrique Honaiser Ostermamm",
                "Henrique Mentz",
                "Jeniffer da Silva Costa",
                "Jonathan William Silva dos Santos",
                "Leonardo Gabriel Grasel de Almeida",
                "Mateus Bueno dos Passos Teixeira",
                "Mateus Ramos",
                "Matheus Augusto Schmitz",
                "Máicon Träsel Loebens",
                "Otávio Fabrin Bubans",
                "Pablo da Luz Schlusen",
                "Rafael Henrique da Silva",
                "Rodrigo Scheuer",
                "Régis Martiny",
                "Victor Oliveira"
            };

            var listaEspelhosPassados = new List<string[]>();
            // 03/10 segunda semana OO
            listaEspelhosPassados.Add(new string[] { "Rafael Henrique da Silva", "Régis Martiny", "Jeniffer da Silva Costa", "Jonathan William Silva dos Santos", "Gabriel Ferreira da Rosa", "Henrique Mentz", "Pablo da Luz Schlusen", "Rodrigo Scheuer", "Gabriel Dias Henz", "Matheus Augusto Schmitz", "Felipe Thomas Vargas de Souza", "Douglas de Freitas", "Otávio Fabrin Bubans", "Máicon Träsel Loebens", "Cássio Farias Machado", "Henrique Honaiser Ostermamm", "Daniel de Carvalho Figueiredo", "Victor Oliveira", "Mateus Ramos", "Eduardo Dornel Ribas", "Arthur Lima de Souza", "Anna Luisa de Oliveira", "Leonardo Gabriel Grasel de Almeida", "Eliseu José Daroit Júnior", "Mateus Bueno dos Passos Teixeira" });
            // 10/10 sql server            
            listaEspelhosPassados.Add(new string[] { "Daniel de Carvalho Figueiredo", "Gabriel Ferreira da Rosa", "Jeniffer da Silva Costa", "Felipe Thomas Vargas de Souza", "Gabriel Dias Henz", "Mateus Ramos", "Máicon Träsel Loebens", "Eduardo Dornel Ribas", "Leonardo Gabriel Grasel de Almeida", "Henrique Honaiser Ostermamm", "Matheus Augusto Schmitz", "Arthur Lima de Souza", "Anna Luisa de Oliveira", "Régis Martiny", "Otávio Fabrin Bubans", "Mateus Bueno dos Passos Teixeira", "Victor Oliveira", "Douglas de Freitas", "Rodrigo Scheuer", "Eliseu José Daroit Júnior", "Cássio Farias Machado", "Henrique Mentz", "Pablo da Luz Schlusen", "Rafael Henrique da Silva", "Jonathan William Silva dos Santos" });

            var espelhoCreator = new EspelhoDeClasseCreator();
            var melhoresEspelhos = espelhoCreator.ObterMelhoresEspelhos(alunos, listaEspelhosPassados, FiltroCasosEspeciais);

            return View(melhoresEspelhos);
        }

        private bool FiltroCasosEspeciais(string[] espelho)
        {
            var posicaoJeniffer = Array.IndexOf(espelho, "Jeniffer da Silva Costa");
            var posicaoGabrielRosa = Array.IndexOf(espelho, "Gabriel Ferreira da Rosa");
            var leonardo = Array.IndexOf(espelho, "Leonardo Gabriel Grasel de Almeida");

            //Devem ficar na primeira fileira
            if (posicaoJeniffer > 5 || posicaoGabrielRosa > 5)
                return false;

            if (leonardo > 11)
                return false;

            return true;
        }
    }
}