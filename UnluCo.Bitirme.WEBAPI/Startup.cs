using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.Bitirme.DataAcces;
using UnluCo.Bitirme.Business;
using UnluCo.Bitirme.Business.Interface;
using UnluCo.Bitirme.Business.Concrete;
using UnluCo.Bitirme.DataAcces.Interface;
using UnluCo.Bitirme.DataAcces.Concrete;
using UnluCo.Bitirme.Business.Rules.Interface;
using UnluCo.Bitirme.Business.Rules.Concrete;
using UnluCo.Bitirme.Business.Unitofwork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace UnluCo.Bitirme.WEBAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            opt.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateAudience = true ,
                ValidateIssuer=true ,
                ValidateLifetime=true,
                ValidateIssuerSigningKey=true,
                ValidIssuer=Configuration["Token:Issuer"],
                ValidAudience=Configuration["Token:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Token:SignKey"])) ,
                ClockSkew=TimeSpan.Zero 
            });
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "UnluCo.Bitirme.WEBAPI", Version = "v1" });
            });
            services.AddDbContext<DbContextOperation>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ConString")));
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<IUsers, UsersRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IRulesForSignUp, RulesForUsers>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICategory, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IOffer, OfferRepository>();
            services.AddScoped<IOfferService, OfferService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IProducts, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddTransient<IEmailSender, EmailSender>(i =>
                new EmailSender(
                    Configuration["EmailSender:Host"],
                    Configuration.GetValue<int>("EmailSender:Port"),
                    Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    Configuration["EmailSender:UserName"],
                    Configuration["EmailSender:Password"]
                ));
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UnluCo.Bitirme.WEBAPI v1"));
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
