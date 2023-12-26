using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.EntityLayer;

namespace TR.DataAccessLayer
{
	public class Context : IdentityDbContext<AppNetUser, AppNetRole,int, AppUserClaim,AspNetUserRole,AspNetUserLogin, AppNetRoleClaim, AspNetUserToken>
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{

		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-491CL38\\YAYLALISERVER22;database=TROrionsDB;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			SeedData.Seed(builder);
			base.OnModelCreating(builder);
			
		}
		public DbSet<PhoneBook> PhoneBooks { get; set; }
	}
}
