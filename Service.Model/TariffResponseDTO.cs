using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Service.Model
{
    public class TariffResponseDTO: IEquatable<TariffResponseDTO>, IComparable<TariffResponseDTO>
    {
        public string tariffName { get; set; }
        public decimal annualCosts { get; set; }
        public int CompareTo(TariffResponseDTO comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.annualCosts.CompareTo(comparePart.annualCosts);
        }


        public bool Equals([AllowNull] TariffResponseDTO other)
        {
            if (other == null && this ==null) return true;
            if (other == null && this != null) return false;
            return this.tariffName.Equals(other.tariffName) && this.annualCosts == other.annualCosts;
        }
    }
}
