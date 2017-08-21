namespace Sample2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GlamModel : DbContext
    {
        public GlamModel()
            : base("name=Model")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<CLIENT> CLIENTs { get; set; }
        public virtual DbSet<CLIENT_ORDER> CLIENT_ORDER { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<EMPLOYEE_TYPE> EMPLOYEE_TYPE { get; set; }
        public virtual DbSet<FITTING> FITTINGs { get; set; }
        public virtual DbSet<GARMENT> GARMENTs { get; set; }
        public virtual DbSet<GARMENT_TYPE> GARMENT_TYPE { get; set; }
        public virtual DbSet<LATE_RETURN> LATE_RETURN { get; set; }
        public virtual DbSet<ORDER_STATUS> ORDER_STATUS { get; set; }
        public virtual DbSet<ORDER_TYPE> ORDER_TYPE { get; set; }
        public virtual DbSet<PRODUCT> PRODUCTs { get; set; }
        public virtual DbSet<PRODUCT_TYPE> PRODUCT_TYPE { get; set; }
        public virtual DbSet<RAW_MATERIAL> RAW_MATERIAL { get; set; }
        public virtual DbSet<RAW_MATERIAL_TYPE> RAW_MATERIAL_TYPE { get; set; }
        public virtual DbSet<RENTAL> RENTALs { get; set; }
        public virtual DbSet<RENTAL_STATUS> RENTAL_STATUS { get; set; }
        public virtual DbSet<SALE> SALEs { get; set; }
        public virtual DbSet<SALE_RETURN> SALE_RETURN { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIERs { get; set; }
        public virtual DbSet<SUPPLIER_ORDER> SUPPLIER_ORDER { get; set; }
        public virtual DbSet<SUPPLIER_ORDER_STATUS> SUPPLIER_ORDER_STATUS { get; set; }
        public virtual DbSet<SUPPLIER_PRODUCT_RETURN> SUPPLIER_PRODUCT_RETURN { get; set; }
        public virtual DbSet<SUPPLIER_RAW_MATERIAL_RETURN> SUPPLIER_RAW_MATERIAL_RETURN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ClientName)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ClientSurname)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT>()
                .Property(e => e.ClientEmail)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.OrderDate)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.ReceiptNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.Paid)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.OrderDescription)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.Colour)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENT_ORDER>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EmployeeName)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EmployeeSurname)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EmployeeAddress)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EmployeeEmail)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.EmployeePassword)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE>()
                .Property(e => e.AccessLevel)
                .IsUnicode(false);

            modelBuilder.Entity<EMPLOYEE_TYPE>()
                .Property(e => e.EmployeeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<FITTING>()
                .Property(e => e.FittingDate)
                .IsUnicode(false);

            modelBuilder.Entity<FITTING>()
                .Property(e => e.FittingDescription)
                .IsUnicode(false);

            modelBuilder.Entity<GARMENT>()
                .Property(e => e.Colour)
                .IsUnicode(false);

            modelBuilder.Entity<GARMENT>()
                .Property(e => e.Material)
                .IsUnicode(false);

            modelBuilder.Entity<GARMENT>()
                .Property(e => e.GarmentDescripion)
                .IsUnicode(false);

            modelBuilder.Entity<GARMENT>()
                .Property(e => e.Price)
                .IsUnicode(false);

            modelBuilder.Entity<GARMENT>()
                .Property(e => e.WriteOff)
                .IsUnicode(false);

            modelBuilder.Entity<GARMENT_TYPE>()
                .Property(e => e.TypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<LATE_RETURN>()
                .Property(e => e.LateReturnDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STATUS>()
                .Property(e => e.OrderStatusDate)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_STATUS>()
                .Property(e => e.OrderStatusDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ORDER_TYPE>()
                .Property(e => e.Descrip)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Colour)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Product_Description)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.Price)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.SellingPrice)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT>()
                .Property(e => e.WriteOff)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCT_TYPE>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RAW_MATERIAL>()
                .Property(e => e.RawDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RAW_MATERIAL>()
                .Property(e => e.CostPrice)
                .IsUnicode(false);

            modelBuilder.Entity<RAW_MATERIAL>()
                .Property(e => e.MarkUp)
                .IsUnicode(false);

            modelBuilder.Entity<RAW_MATERIAL>()
                .Property(e => e.WriteOff)
                .IsUnicode(false);

            modelBuilder.Entity<RAW_MATERIAL_TYPE>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RENTAL_STATUS>()
                .Property(e => e.RentalStatusDescription)
                .IsUnicode(false);

            modelBuilder.Entity<RENTAL_STATUS>()
                .Property(e => e.RentalStatusDate)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.SaleDate)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.Price)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.ReceiptNum)
                .IsUnicode(false);

            modelBuilder.Entity<SALE>()
                .Property(e => e.Item)
                .IsUnicode(false);

            modelBuilder.Entity<SALE_RETURN>()
                .Property(e => e.SaleReturnDate)
                .IsUnicode(false);

            modelBuilder.Entity<SALE_RETURN>()
                .Property(e => e.RefundPrice)
                .IsUnicode(false);

            modelBuilder.Entity<SALE_RETURN>()
                .Property(e => e.ReceiptNr)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SupplierName)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SupplierAddressLine1)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SupplierAddressLine2)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SupplierEmail)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SupplierBank)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER>()
                .Property(e => e.SupplierBranch)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_ORDER>()
                .Property(e => e.SupOrderDate)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_ORDER>()
                .Property(e => e.AmountPayable)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_ORDER_STATUS>()
                .Property(e => e.SupStatusDate)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_ORDER_STATUS>()
                .Property(e => e.SupStatusDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_PRODUCT_RETURN>()
                .Property(e => e.DateSupProductReturn)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_PRODUCT_RETURN>()
                .Property(e => e.AmountRefundable)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_PRODUCT_RETURN>()
                .Property(e => e.DescripSupProductReturn)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_RAW_MATERIAL_RETURN>()
                .Property(e => e.DateSupRMReturn)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_RAW_MATERIAL_RETURN>()
                .Property(e => e.AmountRefundable)
                .IsUnicode(false);

            modelBuilder.Entity<SUPPLIER_RAW_MATERIAL_RETURN>()
                .Property(e => e.DescripSupRMReturn)
                .IsUnicode(false);
        }
    }
}
