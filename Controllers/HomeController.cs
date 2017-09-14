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
                "Luis Lima",
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

            var espelhoCreator = new EspelhoDeClasseCreator();
            var melhoresEspelhos = espelhoCreator.ObterMelhoresEspelhos(alunosAtivos, listaEspelhosPassados, FiltroCasosEspeciais);

            return View(melhoresEspelhos);
        }

        private bool FiltroCasosEspeciais(string[] espelho)
        {
            var posicaoLeonardo = Array.IndexOf(espelho, "Leonardo Bork");
            var posicaoLuis = Array.IndexOf(espelho, "Luis Lima");
            var posicaoWillian = Array.IndexOf(espelho, "Willian Velhos");

            var primeiraFileira = 5;
            ////var segundaFileira = 11;
            ////var terceiraFileira = 17;

            //////Casos que possuem restrições, caso eles fiquem atrás dessas posições 
            //////o espelho deve ser descartado
            if (posicaoLeonardo > primeiraFileira || posicaoLuis > primeiraFileira)
                return false;

            if (posicaoWillian != 0)
                return false;

            return true;
        }
    }
}