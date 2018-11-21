namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CUSTOMER")]
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            AUCTION = new HashSet<AUCTION>();
            DOCUMENT = new HashSet<DOCUMENT>();
            RATING = new HashSet<RATING>();
        }

        public Guid ID { get; set; }

        public Guid? USERID { get; set; }

        public bool ISCOMPANY { get; set; }

        [Required]
        [StringLength(150)]
        public string FULLNAME { get; set; }

        [Required]
        public string ADDRESS { get; set; }

        [Required]
        [StringLength(15)]
        public string PHONE_NUMBER { get; set; }

        [Required]
        [StringLength(150)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(15)]
        public string BIN_IIN { get; set; }

        [StringLength(150)]
        public string DESCRIPTION { get; set; }

        [StringLength(150)]
        public string LINK_WEBSITE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUCTION> AUCTION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENT> DOCUMENT { get; set; }

        public virtual USER_INFO USER_INFO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATING> RATING { get; set; }
    }
}
