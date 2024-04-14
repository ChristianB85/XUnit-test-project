using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using MyApp;

namespace MyAppTestUnit
{
    public class CalculatorTestUnit
    {

        [Theory]
        [InlineData(2,2,4)]

        public void CalculatorTest(int x, int y, int expectedValue)
        {
            //Arrange
            Calculator Calc = new Calculator();

            //Act
            int result = Calc.Add(x, y);

            //Assert
            Assert.Equal(expectedValue, Calc.result);
        }
    }
}
