using AuctionProjectV2.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service.Users
{

    public static class SupplierService
    {
        private static Mapping _dbContext;
        private static USER_INFO user = new USER_INFO();

        //public static void AddSupplierToDb(string login, string password, string name,
        //    int isJuradic, string address, string phone, string email, string bin_iin,
        //    string description, string link_website)
        //{
        //    user = UserInfoService.AddUserInfoToDb(login, password, "user");

        //    SUPPLIER SUPPLIER_ = new SUPPLIER()
        //    {
        //        ID = Guid.NewGuid(),
        //        USERID = user.ID,
        //        ISCOMPANY = isJuradic,
        //        FULLNAME = name,
        //        ADDRESS = address,
        //        PHONE_NUMBER = phone,
        //        EMAIL = email,
        //        BIN_IIN = bin_iin,
        //        DESCRIPTION = description,
        //        LINK_WEBSITE = link_website,
        //        BALNCE = 0
        //    };
        //    _dbContext.SUPPLIER.Add(SUPPLIER_);
        //    _dbContext.SaveChanges();
        //}

        public static void AddSupplierToDb(SUPPLIER SUPPLIER_)
        {
            if (SUPPLIER_ != null)
                _dbContext.SUPPLIER.Add(SUPPLIER_);
            _dbContext.SaveChanges();
        }

        public static SUPPLIER FindSupplierById(Guid guid)
        {
            var list = _dbContext.SUPPLIER.ToList();
            return list.Find(x => x.ID == guid);
        }

        public static List<SUPPLIER> FindSupplierByName(string name)
        {
            var list = _dbContext.SUPPLIER.ToList();
            return list.FindAll(x => x.FULLNAME == name);
        }

        public static List<SUPPLIER> ReturnAllSuppliers()
        {
            return _dbContext.SUPPLIER.ToList();
        }

        static SupplierService()
        {
            _dbContext = new Mapping();
        }

    }
}
