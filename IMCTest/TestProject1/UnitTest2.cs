using IMCTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class UnitTest2
    {
        [Fact]
        public void Classifica() 
        {
            //Arrange
            double rNum = 19;
            string result = "Normal.";

            //Act

            var resultado = IMC.Classificacao(rNum);

            //Assert
            Assert.Equal(result, resultado);

        }

        [Theory]
        [InlineData(17, "Baixo Peso.")]
        [InlineData(20, "Baixo Peso.")]
        [InlineData(30, "Obesidade.")]

        public void ClassificaLista(double rNum, string result)
        {

            //Act

            var resultado = IMC.Classificacao(rNum);

            //Assert
            Assert.Equal(result, resultado);

        }
    }
}
