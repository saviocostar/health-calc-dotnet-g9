using Health_Calc_Pack;
using Health_Calc_Pack.Interfaces;
using Health_Calc_Pack.Helpers;

namespace HealthCalcPack.Tests.IMCTests
{
    public class IMCCategoryTest
    {

        [Theory]
        [InlineData(17, IMCConstants.MAGREZA)]
        [InlineData(20, IMCConstants.NORMAL)]
        [InlineData(25, IMCConstants.SOBREPESO)]
        [InlineData(30, IMCConstants.OBESIDADE)]
        [InlineData(40, IMCConstants.GRAVE)]
        [InlineData(-1, IMCConstants.VALOR_PADRAO)]
        public void IMCCategory_Magreza_ValidTest(double imcValue, string imcCategory)
        {
            // Arrange
            IIMC imc = new IMC();

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(imcCategory, result);
        }
    }
}

