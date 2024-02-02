using FluentMigrator;

namespace Dnd.Migrator.Migrations;

[Migration(1)]
public class PagesTableMS : Migration
{
    public override void Up()
    {
        Execute.Sql(@"
            IF NOT EXISTS (
                SELECT * FROM sys.tables t 
                JOIN sys.schemas s ON (t.schema_id = s.schema_id) 
                WHERE s.name = 'Pages') 	
                CREATE TABLE Pages(
                    Id INT PRIMARY KEY IDENTITY,
                    Name nvarchar(150),
                    Rare tinyint,
                    Sourse nvarchar(200),
                    Text nvarchar(max),
                    MainImage binary,
                    Images binary,
                    Tags nvarchar(100)
                    );");
    }

    public override void Down()
    {
        Execute.Sql("IF EXISTS (" +
                    "DROP TABLE dbo.Pages" +
                    ");");
    }
}