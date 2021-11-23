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
    public class PokemonTypeChartTests
    {
        [TestMethod()]
        public void PokemonTypeChartTest_SuperEffective()
        {
            var typeChart = new PokemonTypeChart();
            Assert.AreEqual(Effectiveness.SuperEffective, typeChart[PokemonType.Normal, PokemonType.Fighting]);
        }
        [TestMethod()]
        public void PokemonTypeChartTest_Normal()
        {
            var typeChart = new PokemonTypeChart();
            Assert.AreEqual(Effectiveness.Normal, typeChart[PokemonType.Water, PokemonType.Psychic]);
        }
        [TestMethod()]
        public void PokemonTypeChartTest_NotVeryEffective()
        {
            var typeChart = new PokemonTypeChart();
            Assert.AreEqual(Effectiveness.NotVeryEffective, typeChart[PokemonType.Flying, PokemonType.Bug]);
        }
        [TestMethod()]
        public void PokemonTypeChartTest_NoEffect()
        {
            var typeChart = new PokemonTypeChart();
            Assert.AreEqual(Effectiveness.NoEffect, typeChart[PokemonType.Fairy, PokemonType.Dragon]);
        }
    }
}