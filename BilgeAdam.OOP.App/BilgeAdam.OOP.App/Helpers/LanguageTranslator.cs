using BilgeAdam.OOP.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.OOP.App.Helpers
{
    public class LanguageTranslator
    {
        private Dictionary<Language, string> maps;
        public LanguageTranslator()
        {
            maps = new Dictionary<Language, string>
            {
                [Language.English] = "İngilizce",
                [Language.Turkish] = "Türkçe",
                [Language.German] = "Almanca",
                [Language.Russian] = "Rusça",
                [Language.French] = "Fransızca",
                [Language.Spanish] = "İspanyolca",
                [Language.Japanese] = "Japonca"
            };
        }

        public IEnumerable<LanguageMap> GetLanguages()
        {
            foreach (var map in maps)
            {
                yield return new LanguageMap { Key = map.Key, Text = map.Value };
            }
        }

        public class LanguageMap
        {
            public Language Key { get; set; }
            public string Text { get; set; }
        }
    }
}
