namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (4, 'Romance')");
            Sql("INSERT INTO MovieGenres (Id, Name) VALUES (5, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
