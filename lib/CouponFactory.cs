using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class CouponFactory : ICouponTypeFactory
    {
        public CouponType GetCouponType(string promoCode)
        {
            CouponType output;

            switch (promoCode.ToUpper())
            {
                case "DIS10":
                    output = CouponType.DIS10;
                    break;
                case "STARCARD":
                    output = CouponType.STARCARD;
                    break;
                default:
                    output = CouponType.NONE;
                    break;
            }

            return output;
        }
    }


}
