using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TedarikYonetim.Model;

namespace TedarikYonetim.Dal
{
    public partial class TedarikYonetimContext : DbContext
    {
        public TedarikYonetimContext()
        {

        }

        public TedarikYonetimContext(DbContextOptions<TedarikYonetimContext> options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-3FJGH6E\murat;Initial Catalog=tedarikyonetim;Integrated Security=False;user id=sa;password=sa123");

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
