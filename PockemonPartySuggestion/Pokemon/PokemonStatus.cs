using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPartySuggestion.Pokemon
{
    /// <summary>
    /// ポケモンのタイプをenumで分類
    ///  
    /// /// /// </summary>
    public enum PokemonType{
        None = 0,
        Normal,
        Fire,
        Water,
        Grass,
        Electric,
        Ice,
        Fighting,
        Poison,
        Ground,
        Flying,
        Psychic,
        Bug,
        Rock,
        Ghost,
        Dragon,
        Dark,
        Steel,
        Fairy
    }

    public static class PokemonTypeDict{
        static PokemonTypeDict(){
            pokemonTypeDict = CreatePokemonDict();
        }

        private static Dictionary<String, PokemonType> CreatePokemonDict(){
            var pokeDict = new Dictionary<String, PokemonType>();
            pokeDict.Add("", PokemonType.None);
            pokeDict.Add("ノーマル", PokemonType.Normal);
            pokeDict.Add("ほのお", PokemonType.Fire);
            pokeDict.Add("みず", PokemonType.Water);
            pokeDict.Add("くさ", PokemonType.Grass);
            pokeDict.Add("でんき", PokemonType.Electric);
            pokeDict.Add("こおり", PokemonType.Ice);
            pokeDict.Add("かくとう", PokemonType.Fighting);
            pokeDict.Add("どく", PokemonType.Poison);
            pokeDict.Add("じめん", PokemonType.Ground);
            pokeDict.Add("ひこう", PokemonType.Flying);
            pokeDict.Add("エスパー", PokemonType.Psychic);
            pokeDict.Add("むし", PokemonType.Bug);
            pokeDict.Add("いわ", PokemonType.Rock);
            pokeDict.Add("ゴースト", PokemonType.Ghost);
            pokeDict.Add("ドラゴン", PokemonType.Dragon);
            pokeDict.Add("あく", PokemonType.Dark);
            pokeDict.Add("はがね", PokemonType.Steel);
            pokeDict.Add("フェアリー", PokemonType.Fairy);
            return pokeDict;
        } 
        private static Dictionary<String, PokemonType> pokemonTypeDict;
    }
    public class PokemonStatus
    {
        public String No {get; set;}
        public String Name {get; set;}
        public PokemonType Type1 {get; set;} 
    }
}
