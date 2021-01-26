namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMovieDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Hangover', 4, 2009-08-5, 2020-10-10, 4)");

        }

        public override void Down()
        {
        }
    }
}
