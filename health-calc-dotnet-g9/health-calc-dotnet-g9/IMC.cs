using Health_Calc_Pack.Interfaces;

namespace Health_Calc_Pack
{
    public class IMC : IIMC
    {
        public double CalcIMC(double Height, double Weight)
        {
            const int ROUND_DIGITS = 2;

            double imc = Weight / (Height * Height);

            return Math.Round(imc, ROUND_DIGITS);
        }

        public string GetIMCCategory(double Imc)
        {
            const double MAGREZA_FAIXA1 = 18.5;
            const double NORMAL_FAIXA1 = 18.5;
            const double NORMAL_FAIXA2 = 24.9;
            const double SOBREPESO_FAIXA1 = 24.9;
            const double SOBREPESO_FAIXA2 = 29.9;
            const double OBESIDADE_FAIXA1 = 29.9;
            const double OBESIDADE_FAIXA2 = 39.9;
            const double GRAVE_FAIXA1 = 39.9;

            const string MAGREZA = "Magreza";
            const string NORMAL = "Normal";
            const string SOBREPESO = "Sobrepeso";
            const string OBESIDADE = "Obesidade";
            const string GRAVE = "Grave";
            const string VALOR_PADRAO = "Invalido";


            return Imc switch
            {               
                > 0 and < MAGREZA_FAIXA1 => MAGREZA,
                > NORMAL_FAIXA1 and < NORMAL_FAIXA2 => NORMAL,
                > SOBREPESO_FAIXA1 and < SOBREPESO_FAIXA2 => SOBREPESO,
                > OBESIDADE_FAIXA1 and < OBESIDADE_FAIXA2 => OBESIDADE,
                > GRAVE_FAIXA1 => GRAVE,
                _ => VALOR_PADRAO
            };
        }

        public bool IsValidData(double Height, double Weight)
        {
            return Height < 3
                    && Height > 0
                    && Weight < 300
                    && Weight > 0;
        }
    }
}