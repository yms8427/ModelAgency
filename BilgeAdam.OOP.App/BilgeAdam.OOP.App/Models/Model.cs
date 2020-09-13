using BilgeAdam.OOP.App.Enums;
using System;
namespace BilgeAdam.OOP.App.Models
{
    public class Model
    {
        public Model()
        {

        }

        public Model(string fullName, DateTime birthDate)
        {
            FullName = fullName;
            BirthDate = birthDate;
        }
        public Model(byte breast, byte waist, byte hips, byte height, float weight)
        {
            Size = new Size(breast, waist, hips);
            Measure = new Measure(height, weight);
        }
        public string FullName { get; set; }
        public Language Language { get; set; }
        public Size Size { get; set; }
        public Measure Measure { get; set; }
        public double Price { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
