namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RATING")]
    public partial class RATING
    {
        public Guid ID { get; set; }

        public Guid? SUPPLIER_ID { get; set; }

        public Guid? CUSTOMER_ID { get; set; }

        [Column("Rating")]
        public double Rating1 { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
