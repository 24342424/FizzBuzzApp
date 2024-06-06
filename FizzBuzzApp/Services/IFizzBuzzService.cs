using System.Collections.Generic;

namespace FizzBuzzApp.Services
{
    public interface IFizzBuzzService
    {
        List<string> ProcessFizzBuzz(List<string> inputValues);
    }
}
