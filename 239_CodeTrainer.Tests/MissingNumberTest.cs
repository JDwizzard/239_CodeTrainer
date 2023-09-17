using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _239_CodeTrainer.Tests
{
    public class FindMissingNumberTest
    {
        [Theory]
        [InlineData("1 2 3 5 6 7 8 9 10", "4")]
        [InlineData("4 2 1", "3")]
        [InlineData("2 4 3 6 1", "5")]
        public void ProcessMethod_Returns_CorrectResult(string input, string expected)
        {
            string[] arr = input.Split(' ');
            string actual = FindMissingNumber.process(arr, arr.Length);
            Assert.Equal(expected, actual);
        }
    }
}
