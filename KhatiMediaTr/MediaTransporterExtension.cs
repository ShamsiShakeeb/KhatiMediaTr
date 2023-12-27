using Microsoft.Extensions.DependencyInjection;

namespace KhatiMediaTr
{
    public static class MediaTransporterExtension
    {
        public static void AddMediaTr(this IServiceCollection services)
        {
            services.AddScoped(typeof(IMediaTr<,>), typeof(MediaTr<,>));
            var type = typeof(IEventHandler);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.Name != typeof(IEventHandler).Name)
                .ToList();

            foreach (var item in types)
            {
                services.AddScoped(item);
            }

        }
    }
}
