using Service.Model;
using Service.Tarrifs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Calculator
    {
        public Calculator()
        {
            
        }
        public List<TariffResponseDTO> calculateForAllApplications(decimal consumption)
        {
            
            BasicElectricityTariff bte = new BasicElectricityTariff();
            bte.calculationModel(consumption);

            PackagedTariff pt = new PackagedTariff();
            pt.calculationModel(consumption);

            List<TariffResponseDTO> response = new List<TariffResponseDTO>()
            {
               new TariffResponseDTO(){annualCosts = bte.annualCosts,tariffName = bte.tariffName},
               new TariffResponseDTO(){annualCosts = pt.annualCosts,tariffName = pt.tariffName},
            };

            response.Sort();
            return response;
        }
    }
}
