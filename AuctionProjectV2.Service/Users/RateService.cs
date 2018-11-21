using AuctionProjectV2.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service.Users
{
    public static class RateService
    {
        private static Mapping _dbContext;

        public static void MakeRate(Guid SupplierId, Guid CustomerId, double Summ)
        {
            RATE rate = new RATE()
            {
                ID = Guid.NewGuid(),
                SUPPLIER_ID = SupplierId,
                SUMM = Summ                               
            };
        }

        public static RATE FindRateById(Guid guid)
        {
            return _dbContext.RATE.ToList().Find(x => x.ID==guid);
        }

        public static RATE FindRateByCustomerId(Guid guid)
        {
            return _dbContext.RATE.ToList().Find(x => x.SUPPLIER_ID == guid);
        }

        static RateService()
        {
            _dbContext = new Mapping();
        }
    }
}
