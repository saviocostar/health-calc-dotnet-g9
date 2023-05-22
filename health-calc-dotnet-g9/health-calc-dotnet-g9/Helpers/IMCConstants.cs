using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Calc_Pack.Helpers
{
    public static class IMCConstants
    {
        public const int ROUND_DIGITS = 2;

        public const double MAGREZA_FAIXA1 = 18.5;
        public const double NORMAL_FAIXA1 = 18.5;
        public const double NORMAL_FAIXA2 = 24.9;
        public const double SOBREPESO_FAIXA1 = 24.9;
        public const double SOBREPESO_FAIXA2 = 29.9;
        public const double OBESIDADE_FAIXA1 = 29.9;
        public const double OBESIDADE_FAIXA2 = 39.9;
        public const double GRAVE_FAIXA1 = 39.9;
        
        public const string MAGREZA = "Magreza";
        public const string NORMAL = "Normal";
        public const string SOBREPESO = "Sobrepeso";
        public const string OBESIDADE = "Obesidade";
        public const string GRAVE = "Grave";
        public const string VALOR_PADRAO = "Invalido";

        public const double HEIGHT_LOWER_LIMIT = 0;
        public const double HEIGHT_HIGH_LIMIT = 3;
        public const double WEIGHT_LOWER_LIMIT = 0;
        public const double WEIGHT_HIGH_LIMIT = 300;
    }
}
