namespace AuctionProjectV2.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USER_INFO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER_INFO()
        {
            CUSTOMER = new HashSet<CUSTOMER>();
            SUPPLIER = new HashSet<SUPPLIER>();
        }

        public Guid ID { get; set; }

        [Required]
        [StringLength(35)]
        public string LOGIN { get; set; }

        [Required]
        [StringLength(35)]
        public string PASSWORD { get; set; }

        public int? ROLEID { get; set; }

        public double AMOUNT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUSTOMER> CUSTOMER { get; set; }

        public virtual ROLE ROLE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPPLIER> SUPPLIER { get; set; }
    }
}
