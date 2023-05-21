using Health_Calc_Pack;
using Health_Calc_Pack.Interfaces;

namespace HealthCalcPack.Tests.IMCTests
{
    public class IMCCalcTest
    {
        [Fact]
        public void IMCCategory_Magreza_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 17;
            string expectedResult = "Magreza";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Normal_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 20;
            string expectedResult = "Normal";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Sobrepeso_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 25;
            string expectedResult = "Sobrepeso";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Obesidade_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 35;
            string expectedResult = "Obesidade";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Grave_ValidTest()
        {
            IIMC imc = new IMC();
            double imcValue = 50.2;
            string expectedResult = "Grave";

            string result = imc.GetIMCCategory(imcValue);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategory_Invalid_ValidTest()
        {
            // Arrange
            IIMC imc = new IMC();
            double imcValue = 0;
            string expectedResult = "Invalido";

            // Methods
            string result = imc.GetIMCCategory(imcValue);

            // Test
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void IMCCategoru_ValidValues_InvalidTest()
        {
            IIMC imc = new IMC();
            double imcValue = 20.2;
            string expectedResult = "Grave";

            string result = imc.GetIMCCategory(imcValue);

            Assert.NotEqual(expectedResult, result);
        }
    }
}

