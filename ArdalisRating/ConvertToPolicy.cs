using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.IO;


namespace ArdalisRating
{
    internal class ConvertToPolicy
    {
        public Policy LoadPolicy()
        {
            Console.WriteLine("Loading policy.");
            string policyJson = File.ReadAllText("policy.json");
            return JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());
        }
    }
}
