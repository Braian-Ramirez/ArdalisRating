using System;


namespace ArdalisRating
{
    internal class LifePolicy
    {
        public decimal Rating { get; set; }

        public void RateLifePolicy(Policy policy)
        {
            Console.WriteLine("Rating LIFE policy...");
            Console.WriteLine("Validating policy.");
            if (policy.DateOfBirth == DateTime.MinValue)
            {
                Console.WriteLine("Life policy must include Date of Birth.");
                return;
            }
            if (policy.DateOfBirth < DateTime.Today.AddYears(-100))
            {
                Console.WriteLine("Centenarians are not eligible for coverage.");
                return;
            }
            if (policy.Amount == 0)
            {
                Console.WriteLine("Life policy must include an Amount.");
                return;
            }
            int age = DateTime.Today.Year - policy.DateOfBirth.Year;
            if (policy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < policy.DateOfBirth.Day ||
                DateTime.Today.Month < policy.DateOfBirth.Month)
            {
                age--;
            }
            decimal baseRate = policy.Amount * age / 200;
            if (policy.IsSmoker)
            {
                Rating = baseRate * 2;
                
            }
            Rating = baseRate;
        }
    }
}