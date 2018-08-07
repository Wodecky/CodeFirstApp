using CodeFirstApp.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=AppDbConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            modelBuilder.Conventions.Add(new DecimalPropertyConvention(18, 4));
            base.OnModelCreating(modelBuilder);

        }

        #region Model

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<PhoneEntry> PhoneEntries { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<OtherInfo> OtherInfos { get; set; }



        #endregion
    }
}
