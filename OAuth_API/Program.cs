using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{   // Enables the Annotations of the Swashbuckle.AspNetCore.Annotations NuGet
    c.EnableAnnotations();
    // You can create different Swagger Documents and make Controllers to appear in certain documents. You can change between them on the up-right dropdown.
    c.SwaggerDoc("main", new OpenApiInfo { Title = "OAuth 2.0 REST API", Version = "v1", Description = "REST API securized with OAuth 2.0 and JWT Tokens + Customization options"});
    c.SwaggerDoc("other", new OpenApiInfo { Title = "Other", Version = "v1", Description = "Other's description"});

    // Token authentication window
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Put the session Bearer Token.",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });

    // Authentication type
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
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

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters // Token validator options
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "This",
        ValidAudience = "Client",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Put13245!.Here12345!.Your12345!.Key12345!")) // Key (must be above 256 bits)
    };
});

builder.Services.AddAuthorization(options => // Authorization rules
{
    options.AddPolicy("Admin", policy => // Administrator rule, the endpoints with '[Authorize("Admin")]' will require an admin account
    {
        policy.RequireAuthenticatedUser();
        policy.RequireClaim("Admin", "admin");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {   // Aditional options
        options.DefaultModelsExpandDepth(-1); // Removes the model list at the end of the page
        // Add the documents to the dropdown
        options.SwaggerEndpoint("/swagger/main/swagger.json", "Main");
        options.SwaggerEndpoint("/swagger/other/swagger.json", "Other");
        options.DocumentTitle = "OAuth 2.0 REST API"; // Browser Tab Name
        options.EnableFilter(); // Creates an Text box to filter Controllers
        options.DisplayRequestDuration(); // Shows the runtime ms on every Endpoint
        // Deafault state of the Endpoints (Expanded or Hiden)
        //options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.Full); 
        //options.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
        // Header Custom content
        options.HeadContent = "<link rel=\"icon\" type=\"image/png\" href=\"/Img/favicon.png\">" // Favicon (wwwroot/Img/...)
                            + "<span class=\"header\">&emsp;Generated with Swashbuckle's Swagger UI</span>"; // Custom Header Text
        options.InjectStylesheet("/Style/style.css"); // Custom CSS (wwwroot/Style/...)
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
