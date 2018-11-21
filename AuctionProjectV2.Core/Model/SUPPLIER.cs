namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUPPLIER")]
    public partial class SUPPLIER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPPLIER()
        {
            RATE = new HashSet<RATE>();
            RATING = new HashSet<RATING>();
            DOCUMENT = new HashSet<DOCUMENT>();
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

        public double BALNCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATE> RATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RATING> RATING { get; set; }

        public virtual USER_INFO USER_INFO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENT> DOCUMENT { get; set; }
    }
}
