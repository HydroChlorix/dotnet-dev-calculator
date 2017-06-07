
using Lib;
using System;
using Xunit;

namespace TestProject
{
    public class UnitTest_Coupon
    {
        private CouponFactory factory = new CouponFactory();

        [Fact]
        public void TEST_GET_NONE_WORK()
        {
            // arrange
            var expect = CouponType.NONE;
            var code = "NONE";

            // assert 
            var actual = factory.GetCouponType(code);

            // act
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void TEST_DIS10_WORK()
        {
            // arrange
            var expect = CouponType.DIS10;
            var code = "DIS10";

            // assert 
            var actual = factory.GetCouponType(code);

            // act
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void TEST_STARCARD_WORK()
        {
            // arrange
            var expect = CouponType.STARCARD;
            var code = "STARCARD";

            // assert 
            var actual = factory.GetCouponType(code);

            // act
            Assert.Equal(expect, actual);
        }
    }
}
