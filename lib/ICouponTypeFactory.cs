namespace Lib
{
    interface ICouponTypeFactory
    {
        CouponType GetCouponType(string promoCode);
    }

    public enum CouponType
    {
        NONE,
        DIS10,
        STARCARD
    }

}
