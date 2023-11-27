using Microsoft.Data.SqlClient;

namespace Dnd.DAL.Factories.Interfaces;

/// <summary>
///     Фабрика подключений к базе данных.
/// </summary>
public interface IDbConnectionFactory<TConnection> : IDisposable
{
    /// <summary>
    ///     Создать подключение к БД.
    /// </summary>
    /// <returns></returns>
    SqlConnection CreateConnection();
}