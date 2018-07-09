namespace UI.Models
{
    public static class Calculator
    {
        public static DivisionModel Divide(DivisionModel division)
        {
            division.Result = division.Numerator / division.Denominator;
            return division;
        }
    }

    public class DivisionModel
    {
        public double Numerator { get; set; } 
        public double Denominator { get; set;}
        public double Result { get; set; } 
    }
}