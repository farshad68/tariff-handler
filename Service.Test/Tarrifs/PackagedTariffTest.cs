using Service.Tarrifs;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Service.Test.Tarrifs
{
    public class PackagedTariffTest
    {
        [Fact]
        public void name_of_calculationModel_is_correct()
        {
            PackagedTariff pt = new PackagedTariff();
            string expected = "Packaged tariff";
            Assert.Equal(expected, pt.tariffName);
        }
        [Fact]
        public void calculationModel_with_negativ_consumption_should_throw_exception()
        {
            PackagedTariff pt = new PackagedTariff();
            Exception ex = Assert.Throws<Exception>(() => pt.calculationModel(-1));
            Assert.Equal("consumption cannot be negativ value", ex.Message);
        }
        [Theory]
        [InlineData(0, 800)]
        [InlineData(3500, 800)]
        [InlineData(4500, 950)]
        [InlineData(6000, 1400)]
        public void calculationModel_with_positive_consumption_should_return_correct_tarrif(decimal consumption, decimal expected)
        {
            PackagedTariff pt = new PackagedTariff();
            pt.calculationModel(consumption);
            Assert.Equal(expected, pt.annualCosts);
        }
    }
}
