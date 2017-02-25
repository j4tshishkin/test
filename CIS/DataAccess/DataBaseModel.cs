namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataBaseModel : DbContext
    {
        public DataBaseModel()
            : base("data source=portaldb.cck41gf2uwbl.eu-west-1.rds.amazonaws.com;initial catalog=CIS;user id=admin;password=p6gCVksc;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<TableForTest> TableForTest { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
