using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public interface ICalculatorFactory
    {
        IDiscount GetDiscountCalculator(int customer, int price, CouponType coupon);
    }
    public class DiscountCalculatorFactory : ICalculatorFactory
    {
        public IDiscount GetDiscountCalculator(int customer, int price, CouponType coupon)
        {
            List<DiscountCalculator> result = new List<DiscountCalculator>();

            if (coupon == CouponType.DIS10)
            {
                result.Add(new DiscountCalculator(10));
            }

            if (price >= 2000)
            {
                result.Add(new DiscountCalculator(10));
            }

            if (customer == 2 && coupon == CouponType.STARCARD)
            {
                result.Add(new DiscountCalculator(30));
            }

            if (customer == 4 && coupon == CouponType.STARCARD)
            {
                result.Add(new DiscountCalculator(25));
            }

            if (price >= 2500)
            {
                result.Add(new DiscountCalculator(25));
            }

            return result.OrderByDescending(x => x.GetDiscountPercent).FirstOrDefault();
        }
    }
}
