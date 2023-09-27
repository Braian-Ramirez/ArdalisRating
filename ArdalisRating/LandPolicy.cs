using System;

namespace ArdalisRating
{
    internal class LandPolicy
    {
        public decimal Rating { get; set; }
        public void RateLandPolicy(Policy policy)
        {
            Console.WriteLine("Rating LAND policy...");
            Console.WriteLine("Validating policy.");
            if (policy.BondAmount == 0 || policy.Valuation == 0)
            {
                Console.WriteLine("Land policy must specify Bond Amount and Valuation.");
                return;
            }
            if (policy.BondAmount < 0.8m * policy.Valuation)
            {
                Console.WriteLine("Insufficient bond amount.");
                return;
            }
            Rating = policy.BondAmount * 0.05m;
        }
    }
}
