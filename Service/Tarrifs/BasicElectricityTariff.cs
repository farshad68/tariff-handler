using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Tarrifs
{
    public class BasicElectricityTariff:Tarrif
    {
        public BasicElectricityTariff():base("basic electricity tariff") { }
        public override void calculationModel(decimal consumption)
        {
            if (consumption < 0) throw new Exception("consumption cannot be negativ value");
            decimal annualCosts = 12 * 5 + 0.22M * consumption;
            setAnnualCost(annualCosts);
        }
    }
}
