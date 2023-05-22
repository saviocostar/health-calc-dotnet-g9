namespace Health_Calc_Pack.Interfaces
{
    public interface IIMC
    {
        double CalcIMC(double Height, double Weight);
        bool IsValidData(double Height, double Weight);
        string GetIMCCategory(double Imc);
    }
}