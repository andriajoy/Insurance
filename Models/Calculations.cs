using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceDBfirst.Models
{
    public class Calculations
    {
        enum PremiumModes
        {
            Annual = 12,
            Quarterly = 3,
            Monthly = 1
        }

        public double CalculatePremium(int PlanNumber, int SumAssured, int PolicyTerm, string PremiumMode)
        {
            int months = (int)((PremiumModes)Enum.Parse(typeof(PremiumModes), PremiumMode, true));
            double Premium = (SumAssured/(PolicyTerm * 12)) * months;

            if (PlanNumber == 1)
                Premium += 0.03 * Premium;

            return Premium;
        }
    }
}