namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rating_Counting
    {
        [Key]
        [StringLength(150)]
        public string FULLNAME { get; set; }

        public int? CountOfThings { get; set; }

        public double? AvgRatng { get; set; }
    }
}
