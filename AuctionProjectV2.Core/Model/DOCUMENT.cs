namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCUMENT")]
    public partial class DOCUMENT
    {
        [Key]
        [Column(Order = 0)]
        public Guid ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid FKID { get; set; }

        [Key]
        [Column(Order = 2)]
        public string DOC_NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        public string DOC_PATH { get; set; }

        [Key]
        [Column(Order = 4)]
        public string TYPE { get; set; }

        public virtual AUCTION AUCTION { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        public virtual RATE RATE { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
