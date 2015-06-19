CREATE TRIGGER tr_removeOldCoupons
ON [dbo].Coupon
AFTER INSERT
AS
BEGIN
  DELETE FROM [dbo].Coupon
     Where ID in (select A.ID
					from coupon A, couponmaker B
					where A.CouponMakerID=B.ID
					AND getdate()-B.endDate=365)
END