using System;

namespace ArdalisRating
{
    internal class AutoPolicy
    {
        public decimal Rating { get; set; }
        public void RateAutoPolicy(Policy policy)
        {
            Console.WriteLine("Rating AUTO policy...");
            Console.WriteLine("Validating policy.");
            if (String.IsNullOrEmpty(policy.Make))
            {
                Console.WriteLine("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    Rating = 1000m;
                }
                Rating = 900m;
            }
        }
    }
}

