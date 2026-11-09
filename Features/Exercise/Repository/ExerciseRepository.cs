using Dapper;
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

    public async Task<IEnumerable<Exercise>> GetExerciseAsync(CancellationToken cancellationToken)
    {
        await using var connection = await _npgsqlDataSource.OpenConnectionAsync(cancellationToken: cancellationToken);

        var query = GetAllExercisesQuery.List;

        return await connection.QueryAsync<Exercise>(
            new CommandDefinition(query, cancellationToken: cancellationToken)
        );
    }
}