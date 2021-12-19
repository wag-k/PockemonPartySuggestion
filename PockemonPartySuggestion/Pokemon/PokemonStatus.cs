using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPartySuggestion.Pokemon
{
    public class PokemonStatus
    {
        public String No {get; set;}
        public String Name {get; set;}
        public PokemonType[] Types {get; set;} 
        public String[] Abilities {get; set;}
        public BaseStatus Status {get; set;}
    }

    public struct BaseStatus{
        public int HP{get; set;}
        public int Atk{get; set;}
        public int Def{get; set;}
        public int SpAtk{get; set;}
        public int SpDef{get; set;}
        public int Speed{get; set;}
        public int Sum{get; set;}
    }
}
