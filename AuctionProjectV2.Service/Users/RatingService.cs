using AuctionProjectV2.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service.Users
{
    public static class RatingService
    {
        private static Mapping _dbContext;

        public static void RatingCreation(Guid SupplierId, Guid CustomerId)
        {
            RATING rating = new RATING()
            {
                ID = Guid.NewGuid(),
                SUPPLIER_ID = SupplierId,
                CUSTOMER_ID = CustomerId
            };
        }

        public static List<RATING> GetAllRatings()
        {
            return _dbContext.RATING.ToList();
        }

        static RatingService()
        {
            _dbContext = new Mapping();
        }
    }
}
