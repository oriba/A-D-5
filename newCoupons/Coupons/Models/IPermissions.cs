using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coupons.Models
{
    public interface IPermissions
    {

        bool ListCustomers { get; }

        bool ListOwners { get; }

        bool DeleteAndApproveOrderCoupon { get; }

        //bool EditDeleteBusiness { get; }
        
        bool EditBusiness { get; }

        bool DeleteBusiness { get; }

        bool DetailsBusiness { get; }

        bool CreateBusiness { get; }

        bool CreateCoupon { get; }

        bool EditDeleteCoupon { get; }

        bool EditDeleteCouponMaker { get; }

        bool OrderCouponMaker { get; }

        bool IsCustomer { get; }

        bool IsOwner { get; }

        bool IsAdmin { get; }

        bool IsGuest { get; }

    }

    public class CustomerPermissions : IPermissions
    {
        public static readonly IPermissions Default = new CustomerPermissions();

        private CustomerPermissions()
        {

        }

        public bool ListCustomers
        {
            get { return false; }
        }

        public bool ListOwners
        {
            get { return false; }
        }

        public bool DeleteAndApproveOrderCoupon
        {
            get { return false; }
        }

        public bool EditBusiness
        {
            get { return false; }
        }

        public bool DeleteBusiness
        {
            get { return false; }
        }

        public bool DetailsBusiness
        {
            get { return false; }
        }

        public bool CreateBusiness
        {
            get { return false; }
        }

        public bool CreateCoupon
        {
            get { return false; }
        }

        public bool EditDeleteCoupon
        {
            get { return false; }
        }

        public bool EditDeleteCouponMaker
        {
            get { return false; }
        }

        public bool OrderCouponMaker
        {
            get { return true; }
        }

        public bool IsCustomer
        {
            get { return true; }
        }

        public bool IsOwner
        {
            get { return false; }
        }

        public bool IsAdmin
        {
            get { return false; }
        }

        public bool IsGuest
        {
            get { return false; }
        }
    }


    public class OwnerPermissions : IPermissions
    {
        public static readonly IPermissions Default = new OwnerPermissions();

        private OwnerPermissions()
        {

        }

        public bool ListCustomers
        {
            get { return false; }
        }

        public bool ListOwners
        {
            get { return false; }
        }

        public bool DeleteAndApproveOrderCoupon
        {
            get { return false; }
        }

        public bool EditBusiness
        {
            get { return true; }
        }

        public bool DeleteBusiness
        {
            get { return false; }
        }

        public bool DetailsBusiness
        {
            get { return true; }
        }

        public bool CreateBusiness
        {
            get { return false; }
        }

        public bool CreateCoupon
        {
            get { return true; }
        }

        public bool EditDeleteCoupon
        {
            get { return false; }
        }

        public bool EditDeleteCouponMaker
        {
            get { return false; }
        }

        public bool OrderCouponMaker
        {
            get { return true; }
        }

        public bool IsCustomer
        {
            get { return false; }
        }

        public bool IsOwner
        {
            get { return true; }
        }

        public bool IsAdmin
        {
            get { return false; }
        }

        public bool IsGuest
        {
            get { return false; }
        }
    }

    public class AdminPermissions : IPermissions
    {
        public static readonly IPermissions Default = new AdminPermissions();

        private AdminPermissions()
        {

        }

        public bool ListCustomers
        {
            get { return true; }
        }

        public bool ListOwners
        {
            get { return true; }
        }

        public bool DeleteAndApproveOrderCoupon
        {
            get { return true; }
        }

        public bool EditBusiness
        {
            get { return false; }
        }

        public bool DeleteBusiness
        {
            get { return true; }
        }

        public bool DetailsBusiness
        {
            get { return true; }
        }

        public bool CreateBusiness
        {
            get { return true; }
        }

        public bool CreateCoupon
        {
            get { return true; }
        }

        public bool EditDeleteCoupon
        {
            get { return true; }
        }

        public bool EditDeleteCouponMaker
        {
            get { return true; }
        }

        public bool OrderCouponMaker
        {
            get { return true; }
        }

        public bool IsCustomer
        {
            get { return false; }
        }

        public bool IsOwner
        {
            get { return false; }
        }

        public bool IsAdmin
        {
            get { return true; }
        }

        public bool IsGuest
        {
            get { return false; }
        }
    }

    public class GuestPermissions : IPermissions
    {
        public static readonly IPermissions Default = new GuestPermissions();

        private GuestPermissions()
        {

        }

        public bool ListCustomers
        {
            get { return false; }
        }

        public bool ListOwners
        {
            get { return false; }
        }

        public bool DeleteAndApproveOrderCoupon
        {
            get { return false; }
        }

        public bool EditBusiness
        {
            get { return false; }
        }

        public bool DeleteBusiness
        {
            get { return false; }
        }

        public bool DetailsBusiness
        {
            get { return false; }
        }

        public bool CreateBusiness
        {
            get { return false; }
        }

        public bool CreateCoupon
        {
            get { return false; }
        }

        public bool EditDeleteCoupon
        {
            get { return false; }
        }

        public bool EditDeleteCouponMaker
        {
            get { return false; }
        }

        public bool OrderCouponMaker
        {
            get { return false; }
        }

        public bool IsCustomer
        {
            get { return false; }
        }

        public bool IsOwner
        {
            get { return false; }
        }

        public bool IsAdmin
        {
            get { return false; }
        }

        public bool IsGuest
        {
            get { return true; }
        }
    }

}
