using Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Service.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_Should_Return_correct_response()
        {
            Calculator cl = new Calculator();
            List<TariffResponseDTO> expected = new List<TariffResponseDTO>() 
            { 
                new TariffResponseDTO(){tariffName="Packaged tariff",annualCosts=800},
                new TariffResponseDTO(){tariffName="basic electricity tariff",annualCosts = 830}
            };
            List<TariffResponseDTO> acctual  = cl.calculateForAllApplications(3500);
            Assert.Equal(expected, acctual);
        }
    }
}
