using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPartySuggestion.Pokemon
{
    /// <summary>
    /// タイプの有効性。%で表示 
    /// </summary>
    public enum Effectiveness{
        NoEffect = 0,
        NotVeryEffective = 50,
        Normal = 100,
        SuperEffective = 200,
    }


    public class PokemonTypeChart
    {
        /// <summary>
        /// インデクサで受け、攻めの時の相性を返す
        /// </summary>
        /// <value></value>
        public Effectiveness this[PokemonType defenseType, PokemonType attackType]{
            get {return typeChart[defenseType][attackType];}
        }
        public static Dictionary<PokemonType, TypeChart> TypeChart{get {return typeChart;}}
        static Dictionary<PokemonType, TypeChart> typeChart;

        static PokemonTypeChart(){
            typeChart = CreateTypeChart();
        }

        public PokemonTypeChart(){

        }

        /// <summary>
        /// タイプ相性表の作成
        /// </summary>
        /// <returns></returns>
        static Dictionary<PokemonType, TypeChart> CreateTypeChart(){
            var chart = new Dictionary<PokemonType, TypeChart>();
            chart[PokemonType.None] = new NoneTypeChart();
            chart[PokemonType.Normal] = new NormalTypeChart();
            chart[PokemonType.Fire] = new FireTypeChart();
            chart[PokemonType.Water] = new WaterTypeChart();
            chart[PokemonType.Electric] = new ElectricTypeChart();
            chart[PokemonType.Grass] = new GrassTypeChart();
            chart[PokemonType.Ice] = new IceTypeChart();
            chart[PokemonType.Fighting] = new FireTypeChart();
            chart[PokemonType.Poison] = new PoisonTypeChart();
            chart[PokemonType.Ground] = new GroundTypeChart();
            chart[PokemonType.Flying] = new FlyingTypeChart();
            chart[PokemonType.Psychic] = new PhychicTypeChart();
            chart[PokemonType.Bug] = new BugTypeChart();
            chart[PokemonType.Rock] = new RockTypeChart();
            chart[PokemonType.Ghost] = new GhostTypeChart();
            chart[PokemonType.Dragon] = new DragonTypeChart();
            chart[PokemonType.Dark] = new DarkTypeChart();
            chart[PokemonType.Steel] = new SteelTypeChart();
            chart[PokemonType.Fairy] = new FairyTypeChart();
            return chart;
        }
    }

    /// <summary>
    /// 単タイプの相性表
    /// attackTypeで攻撃されたときに効果抜群かどうか返してくれる辞書
    /// 派生して使うこと。
    /// </summary>
    public abstract class TypeChart{

        public abstract PokemonType Type{get;}
        public Effectiveness this[PokemonType attackType]{
            get {return typeChart[attackType];}
        }
        public TypeChart(){
            this.typeChart = CreateTypeChart();
        }
        public abstract Dictionary<PokemonType, Effectiveness> CreateTypeChart();
        private Dictionary<PokemonType, Effectiveness> typeChart;
    }

    public class NoneTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.None;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Fire] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Water] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Electric] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Ice] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Poison] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Ground] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Flying] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Bug] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Rock] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Dark] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Steel] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.NoEffect;
            return singleTypeChart;
        }
    }
    public class NormalTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Normal;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }

    public class FireTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Fire;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.NotVeryEffective;
            return singleTypeChart;
        }
    }

    public class WaterTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Water;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Electric] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Grass] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }

    public class ElectricTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Electric;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }

    public class GrassTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Grass;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Electric] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ground] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class IceTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Ice;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class FightingTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Fighting;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Bug] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.SuperEffective;
            return singleTypeChart;
        }
    }
    public class PoisonTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Poison;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ground] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Bug] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.NotVeryEffective;
            return singleTypeChart;
        }    
    }
    public class GroundTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Ground;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Electric] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Grass] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class FlyingTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Flying;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class PhychicTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Psychic;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Bug] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class BugTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Bug;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class RockTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Rock;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fire] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ground] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class GhostTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Ghost;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class DragonTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Dragon;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Electric] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.SuperEffective;
            return singleTypeChart;
        }
    }
    public class DarkTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Dark;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Bug] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dark] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Steel] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
    public class SteelTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Steel;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fire] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ice] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Ground] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Flying] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Bug] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Dark] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Steel] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.NotVeryEffective;
            return singleTypeChart;
        }
    }
    public class FairyTypeChart : TypeChart{
        public override PokemonType Type { get {return PokemonType.Fairy;}}
        public override Dictionary<PokemonType, Effectiveness> CreateTypeChart(){
            var singleTypeChart = new Dictionary<PokemonType, Effectiveness>();
            singleTypeChart[PokemonType.None] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Normal] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fire] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Water] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Electric] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Grass] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ice] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Fighting] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Poison] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Ground] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Flying] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Psychic] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Bug] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Rock] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Ghost] = Effectiveness.Normal;
            singleTypeChart[PokemonType.Dragon] = Effectiveness.NoEffect;
            singleTypeChart[PokemonType.Dark] = Effectiveness.NotVeryEffective;
            singleTypeChart[PokemonType.Steel] = Effectiveness.SuperEffective;
            singleTypeChart[PokemonType.Fairy] = Effectiveness.Normal;
            return singleTypeChart;
        }
    }
}