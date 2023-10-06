using System;

namespace ArdalisRating
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dialogue dialogue = new Dialogue();

            dialogue.ardalisInsurance();

            var engine = new RatingEngine();
            engine.Rate();

            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }

        }
    }
}
