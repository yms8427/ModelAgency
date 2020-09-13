namespace BilgeAdam.OOP.App.Models
{
    public class Size
    {
        public Size(byte breast, byte waist, byte hips)
        {
            Breast = breast;
            Waist = waist;
            Hips = hips;
        }
        public byte Breast { get; set; }
        public byte Waist { get; set; }
        public byte Hips { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Breast, Waist, Hips);
        }
    }
}
