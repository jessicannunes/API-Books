using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books_APIweb.Migrations
{
    /// <inheritdoc />
    public partial class InsertBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Books(Isbn,Title,PublishingCompany,Price) " +
                "Values('9786555606454','Elon Musk','Intrinsica','79.90')");

            mb.Sql("Insert into Books(Isbn,Title,PublishingCompany,Price) " +
             "Values('9786555646139','Nada Pode Me Ferir','Sextante','59.90')");

            mb.Sql("Insert into Books(Isbn,Title,PublishingCompany,Price) " +
             "Values('9788542221541','Tiago Brunet','Academia','83.90')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from books");
        }
    }
}
