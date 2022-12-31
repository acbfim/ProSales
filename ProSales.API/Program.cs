using System.Text.Json.Serialization;


var builder = WebApplication.CreateBuilder(args);

//var connetionString = builder.Configuration.GetConnectionString("MariaDBContext");

builder.Services.AddConfigContexts(builder.Configuration.GetSection("ConnectionStrings"));

builder.Services.AddMyDependencyGroup();
builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerConfig();
//builder.Services.AddSwaggerGen();

builder.Services.AddConfigIdentity();

builder.Services.AddAuth();

builder.Services.AddCors(options =>
                {
                    options.AddPolicy("CorsPolicy", builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
                });


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

app.UseCors("CorsPolicy");

app.Run();
