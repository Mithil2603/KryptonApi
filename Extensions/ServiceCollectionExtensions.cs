using KryptonApi.Features.Exercise.GetById;
using KryptonApi.Features.Exercise.List;
using KryptonApi.Features.Exercise.Repository;
using KryptonApi.Features.Exercise.Repository.Interface;

namespace KryptonApi.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddExerciseFeature(this IServiceCollection services)
    {
        services.AddScoped<IExerciseRepository, ExerciseRepository>();
        services.AddScoped<ListExerciseHandler>();
        services.AddScoped<GetExerciseByIdHandler>();
        return services;
    }
}