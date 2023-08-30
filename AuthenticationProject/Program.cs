using AuthenticationProject.common;
using AuthenticationProject.Data;
using AuthenticationProject.Models;
using AuthenticationProject.Repositories;
using AuthenticationProject.Repositories.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAccountRepository, AccountRepository>();
builder.Services.AddTransient<IResidentRepository, ResidentRepository>();
builder.Services.AddTransient<IApartmentRepository, ApartmentRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IPermissionRepository, PermissionRepository>();
builder.Services.AddTransient<IAddressRepository, AddressRepository>();
builder.Services.AddTransient<IBuildingCategoryRepository, BuildingCategoryRepository>();
builder.Services.AddTransient<IUrbanAreaRepository, UrbanAreaRepository>();


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMemoryCache();
builder.Services.AddScoped<CacheHelper>();
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AuthenticationDBContext>().AddDefaultTokenProviders();

//Use HttpContext without controllerBase
builder.Services.AddHttpContextAccessor();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration["JWT:ValidIssuer"],             // Replace with your issuer
                ValidAudience = builder.Configuration["JWT:ValidAudience"],         // Replace with your audience
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
            };
        });

void ConfigurePolicy(AuthorizationOptions options, string policyName)
{
    options.AddPolicy(policyName, policy =>
    {
        policy.AuthenticationSchemes.Add(JwtBearerDefaults.AuthenticationScheme);
        policy.RequireAuthenticatedUser();
        policy.RequireRole(policyName);
    });
}

builder.Services.AddAuthorization(options =>
{

    ConfigurePolicy(options, "Apartment_Create");
    ConfigurePolicy(options, "Apartment_Update");
    ConfigurePolicy(options, "Apartment_Delete");
    ConfigurePolicy(options, "Apartment_DeleteMultiple");
    ConfigurePolicy(options, "Apartment_GetAll");
    ConfigurePolicy(options, "Apartment_GetById");

    ConfigurePolicy(options, "User_Create");
    ConfigurePolicy(options, "User_Update");
    ConfigurePolicy(options, "User_Delete");
    ConfigurePolicy(options, "User_DeleteMultiple");
    ConfigurePolicy(options, "User_GetAll");
    ConfigurePolicy(options, "User_GetById");

    ConfigurePolicy(options, "Resident_Create");
    ConfigurePolicy(options, "Resident_Update");
    ConfigurePolicy(options, "Resident_Delete");
    ConfigurePolicy(options, "Resident_DeleteMultiple");
    ConfigurePolicy(options, "Resident_GetAll");
    ConfigurePolicy(options, "Resident_GetById");

    ConfigurePolicy(options, "Permission_Create");
    ConfigurePolicy(options, "Permission_Update");
    ConfigurePolicy(options, "Permission_Delete");
    ConfigurePolicy(options, "Permission_DeleteMultiple");
    ConfigurePolicy(options, "Permission_GetAll");
    ConfigurePolicy(options, "Permission_GetById");

    ConfigurePolicy(options, "Customer_Create");
    ConfigurePolicy(options, "Customer_Update");
    ConfigurePolicy(options, "Customer_Delete");
    ConfigurePolicy(options, "Customer_DeleteMultiple");
    ConfigurePolicy(options, "Customer_GetAll");
    ConfigurePolicy(options, "Customer_GetById");
});

builder.Services.AddDbContext<AuthenticationDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors(cors => cors.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("MyPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();

app.UseRouting();

app.UseHttpsRedirection();

app.UseStaticFiles();

