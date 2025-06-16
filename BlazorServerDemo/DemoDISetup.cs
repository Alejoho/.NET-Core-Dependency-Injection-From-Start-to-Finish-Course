using BlazorServerDemo.Data;

namespace BlazorServerDemo
{
    public static class DemoDISetup
    {
        public static IServiceCollection AddDemoInfo(this IServiceCollection services)
        {
            services.AddTransient<IDemo, Demo>();
            services.AddTransient<IUtcDemo, UtcDemo>();
            services.AddTransient<ILocalDemo, Demo>();
            services.AddTransient<ProcessDemo>();

            return services;
        }
    }
}
