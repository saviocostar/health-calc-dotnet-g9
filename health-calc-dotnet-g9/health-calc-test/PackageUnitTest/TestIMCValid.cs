using Health_Calc_Pack;
using Health_Calc_Pack.Interfaces;

namespace Health_Calc_Pack_Test.PackageUnitTest
{
    public class IMCIsValidTest
    {
        [Theory]
        [InlineData(1.8, 7.6)]
        [InlineData(2, 290)]
        public void IMCIsValid_ValidValues_ValidResult(double height, double weight)
        {
            // Arrange
            IIMC imc = new IMC();

            // Methods
            bool result = imc.IsValidData(height, weight);

            // Test
            Assert.True(result);
        }

        [Theory]
        [InlineData(1.8, 301)]
        [InlineData(1.8, 0)]
        [InlineData(1.8, -1)]
        [InlineData(3.01, 108)]
        [InlineData(0, 108)]
        [InlineData(-1, 108)]
        public void IMCIsValid_InvalidValues_InvalidResult(double height, double weight)
        {
            // Arrange
            IIMC imc = new IMC();

            // Methods
            bool result = imc.IsValidData(height, weight);

            // Test
            Assert.False(result);
        }
    }
}