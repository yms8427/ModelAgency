namespace BilgeAdam.OOP.App.Models
{
    public class Measure
    {
        public Measure(byte height, float weight)
        {
            Height = height;
            Weight = weight;
        }
        public byte Height { get; set; }
        public float Weight { get; set; }

        public override string ToString()
        {
            return $"{Height}, {Weight}";
        }
    }
}
