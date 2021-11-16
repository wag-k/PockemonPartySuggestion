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
    public class PokemonTypeDictTests
    {
        [TestMethod()]
        public void GetInstanceTest()
        {
            var dict = PokemonTypeDict.GetInstance();
            Assert.AreEqual(PokemonType.None, dict[""]);
            Assert.AreEqual(PokemonType.Normal, dict["ノーマル"]);
            Assert.AreEqual(PokemonType.Fairy, dict["フェアリー"]);
        }
    }
}

namespace PokemonPartySuggestionTests.Pokemon
{
    class PokemonTypeDictTests
    {
    }
}
