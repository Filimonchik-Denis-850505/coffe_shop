using Microsoft.EntityFrameworkCore.Migrations;

namespace DbMigrator.Migrations
{
    public partial class add_new_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                INSERT INTO public.""Product""
                    (""ProductTypeId"", ""Name"", ""Weight"" ,""Price"", ""Description"")
                VALUES 
                    (1, 'Late', 1000, 11, 'Anton deliver that coffe to customer'),
                    (2, 'Mokachino', 1000, 56, 'Anton deliver that tea to customer'),
                    (2, 'Fuzze', 1000, 12, 'Anton deliver that tea to customer'),
                    (1, 'Mokachino', 1000, 32, 'Anton deliver that tea to customer'),
                    (1, 'Medovuxa', 1000, 222, 'Anton deliver that tea to customer'),
                    (1, 'Paules', 1000, 32, 'Anton deliver that tea to customer'),
                    (2, 'Merin', 1000, 999, 'Anton deliver that tea to customer')
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
