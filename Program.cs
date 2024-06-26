
using LolTrack.EFDBContext;
using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<UserService, UserService>();
builder.Services.AddSingleton<ItemService, ItemService>();
builder.Services.AddSingleton<ChampService, ChampService>();
builder.Services.AddSingleton<RuneService, RuneService>();
builder.Services.AddSingleton<SSpellService, SSpellService>();
builder.Services.AddSingleton<PlayerService, PlayerService>();
builder.Services.AddSingleton<MatchService, MatchService>();
builder.Services.AddSingleton<AbilityService, AbilityService>();
builder.Services.AddDbContext<LolDbContext>();
builder.Services.AddTransient<DbService>();
builder.Services.AddTransient < JsonFileService<Ability>>();
builder.Services.AddTransient < JsonFileService<Champion>>();
builder.Services.AddTransient < JsonFileService<Item>>();
builder.Services.AddTransient < JsonFileService<Match>>();
builder.Services.AddTransient < JsonFileService<Player>>();
builder.Services.AddTransient < JsonFileService<Rune>>();
builder.Services.AddTransient < JsonFileService<SSpell>>();
builder.Services.AddTransient < JsonFileService<User>>();


builder.Services.Configure<CookiePolicyOptions>(options => {
    // This lambda determines whether user consent for non-essential cookies is needed for a given request. options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.None;

});



builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions => {
    cookieOptions.LoginPath = "/Login/LogInPage";
    cookieOptions.LogoutPath = "/LogIn/LogOutPage"; 

});
builder.Services.AddMvc().AddRazorPagesOptions(options => {
    options.Conventions.AuthorizeFolder("/Pages"); // her skal der v�re en reference til den rette mappe

}).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

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

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
