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
                //"Douglas de Freitas",
                "Eduardo Dornel Ribas",
                "Eliseu José Daroit Júnior",
                "Felipe Thomas Vargas de Souza",
                "Gabriel Dias Henz",
                "Gabriel Ferreira da Rosa",
                "Henrique Honaiser Ostermamm",
                "Henrique Mentz",
                //"Jeniffer da Silva Costa",
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
            // 17/10 sql server            
            listaEspelhosPassados.Add(new string[] { "Eliseu José Daroit Júnior", "Rafael Henrique da Silva", "Jeniffer da Silva Costa", "Victor Oliveira", "Máicon Träsel Loebens", "Gabriel Ferreira da Rosa", "Anna Luisa de Oliveira", "Matheus Augusto Schmitz", "Otávio Fabrin Bubans", "Leonardo Gabriel Grasel de Almeida", "Henrique Mentz", "Daniel de Carvalho Figueiredo", "Mateus Ramos", "Rodrigo Scheuer", "Cássio Farias Machado", "Pablo da Luz Schlusen", "Felipe Thomas Vargas de Souza", "Jonathan William Silva dos Santos", "Régis Martiny", "Gabriel Dias Henz", "Eduardo Dornel Ribas", "Mateus Bueno dos Passos Teixeira", "Douglas de Freitas", "Arthur Lima de Souza", "Henrique Honaiser Ostermamm" });
            //19/10 html e css
            listaEspelhosPassados.Add(new string[] { "Gabriel Ferreira da Rosa", "Matheus Augusto Schmitz", "Mateus Bueno dos Passos Teixeira", "Máicon Träsel Loebens", "Felipe Thomas Vargas de Souza", "Jeniffer da Silva Costa", "Otávio Fabrin Bubans", "Cássio Farias Machado", "Leonardo Gabriel Grasel de Almeida", "Gabriel Dias Henz", "Daniel de Carvalho Figueiredo", "Eliseu José Daroit Júnior", "Henrique Mentz", "Rafael Henrique da Silva", "Victor Oliveira", "Pablo da Luz Schlusen", "Arthur Lima de Souza", "Jonathan William Silva dos Santos", "Anna Luisa de Oliveira", "Mateus Ramos", "Régis Martiny", "Douglas de Freitas", "Henrique Honaiser Ostermamm", "Rodrigo Scheuer", "Eduardo Dornel Ribas" });
            //26/10 javascript 
            listaEspelhosPassados.Add(new string[] { "Gabriel Ferreira da Rosa", "Henrique Honaiser Ostermamm", "Henrique Mentz", "Otávio Fabrin Bubans", "Anna Luisa de Oliveira", "Jeniffer da Silva Costa", "Gabriel Dias Henz", "Leonardo Gabriel Grasel de Almeida", "Mateus Bueno dos Passos Teixeira", "Felipe Thomas Vargas de Souza", "Eduardo Dornel Ribas", "Pablo da Luz Schlusen", "Matheus Augusto Schmitz", "Victor Oliveira", "Régis Martiny", "Rodrigo Scheuer", "Douglas de Freitas", "Rafael Henrique da Silva", "Arthur Lima de Souza", "Máicon Träsel Loebens", "Eliseu José Daroit Júnior", "Mateus Ramos", "Cássio Farias Machado", "Jonathan William Silva dos Santos", "Daniel de Carvalho Figueiredo" });
            //07/11 .net
            listaEspelhosPassados.Add(new string[] { "Gabriel Ferreira da Rosa", "Cássio Farias Machado", "Douglas de Freitas", "Leonardo Gabriel Grasel de Almeida", "Jeniffer da Silva Costa", "Mateus Bueno dos Passos Teixeira", "Pablo da Luz Schlusen", "Henrique Honaiser Ostermamm", "Máicon Träsel Loebens", "Henrique Mentz", "Arthur Lima de Souza", "Eliseu José Daroit Júnior", "Matheus Augusto Schmitz", "Daniel de Carvalho Figueiredo", "Eduardo Dornel Ribas", "Victor Oliveira", "Gabriel Dias Henz", "Anna Luisa de Oliveira", "Régis Martiny", "Rodrigo Scheuer", "Otávio Fabrin Bubans", "Rafael Henrique da Silva", "Felipe Thomas Vargas de Souza", "Mateus Ramos", "Jonathan William Silva dos Santos" });
            //22/11 reforço .net
            listaEspelhosPassados.Add(new string[] { "Jeniffer da Silva Costa", "Mateus Ramos", "Gabriel Ferreira da Rosa", "Gabriel Dias Henz", "Rafael Henrique da Silva", "Leonardo Gabriel Grasel de Almeida", "Régis Martiny", "Jonathan William Silva dos Santos", "Máicon Träsel Loebens", "Anna Luisa de Oliveira", "Rodrigo Scheuer", "Henrique Honaiser Ostermamm", "Mateus Bueno dos Passos Teixeira", "Pablo da Luz Schlusen", "Otávio Fabrin Bubans", "Eduardo Dornel Ribas", "Matheus Augusto Schmitz", "Eliseu José Daroit Júnior", "Arthur Lima de Souza", "Daniel de Carvalho Figueiredo", "Felipe Thomas Vargas de Souza", "Cássio Farias Machado", "Victor Oliveira", "Henrique Mentz" });
            //28/11 java
            listaEspelhosPassados.Add(new string[] { "Arthur Lima de Souza", "Jeniffer da Silva Costa", "Máicon Träsel Loebens", "Gabriel Ferreira da Rosa", "Gabriel Dias Henz", "Henrique Honaiser Ostermamm", "Anna Luisa de Oliveira", "Pablo da Luz Schlusen", "Leonardo Gabriel Grasel de Almeida", "Felipe Thomas Vargas de Souza", "Otávio Fabrin Bubans", "Henrique Mentz", "Mateus Ramos", "Victor Oliveira", "Rodrigo Scheuer", "Eliseu José Daroit Júnior", "Daniel de Carvalho Figueiredo", "Régis Martiny", "Eduardo Dornel Ribas", "Rafael Henrique da Silva", "Jonathan William Silva dos Santos", "Matheus Augusto Schmitz", "Cássio Farias Machado", "Mateus Bueno dos Passos Teixeira" });
            //06/12 java
            listaEspelhosPassados.Add(new string[] { "Leonardo Gabriel Grasel de Almeida", "Gabriel Dias Henz", "Jonathan William Silva dos Santos", "Gabriel Ferreira da Rosa", "Felipe Thomas Vargas de Souza", "Mateus Bueno dos Passos Teixeira", "Cássio Farias Machado", "Pablo da Luz Schlusen", "Daniel de Carvalho Figueiredo", "Otávio Fabrin Bubans", "Eduardo Dornel Ribas", "Anna Luisa de Oliveira", "Rodrigo Scheuer", "Arthur Lima de Souza", "Victor Oliveira", "Henrique Honaiser Ostermamm", "Mateus Ramos", "Matheus Augusto Schmitz", "Eliseu José Daroit Júnior", "Rafael Henrique da Silva", "Máicon Träsel Loebens", "Henrique Mentz", "Régis Martiny" });
            //12/12 java 
            listaEspelhosPassados.Add(new string[] { "Gabriel Ferreira da Rosa", "Arthur Lima de Souza", "Felipe Thomas Vargas de Souza", "Mateus Ramos", "Leonardo Gabriel Grasel de Almeida", "Daniel de Carvalho Figueiredo", "Henrique Mentz", "Gabriel Dias Henz", "Matheus Augusto Schmitz", "Jonathan William Silva dos Santos", "Pablo da Luz Schlusen", "Otávio Fabrin Bubans", "Cássio Farias Machado", "Eduardo Dornel Ribas", "Rodrigo Scheuer", "Máicon Träsel Loebens", "Henrique Honaiser Ostermamm", "Eliseu José Daroit Júnior", "Victor Oliveira", "Anna Luisa de Oliveira", "Rafael Henrique da Silva", "Mateus Bueno dos Passos Teixeira", "Régis Martiny" });

            var espelhoCreator = new EspelhoDeClasseCreator();
            var melhoresEspelhos = espelhoCreator.ObterMelhoresEspelhos(alunos, listaEspelhosPassados, FiltroCasosEspeciais);

            return View(melhoresEspelhos);
        }

        private bool FiltroCasosEspeciais(string[] espelho)
        {
            var posicaoGabrielRosa = Array.IndexOf(espelho, "Gabriel Ferreira da Rosa");
            var leonardo = Array.IndexOf(espelho, "Leonardo Gabriel Grasel de Almeida");
            var pablo = Array.IndexOf(espelho, "Pablo da Luz Schlusen");

            //Casos que possuem restrições, caso eles fiquem atrás dessas posições 
            //o espelho deve ser descartado
            if (posicaoGabrielRosa > 5)
                return false;

            if (leonardo > 11 || pablo > 11)
                return false;

            return true;
        }
    }
}