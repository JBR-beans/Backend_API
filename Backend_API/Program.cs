
using Backend_API.Models;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Backend_API.Data;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Backend_API.Areas.Identity.Data;

namespace Backend_API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddDbContext<Backend_APIContext>(options =>
			    options.UseSqlServer(builder.Configuration.GetConnectionString("Backend_APIContext") ?? throw new InvalidOperationException("Connection string 'Backend_APIContext' not found.")));

   builder.Services.AddDefaultIdentity<SiteUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<Backend_APIContext>();

			// Add services to the container.

			builder.Services.AddControllers().AddJsonOptions(options =>
			{
				options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
				options.JsonSerializerOptions.WriteIndented = true;
			});

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();
			app.MapRazorPages();

			Content test = new Content
			{
				ContentId = 1,
				Title = "Test Title",
				Body = "Test Body",
				CreatedAt = DateTime.Now,
				UpdatedAt = DateTime.Now,
				Author = "dev"
			};

			app.Run();
		}
	}
}
