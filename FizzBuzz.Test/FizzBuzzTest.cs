using FizzBuzz.Kata;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest   
    {
        [Fact]
        public void GivenNumberWhenMultipleOfThreeThenReturnFizz()
        {
            var numberDivisibleByThree = 3;
            var calculator = new Calculator();
            var result = calculator.Divide(numberDivisibleByThree);
            
            Assert.Equal("Fizz",result);
        }

        [Fact]
        public void GivenNumberWhenMultipleOfFiveThenReturnBuzz()
        {
            var numberDivisibleByFive = 5;
            var calculator = new Calculator();
            var result = calculator.Divide(numberDivisibleByFive);
            
            Assert.Equal("Buzz", result);
        }
        
        [Fact]
        public void GivenNumberWhenMultipleOfFiveAndThreeThenReturnFizzBuzz()
        {
            var numberDivisibleByFiveAndThree = 15;
            var calculator = new Calculator();
            var result = calculator.Divide(numberDivisibleByFiveAndThree);
            
            Assert.Equal("FizzBuzz", result);
        }
        
        
    }
}