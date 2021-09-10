using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InsertSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Царица наук", "Математика" },
                    { 2, "Основа всего", "Физика" },
                    { 3, "В здоровом теле - здоровый дух", "Физкультура" },
                    { 4, "У того, кто не знает прошлого - нет будущего", "История" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CourseId", "Name" },
                values: new object[,]
                {
                    { 17, 3, "ГА-223" },
                    { 18, 3, "ПВ-232" },
                    { 19, 1, "СП-344" },
                    { 20, 1, "ОР-421" },
                    { 21, 1, "РФ-231" },
                    { 23, 2, "РР-214" },
                    { 16, 3, "РА-344" },
                    { 24, 2, "ФП-341" },
                    { 25, 4, "ПЦ-344" },
                    { 26, 4, "ТО-324" },
                    { 28, 4, "РА-364" },
                    { 22, 2, "ШО-521" },
                    { 15, 1, "МВ-354" },
                    { 27, 4, "НР-433" },
                    { 13, 3, "ВП-322" },
                    { 14, 3, "УЦ-311" },
                    { 2, 2, "ЛП-102" },
                    { 3, 3, "РР-103" },
                    { 4, 2, "РС-104" },
                    { 5, 1, "РА-105" },
                    { 6, 3, "РА-202" },
                    { 1, 1, "КБ-101" },
                    { 8, 4, "РА-204" },
                    { 9, 1, "НК-205" },
                    { 10, 3, "БК-301" },
                    { 11, 4, "РА-353" },
                    { 12, 1, "РА-333" },
                    { 7, 4, "АР-203" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 328, new DateTime(1989, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Артём", 21, "Кузьмин" },
                    { 329, new DateTime(1990, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Варвара", 21, "Николаева" },
                    { 330, new DateTime(1998, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Виктория", 21, "Казакова" },
                    { 331, new DateTime(1992, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Александр", 21, "Васильев" },
                    { 332, new DateTime(1996, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Софья", 21, "Трофимова" },
                    { 334, new DateTime(1990, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Платон", 21, "Третьяков" },
                    { 335, new DateTime(1985, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Ника", 22, "Ильинская" },
                    { 336, new DateTime(1989, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Эмилия", 22, "Кононова" },
                    { 337, new DateTime(1987, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Михаил", 22, "Иванов" },
                    { 327, new DateTime(1997, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Григорий", 21, "Николаев" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 338, new DateTime(2001, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Ксения", 22, "Богданова" },
                    { 333, new DateTime(1996, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "София", 21, "Рожкова" },
                    { 326, new DateTime(1990, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Диана", 21, "Королева" },
                    { 319, new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Оливия", 20, "Маркина" },
                    { 324, new DateTime(1987, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Мелисса", 21, "Ермакова" },
                    { 323, new DateTime(1996, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Алексей", 21, "Смирнов" },
                    { 322, new DateTime(1996, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Юлия", 21, "Михеева" },
                    { 321, new DateTime(1999, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Александр", 21, "Яковлев" },
                    { 320, new DateTime(1988, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Антон", 21, "Овчинников" },
                    { 318, new DateTime(1999, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Александр", 20, "Гусев" },
                    { 317, new DateTime(2000, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Максим", 20, "Кузнецов" },
                    { 316, new DateTime(1991, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Юлия", 20, "Новикова" },
                    { 315, new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Виктория", 20, "Митрофанова" },
                    { 314, new DateTime(1989, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Лев", 20, "Васильев" },
                    { 313, new DateTime(1995, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Анастасия", 20, "Коновалова" },
                    { 312, new DateTime(1993, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Вероника", 20, "Орехова" },
                    { 339, new DateTime(1989, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Екатерина", 22, "Давыдова" },
                    { 325, new DateTime(1997, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Тигран", 21, "Ермаков" },
                    { 340, new DateTime(1998, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Ольга", 22, "Герасимова" },
                    { 356, new DateTime(1989, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Леон", 22, "Белоусов" },
                    { 342, new DateTime(1992, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Дарья", 22, "Горячева" },
                    { 369, new DateTime(1995, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Софья", 23, "Смирнова" },
                    { 368, new DateTime(1988, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Дмитрий", 23, "Горбачев" },
                    { 367, new DateTime(1985, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Всеволод", 23, "Тихонов" },
                    { 366, new DateTime(2001, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Яна", 23, "Семина" },
                    { 365, new DateTime(1996, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Василиса", 23, "Смирнова" },
                    { 364, new DateTime(1996, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Софья", 23, "Панова" },
                    { 363, new DateTime(1986, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Виктория", 23, "Козлова" },
                    { 362, new DateTime(1990, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "София", 23, "Зимина" },
                    { 361, new DateTime(1995, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Мирослава", 23, "Захарова" },
                    { 360, new DateTime(1988, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Александр", 23, "Афанасьев" },
                    { 359, new DateTime(1988, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Марк", 23, "Никитин" },
                    { 358, new DateTime(1988, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Никита", 22, "Иванов" },
                    { 357, new DateTime(1988, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Виктория", 22, "Ершова" },
                    { 311, new DateTime(1993, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Дмитрий", 20, "Лобанов" },
                    { 355, new DateTime(1988, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Алия", 22, "Сомова" },
                    { 354, new DateTime(1988, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Олеся", 22, "Гаврилова" },
                    { 353, new DateTime(2001, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Ольга", 22, "Трофимова" },
                    { 352, new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Дмитрий", 22, "Гусев" },
                    { 351, new DateTime(1995, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Ева", 22, "Щербакова" },
                    { 350, new DateTime(1992, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Екатерина", 22, "Ефимова" },
                    { 349, new DateTime(1985, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Елизавета", 22, "Емельянова" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 348, new DateTime(1994, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Эмин", 22, "Зимин" },
                    { 347, new DateTime(1996, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Фёдор", 22, "Романов" },
                    { 346, new DateTime(1999, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Милана", 22, "Голубева" },
                    { 345, new DateTime(1993, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Роман", 22, "Корнев" },
                    { 344, new DateTime(1994, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Даниил", 22, "Колесов" },
                    { 343, new DateTime(2000, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Мирон", 22, "Архипов" },
                    { 341, new DateTime(2001, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Даниэль", 22, "Козловский" },
                    { 310, new DateTime(2001, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Василий", 20, "Алексеев" },
                    { 294, new DateTime(2000, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Арина", 18, "Ежова" },
                    { 308, new DateTime(2001, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Алексей", 20, "Данилов" },
                    { 276, new DateTime(1985, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Александра", 17, "Сергеева" },
                    { 275, new DateTime(1999, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Иван", 17, "Виноградов" },
                    { 274, new DateTime(1986, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Полина", 17, "Яковлева" },
                    { 273, new DateTime(1986, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Полина", 17, "Елизарова" },
                    { 272, new DateTime(1987, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Никита", 17, "Григорьев" },
                    { 271, new DateTime(1985, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Степан", 17, "Зайцев" },
                    { 270, new DateTime(1990, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Мария", 17, "Максимова" },
                    { 269, new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Светлана", 17, "Астафьева" },
                    { 268, new DateTime(2001, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Савелий", 17, "Некрасов" },
                    { 267, new DateTime(1999, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Мария", 16, "Кириллова" },
                    { 266, new DateTime(1994, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Дарья", 16, "Иванова" },
                    { 265, new DateTime(1999, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Матвей", 16, "Коновалов" },
                    { 264, new DateTime(1995, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Мия", 16, "Исаева" },
                    { 263, new DateTime(1985, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Матвей", 16, "Сахаров" },
                    { 262, new DateTime(1991, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Виктория", 16, "Смирнова" },
                    { 261, new DateTime(1998, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Алёна", 16, "Горячева" },
                    { 260, new DateTime(1993, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "София", 16, "Зубова" },
                    { 259, new DateTime(1992, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Милана", 16, "Макарова" },
                    { 258, new DateTime(1989, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Милослава", 16, "Грачева" },
                    { 257, new DateTime(1987, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Артём", 16, "Постников" },
                    { 256, new DateTime(1993, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Яна", 16, "Беляева" },
                    { 255, new DateTime(2001, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Никита", 16, "Соловьев" },
                    { 254, new DateTime(1995, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Лев", 16, "Волков" },
                    { 253, new DateTime(1993, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Артур", 16, "Лобанов" },
                    { 252, new DateTime(1988, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Дмитрий", 16, "Елисеев" },
                    { 251, new DateTime(1985, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Демид", 16, "Жуков" },
                    { 250, new DateTime(1986, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Валерия", 16, "Вавилова" },
                    { 277, new DateTime(1989, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Алёна", 17, "Боброва" },
                    { 309, new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Егор", 20, "Назаров" },
                    { 278, new DateTime(1998, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Софья", 17, "Зимина" },
                    { 280, new DateTime(2001, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Матвей", 17, "Пугачев" },
                    { 307, new DateTime(1993, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Амира", 20, "Малинина" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 306, new DateTime(1990, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Артём", 20, "Власов" },
                    { 305, new DateTime(1987, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Татьяна", 20, "Голикова" },
                    { 304, new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Никита", 19, "Павловский" },
                    { 303, new DateTime(1986, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Тимофей", 19, "Терехов" },
                    { 302, new DateTime(1989, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Георгий", 19, "Крюков" },
                    { 301, new DateTime(1990, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Тимофей", 19, "Данилов" },
                    { 300, new DateTime(1998, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Иван", 19, "Сидоров" },
                    { 299, new DateTime(1994, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Екатерина", 19, "Васильева" },
                    { 298, new DateTime(1989, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Мария", 19, "Осипова" },
                    { 297, new DateTime(1988, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Милана", 18, "Степанова" },
                    { 296, new DateTime(1985, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Анастасия", 18, "Дементьева" },
                    { 295, new DateTime(1985, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Фёдор", 18, "Морозов" },
                    { 370, new DateTime(1998, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Полина", 24, "Чеботарева" },
                    { 293, new DateTime(1994, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Ульяна", 18, "Данилова" },
                    { 292, new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Вера", 18, "Устинова" },
                    { 291, new DateTime(1998, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Ульяна", 18, "Соколова" },
                    { 290, new DateTime(1992, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Александр", 18, "Кузин" },
                    { 289, new DateTime(2000, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Артём", 18, "Борисов" },
                    { 288, new DateTime(1985, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Макар", 18, "Логинов" },
                    { 287, new DateTime(1996, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Ульяна", 18, "Смирнова" },
                    { 286, new DateTime(1995, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Александр", 18, "Панкратов" },
                    { 285, new DateTime(1989, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Арсений", 18, "Алексеев" },
                    { 284, new DateTime(1996, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Стефания", 18, "Кузнецова" },
                    { 283, new DateTime(1986, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Марк", 18, "Журавлев" },
                    { 282, new DateTime(1993, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Евгения", 18, "Назарова" },
                    { 281, new DateTime(1991, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Гордей", 18, "Морозов" },
                    { 279, new DateTime(1998, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Денис", 17, "Попов" },
                    { 371, new DateTime(2001, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Анастасия", 24, "Григорьева" },
                    { 387, new DateTime(1990, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Ева", 24, "Кольцова" },
                    { 373, new DateTime(1988, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Максим", 24, "Суслов" },
                    { 463, new DateTime(1985, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Милана", 27, "Высоцкая" },
                    { 462, new DateTime(1992, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Артур", 27, "Щеглов" },
                    { 461, new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Георгий", 27, "Титов" },
                    { 460, new DateTime(1985, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Варвара", 27, "Русанова" },
                    { 459, new DateTime(1994, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Марк", 27, "Сергеев" },
                    { 458, new DateTime(1986, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Матвей", 27, "Комаров" },
                    { 457, new DateTime(1998, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Алиса", 27, "Смирнова" },
                    { 456, new DateTime(1994, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Максим", 27, "Григорьев" },
                    { 455, new DateTime(1999, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Нина", 27, "Евдокимова" },
                    { 454, new DateTime(1997, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Дарья", 27, "Свиридова" },
                    { 453, new DateTime(1998, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Виктория", 27, "Короткова" },
                    { 452, new DateTime(1992, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Валерия", 27, "Шишкина" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 451, new DateTime(1989, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Алиса", 27, "Никулина" },
                    { 450, new DateTime(1991, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Руслан", 27, "Ананьев" },
                    { 449, new DateTime(1985, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Кира", 27, "Лаврова" },
                    { 448, new DateTime(1991, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Георгий", 27, "Афанасьев" },
                    { 447, new DateTime(1989, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Виктория", 27, "Рудакова" },
                    { 446, new DateTime(1989, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Василиса", 27, "Соколова" },
                    { 445, new DateTime(1986, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Екатерина", 27, "Егорова" },
                    { 444, new DateTime(1998, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Тимофей", 27, "Смирнов" },
                    { 443, new DateTime(1990, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Александр", 27, "Михайлов" },
                    { 442, new DateTime(2000, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Михаил", 26, "Чернов" },
                    { 441, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Фёдор", 26, "Ермолов" },
                    { 440, new DateTime(1986, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Олег", 26, "Лобанов" },
                    { 439, new DateTime(1999, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Александра", 26, "Сидорова" },
                    { 438, new DateTime(1991, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Василиса", 26, "Сергеева" },
                    { 437, new DateTime(1999, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Дмитрий", 26, "Яшин" },
                    { 464, new DateTime(1992, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Таисия", 27, "Полякова" },
                    { 436, new DateTime(1987, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Вероника", 26, "Беспалова" },
                    { 465, new DateTime(1999, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Егор", 27, "Беляев" },
                    { 467, new DateTime(1997, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Ярослав", 27, "Миронов" },
                    { 494, new DateTime(1989, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Давид", 28, "Егоров" },
                    { 493, new DateTime(1989, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Марина", 28, "Боброва" },
                    { 492, new DateTime(1988, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Агния", 28, "Смирнова" },
                    { 491, new DateTime(1995, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Матвей", 28, "Носов" },
                    { 490, new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Кристина", 28, "Евдокимова" },
                    { 489, new DateTime(1994, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Анна", 28, "Акимова" },
                    { 488, new DateTime(1993, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Кира", 28, "Гусева" },
                    { 487, new DateTime(2001, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Дарья", 28, "Калинина" },
                    { 486, new DateTime(1991, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Василий", 28, "Смирнов" },
                    { 485, new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Леонид", 28, "Орлов" },
                    { 484, new DateTime(1994, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Кирилл", 28, "Артамонов" },
                    { 483, new DateTime(1994, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Милана", 28, "Михайлова" },
                    { 482, new DateTime(1987, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Егор", 28, "Петров" },
                    { 481, new DateTime(1998, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Мария", 28, "Виноградова" },
                    { 480, new DateTime(1990, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Михаил", 28, "Попов" },
                    { 479, new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Сергей", 28, "Гуляев" },
                    { 478, new DateTime(1996, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Дмитрий", 28, "Князев" },
                    { 477, new DateTime(1999, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Михаил", 28, "Кузнецов" },
                    { 476, new DateTime(1991, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Софья", 28, "Артамонова" },
                    { 475, new DateTime(1999, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Анастасия", 28, "Беляева" },
                    { 474, new DateTime(2001, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Елизавета", 28, "Кузнецова" },
                    { 473, new DateTime(1990, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Дарья", 28, "Тимофеева" },
                    { 472, new DateTime(1995, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Диана", 28, "Завьялова" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 471, new DateTime(1998, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Андрей", 28, "Матвеев" },
                    { 470, new DateTime(1997, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Амина", 28, "Семенова" },
                    { 469, new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Алла", 27, "Захарова" },
                    { 468, new DateTime(1989, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "София", 27, "Головина" },
                    { 466, new DateTime(1997, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Алиса", 27, "Константинова" },
                    { 435, new DateTime(1997, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Мия", 26, "Винокурова" },
                    { 434, new DateTime(1992, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Василиса", 26, "Михайлова" },
                    { 433, new DateTime(1995, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Сара", 26, "Чеботарева" },
                    { 400, new DateTime(1997, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Яна", 25, "Ершова" },
                    { 399, new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Милана", 25, "Игнатова" },
                    { 398, new DateTime(1990, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Дмитрий", 25, "Быков" },
                    { 397, new DateTime(1998, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Тимофей", 24, "Николаев" },
                    { 396, new DateTime(1994, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Алиса", 24, "Гончарова" },
                    { 395, new DateTime(1989, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Елизавета", 24, "Золотова" },
                    { 394, new DateTime(1986, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Всеволод", 24, "Орлов" },
                    { 393, new DateTime(1994, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Вероника", 24, "Григорьева" },
                    { 392, new DateTime(1986, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Камила", 24, "Трифонова" },
                    { 391, new DateTime(1990, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Кирилл", 24, "Соколов" },
                    { 390, new DateTime(1993, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Елизавета", 24, "Иванова" },
                    { 389, new DateTime(2000, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Милана", 24, "Новикова" },
                    { 388, new DateTime(1997, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Алиса", 24, "Терентьева" },
                    { 249, new DateTime(1987, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Павел", 16, "Голубев" },
                    { 386, new DateTime(1985, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Богдан", 24, "Ситников" },
                    { 385, new DateTime(2001, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Игорь", 24, "Лапшин" },
                    { 384, new DateTime(2001, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Павел", 24, "Васильев" },
                    { 383, new DateTime(1993, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Ярослав", 24, "Черепанов" },
                    { 382, new DateTime(1986, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Дмитрий", 24, "Кошелев" },
                    { 381, new DateTime(1994, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Артём", 24, "Михайлов" },
                    { 380, new DateTime(1999, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Василиса", 24, "Шарова" },
                    { 379, new DateTime(1987, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Никита", 24, "Молчанов" },
                    { 378, new DateTime(1986, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Алиса", 24, "Никитина" },
                    { 377, new DateTime(1994, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Анна", 24, "Иванова" },
                    { 376, new DateTime(1988, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Фёдор", 24, "Иванов" },
                    { 375, new DateTime(1985, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Дмитрий", 24, "Герасимов" },
                    { 374, new DateTime(2001, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Екатерина", 24, "Беляева" },
                    { 401, new DateTime(1986, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Вероника", 25, "Соколова" },
                    { 402, new DateTime(1996, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Агния", 25, "Попова" },
                    { 403, new DateTime(1985, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Алексей", 25, "Кулешов" },
                    { 404, new DateTime(1998, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Лука", 25, "Фролов" },
                    { 432, new DateTime(1985, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Дарья", 26, "Березина" },
                    { 431, new DateTime(1996, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Савелий", 26, "Воронин" },
                    { 430, new DateTime(1992, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Александр", 26, "Наумов" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 429, new DateTime(1988, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Алиса", 26, "Давыдова" },
                    { 428, new DateTime(2001, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Михаил", 26, "Денисов" },
                    { 427, new DateTime(1986, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Александра", 26, "Кольцова" },
                    { 426, new DateTime(1997, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Андрей", 26, "Егоров" },
                    { 425, new DateTime(1993, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Леон", 26, "Воронин" },
                    { 424, new DateTime(1993, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Максим", 26, "Жуков" },
                    { 423, new DateTime(1999, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Всеволод", 26, "Виноградов" },
                    { 422, new DateTime(1986, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Эмма", 26, "Шевцова" },
                    { 421, new DateTime(1989, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Амина", 26, "Овчинникова" },
                    { 420, new DateTime(1996, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Эвелина", 26, "Белоусова" },
                    { 372, new DateTime(1996, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Иван", 24, "Мартынов" },
                    { 419, new DateTime(1992, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Екатерина", 25, "Беляева" },
                    { 417, new DateTime(1994, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Анна", 25, "Кондратова" },
                    { 416, new DateTime(1999, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Ясмина", 25, "Потапова" },
                    { 415, new DateTime(1988, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Андрей", 25, "Никифоров" },
                    { 414, new DateTime(2000, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Тимофей", 25, "Родин" },
                    { 413, new DateTime(1986, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Анна", 25, "Латышева" },
                    { 412, new DateTime(1999, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Злата", 25, "Попова" },
                    { 411, new DateTime(1996, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Савелий", 25, "Орлов" },
                    { 410, new DateTime(1987, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Денис", 25, "Васильев" },
                    { 409, new DateTime(1988, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Кристина", 25, "Павлова" },
                    { 408, new DateTime(1994, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "София", 25, "Лазарева" },
                    { 407, new DateTime(1991, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Данил", 25, "Сергеев" },
                    { 406, new DateTime(1990, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Василиса", 25, "Иванова" },
                    { 405, new DateTime(1988, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Евгения", 25, "Медведева" },
                    { 418, new DateTime(1986, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Артур", 25, "Майоров" },
                    { 248, new DateTime(1993, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Елизавета", 16, "Ермакова" },
                    { 232, new DateTime(1995, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Артём", 15, "Алексеев" },
                    { 246, new DateTime(1990, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Варвара", 15, "Романова" },
                    { 89, new DateTime(2001, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Елизавета", 5, "Романова" },
                    { 88, new DateTime(1995, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Лев", 5, "Иванов" },
                    { 87, new DateTime(1999, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Виктория", 5, "Яшина" },
                    { 86, new DateTime(2001, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Георгий", 5, "Большаков" },
                    { 85, new DateTime(1997, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Лев", 5, "Калинин" },
                    { 84, new DateTime(1988, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Никита", 5, "Тарасов" },
                    { 83, new DateTime(1991, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Евдокия", 4, "Прохорова" },
                    { 82, new DateTime(1985, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Арина", 4, "Чернышева" },
                    { 81, new DateTime(1991, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Константин", 4, "Волков" },
                    { 80, new DateTime(1989, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Диана", 4, "Колесникова" },
                    { 79, new DateTime(1996, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Давид", 4, "Голованов" },
                    { 78, new DateTime(2001, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Макар", 4, "Корнеев" },
                    { 77, new DateTime(1987, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Анастасия", 4, "Капустина" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 76, new DateTime(1989, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Ульяна", 4, "Давыдова" },
                    { 75, new DateTime(1990, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Ангелина", 4, "Кондрашова" },
                    { 74, new DateTime(1994, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Ксения", 4, "Попова" },
                    { 73, new DateTime(2001, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Алиса", 4, "Логинова" },
                    { 72, new DateTime(1990, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Мирон", 4, "Казаков" },
                    { 71, new DateTime(1991, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Полина", 4, "Ковалева" },
                    { 70, new DateTime(1997, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Сергей", 4, "Лукьянов" },
                    { 69, new DateTime(1989, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Елисей", 4, "Аксенов" },
                    { 68, new DateTime(1988, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Олег", 4, "Смирнов" },
                    { 67, new DateTime(1991, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Ян", 4, "Герасимов" },
                    { 66, new DateTime(1990, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Алиса", 4, "Корнилова" },
                    { 65, new DateTime(1985, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Елизавета", 3, "Смирнова" },
                    { 64, new DateTime(1988, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Максим", 3, "Дубов" },
                    { 63, new DateTime(1988, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Максим", 3, "Егоров" },
                    { 90, new DateTime(1997, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Виктория", 5, "Медведева" },
                    { 62, new DateTime(1990, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Елизавета", 3, "Малышева" },
                    { 91, new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Анастасия", 5, "Иванова" },
                    { 93, new DateTime(1987, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Мирослава", 6, "Высоцкая" },
                    { 120, new DateTime(1995, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Артём", 7, "Исаев" },
                    { 119, new DateTime(1986, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Софья", 7, "Алешина" },
                    { 118, new DateTime(1985, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Тимофей", 7, "Коновалов" },
                    { 117, new DateTime(1992, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Анна", 7, "Воронкова" },
                    { 116, new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Марк", 7, "Кудряшов" },
                    { 115, new DateTime(2000, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Дарья", 7, "Фокина" },
                    { 114, new DateTime(1995, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Екатерина", 7, "Вавилова" },
                    { 113, new DateTime(1990, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Серафима", 7, "Волкова" },
                    { 112, new DateTime(1987, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Вероника", 7, "Кузнецова" },
                    { 111, new DateTime(2001, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Кирилл", 7, "Жилин" },
                    { 110, new DateTime(1985, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Николай", 7, "Исаев" },
                    { 109, new DateTime(1988, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Павел", 7, "Медведев" },
                    { 108, new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Вероника", 6, "Денисова" },
                    { 107, new DateTime(1994, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "София", 6, "Ракова" },
                    { 106, new DateTime(1991, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Арсений", 6, "Рогов" },
                    { 105, new DateTime(1995, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Владислав", 6, "Нефедов" },
                    { 104, new DateTime(1999, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Полина", 6, "Воробьева" },
                    { 103, new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Малика", 6, "Козлова" },
                    { 102, new DateTime(1989, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Ульяна", 6, "Краснова" },
                    { 101, new DateTime(1994, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Дмитрий", 6, "Семенов" },
                    { 100, new DateTime(1999, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Михаил", 6, "Львов" },
                    { 99, new DateTime(1986, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Вероника", 6, "Пономарева" },
                    { 98, new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Арина", 6, "Воробьева" },
                    { 97, new DateTime(1995, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Таисия", 6, "Дубровина" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 96, new DateTime(1995, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Арина", 6, "Егорова" },
                    { 95, new DateTime(1991, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Степан", 6, "Ильин" },
                    { 94, new DateTime(2000, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Никита", 6, "Рубцов" },
                    { 92, new DateTime(1991, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Елизавета", 5, "Константинова" },
                    { 121, new DateTime(2000, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Оливия", 7, "Крючкова" },
                    { 61, new DateTime(2000, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Алексей", 3, "Беляев" },
                    { 59, new DateTime(2001, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Алёна", 3, "Морозова" },
                    { 27, new DateTime(1990, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Константин", 2, "Павлов" },
                    { 26, new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Нина", 2, "Соловьева" },
                    { 25, new DateTime(1995, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Матвей", 2, "Озеров" },
                    { 24, new DateTime(1998, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Аиша", 2, "Дубровина" },
                    { 23, new DateTime(1995, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Кирилл", 2, "Федоров" },
                    { 22, new DateTime(1990, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Егор", 2, "Степанов" },
                    { 21, new DateTime(1986, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Савелий", 2, "Воронов" },
                    { 20, new DateTime(1991, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Денис", 2, "Чернов" },
                    { 19, new DateTime(1996, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Анастасия", 2, "Сергеева" },
                    { 18, new DateTime(2001, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Милана", 2, "Куликова" },
                    { 17, new DateTime(1993, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Мия", 2, "Кузьмина" },
                    { 16, new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Никита", 2, "Румянцев" },
                    { 15, new DateTime(1990, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Александра", 2, "Петрова" },
                    { 14, new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Кира", 2, "Ковалева" },
                    { 13, new DateTime(2000, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Ульяна", 2, "Гаврилова" },
                    { 12, new DateTime(1991, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "София", 2, "Юдина" },
                    { 11, new DateTime(1995, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Эвелина", 2, "Горшкова" },
                    { 10, new DateTime(1995, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Дарья", 1, "Корнеева" },
                    { 9, new DateTime(2000, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Майя", 1, "Гришина" },
                    { 8, new DateTime(1987, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Мария", 1, "Соловьева" },
                    { 7, new DateTime(1990, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Илья", 1, "Харитонов" },
                    { 6, new DateTime(1987, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Ольга", 1, "Кузнецова" },
                    { 5, new DateTime(1999, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Елизавета", 1, "Волкова" },
                    { 4, new DateTime(1996, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Эвелина", 1, "Михайлова" },
                    { 3, new DateTime(2000, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Тимофей", 1, "Яковлев" },
                    { 2, new DateTime(1986, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Милана", 1, "Михайлова" },
                    { 1, new DateTime(1990, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Ксения", 1, "Пономарева" },
                    { 28, new DateTime(1999, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Макар", 2, "Захаров" },
                    { 60, new DateTime(1996, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Виктория", 3, "Тарасова" },
                    { 29, new DateTime(1998, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Николай", 2, "Афанасьев" },
                    { 31, new DateTime(1986, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Михаил", 2, "Дмитриев" },
                    { 58, new DateTime(1986, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Виктория", 3, "Блинова" },
                    { 57, new DateTime(1996, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Герман", 3, "Кукушкин" },
                    { 56, new DateTime(1997, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Нина", 3, "Абрамова" },
                    { 55, new DateTime(1992, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Мария", 3, "Степанова" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 54, new DateTime(1986, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Матвей", 3, "Воробьев" },
                    { 53, new DateTime(1986, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Варвара", 3, "Краснова" },
                    { 52, new DateTime(1998, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Матвей", 3, "Волков" },
                    { 51, new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Владислав", 3, "Капустин" },
                    { 50, new DateTime(2001, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Тимофей", 3, "Федотов" },
                    { 49, new DateTime(1986, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Арина", 3, "Савельева" },
                    { 48, new DateTime(1990, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Арина", 3, "Зуева" },
                    { 47, new DateTime(1997, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Анна", 3, "Андрианова" },
                    { 46, new DateTime(1987, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Платон", 3, "Терехов" },
                    { 45, new DateTime(1996, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Тимофей", 3, "Тарасов" },
                    { 44, new DateTime(1986, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Евгения", 3, "Алексеева" },
                    { 43, new DateTime(1985, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Любовь", 3, "Покровская" },
                    { 42, new DateTime(1987, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Амира", 3, "Филатова" },
                    { 41, new DateTime(1986, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Даниил", 3, "Лаптев" },
                    { 40, new DateTime(2001, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Кира", 3, "Савельева" },
                    { 39, new DateTime(1996, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Лев", 2, "Попов" },
                    { 38, new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Артём", 2, "Колпаков" },
                    { 37, new DateTime(1999, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Максим", 2, "Денисов" },
                    { 36, new DateTime(1993, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Мария", 2, "Пирогова" },
                    { 35, new DateTime(1988, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Софья", 2, "Винокурова" },
                    { 34, new DateTime(2000, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Роман", 2, "Кузьмин" },
                    { 33, new DateTime(1988, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Ева", 2, "Рябинина" },
                    { 32, new DateTime(1989, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Артём", 2, "Макаров" },
                    { 30, new DateTime(1992, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Иван", 2, "Иванов" },
                    { 122, new DateTime(1998, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Мария", 7, "Сорокина" },
                    { 123, new DateTime(1995, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Елизавета", 7, "Фролова" },
                    { 124, new DateTime(1995, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Андрей", 7, "Бочаров" },
                    { 214, new DateTime(1992, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Мирослава", 14, "Федорова" },
                    { 213, new DateTime(1998, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Владислав", 14, "Кудряшов" },
                    { 212, new DateTime(1991, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Максим", 14, "Болдырев" },
                    { 211, new DateTime(1989, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Иван", 14, "Зимин" },
                    { 210, new DateTime(1985, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Никита", 14, "Быков" },
                    { 209, new DateTime(1996, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Даниил", 14, "Шилов" },
                    { 208, new DateTime(1998, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Полина", 14, "Карпова" },
                    { 207, new DateTime(1986, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Злата", 14, "Соколова" },
                    { 206, new DateTime(1992, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Таисия", 14, "Морозова" },
                    { 205, new DateTime(1990, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Алёна", 14, "Фетисова" },
                    { 204, new DateTime(1992, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Мирон", 14, "Коновалов" },
                    { 203, new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Максим", 13, "Андреев" },
                    { 202, new DateTime(1995, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Михаил", 13, "Муратов" },
                    { 201, new DateTime(1993, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Анастасия", 13, "Парамонова" },
                    { 200, new DateTime(1994, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Артур", 13, "Некрасов" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 199, new DateTime(1991, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Макар", 13, "Семенов" },
                    { 198, new DateTime(1993, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Алиса", 13, "Алексеева" },
                    { 197, new DateTime(1991, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Артём", 13, "Зайцев" },
                    { 196, new DateTime(1996, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Матвей", 13, "Потапов" },
                    { 195, new DateTime(1994, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Аглая", 13, "Смирнова" },
                    { 194, new DateTime(1989, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Егор", 13, "Гаврилов" },
                    { 193, new DateTime(1994, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Елизавета", 13, "Козловская" },
                    { 192, new DateTime(1990, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Ангелина", 13, "Иванова" },
                    { 191, new DateTime(1986, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Екатерина", 12, "Елизарова" },
                    { 190, new DateTime(1998, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Фёдор", 12, "Виноградов" },
                    { 189, new DateTime(2001, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Анна", 12, "Митрофанова" },
                    { 188, new DateTime(1986, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Полина", 12, "Сорокина" },
                    { 215, new DateTime(1985, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Лев", 14, "Сальников" },
                    { 187, new DateTime(2001, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Ника", 12, "Кочетова" },
                    { 216, new DateTime(1994, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Роман", 14, "Елизаров" },
                    { 218, new DateTime(1996, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Варвара", 14, "Кудряшова" },
                    { 245, new DateTime(1990, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Яна", 15, "Волкова" },
                    { 244, new DateTime(1988, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Константин", 15, "Панин" },
                    { 243, new DateTime(1993, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Артём", 15, "Киселев" },
                    { 242, new DateTime(2001, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Мирослава", 15, "Смирнова" },
                    { 241, new DateTime(1999, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Варвара", 15, "Миронова" },
                    { 240, new DateTime(1987, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Карина", 15, "Иванова" },
                    { 239, new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Николай", 15, "Лобанов" },
                    { 238, new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Марк", 15, "Левин" },
                    { 237, new DateTime(1992, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Кирилл", 15, "Калачев" },
                    { 236, new DateTime(2000, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Кирилл", 15, "Лаврентьев" },
                    { 235, new DateTime(1999, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Мирослава", 15, "Колпакова" },
                    { 234, new DateTime(2001, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Арина", 15, "Крылова" },
                    { 233, new DateTime(1994, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Ульяна", 15, "Морозова" },
                    { 495, new DateTime(1987, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Егор", 28, "Молчанов" },
                    { 231, new DateTime(1991, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Анастасия", 15, "Комарова" },
                    { 230, new DateTime(1986, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Марк", 15, "Коновалов" },
                    { 229, new DateTime(1989, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Матвей", 15, "Панфилов" },
                    { 228, new DateTime(1987, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Всеволод", 15, "Носов" },
                    { 227, new DateTime(1992, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Анна", 15, "Анохина" },
                    { 226, new DateTime(1985, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Варвара", 14, "Денисова" },
                    { 225, new DateTime(1988, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Таисия", 14, "Королева" },
                    { 224, new DateTime(1998, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Руслан", 14, "Михайлов" },
                    { 223, new DateTime(1990, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Владислав", 14, "Дубинин" },
                    { 222, new DateTime(1994, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Василиса", 14, "Кузнецова" },
                    { 221, new DateTime(1998, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Артём", 14, "Поляков" },
                    { 220, new DateTime(1986, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Виктория", 14, "Прохорова" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 219, new DateTime(1990, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Олеся", 14, "Борисова" },
                    { 217, new DateTime(2000, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Сергей", 14, "Кузьмин" },
                    { 186, new DateTime(1990, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Даниил", 12, "Тихонов" },
                    { 185, new DateTime(1987, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Мирон", 11, "Лавров" },
                    { 184, new DateTime(1987, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Лука", 11, "Лаврентьев" },
                    { 151, new DateTime(1987, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "София", 9, "Зорина" },
                    { 150, new DateTime(1999, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Даниил", 9, "Калугин" },
                    { 149, new DateTime(1997, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Ульяна", 9, "Соловьева" },
                    { 148, new DateTime(1996, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Роман", 9, "Лебедев" },
                    { 147, new DateTime(1998, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Мирон", 9, "Матвеев" },
                    { 146, new DateTime(1997, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Илья", 9, "Леонтьев" },
                    { 145, new DateTime(1992, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Ариана", 9, "Демидова" },
                    { 144, new DateTime(1995, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Вячеслав", 9, "Михайлов" },
                    { 143, new DateTime(1985, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Яна", 9, "Михайлова" },
                    { 142, new DateTime(1996, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Тимофей", 9, "Кулаков" },
                    { 141, new DateTime(1991, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Наталья", 9, "Фомина" },
                    { 140, new DateTime(1990, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Роман", 9, "Степанов" },
                    { 139, new DateTime(1987, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Даниил", 9, "Сычев" },
                    { 138, new DateTime(1998, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Кирилл", 9, "Фадеев" },
                    { 137, new DateTime(1996, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Кира", 9, "Васильева" },
                    { 136, new DateTime(1986, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Михаил", 9, "Самсонов" },
                    { 135, new DateTime(1998, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Александр", 9, "Агапов" },
                    { 134, new DateTime(1986, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Иван", 8, "Богданов" },
                    { 133, new DateTime(1992, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Давид", 8, "Гусев" },
                    { 132, new DateTime(1988, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Варвара", 8, "Бирюкова" },
                    { 131, new DateTime(1994, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Тимур", 8, "Новиков" },
                    { 130, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Михаил", 8, "Смирнов" },
                    { 129, new DateTime(1986, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Алексей", 7, "Богданов" },
                    { 128, new DateTime(1989, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Мирослава", 7, "Яковлева" },
                    { 127, new DateTime(1989, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Давид", 7, "Шубин" },
                    { 126, new DateTime(1998, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Арсений", 7, "Попов" },
                    { 125, new DateTime(1988, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Мелисса", 7, "Щеглова" },
                    { 152, new DateTime(1988, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Степан", 9, "Зотов" },
                    { 153, new DateTime(1988, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Мария", 9, "Воронова" },
                    { 154, new DateTime(1991, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Алиса", 9, "Данилова" },
                    { 155, new DateTime(1992, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Константин", 9, "Киселев" },
                    { 183, new DateTime(1998, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Гордей", 11, "Кузнецов" },
                    { 182, new DateTime(2001, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Анна", 11, "Щербакова" },
                    { 181, new DateTime(1985, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Максим", 11, "Лаптев" },
                    { 180, new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Ульяна", 11, "Тихонова" },
                    { 179, new DateTime(1987, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Константин", 11, "Шишкин" },
                    { 178, new DateTime(1999, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Максим", 11, "Виноградов" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 177, new DateTime(1986, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Дарья", 11, "Агеева" },
                    { 176, new DateTime(1993, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Алина", 11, "Макеева" },
                    { 175, new DateTime(1988, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Анна", 11, "Кулешова" },
                    { 174, new DateTime(1992, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Илья", 11, "Троицкий" },
                    { 173, new DateTime(1998, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Ярослава", 11, "Морозова" },
                    { 172, new DateTime(2000, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Маргарита", 11, "Кочергина" },
                    { 171, new DateTime(1994, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Кирилл", 10, "Самсонов" },
                    { 247, new DateTime(1994, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Али", 16, "Романов" },
                    { 170, new DateTime(1995, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Елизавета", 10, "Иванова" },
                    { 168, new DateTime(1985, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Ева", 10, "Соловьева" },
                    { 167, new DateTime(1987, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Матвей", 10, "Леонтьев" },
                    { 166, new DateTime(1992, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Варвара", 10, "Смирнова" },
                    { 165, new DateTime(1991, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Таисия", 10, "Вешнякова" },
                    { 164, new DateTime(1994, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Сергей", 10, "Кондратьев" },
                    { 163, new DateTime(1995, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Анфиса", 10, "Смирнова" },
                    { 162, new DateTime(1995, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Георгий", 10, "Белов" },
                    { 161, new DateTime(1987, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Дарья", 10, "Щукина" },
                    { 160, new DateTime(2001, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Алина", 10, "Ермакова" },
                    { 159, new DateTime(1992, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Михаил", 10, "Лопатин" },
                    { 158, new DateTime(1986, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Ульяна", 9, "Попова" },
                    { 157, new DateTime(1989, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Фёдор", 9, "Наумов" },
                    { 156, new DateTime(1996, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Арина", 9, "Ларионова" },
                    { 169, new DateTime(1994, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Иван", 10, "Губанов" },
                    { 496, new DateTime(1988, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Николай", 28, "Терехов" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 496);
        }
    }
}
