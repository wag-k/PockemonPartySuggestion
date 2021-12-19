using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPartySuggestion.Pokemon
{
    /// <summary>
    /// ポケモン図鑑
    /// Keyはポケモンの名前
    /// Valueはポケモンのステータス
    /// </summary>
    public class PokemonDict : Dictionary<String, PokemonStatus>
    {
        /// <summary>
        /// 図鑑の読み込み
        /// Loadに失敗したらnullを返す
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static PokemonDict Load(String filePath){
            var pokemonDict = new PokemonDict();
            var typeDict = PokemonTypeDict.GetInstance();
            try{
                using(var fs = new FileStream(filePath, FileMode.Open))
                using(var sr = new StreamReader(fs))
                {
                    sr.ReadLine(); // ヘッダは捨てる。なんだか変な気がするので今後リファクタリングしたい。
                    while(sr.Peek() >= 0){
                        var line = sr.ReadLine();
                        // CSV形式を想定
                        var parameters = line.Split(',');
                        // 種族値が数値で入っているかチェック
                        if(!Int32.TryParse(parameters[7], out var hp)){continue;}
                        if(!Int32.TryParse(parameters[8], out var atk)){continue;}
                        if(!Int32.TryParse(parameters[9], out var def)){continue;}
                        if(!Int32.TryParse(parameters[10], out var spAtk)){continue;}
                        if(!Int32.TryParse(parameters[11], out var spDef)){continue;}
                        if(!Int32.TryParse(parameters[12], out var speed)){continue;}
                        if(!Int32.TryParse(parameters[13], out var sum)){continue;}
                        var baseStatus = new BaseStatus(){
                            HP = hp,
                            Atk = atk,
                            Def = def,
                            SpAtk = spAtk,
                            SpDef = spDef,
                            Speed = speed,
                            Sum = sum,
                        };
                        var pokemonStatus = new PokemonStatus(){
                            No = parameters[0],
                            Name = parameters[1],
                            Types = new PokemonType[]{typeDict[parameters[2]],typeDict[parameters[3]]},
                            Abilities = new String[]{parameters[4], parameters[5], parameters[6]},
                            Status = baseStatus,
                        };
                        // 図鑑にポケモンを追加
                        pokemonDict.Add(pokemonStatus.Name, pokemonStatus);
                    }
                }
            }catch(Exception e){
                Debug.WriteLine($"PokemonDic.LoadError:{e.Message}");
                return null;
            }
            return pokemonDict;
        }
    }
}
