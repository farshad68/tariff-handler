using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public abstract class Tarrif
    {
        public string tariffName { get;private set; }
        public decimal annualCosts { get; private set; }
        public void setAnnualCost(decimal _annualCost) {
            annualCosts = _annualCost;
        }
        public Tarrif(string _tariffName)
        {
            tariffName = _tariffName;
        }

        public virtual void calculationModel(decimal Consumption)
        {

        }
    }
}
