using AuctionProjectV2.Core.Model;
using AuctionProjectV2.Service.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service
{
    public static class CustomerService
    {
        private static Mapping _dbContext;
        private static USER_INFO user = new USER_INFO();

        public static CUSTOMER AddCustomerToDb(string login, string password, string name,
            bool isJuradic, string address, string phone, string email, string bin_iin,
            string description, string link_website)
        {
            user = UserInfoService.AddUserInfoToDb(login, password, "user");

            CUSTOMER CUSTOMER_ = new CUSTOMER()
            {
                ID = Guid.NewGuid(),
                USERID = user.ID,
                ISCOMPANY = isJuradic,
                FULLNAME = name,
                ADDRESS = address,
                PHONE_NUMBER = phone,
                EMAIL = email,
                BIN_IIN = bin_iin,
                DESCRIPTION = description,
                LINK_WEBSITE = link_website
            };
            _dbContext.CUSTOMER.Add(CUSTOMER_);

            SUPPLIER SUPPLIER_ = new SUPPLIER()
            {
                ID = Guid.NewGuid(),
                USERID = user.ID,
                ISCOMPANY = isJuradic,
                FULLNAME = name,
                ADDRESS = address,
                PHONE_NUMBER = phone,
                EMAIL = email,
                BIN_IIN = bin_iin,
                DESCRIPTION = description,
                LINK_WEBSITE = link_website
            };
            SupplierService.AddSupplierToDb(SUPPLIER_);

            _dbContext.SaveChanges();

            return CUSTOMER_;
        }

        public static CUSTOMER AddCustomerToDb(string login, string password, string name,
            bool isJuradic, string address, string phone, string email, string bin_iin)
        {
            user = UserInfoService.AddUserInfoToDb(login, password, "user");
            CUSTOMER CUSTOMER_ = new CUSTOMER()
            {
                ID = Guid.NewGuid(),
                USERID = user.ID,
                ISCOMPANY = isJuradic,
                FULLNAME = name,
                ADDRESS = address,
                PHONE_NUMBER = phone,
                EMAIL = email,
                BIN_IIN = bin_iin
            };
            _dbContext.CUSTOMER.Add(CUSTOMER_);
            _dbContext.SaveChanges();
            return CUSTOMER_;
        }



        public static CUSTOMER FindCustomerById(Guid guid)
        {
            var list = _dbContext.CUSTOMER.ToList();
            return list.Find(x => x.ID == guid);
        }

        public static CUSTOMER FindCustomerByUserInfoId(Guid guid)
        {
            var list = _dbContext.CUSTOMER.ToList();
            return list.Find(x => x.USERID == guid);
        }

        public static List<CUSTOMER> FindCustomerByName(string name)
        {
            var list = _dbContext.CUSTOMER.ToList();
            return list.FindAll(x => x.FULLNAME == name);
        }

        public static List<CUSTOMER> ReturnAllCustomers()
        {
            return _dbContext.CUSTOMER.ToList();
        }

        static CustomerService()
        {
            _dbContext = new Mapping();
        }

    }
}
