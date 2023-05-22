using Health_Calc_Pack;
using Health_Calc_Pack.Interfaces;

namespace Health_Calc_Pack_Test.PackageUnitTest
{
    public class IMCIsValidTest
    {
        [Fact]
        public void IMCIsValid_ValidValues_ValidResult()
        {

            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = 76;

            bool result = imc.IsValidData(heigth, weight);

            Assert.True(result);
        }

        [Fact]
        public void IMCIsValid_InvalidWeight1_InvalidResult()
        {

            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = 301;

            bool result = imc.IsValidData(heigth, weight);

            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidWeight2_InvalidResult()
        {

            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = 0;

            bool result = imc.IsValidData(heigth, weight);

            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidWeight3_InvalidResult()
        {

            IIMC imc = new IMC();
            double heigth = 1.8;
            double weight = -1;

            bool result = imc.IsValidData(heigth, weight);

            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidHeight1_InvalidResult()
        {

            IIMC imc = new IMC();
            double heigth = 3.01;
            double weight = 108;
            bool result = imc.IsValidData(heigth, weight);

            Assert.False(result);
        }

        [Fact]
        public void IMCIsValid_InvalidHeight2_InvalidResult()
        {
            IIMC imc = new IMC();
            double heigth = 0;
            double weight = 108;

            bool result = imc.IsValidData(heigth, weight);
        }
    }
}