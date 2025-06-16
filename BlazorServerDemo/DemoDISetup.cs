using BlazorServerDemo.Data;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services)
        {
            //services.AddScoped<IDemo, UtcDemo>();
            services.AddTransient<IDemo, Demo>();
            //services.AddScoped<IUtcDemo, UtcDemo>();
            //services.AddScoped<ILocalDemo, Demo>();
            services.AddTransient<ProcessDemo>();

            return services;
        }
    }
}
