using HIMS.Data;

using HIMS.Data.Master;
using HIMS.Model.Transaction;
using HIMS.Model;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using HIMS.Data.Opd;

namespace HIMS.API.Extensions
{
    public static class ServiceExtension
    {
        public static void AddLinuxApacheConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            //configuration for linux apache
            services.Configure<ForwardedHeadersOptions>(options =>
            {
                options.KnownProxies.Add(IPAddress.Parse(configuration.GetValue<string>("AppSettings:IPAddress")));
            });
        }

        public static void AddMyCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    //.AllowCredentials()
                    );
            });
        }

        public static void AddMyConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));
            services.AddSingleton(resolver => resolver.GetRequiredService<IOptions<AppSettings>>().Value);
        }

        public static void AddMyDependancies(this IServiceCollection services, IConfiguration configuration)
        {
            //var conn = configuration.GetValue<string>("AppSettings:ConnectionString");
            //Get Env from EnvVariable
            var conn = configuration.GetValue<string>("AppSettings:CONNECTION_STRING");
            services.AddScoped(sqc => new SqlConnection(conn));
            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<IGenericRepository, GenericRepository>();
           
            services.AddTransient<IGenericComboRepository, GenericComboRepository>();
            services.AddTransient<IComboboxRepository, ComboboxRepository>();
           
            services.AddTransient<I_MenuMaster, R_MenuMaster>();
            services.AddTransient<I_LoginManager, R_LoginManager>();
            services.AddTransient<I_MenuMasterDetails, R_MenuMasterDetails>();
            services.AddTransient<I_MenuMasterDetails_Details, R_MenuMasterDetails_Details>();
                
            services.AddTransient<IGenericComboRepository, GenericComboRepository>();
            services.AddTransient<IComboboxRepository, ComboboxRepository>();
            
           
            services.AddTransient<I_MenuMaster, R_MenuMaster>();
            services.AddTransient<I_MenuMasterDetails, R_MenuMasterDetails>();
            services.AddTransient<I_MenuMasterDetails_Details, R_MenuMasterDetails_Details>();



            services.AddTransient<I_Doctordetils, R_Doctordetils>();
            services.AddTransient<I_Citydetail, R_Citydetail>();
            services.AddTransient<I_MRDetails, R_MRDetails>();
            services.AddTransient<I_ProductDetails, R_ProductDetails>();
            services.AddTransient<I_MonthlytourPlan, R_MonthlytourPlan>();

            // services.AddTransient<>();

        }

        public static void AddMyAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            // configure strongly typed settings objects
            //var appSettingsSection = configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            //var appSettings = appSettingsSection.Get<AppSettings>();
            var secret = configuration.GetValue<string>("AppSettings:SECRET");
            //var secret = Environment.GetEnvironmentVariable("SECRET");
            var key = Encoding.ASCII.GetBytes(secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddAuthorization();
        }

        public static void AddMySwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Airmid Services",
                    Description = "Airmid Services Project"
                });
                c.AddSecurityDefinition("Bearer",
                    new OpenApiSecurityScheme
                    {
                        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                        Name = "Authorization",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.ApiKey,
                        Scheme = "Bearer"
                    });
                c.AddSecurityRequirement(
                    new OpenApiSecurityRequirement {
                        {
                            new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                },
                                Scheme = "oauth2",
                                Name = "Bearer",
                                In = ParameterLocation.Header,
                            },
                            new List<string>()
                        }
                    });
            });
        }

    }
}
