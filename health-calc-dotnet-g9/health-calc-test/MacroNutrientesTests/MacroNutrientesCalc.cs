using System.Security.AccessControl;

using Health_Calc_Pack.Entities;
using Health_Calc_Pack.Entities.Enums;
using Health_Calc_Pack.Implementations;
using Health_Calc_Pack.Interfaces;

namespace Health_Calc_Pack_Test.MacroNutrientesTests
{
    public class MacroNutrientesCalc
    {
        public class TestResults
        {
            public static IEnumerable<object[]> ValidResultData = new List<object[]>()
            {
                new object[]
                {
                    20,
                    EnumWeightObjective.Gain,
                    new MacroNutrientesObj
                    {
                        Proteins = 40,
                        Carbohydrates = 80,
                        Fats = 20
                    }
                },
                new object[]
                {
                    20,
                    EnumWeightObjective.Maintain,
                    new MacroNutrientesObj
                    {
                        Proteins = 80,
                        Carbohydrates = 80,
                        Fats = 40
                    }
                },
                new object[]
                {
                    20,
                    EnumWeightObjective.Lose,
                    new MacroNutrientesObj
                    {
                        Proteins = 80,
                        Carbohydrates = 60,
                        Fats = 60
                    }
                },
            };
            public static IEnumerable<object[]> InvalidResultData = new List<object[]>()
            {
                new object[]
                {
                    25,
                    EnumWeightObjective.Gain,
                    new MacroNutrientesObj
                    {
                        Proteins = 44,
                        Carbohydrates = 66,
                        Fats = 14
                    }
                },
                new object[]
                {
                    25,
                    EnumWeightObjective.Maintain,
                    new MacroNutrientesObj
                    {
                        Proteins = 44,
                        Carbohydrates = 44,
                        Fats = 14
                    }
                },
                new object[]
                {
                    22,
                    EnumWeightObjective.Lose,
                    new MacroNutrientesObj
                    {
                        Proteins = 44,
                        Carbohydrates = 22,
                        Fats = 14
                    }
                },
            };
        }

        [Theory]
        [MemberData(nameof(TestResults.ValidResultData), MemberType = typeof(TestResults))]
        public void MacroNutrientesCalc_ValidValues_ValidTest(double weight, EnumWeightObjective objective, MacroNutrientesObj expectedResult)
        {
            // Arrange
            IMacroNutrientes macroNutrientes = new MacroNutrientes();

            // Methods
            var result = macroNutrientes.GetMacroNutrientes(weight, objective);

            // Test
            Assert.Equivalent(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(TestResults.InvalidResultData), MemberType = typeof(TestResults))]
        public void MacroNutrientesCalc_InvalidValues_InvalidTest(double weight, EnumWeightObjective objective, MacroNutrientesObj expectedResult)
        {
            // Arrange
            IMacroNutrientes macroNutrientes = new MacroNutrientes();

            // Methods
            var result = macroNutrientes.GetMacroNutrientes(weight, objective);

            // Test
            Assert.NotEqual(expectedResult, result);
        }

        [Fact]
        public void MacroNutrientesCalc_InvalidValues_Exception()
        {
            // Arrange
            IMacroNutrientes macroNutrientes = new MacroNutrientes();
            double weight = 150;
            EnumWeightObjective objective = (EnumWeightObjective) 5;

            // Test
            Assert.Throws<NotImplementedException>(() => macroNutrientes.GetMacroNutrientes(weight, objective));
        }
    }
}
