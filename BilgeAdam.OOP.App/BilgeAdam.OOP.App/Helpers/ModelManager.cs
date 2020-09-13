using BilgeAdam.OOP.App.Enums;
using BilgeAdam.OOP.App.Models;
using System;
using System.ComponentModel;
using System.IO;

namespace BilgeAdam.OOP.App.Helpers
{
    public class ModelManager
    {
        public ModelManager()
        {
            Models = new BindingList<Model>();
        }
        public BindingList<Model> Models { get; set; }

        public void Initialize()
        {

            var a = File.ReadAllBytes("C:\\özel.txt");
            Models.Add(new Model(91, 61, 91, 173, 62.3F)
            {
                FullName = "Tyra Banks",
                BirthDate = new DateTime(1992, 3, 16),
                Language = Language.French,
                Price = 3600
            });
            Models.Add(new Model
            {
                FullName = "Adriana Lima",
                BirthDate = new DateTime(1993, 2, 27),
                Language = Language.English,
                Price = 4200,
                Size = new Size(89, 60, 89),
                Measure = new Measure(169, 55)
            });
            Models.Add(new Model(92, 60, 89, 174, 59)
            {
                FullName = "Heidi Klum",
                BirthDate = new DateTime(1994, 11, 4),
                Language = Language.German,
                Price = 2300
            });
            Models.Add(new Model(90, 60, 90, 178, 60)
            {
                FullName = "Karolina Kurkova",
                BirthDate = new DateTime(1990, 7, 18),
                Language = Language.Russian,
                Price = 4300,
                Size = new Size(93, 63, 95),
                Measure = new Measure(180, 61)
            });
            Models.Add(new Model(93, 62, 92, 182, 61)
            {
                FullName = "Claudia Schiffer",
                BirthDate = new DateTime(1998, 2, 12),
                Language = Language.German,
                Price = 3200
            });
            Models.Add(new Model(88, 55, 87, 165, 48)
            {
                FullName = "Azra Akın",
                BirthDate = new DateTime(1996, 12, 1),
                Language = Language.Turkish,
                Price = 2800
            });
            Models.Add(new Model(94, 63, 94, 180, 57)
            {
                FullName = "Lily Aldridge",
                BirthDate = new DateTime(1997, 10, 20),
                Language = Language.Spanish,
                Price = 4100
            });
            Models.Add(new Model(92, 60, 91, 179, 61)
            {
                FullName = "Marisa Miller",
                BirthDate = new DateTime(1998, 4, 9),
                Language = Language.English,
                Price = 3600
            });
            Models.Add(new Model(95, 64, 92, 188, 66)
            {
                FullName = "Rina Fukushi",
                BirthDate = new DateTime(1995, 1, 28),
                Language = Language.Japanese,
                Price = 2900
            });
        }
    }
}
