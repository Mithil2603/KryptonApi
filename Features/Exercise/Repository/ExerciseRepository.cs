using Dapper;
using KryptonApi.Features.Exercise.Entities;
using KryptonApi.Features.Exercise.List;
using KryptonApi.Features.Exercise.Queries;
using KryptonApi.Features.Exercise.Repository.Interface;
using Npgsql;

namespace KryptonApi.Features.Exercise.Repository;

public class ExerciseRepository : IExerciseRepository
{
    private readonly NpgsqlDataSource _npgsqlDataSource;

    public ExerciseRepository(NpgsqlDataSource npgsqlDataSource)
    {
        _npgsqlDataSource = npgsqlDataSource;
    }

    public async Task<IEnumerable<Exercises>> GetExerciseAsync(ListExerciseRequest request, CancellationToken cancellationToken)
    {
        await using var connection = await _npgsqlDataSource.OpenConnectionAsync(cancellationToken: cancellationToken);

        var query = GetAllExercisesQuery.List;
        var parameters = new DynamicParameters();
        var conditions = new List<string>();

        if (request.Name is not null)
        {
            conditions.Add("name = @Name");
            parameters.Add("Name", request.Name);
        }

        if (request.Category is not null)
        {
            conditions.Add("category = @Category");
            parameters.Add("Category", request.Category?.ToString());
        }

        if (request.MuscleGroup is not null)
        {
            conditions.Add("muscle_group = @MuscleGroup");
            parameters.Add("MuscleGroup", request.MuscleGroup?.ToString());
        }

        if (request.Equipment is not null)
        {
            conditions.Add("equipment = @Equipment");
            parameters.Add("Equipment", request.Equipment?.ToString());
        }

        if (request.IsActive is not null)
        {
            conditions.Add("is_active = @IsActive");
            parameters.Add("IsActive", request.IsActive?.ToString());
        }

        if (conditions.Count > 0)
        {
            query += " WHERE " + string.Join(" AND ", conditions);
        }

        return await connection.QueryAsync<Exercises>(
            new CommandDefinition(query, parameters, cancellationToken: cancellationToken)
        );
    }
}