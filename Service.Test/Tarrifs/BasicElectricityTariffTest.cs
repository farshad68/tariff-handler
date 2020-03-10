using Service.Tarrifs;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Service.Test.Tarrifs
{
    public class BasicElectricityTariffTest
    {

        [Fact]
        public void name_of_calculationModel_is_correct()
        {
            BasicElectricityTariff bet = new BasicElectricityTariff();
            string expected = "basic electricity tariff";
            Assert.Equal(expected, bet.tariffName);
        }
        [Fact]
        public void calculationModel_with_negativ_consumption_should_throw_exception()
        {
            BasicElectricityTariff bet = new BasicElectricityTariff();
            Exception ex = Assert.Throws<Exception>(() => bet.calculationModel(-1));
            Assert.Equal("consumption cannot be negativ value", ex.Message);
        }
        [Theory]
        [InlineData(0, 60)]
        [InlineData(3500, 830)]
        [InlineData(4500, 1050)]
        [InlineData(6000, 1380)]
        public void calculationModel_with_positive_consumption_should_return_correct_tarrif(decimal consumption,decimal expected)
        {
            BasicElectricityTariff bet = new BasicElectricityTariff();
            bet.calculationModel(consumption);
            Assert.Equal(expected, bet.annualCosts);
        }
    }
}
