using Dapper;
using Dnd.DAL.Factories.Interfaces;
using Dnd.DAL.Models;
using Dnd.DAL.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace Dnd.DAL.Repositories.Implementation;

public class PageRepository : IPageRepository
{
    private readonly IDbConnectionFactory<SqlConnection> _dbConnectionFactory;

    public PageRepository(IDbConnectionFactory<SqlConnection> dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task CreateAsync(PageDto page)
    {
        //TODO: Tags должны быть в отдельной таблице
        var sql =
            "INSERT INTO pages " +
            "(name, type, rare, sourse, text, mainimage, images, tags) " +
            "VALUES(@Name, @Type, @rare, @Sourse, @Text, @MainImage, @Images, @Tags)";

        var connection = _dbConnectionFactory.CreateConnection();
        await connection.ExecuteAsync(sql, page);
    }
}