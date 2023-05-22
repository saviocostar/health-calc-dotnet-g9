using Health_Calc_Pack;
using Health_Calc_Pack.Interfaces;

namespace Health_Calc_Pack_Test.PackageUnitTest
{
    public class IMCTest
    {
        [Fact]
        public void IMCCalc_ValidValues_ValidTest()
        {         
            IIMC imc = new IMC();
            double height = 1.81;
            double weight = 77;
            double expectedResult = 23.5;

            double result = imc.CalcIMC(height, weight);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCalc_ValidValues_InvalidTest()
        {

            IIMC imc = new IMC();
            double Height = 1.81;
            double Weight = 77;
            double ExpectedResult = 50.2;

            double result = imc.CalcIMC(Height, Weight);

            Assert.NotEqual(ExpectedResult, result);
        }
    }
}