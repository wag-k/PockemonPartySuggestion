using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokemonPartySuggestion.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPartySuggestion.Pokemon.Tests
{
    [TestClass()]
    public class PokemonDictTests
    {
        static String CsvFilePath = "./data/pokemon_status.csv";
        [TestMethod()]
        public void LoadTest()
        {
            var pokemonName = "コラッタ";
            var pokemonDict = PokemonDict.Load(CsvFilePath);
            var koratta = pokemonDict[pokemonName];
            Assert.AreEqual(pokemonName, koratta.Name);
            Assert.AreEqual(253, koratta.Status.Sum);
        }
    }
}