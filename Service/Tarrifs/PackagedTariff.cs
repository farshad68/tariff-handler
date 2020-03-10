using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Tarrifs
{
    public class PackagedTariff:Tarrif
    {
        public PackagedTariff() : base("Packaged tariff") { }
        public override void calculationModel(decimal consumption)
        {
            if (consumption < 0) throw new Exception("consumption cannot be negativ value");
            //consumption <= 4000
            decimal annualCosts = 800M ;
            if (consumption > 4000)
            {
                annualCosts += (consumption - 4000) * 0.3M;
            }                        
            setAnnualCost(annualCosts);
        }
    }
}
