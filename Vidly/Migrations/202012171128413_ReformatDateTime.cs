namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReformatDateTime : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET ReleaseDate = '2009-08-5' WHERE Id = 1");
            Sql("UPDATE Movies SET ReleaseDate = '2008-08-21' WHERE Id = 2");
            Sql("UPDATE Movies SET Name = 'Wall-E' WHERE ID = 2");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Zootopia', 3, '2016-04-3', '2020-10-08', 1)");
            Sql("INSERT INTO Movies (Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES ('Logan', 1, '2017-1-3', '2020-5-08', 2)");
        }

        public override void Down()
        {
        }
    }
}
