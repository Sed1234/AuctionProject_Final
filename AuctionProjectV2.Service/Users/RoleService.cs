using AuctionProjectV2.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service
{
    public static class RoleService
    {
        public static  Mapping _dbContext;
        private static ROLE roleAdmin = new ROLE();
        private static ROLE roleUser = new ROLE();
        public static void CreationRoles()
        {
            roleAdmin.NAME = "admin";
			roleAdmin.ID = 1;
            roleUser.NAME = "user";
			roleUser.ID = 2;

            _dbContext.ROLE.Add(roleAdmin);
            _dbContext.ROLE.Add(roleUser);


            _dbContext.SaveChanges();
        }

        public static ROLE GetAdminRole()
        {
            return _dbContext.ROLE.ToList().Find(x => x.NAME == "admin");
        }

        public static ROLE GetUserRole()
        {
            return _dbContext.ROLE.ToList().Find(x => x.NAME == "user");
        }

        static RoleService()
        {
            _dbContext = new Mapping();
        }
    }
}
