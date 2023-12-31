﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class Flood
    {

        public decimal Rating { get; set; }

        public void  RateFloodPolicy (Policy policy)
        {

            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Flood policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.ElevationAboveSeaLevelFeet <= 0)
            {
                Console.WriteLine("Flood policy is not available for elevations at or below sea level.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return;
            }
            decimal multiple = 1.0m;
            if (policy.ElevationAboveSeaLevelFeet < 100)
            {
                multiple = 2.0m;
            }
            else if (policy.ElevationAboveSeaLevelFeet < 500)
            {
                multiple = 1.5m;
            }
            else if (policy.ElevationAboveSeaLevelFeet < 1000)
            {
                multiple = 1.1m;
            }
           
            Rating = policy.BondAmount * 0.05m * multiple;
        }
    }
}
