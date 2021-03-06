﻿using EspelhoDeClasse.Dominio;
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
                "Alvaro Schmidt",
                "Bel Cogo",
                "Bruno Hoffmann",
                "Francisco Mossi",
                "Gustavo Rodrigues",
                "Jacob Stein",
                "Jessica Rocha",
                "Joao Fidellis",
                "Julia Vila",
                "Leandro Paz",
                "Leonardo Bork",
                "Luan Avila",
                //"Luis Lima",
                "Marcele Dorneles",
                "Mathias Voelcker",
                "Natalia Silva",
                "Pablo Garcia",
                "Pedro Rohr",
                "Steffano Heckler",
                "Victor Damke",
                "Victor Scherer",
                "Vitor Ramos",
                "Viviane Machado",
                "Willian Pazinatto",
                "Willian Velhos"
            };

            var listaEspelhosPassados = new List<string[]>();

            //Espelho OO
            listaEspelhosPassados.Add(new string[] { "Willian Velhos", "Steffano Heckler", "Luis Lima", "Viviane Machado", "Pablo Garcia", "Leonardo Bork", "Jacob Stein", "Natalia Silva", "Vitor Ramos", "Marcele Dorneles", "Victor Scherer", "Jessica Rocha", "Joao Fidellis", "Leandro Paz", "Pedro Rohr", "Bruno Hoffmann", "Julia Vila", "Mathias Voelcker", "Bel Cogo", "Willian Pazinatto", "Victor Damke", "Gustavo Rodrigues", "Alvaro Schmidt", "Francisco Mossi", "Luan Avila" });
            //Espelho BD-I
            listaEspelhosPassados.Add(new string[] { "Willian Velhos", "Luis Lima", "Joao Fidellis", "Luan Avila", "Natalia Silva", "Leonardo Bork", "Alvaro Schmidt", "Julia Vila", "Victor Damke", "Jessica Rocha", "Pablo Garcia", "Francisco Mossi", "Viviane Machado", "Marcele Dorneles", "Steffano Heckler", "Mathias Voelcker", "Jacob Stein", "Victor Scherer", "Bel Cogo", "Pedro Rohr", "Vitor Ramos", "Bruno Hoffmann", "Gustavo Rodrigues", "Leandro Paz", "Willian Pazinatto" });
            //Espelho HTML-CSS
            listaEspelhosPassados.Add(new string[] { "Willian Velhos", "Bel Cogo", "Vitor Ramos", "Luis Lima", "Jacob Stein", "Leonardo Bork", "Jessica Rocha", "Bruno Hoffmann", "Leandro Paz", "Julia Vila", "Willian Pazinatto", "Luan Avila", "Viviane Machado", "Alvaro Schmidt", "Marcele Dorneles", "Steffano Heckler", "Natalia Silva", "Pablo Garcia", "Mathias Voelcker", "Francisco Mossi", "Victor Scherer", "Joao Fidellis", "Victor Damke", "Pedro Rohr", "Gustavo Rodrigues" });
            //Espelho JS
            listaEspelhosPassados.Add(new string[] { "Willian Velhos", "Luan Avila", "Leonardo Bork", "Willian Pazinatto", "Viviane Machado", "Victor Damke", "Bruno Hoffmann", "Marcele Dorneles", "Pedro Rohr", "Joao Fidellis", "Gustavo Rodrigues", "Jessica Rocha", "Pablo Garcia", "Jacob Stein", "Francisco Mossi", "Leandro Paz", "Victor Scherer", "Steffano Heckler", "Vitor Ramos", "Julia Vila", "Bel Cogo", "Alvaro Schmidt", "Natalia Silva", "Mathias Voelcker" });
            //Espelho AngularJS
            listaEspelhosPassados.Add(new string[] { "Leonardo Bork", "Steffano Heckler", "Bruno Hoffmann", "Willian Pazinatto", "Jessica Rocha", "Julia Vila", "Vitor Ramos", "Alvaro Schmidt", "Victor Scherer", "Victor Damke", "Mathias Voelcker", "Pedro Rohr", "Marcele Dorneles", "Bel Cogo", "Francisco Mossi", "Gustavo Rodrigues", "Jacob Stein", "Joao Fidellis", "Pablo Garcia", "Luan Avila", "Viviane Machado", "Natalia Silva", "Willian Velhos", "Leandro Paz" });
            //Espelho C#
            listaEspelhosPassados.Add(new string[] { "Leandro Paz", "Francisco Mossi", "Victor Damke", "Jessica Rocha", "Bel Cogo", "Leonardo Bork", "Bruno Hoffmann", "Willian Pazinatto", "Gustavo Rodrigues", "Jacob Stein", "Marcele Dorneles", "Willian Velhos", "Luan Avila", "Mathias Voelcker", "Steffano Heckler", "Natalia Silva", "Victor Scherer", "Pablo Garcia", "Vitor Ramos", "Viviane Machado", "Julia Vila", "Joao Fidellis", "Alvaro Schmidt", "Pedro Rohr" });

            var espelhoCreator = new EspelhoDeClasseCreator();
            var melhoresEspelhos = espelhoCreator.ObterMelhoresEspelhos(alunosAtivos, listaEspelhosPassados, FiltroCasosEspeciais);

            return View(melhoresEspelhos);
        }

        private bool FiltroCasosEspeciais(string[] espelho)
        {
            var posicaoLeonardo = Array.IndexOf(espelho, "Leonardo Bork");

            var primeiraFileira = 5;
            ////var segundaFileira = 11;
            ////var terceiraFileira = 17;

            //////Casos que possuem restrições, caso eles fiquem atrás dessas posições 
            //////o espelho deve ser descartado
            if (posicaoLeonardo > primeiraFileira)
                return false;

            return true;
        }
    }
}