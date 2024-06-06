using System.Collections.Generic;

namespace FizzBuzzApp.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<string> ProcessFizzBuzz(List<string> inputValues)
        {
            var results = new List<string>();

            foreach (var input in inputValues)
            {
                if (int.TryParse(input, out int number))
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        results.Add("FizzBuzz");
                    }
                    else if (number % 3 == 0)
                    {
                        results.Add("Fizz");
                    }
                    else if (number % 5 == 0)
                    {
                        results.Add("Buzz");
                    }
                    else
                    {
                        results.Add($"Divided {number} by 3");
                        results.Add($"Divided {number} by 5");
                    }
                }
                else
                {
                    results.Add("Invalid item");
                }
            }

            return results;
        }
    }
}
