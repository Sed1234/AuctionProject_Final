using AuctionProjectV2.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionProjectV2.Service.Auction
{
    public static class AuctionService
    {
        private static Mapping _dbContext;

        public static AUCTION OpenAuction(string description, int categoty_id, Guid customer_Id, 
            DateTime startDate, DateTime finalDate, double startPrice, double stepAuction, string fob, 
            string delivary_address, string status)
        {
            AUCTION auction = new AUCTION()
            {
                ID = Guid.NewGuid(),
                DESCRIPTION = description,
                CATEGORY_ID = categoty_id,
                CUSTID = customer_Id,
                START_DATE = startDate,
                END_DATE = finalDate,
                START_PRICE = startPrice,
                MIN_PRICE = startPrice,
                STEP_OF_AUCTION = stepAuction,
                FOB = fob,
                DELIVERY_ADDRESS = delivary_address,
                STATUS = status
            };

            _dbContext.AUCTION.Add(auction);
            _dbContext.SaveChanges();

            return auction;
        }

        public static List<AUCTION> GetAllAuctions()
        {
            return _dbContext.AUCTION.ToList();
        }

        public static CATEGORY FindCategoryById(int Id)
        {
            return _dbContext.CATEGORY.ToList().Find(x => x.ID == Id);
        }

        static AuctionService()
        {
            _dbContext = new Mapping();
        }



    }
}
