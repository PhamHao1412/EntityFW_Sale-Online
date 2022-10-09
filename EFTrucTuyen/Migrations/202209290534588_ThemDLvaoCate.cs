namespace EFTrucTuyen.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDLvaoCate : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories([CategoryName])VALUES(N'Điện thoại')");
            Sql("INSERT INTO Categories([CategoryName])VALUES(N'Máy tính bảng')");
            Sql("INSERT INTO Categories([CategoryName])VALUES(N'Laptop')");
            Sql("INSERT INTO Categories([CategoryName])VALUES(N'Tai nghe')");



        }

        public override void Down()
        {
        }
    }
}
