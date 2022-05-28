//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.AspNetCore.Authorization;
//using System.Security.Claims;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;


//namespace DecahexBackend
//{
//    public class Startup
//    {

//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }

//        public void ConfigureServices(IServiceCollection services)
//        {

           
//            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//            //    .AddJwtBearer(options =>
//            //    {
//            //        options.Authority = domain;
//            //        options.Audience = Configuration["Auth0:Audience"];
//            //        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
//            //        {
//            //            NameClaimType = ClaimTypes.NameIdentifier
//            //        };
//            //    });



//            //services.AddAuthorization(options =>
//            //{
//            //    options.AddPolicy("read:messages", policy => policy.Requirements.Add(new ScopeRequirement("read:messages", domain)));
//            //});

//            services.AddSingleton<IAuthorizationHandler, ScopeHandler>();

//        }

//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//            }


//            app.UseCors(x => x
//                .AllowAnyMethod()
//                .AllowAnyOrigin()
//                .SetIsOriginAllowed(origin => true)
//                .AllowCredentials()
//            );

//            app.UseHttpsRedirection();

//            app.UseRouting();

//           // app.UseAuthentication();

//           // app.UseAuthorization();


//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });

//        }

//    }
//}
