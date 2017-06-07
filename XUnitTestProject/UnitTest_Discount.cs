using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Lib;

namespace TestProject
{
    public class UnitTest_Discount
    {
        DiscountCalculatorFactory dcf = new DiscountCalculatorFactory();
        private readonly int pricePerPerson = 500;
        //private readonly int PERCENT_10 = 10;
        //private readonly int PERCENT_25 = 25;
        //private readonly int PERCENT_30 = 30;
        [Fact]
        public void TEST_10_PERCENT_DIS10()
        {
            //arrange 
            var customer = 1;
            var price = 500;
            var coupon = CouponType.DIS10;//<-----

            var expect = 10;

            //act
            var actual = dcf.GetDiscountCalculator(customer, price, coupon);

            //assert
            Assert.Equal(expect, actual.GetDiscountPercent);
        }

        [Fact]
        public void TEST_10_PERCENT_PRICE_EQUAL_MORE_2000()
        {
            //arrange 
            var customer = 4;
            var price = 2000;//<----- focus
            var coupon = CouponType.NONE;

            var expect = 10;

            //act
            var actual = dcf.GetDiscountCalculator(customer, price, coupon);

            //assert
            Assert.Equal(expect, actual.GetDiscountPercent);
        }

        [Fact]
        public void TEST_30_PERCENT_2_CUSTOMER_AND_STARCARD()
        {
            //arrange 
            var customer = 2;
            var price = customer * pricePerPerson;
            var coupon = CouponType.STARCARD;//<----- focus

            var expect = 30;

            //act
            var actual = dcf.GetDiscountCalculator(customer, price, coupon);

            //assert
            Assert.Equal(expect, actual.GetDiscountPercent);
        }

        [Fact]
        public void TEST_25_PERCENT_4_CUSTOMER_PAY3()
        {
            //arrange 
            var customer = 4;//<----- focus
            var price = customer * pricePerPerson;
            var coupon = CouponType.STARCARD;

            var expect = 25;

            //act
            var actual = dcf.GetDiscountCalculator(customer, price, coupon);

            //assert
            Assert.Equal(expect, actual.GetDiscountPercent);
        }

        [Fact]
        public void TEST_25_PERCENT_PRICE_MORE_EQUAL_2500()
        {
            //arrange 
            var customer = 5;
            var price = customer * pricePerPerson;//<----- focus
            var coupon = CouponType.NONE;

            var expect = 25;

            //act
            var actual = dcf.GetDiscountCalculator(customer, price, coupon);

            //assert
            Assert.Equal(expect, actual.GetDiscountPercent);
        }

    }
}
