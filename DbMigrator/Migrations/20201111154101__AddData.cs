using Microsoft.EntityFrameworkCore.Migrations;

namespace DbMigrator.Migrations
{
    public partial class _AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"
                INSERT INTO public.""ProductType""
                    (""Id"", ""Name"")
                VALUES 
                    (3, 'MedHerbs')
                  
                  
                ;INSERT INTO public.""Product""
                    (""ProductTypeId"", ""Name"", ""Weight"" ,""Price"", ""Description"")
                VALUES 
                    (1, 'LateMokiyate', 1000, 11, 'Anton deliver that coffe to customer'),
                    (2, 'Narcis', 1000, 56, 'Anton deliver that tea to customer'),
                    (2, 'Nuskat', 1000, 12, 'Anton deliver that tea to customer'),
                    (3, 'Valuga', 1000, 32, 'Anton deliver that tea to customer'),
                    (3, 'Romashka', 1000, 222, 'Anton deliver that tea to customer'),
                    (3, 'Makis', 1000, 32, 'Anton deliver that tea to customer'),
                    (3, 'Levar', 1000, 32, 'Anton deliver that tea to customer'),
                    (3, 'Lucifer', 1000, 222, 'Anton deliver that tea to customer'),
                    (3, 'Pishon', 1000, 999, 'Anton deliver that tea to customer')
            
            
                
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
