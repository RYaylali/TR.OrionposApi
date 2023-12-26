
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using TR.BussinessLayer.Abstract;
using TR.BussinessLayer.IoC;
using TR.BussinessLayer.Manager;
using TR.DataAccessLayer;
using TR.DataAccessLayer.Abstract;
using TR.DataAccessLayer.EntityFramework;
using TR.EntityLayer;

namespace TR.Api
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddCors(opt =>
			{
				opt.AddPolicy("ApiCors", opt =>
				{
					opt.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
				});
			});//CORS, bir web uygulamasının kaynaklarına farklı bir etki alanından erişim izni veren bir web standartıdır. Örneğin, bir web sitesi, JavaScript kodu aracılığıyla bir API'ye AJAX isteği gönderebilir. 
			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			builder.Services.AddDbContext<Context>();

			builder.Services.AddIdentity<AppNetUser, AppNetRole>(opt =>
			{ //identity options lar� verebilece�imiz bir overload yap�s� mevcut. Biz default ayalar� kullanmak istemeyip yap�land�rma yapmak istiyorsak belirtebiliriz. 

				opt.Password.RequireDigit = false;              //�ifremiz say� i�ermesine gerek yok
				opt.Password.RequiredLength = 1;               //gerekli uzunluk 1 e �ektik gibi d�zenlemeler yap�labilir.
				opt.Password.RequireLowercase = false;
				opt.Password.RequireUppercase = false;
				opt.Password.RequireNonAlphanumeric = false;
				opt.SignIn.RequireConfirmedEmail = false;

				//Default olarak false gelir. SignInResult "IsNotAllowed" �zelli�i dir . Mail onaylamas�.
				opt.Lockout.MaxFailedAccessAttempts = 10;       //4 hatal� denemeden sonra hesab� kitle
				opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); //Hesab� 5 dakika boyunca kitle dedik. 
				opt.User.AllowedUserNameCharacters = "abcçdefgğhıijklmnoöpqrsştuüvwxyzABCÇDEFGHIJKLMNOÖPQRSŞTUÜVWXYZ0123456789-._@+";


			}).AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();

			builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

			builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
			{
				builder.RegisterModule(new DependecyResolver());
			});
			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseCors("ApiCors");
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseAuthorization();
			app.UseAuthentication();

			app.MapControllers();

			app.Run();
		}
	}
}
