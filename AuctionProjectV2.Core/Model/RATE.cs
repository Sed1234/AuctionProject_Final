namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RATE")]
    public partial class RATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RATE()
        {
            DOCUMENT = new HashSet<DOCUMENT>();
        }

        public Guid ID { get; set; }

        public Guid? SUPPLIER_ID { get; set; }

        public Guid? AUCTION_ID { get; set; }

        public double SUMM { get; set; }

        [Required]
        public string DESCRIPTION { get; set; }

        public virtual AUCTION AUCTION { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENT> DOCUMENT { get; set; }
    }
}
