namespace Com.Fadong.MCached {
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using Com.Fadong.CommonInterface.Poco;

    public partial class Entities : DbContext {
        public Entities()
            : this(false) { }

        public Entities(bool proxyCreationEnabled)
            : base("name=Entities") {
            this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }

        public Entities(string connectionString)
            : this(connectionString, false) { }

        public Entities(string connectionString, bool proxyCreationEnabled)
            : base(connectionString) {
            this.Configuration.ProxyCreationEnabled = proxyCreationEnabled;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<MenuMaster> MenuMasters { get; set; }
        public DbSet<MkEnum> MkEnums { get; set; }
    }
}
