using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using ExerciseDate34.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

//add services to the container
builder.Services.AddSingleton<ProductService>();

//Add signalR
builder.Services.AddSignalR();
//Add HttpClient
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();


app.MapHub<ProductHub>("/product-hub");
app.MapHub<ChatHub>("/chat-hub");

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
