using Microsoft.EntityFrameworkCore.Migrations;

namespace DbMigrator.Migrations
{
    public partial class addNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
            @"
                INSERT INTO public.""Product""
                    (""ProductTypeId"", ""Name"", ""Weight"" ,""Price"", ""Description"", ""ImageURL"")
                VALUES 
                    (2, 'ИНДИЙСКИЙ АССАМ ', 70, 4.40, 'Классический индийский чёрный чай из провинции Ассам. Чайные листья подвергаются традиционной технологии обработки, введенной англичанами в середине XIX века. Хорошо сочетается с молоком, сахаром и медом. Согревает и бодрит.', 'src/asserts/products/indAssam.png'),
                    (2, 'МОЛОЧНЫЙ УЛУН', 100, 4.80, 'Состав: чай улун, ароматизатор
Яркий купаж на основе зелёного чая и плодов рожкового дерева, дополненный кусочками манго, ягодами годжи и лепестками роз. В аромате чая фруктовая доминанта приправлена шоколадно-ореховыми оттенками. Прекрасно бодрит и улучшает эмоциональный фон. Рекомендован к употреблению в течение всего дня.', 'src/asserts/products/milcUlun.png'),
                    (2, 'Да Хун Пао', 50, 4.80, 'Состав: чай улун
Императорский сорт утёсного сильноферментированного улуна из провинции 
. Особенностью этого чая является традиционная китайская обработка листьев обжаркой для остановки ферментации. Да Хун Пао прекрасно освежает после тяжелых физических упражнений, пробуждает и тонизирует.', 'src/asserts/products/DaXunPao.png')          
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
