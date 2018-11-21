using AuctionProjectV2.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service
{
    public static class UserInfoService
    {
        private static Mapping _dbContext;

        private static USER_INFO user = new USER_INFO();

        public static USER_INFO AddUserInfoToDb(string login, string password, string role)
        {
            user.ID = Guid.NewGuid();
            user.LOGIN = login;
            user.PASSWORD = password;
            if (role == "user")
            {
                user.ROLEID = RoleService.GetUserRole().ID;
            }
            else if (role == "admin")
            {
                user.ROLEID = RoleService.GetAdminRole().ID;
            }
            user.AMOUNT = 1;

            _dbContext.USER_INFO.Add(user);
            _dbContext.SaveChanges();

            return user;
        }

         public static void AddUserToDb(string login, string password, string role)
        {
            user.ID = Guid.NewGuid();
            user.LOGIN = login;
            user.PASSWORD = password;
            if (role == "user")
            {
                user.ROLEID = RoleService.GetUserRole().ID;
            }
            else if (role == "admin")
            {
                user.ROLEID = RoleService.GetAdminRole().ID;
            }
            user.AMOUNT = 1;

            _dbContext.USER_INFO.Add(user);
            _dbContext.SaveChanges();
        }

        public static USER_INFO FindUserById(Guid guid)
        {
            var list = _dbContext.USER_INFO.ToList();
            return list.Find(x => x.ID == guid);
        }

        public static USER_INFO LogIn(string login, string password)
        {
            return _dbContext.USER_INFO.ToList().Find(x => x.LOGIN == login && x.PASSWORD == password);
        }

        public static List<USER_INFO> ReturnAllUsers()
        {
            return _dbContext.USER_INFO.ToList();
        }

        static UserInfoService()
        {
            _dbContext = new Mapping();
        }
    }
}
