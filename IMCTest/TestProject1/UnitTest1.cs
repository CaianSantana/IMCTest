using IMCTest;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CalculoIMC()
        {
            //arrange
            double pNum = 87;
            double sNum = 1.86;
            double rNum = 25.15;

            //act

            var resultado = IMC.Divisao(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);

        }
        [Theory]
        [InlineData(90, 1.60, 35.16)]
        [InlineData(55, 1.75, 18)]
        [InlineData(55, 1.75, 17.96)]

        public void CalculoIMCLista(double pNum, double sNum, double rNum)
        {
            //Act
            var resultado = IMC.Divisao(pNum, sNum);

            //Assert
            Assert.Equal(rNum, resultado);

        }
    }
}