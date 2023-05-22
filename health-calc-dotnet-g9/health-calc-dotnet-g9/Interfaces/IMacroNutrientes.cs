using Health_Calc_Pack.Entities;
using Health_Calc_Pack.Entities.Enums;

namespace Health_Calc_Pack.Interfaces
{
    public interface IMacroNutrientes
    {
        public MacroNutrientesObj GetMacroNutrientes(double weight, EnumWeightObjective objective);
    }
}
