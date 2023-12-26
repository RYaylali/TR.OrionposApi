using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.EntityLayer;

namespace TR.DataAccessLayer
{

	public static class SeedData
	{

		public static void Seed(this ModelBuilder modelBuilder)
		{
			List<AppNetRole> roles = new List<AppNetRole>() {
				new AppNetRole {Id=1, Name = "User", NormalizedName = "USER"  },
				
			};
			modelBuilder.Entity<AppNetRole>();
			List<AppNetUser> users = new List<AppNetUser>() {
				new AppNetUser {
					Id=1,
					UserName="RamazanY",
					NormalizedUserName="RAMAZANY",
                    Name = "Ramazan",
					Email = "ramazan.yaylali@gmail.com",
					NormalizedEmail="ramazan.yaylalı@gmail.com".ToUpper(),
					SecurityStamp=Guid.NewGuid().ToString()
				},
				new AppNetUser {
					Id=2,
					UserName="AhmetY",
					NormalizedUserName="AHMETY",
					Email = "ahmet.yaylali@gmail.com",
					NormalizedEmail="ahmet.yaylalı@gmail.com".ToUpper(),
					Name = "Ahmet",
					SecurityStamp=Guid.NewGuid().ToString()
				}
			};
			modelBuilder.Entity<AppNetUser>().HasData(users);
			var passwordHasher = new PasswordHasher<AppNetUser>();
			users[0].PasswordHash = passwordHasher.HashPassword(users[0], "1234");
			users[1].PasswordHash = passwordHasher.HashPassword(users[1], "1234");
			List<AspNetUserRole> userRoles = new List<AspNetUserRole>();
			userRoles.Add(new AspNetUserRole
			{
				UserId = users[0].Id,
				RoleId = roles.First(q => q.Name == "User").Id
			});
			userRoles.Add(new AspNetUserRole
			{
				UserId = users[1].Id,
				RoleId = roles.First(q => q.Name == "User").Id
			});
			

		}
	}
}
