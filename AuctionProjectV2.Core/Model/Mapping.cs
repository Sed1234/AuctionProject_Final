namespace AuctionProjectV2.Core.Model
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class Mapping : DbContext
	{
		public Mapping()
			: base("name=Mapping")
		{
		}

		public virtual DbSet<AUCTION> AUCTION { get; set; }
		public virtual DbSet<CATEGORY> CATEGORY { get; set; }
		public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
		public virtual DbSet<RATE> RATE { get; set; }
		public virtual DbSet<RATING> RATING { get; set; }
		public virtual DbSet<ROLE> ROLE { get; set; }
		public virtual DbSet<SUPPLIER> SUPPLIER { get; set; }
		public virtual DbSet<USER_INFO> USER_INFO { get; set; }
		public virtual DbSet<DOCUMENT> DOCUMENT { get; set; }
		public virtual DbSet<Rating_Counting> Rating_Counting { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AUCTION>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<AUCTION>()
				.Property(e => e.DELIVERY_ADDRESS)
				.IsUnicode(false);

			modelBuilder.Entity<AUCTION>()
				.Property(e => e.FOB)
				.IsUnicode(false);

			modelBuilder.Entity<AUCTION>()
				.Property(e => e.STATUS)
				.IsUnicode(false);

			modelBuilder.Entity<AUCTION>()
				.HasMany(e => e.DOCUMENT)
				.WithRequired(e => e.AUCTION)
				.HasForeignKey(e => e.FKID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<AUCTION>()
				.HasMany(e => e.RATE)
				.WithOptional(e => e.AUCTION)
				.HasForeignKey(e => e.AUCTION_ID);

			modelBuilder.Entity<CATEGORY>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<CATEGORY>()
				.HasMany(e => e.AUCTION)
				.WithOptional(e => e.CATEGORY)
				.HasForeignKey(e => e.CATEGORY_ID);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.FULLNAME)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.ADDRESS)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.PHONE_NUMBER)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.EMAIL)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.BIN_IIN)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.Property(e => e.LINK_WEBSITE)
				.IsUnicode(false);

			modelBuilder.Entity<CUSTOMER>()
				.HasMany(e => e.AUCTION)
				.WithOptional(e => e.CUSTOMER)
				.HasForeignKey(e => e.CUSTID);

			modelBuilder.Entity<CUSTOMER>()
				.HasMany(e => e.DOCUMENT)
				.WithRequired(e => e.CUSTOMER)
				.HasForeignKey(e => e.FKID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<CUSTOMER>()
				.HasMany(e => e.RATING)
				.WithOptional(e => e.CUSTOMER)
				.HasForeignKey(e => e.CUSTOMER_ID);

			modelBuilder.Entity<RATE>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<RATE>()
				.HasMany(e => e.DOCUMENT)
				.WithRequired(e => e.RATE)
				.HasForeignKey(e => e.FKID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<ROLE>()
				.Property(e => e.NAME)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.FULLNAME)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.ADDRESS)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.PHONE_NUMBER)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.EMAIL)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.BIN_IIN)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.DESCRIPTION)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.Property(e => e.LINK_WEBSITE)
				.IsUnicode(false);

			modelBuilder.Entity<SUPPLIER>()
				.HasMany(e => e.RATE)
				.WithOptional(e => e.SUPPLIER)
				.HasForeignKey(e => e.SUPPLIER_ID);

			modelBuilder.Entity<SUPPLIER>()
				.HasMany(e => e.RATING)
				.WithOptional(e => e.SUPPLIER)
				.HasForeignKey(e => e.SUPPLIER_ID);

			modelBuilder.Entity<SUPPLIER>()
				.HasMany(e => e.DOCUMENT)
				.WithRequired(e => e.SUPPLIER)
				.HasForeignKey(e => e.FKID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<USER_INFO>()
				.Property(e => e.LOGIN)
				.IsUnicode(false);

			modelBuilder.Entity<USER_INFO>()
				.Property(e => e.PASSWORD)
				.IsUnicode(false);

			modelBuilder.Entity<USER_INFO>()
				.HasMany(e => e.CUSTOMER)
				.WithOptional(e => e.USER_INFO)
				.HasForeignKey(e => e.USERID);

			modelBuilder.Entity<USER_INFO>()
				.HasMany(e => e.SUPPLIER)
				.WithOptional(e => e.USER_INFO)
				.HasForeignKey(e => e.USERID);

			modelBuilder.Entity<DOCUMENT>()
				.Property(e => e.DOC_NAME)
				.IsUnicode(false);

			modelBuilder.Entity<DOCUMENT>()
				.Property(e => e.DOC_PATH)
				.IsUnicode(false);

			modelBuilder.Entity<DOCUMENT>()
				.Property(e => e.TYPE)
				.IsUnicode(false);

			modelBuilder.Entity<Rating_Counting>()
				.Property(e => e.FULLNAME)
				.IsUnicode(false);
		}
	}
}
