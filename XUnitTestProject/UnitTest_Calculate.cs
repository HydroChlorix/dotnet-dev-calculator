using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lib;

namespace TestProject
{
    public class UnitTest_Calculate
    {
        private PriceCalculator pc = new PriceCalculator();
        private int _PricePerPerson = 500;
        [Fact]
        public void Test_1_Person()
        {
            //arrange
            var expect = 500;
            var customer = 1;
            //act
            var actual = pc.Calculate(customer , _PricePerPerson);
            //assert
            Assert.Equal(expect, 500);
        }

        [Fact]
        public void Test_6_Person()
        {
            //arrange
            var expect = 3000;
            var customer = 6;
            //act
            var actual = pc.Calculate(customer, _PricePerPerson);
            //assert
            Assert.Equal(expect, actual);
        }
    }
}
