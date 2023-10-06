
using System;


namespace ArdalisRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        LifePolicy lifePolicy = new LifePolicy();
        LandPolicy landPolicy = new LandPolicy();
        AutoPolicy autoPolicy = new AutoPolicy();
        Flood floadPolicy = new Flood();
        ConvertToPolicy loadPolicy = new ConvertToPolicy();
        Flood flood = new Flood();  
        Dialogue dialogue = new Dialogue();
        
        public decimal Rating { get; set; }

        public void Rate()
        {
            dialogue.startingRate();
            var policy = loadPolicy.LoadPolicy();

            switch (policy.Type)
            {
                case PolicyType.Auto:
                    autoPolicy.RateAutoPolicy(policy);
                    Rating = autoPolicy.Rating;
                    break;
                case PolicyType.Land:
                    landPolicy.RateLandPolicy(policy);
                    Rating = landPolicy.Rating;
                    break;
                case PolicyType.Life:
                    lifePolicy.RateLifePolicy(policy);
                    Rating = lifePolicy.Rating;
                    break;
                case PolicyType.Flood:
                    flood.RateFloodPolicy(policy);
                    Rating = floadPolicy.Rating;
                    break;

                default:
                    dialogue.unknownPolicy();
                    break;
            }

            dialogue.ratingCompleted();
        }
    }
}
