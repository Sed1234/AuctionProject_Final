namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUCTION")]
    public partial class AUCTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUCTION()
        {
            DOCUMENT = new HashSet<DOCUMENT>();
            RATE = new HashSet<RATE>();
        }

        public Guid ID { get; set; }

        public Guid? CUSTID { get; set; }

        public int? CATEGORY_ID { get; set; }

        [Required]
        public string DESCRIPTION { get; set; }

        [Required]
        public string DELIVERY_ADDRESS { get; set; }

        [Required]
        public string FOB { get; set; }

        public double START_PRICE { get; set; }

        public double STEP_OF_AUCTION { get; set; }

        public double MIN_PRICE { get; set; }

        [Column(TypeName = "date")]
        public DateTime START_DATE { get; set; }

        [Column(TypeName = "date")]
        public DateTime END_DATE { get; set; }

        [Required]
        [StringLength(10)]
        public string STATUS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENT> DOCUMENT { get; set; }

        public virtual CATEGORY CATEGORY { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATE> RATE { get; set; }
    }
}
