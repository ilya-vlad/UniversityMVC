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
                    { 1001, "Царица наук", "Математика" },
                    { 1002, "Основа всего", "Физика" },
                    { 1003, "В здоровом теле - здоровый дух", "Физкультура" },
                    { 1004, "У того, кто не знает прошлого - нет будущего", "История" }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CourseId", "Name" },
                values: new object[,]
                {
                    { 1017, 1003, "ГА-223" },
                    { 1018, 1003, "ПВ-232" },
                    { 1019, 1001, "СП-344" },
                    { 1020, 1001, "ОР-421" },
                    { 1021, 1001, "РФ-231" },
                    { 1023, 1002, "РР-214" },
                    { 1016, 1003, "РА-344" },
                    { 1025, 1004, "ПЦ-344" },
                    { 1026, 1004, "ТО-324" },
                    { 1027, 1004, "НР-433" },
                    { 1028, 1004, "РА-364" },
                    { 1022, 1002, "ШО-521" },
                    { 1015, 1001, "МВ-354" },
                    { 1024, 1002, "ФП-341" },
                    { 1013, 1003, "ВП-322" },
                    { 1014, 1003, "УЦ-311" },
                    { 1001, 1001, "КБ-101" },
                    { 1003, 1003, "РР-103" },
                    { 1004, 1002, "РС-104" },
                    { 1005, 1001, "РА-105" },
                    { 1006, 1003, "РА-202" },
                    { 1002, 1002, "ЛП-102" },
                    { 1008, 1004, "РА-204" },
                    { 1009, 1001, "НК-205" },
                    { 1010, 1003, "БК-301" },
                    { 1011, 1004, "РА-353" },
                    { 1007, 1004, "АР-203" },
                    { 1012, 1001, "РА-333" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1282, new DateTime(1985, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Евгения", 1020, "Назарова" },
                    { 1283, new DateTime(1990, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Марк", 1020, "Журавлев" },
                    { 1284, new DateTime(1993, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Стефания", 1020, "Кузнецова" },
                    { 1285, new DateTime(2001, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Арсений", 1020, "Алексеев" },
                    { 1287, new DateTime(1990, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Ульяна", 1020, "Смирнова" },
                    { 1288, new DateTime(1985, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Макар", 1020, "Логинов" },
                    { 1289, new DateTime(2000, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Артём", 1021, "Борисов" },
                    { 1281, new DateTime(1996, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Гордей", 1020, "Морозов" },
                    { 1290, new DateTime(1986, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Александр", 1021, "Кузин" },
                    { 1286, new DateTime(1989, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Александр", 1020, "Панкратов" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1280, new DateTime(1995, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Матвей", 1019, "Пугачев" },
                    { 1273, new DateTime(1995, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Полина", 1018, "Елизарова" },
                    { 1278, new DateTime(1986, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Софья", 1019, "Зимина" },
                    { 1277, new DateTime(2000, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Алёна", 1019, "Боброва" },
                    { 1276, new DateTime(1990, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Александра", 1019, "Сергеева" },
                    { 1275, new DateTime(1990, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Иван", 1019, "Виноградов" },
                    { 1274, new DateTime(1996, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Полина", 1019, "Яковлева" },
                    { 1272, new DateTime(1995, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Никита", 1018, "Григорьев" },
                    { 1271, new DateTime(1993, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Степан", 1018, "Зайцев" },
                    { 1270, new DateTime(1997, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Мария", 1018, "Максимова" },
                    { 1269, new DateTime(1987, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Светлана", 1018, "Астафьева" },
                    { 1291, new DateTime(1992, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Ульяна", 1021, "Соколова" },
                    { 1279, new DateTime(1986, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Денис", 1019, "Попов" },
                    { 1292, new DateTime(1996, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Вера", 1021, "Устинова" },
                    { 1308, new DateTime(1998, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Алексей", 1021, "Данилов" },
                    { 1294, new DateTime(1993, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Арина", 1021, "Ежова" },
                    { 1317, new DateTime(1992, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Максим", 1022, "Кузнецов" },
                    { 1316, new DateTime(1988, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Юлия", 1022, "Новикова" },
                    { 1315, new DateTime(1994, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Виктория", 1022, "Митрофанова" },
                    { 1314, new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Лев", 1022, "Васильев" },
                    { 1313, new DateTime(1997, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Анастасия", 1022, "Коновалова" },
                    { 1312, new DateTime(1985, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Вероника", 1022, "Орехова" },
                    { 1311, new DateTime(1991, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Дмитрий", 1022, "Лобанов" },
                    { 1310, new DateTime(1992, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Василий", 1022, "Алексеев" },
                    { 1309, new DateTime(2000, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Егор", 1021, "Назаров" },
                    { 1268, new DateTime(2001, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Савелий", 1018, "Некрасов" },
                    { 1307, new DateTime(1998, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Амира", 1021, "Малинина" },
                    { 1306, new DateTime(2000, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Артём", 1021, "Власов" },
                    { 1305, new DateTime(1987, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Татьяна", 1021, "Голикова" },
                    { 1304, new DateTime(1989, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Никита", 1021, "Павловский" },
                    { 1303, new DateTime(1998, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Тимофей", 1021, "Терехов" },
                    { 1302, new DateTime(1999, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Георгий", 1021, "Крюков" },
                    { 1301, new DateTime(1991, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Тимофей", 1021, "Данилов" },
                    { 1300, new DateTime(2000, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Иван", 1021, "Сидоров" },
                    { 1299, new DateTime(1999, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Екатерина", 1021, "Васильева" },
                    { 1298, new DateTime(1988, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Мария", 1021, "Осипова" },
                    { 1297, new DateTime(1985, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Милана", 1021, "Степанова" },
                    { 1296, new DateTime(1987, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Анастасия", 1021, "Дементьева" },
                    { 1295, new DateTime(1995, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Фёдор", 1021, "Морозов" },
                    { 1293, new DateTime(1988, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Ульяна", 1021, "Данилова" },
                    { 1267, new DateTime(2000, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Мария", 1018, "Кириллова" },
                    { 1251, new DateTime(1987, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Демид", 1018, "Жуков" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1265, new DateTime(1997, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Матвей", 1018, "Коновалов" },
                    { 1237, new DateTime(1987, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Кирилл", 1017, "Калачев" },
                    { 1236, new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Кирилл", 1016, "Лаврентьев" },
                    { 1235, new DateTime(1989, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Мирослава", 1016, "Колпакова" },
                    { 1234, new DateTime(2000, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Арина", 1016, "Крылова" },
                    { 1233, new DateTime(1991, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Ульяна", 1016, "Морозова" },
                    { 1232, new DateTime(1997, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Артём", 1016, "Алексеев" },
                    { 1231, new DateTime(1998, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Анастасия", 1016, "Комарова" },
                    { 1230, new DateTime(2000, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Марк", 1016, "Коновалов" },
                    { 1229, new DateTime(1995, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Матвей", 1016, "Панфилов" },
                    { 1228, new DateTime(1989, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Всеволод", 1016, "Носов" },
                    { 1227, new DateTime(1995, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Анна", 1016, "Анохина" },
                    { 1226, new DateTime(1992, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Варвара", 1016, "Денисова" },
                    { 1225, new DateTime(1985, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Таисия", 1016, "Королева" },
                    { 1224, new DateTime(1991, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Руслан", 1016, "Михайлов" },
                    { 1223, new DateTime(2000, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Владислав", 1016, "Дубинин" },
                    { 1222, new DateTime(1990, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Василиса", 1016, "Кузнецова" },
                    { 1221, new DateTime(1986, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Артём", 1016, "Поляков" },
                    { 1220, new DateTime(1995, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Виктория", 1016, "Прохорова" },
                    { 1219, new DateTime(1987, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Олеся", 1016, "Борисова" },
                    { 1218, new DateTime(1990, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Варвара", 1016, "Кудряшова" },
                    { 1217, new DateTime(1985, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Сергей", 1016, "Кузьмин" },
                    { 1216, new DateTime(1993, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Роман", 1016, "Елизаров" },
                    { 1215, new DateTime(1995, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Лев", 1016, "Сальников" },
                    { 1238, new DateTime(1996, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Марк", 1017, "Левин" },
                    { 1266, new DateTime(1991, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Дарья", 1018, "Иванова" },
                    { 1239, new DateTime(1996, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Николай", 1017, "Лобанов" },
                    { 1241, new DateTime(1994, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Варвара", 1017, "Миронова" },
                    { 1264, new DateTime(1987, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Мия", 1018, "Исаева" },
                    { 1263, new DateTime(1998, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Матвей", 1018, "Сахаров" },
                    { 1262, new DateTime(1991, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Виктория", 1018, "Смирнова" },
                    { 1261, new DateTime(1998, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Алёна", 1018, "Горячева" },
                    { 1260, new DateTime(1993, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "София", 1018, "Зубова" },
                    { 1259, new DateTime(1986, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Милана", 1018, "Макарова" },
                    { 1258, new DateTime(2000, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Милослава", 1018, "Грачева" },
                    { 1257, new DateTime(1987, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Артём", 1018, "Постников" },
                    { 1256, new DateTime(1986, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Яна", 1018, "Беляева" },
                    { 1255, new DateTime(2001, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Никита", 1018, "Соловьев" },
                    { 1254, new DateTime(1993, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Лев", 1018, "Волков" },
                    { 1253, new DateTime(1987, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Артур", 1018, "Лобанов" },
                    { 1252, new DateTime(1992, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Дмитрий", 1018, "Елисеев" },
                    { 1318, new DateTime(1997, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Александр", 1022, "Гусев" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1250, new DateTime(1994, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Валерия", 1018, "Вавилова" },
                    { 1249, new DateTime(1992, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Павел", 1018, "Голубев" },
                    { 1248, new DateTime(1989, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Елизавета", 1018, "Ермакова" },
                    { 1247, new DateTime(1995, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Али", 1017, "Романов" },
                    { 1246, new DateTime(1985, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Варвара", 1017, "Романова" },
                    { 1245, new DateTime(1996, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Яна", 1017, "Волкова" },
                    { 1244, new DateTime(1992, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Константин", 1017, "Панин" },
                    { 1243, new DateTime(1994, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Артём", 1017, "Киселев" },
                    { 1242, new DateTime(1999, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Мирослава", 1017, "Смирнова" },
                    { 1240, new DateTime(1991, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Карина", 1017, "Иванова" },
                    { 1319, new DateTime(1995, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Оливия", 1022, "Маркина" },
                    { 1335, new DateTime(2001, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Ника", 1022, "Ильинская" },
                    { 1321, new DateTime(1996, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Александр", 1022, "Яковлев" },
                    { 1397, new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Тимофей", 1026, "Николаев" },
                    { 1396, new DateTime(1994, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Алиса", 1026, "Гончарова" },
                    { 1395, new DateTime(1993, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Елизавета", 1026, "Золотова" },
                    { 1394, new DateTime(1994, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Всеволод", 1026, "Орлов" },
                    { 1393, new DateTime(1994, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Вероника", 1026, "Григорьева" },
                    { 1392, new DateTime(1998, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Камила", 1026, "Трифонова" },
                    { 1391, new DateTime(1993, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Кирилл", 1026, "Соколов" },
                    { 1390, new DateTime(2000, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Елизавета", 1026, "Иванова" },
                    { 1389, new DateTime(1992, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Милана", 1026, "Новикова" },
                    { 1388, new DateTime(1993, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Алиса", 1026, "Терентьева" },
                    { 1398, new DateTime(1985, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Дмитрий", 1026, "Быков" },
                    { 1387, new DateTime(1997, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Ева", 1026, "Кольцова" },
                    { 1385, new DateTime(1999, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Игорь", 1025, "Лапшин" },
                    { 1384, new DateTime(2001, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Павел", 1025, "Васильев" },
                    { 1383, new DateTime(1997, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Ярослав", 1025, "Черепанов" },
                    { 1382, new DateTime(2001, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Дмитрий", 1025, "Кошелев" },
                    { 1381, new DateTime(1998, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Артём", 1025, "Михайлов" },
                    { 1380, new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Василиса", 1025, "Шарова" },
                    { 1379, new DateTime(1986, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Никита", 1025, "Молчанов" },
                    { 1378, new DateTime(1994, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Алиса", 1025, "Никитина" },
                    { 1377, new DateTime(1996, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Анна", 1025, "Иванова" },
                    { 1376, new DateTime(1989, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Фёдор", 1025, "Иванов" },
                    { 1386, new DateTime(1994, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Богдан", 1025, "Ситников" },
                    { 1399, new DateTime(1995, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Милана", 1026, "Игнатова" },
                    { 1400, new DateTime(1996, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Яна", 1026, "Ершова" },
                    { 1401, new DateTime(1993, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Вероника", 1027, "Соколова" },
                    { 1424, new DateTime(1992, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Максим", 1028, "Жуков" },
                    { 1423, new DateTime(1996, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Всеволод", 1028, "Виноградов" },
                    { 1422, new DateTime(1999, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Эмма", 1028, "Шевцова" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1421, new DateTime(2000, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Амина", 1028, "Овчинникова" },
                    { 1420, new DateTime(1988, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Эвелина", 1028, "Белоусова" },
                    { 1419, new DateTime(2000, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Екатерина", 1028, "Беляева" },
                    { 1418, new DateTime(1996, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Артур", 1028, "Майоров" },
                    { 1417, new DateTime(1986, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Анна", 1027, "Кондратова" },
                    { 1416, new DateTime(2001, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Ясмина", 1027, "Потапова" },
                    { 1415, new DateTime(1993, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Андрей", 1027, "Никифоров" },
                    { 1414, new DateTime(1990, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Тимофей", 1027, "Родин" },
                    { 1413, new DateTime(1991, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Анна", 1027, "Латышева" },
                    { 1412, new DateTime(1991, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Злата", 1027, "Попова" },
                    { 1411, new DateTime(1988, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Савелий", 1027, "Орлов" },
                    { 1410, new DateTime(1994, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Денис", 1027, "Васильев" },
                    { 1409, new DateTime(1987, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Кристина", 1027, "Павлова" },
                    { 1408, new DateTime(1994, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "София", 1027, "Лазарева" },
                    { 1407, new DateTime(1998, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Данил", 1027, "Сергеев" },
                    { 1406, new DateTime(2000, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Василиса", 1027, "Иванова" },
                    { 1405, new DateTime(1999, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Евгения", 1027, "Медведева" },
                    { 1404, new DateTime(1995, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Лука", 1027, "Фролов" },
                    { 1403, new DateTime(1996, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Алексей", 1027, "Кулешов" },
                    { 1402, new DateTime(1985, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Агния", 1027, "Попова" },
                    { 1375, new DateTime(1985, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Дмитрий", 1025, "Герасимов" },
                    { 1374, new DateTime(1999, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Екатерина", 1025, "Беляева" },
                    { 1373, new DateTime(1988, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Максим", 1025, "Суслов" },
                    { 1372, new DateTime(1989, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Иван", 1024, "Мартынов" },
                    { 1344, new DateTime(1988, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Даниил", 1023, "Колесов" },
                    { 1343, new DateTime(1985, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Мирон", 1023, "Архипов" },
                    { 1342, new DateTime(1998, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Дарья", 1023, "Горячева" },
                    { 1341, new DateTime(1993, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Даниэль", 1023, "Козловский" },
                    { 1340, new DateTime(1991, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Ольга", 1023, "Герасимова" },
                    { 1339, new DateTime(2000, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Екатерина", 1023, "Давыдова" },
                    { 1338, new DateTime(1998, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Ксения", 1023, "Богданова" },
                    { 1337, new DateTime(1987, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Михаил", 1023, "Иванов" },
                    { 1336, new DateTime(1998, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Эмилия", 1023, "Кононова" },
                    { 1214, new DateTime(1987, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Мирослава", 1016, "Федорова" },
                    { 1334, new DateTime(1994, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Платон", 1022, "Третьяков" },
                    { 1333, new DateTime(2001, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "София", 1022, "Рожкова" },
                    { 1332, new DateTime(1998, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Софья", 1022, "Трофимова" },
                    { 1331, new DateTime(1989, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Александр", 1022, "Васильев" },
                    { 1330, new DateTime(2000, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Виктория", 1022, "Казакова" },
                    { 1329, new DateTime(1988, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Варвара", 1022, "Николаева" },
                    { 1328, new DateTime(1994, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Артём", 1022, "Кузьмин" },
                    { 1327, new DateTime(1997, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Григорий", 1022, "Николаев" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1326, new DateTime(1987, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Диана", 1022, "Королева" },
                    { 1325, new DateTime(2001, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Тигран", 1022, "Ермаков" },
                    { 1324, new DateTime(1994, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Мелисса", 1022, "Ермакова" },
                    { 1323, new DateTime(1992, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Алексей", 1022, "Смирнов" },
                    { 1322, new DateTime(1998, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Юлия", 1022, "Михеева" },
                    { 1345, new DateTime(1997, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Роман", 1023, "Корнев" },
                    { 1320, new DateTime(1987, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Антон", 1022, "Овчинников" },
                    { 1346, new DateTime(1987, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Милана", 1023, "Голубева" },
                    { 1348, new DateTime(1989, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Эмин", 1023, "Зимин" },
                    { 1371, new DateTime(2001, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Анастасия", 1024, "Григорьева" },
                    { 1370, new DateTime(1993, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Полина", 1024, "Чеботарева" },
                    { 1369, new DateTime(1996, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Софья", 1024, "Смирнова" },
                    { 1368, new DateTime(1997, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Дмитрий", 1024, "Горбачев" },
                    { 1367, new DateTime(2000, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Всеволод", 1024, "Тихонов" },
                    { 1366, new DateTime(1998, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Яна", 1024, "Семина" },
                    { 1365, new DateTime(1999, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Василиса", 1024, "Смирнова" },
                    { 1364, new DateTime(1995, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Софья", 1024, "Панова" },
                    { 1363, new DateTime(1992, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Виктория", 1024, "Козлова" },
                    { 1362, new DateTime(2001, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "София", 1024, "Зимина" },
                    { 1361, new DateTime(2000, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Мирослава", 1024, "Захарова" },
                    { 1360, new DateTime(1987, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Александр", 1024, "Афанасьев" },
                    { 1359, new DateTime(2000, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Марк", 1024, "Никитин" },
                    { 1358, new DateTime(1991, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Никита", 1024, "Иванов" },
                    { 1357, new DateTime(1998, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Виктория", 1024, "Ершова" },
                    { 1356, new DateTime(2000, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Леон", 1024, "Белоусов" },
                    { 1355, new DateTime(1997, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Алия", 1024, "Сомова" },
                    { 1354, new DateTime(1995, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Олеся", 1024, "Гаврилова" },
                    { 1353, new DateTime(1988, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Ольга", 1024, "Трофимова" },
                    { 1352, new DateTime(1994, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Дмитрий", 1024, "Гусев" },
                    { 1351, new DateTime(1998, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Ева", 1024, "Щербакова" },
                    { 1350, new DateTime(1996, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Екатерина", 1024, "Ефимова" },
                    { 1349, new DateTime(1993, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Елизавета", 1023, "Емельянова" },
                    { 1347, new DateTime(1989, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Фёдор", 1023, "Романов" },
                    { 1213, new DateTime(1985, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Владислав", 1016, "Кудряшов" },
                    { 1197, new DateTime(1987, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Артём", 1015, "Зайцев" },
                    { 1211, new DateTime(1999, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Иван", 1016, "Зимин" },
                    { 1076, new DateTime(1995, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Ульяна", 1006, "Давыдова" },
                    { 1075, new DateTime(1985, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Ангелина", 1006, "Кондрашова" },
                    { 1074, new DateTime(1994, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Ксения", 1006, "Попова" },
                    { 1073, new DateTime(1996, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Алиса", 1006, "Логинова" },
                    { 1072, new DateTime(1985, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Мирон", 1006, "Казаков" },
                    { 1071, new DateTime(1989, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Полина", 1006, "Ковалева" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1070, new DateTime(1999, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Сергей", 1006, "Лукьянов" },
                    { 1069, new DateTime(1995, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Елисей", 1006, "Аксенов" },
                    { 1068, new DateTime(1994, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Олег", 1006, "Смирнов" },
                    { 1067, new DateTime(1985, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Ян", 1006, "Герасимов" },
                    { 1077, new DateTime(1989, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Анастасия", 1006, "Капустина" },
                    { 1066, new DateTime(1985, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Алиса", 1006, "Корнилова" },
                    { 1064, new DateTime(1988, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Максим", 1006, "Дубов" },
                    { 1063, new DateTime(1988, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Максим", 1006, "Егоров" },
                    { 1062, new DateTime(1987, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Елизавета", 1006, "Малышева" },
                    { 1061, new DateTime(1996, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Алексей", 1006, "Беляев" },
                    { 1060, new DateTime(1986, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Виктория", 1006, "Тарасова" },
                    { 1059, new DateTime(1992, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Алёна", 1006, "Морозова" },
                    { 1058, new DateTime(1999, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Виктория", 1006, "Блинова" },
                    { 1057, new DateTime(1999, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Герман", 1006, "Кукушкин" },
                    { 1056, new DateTime(1988, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Нина", 1006, "Абрамова" },
                    { 1055, new DateTime(1994, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Мария", 1006, "Степанова" },
                    { 1065, new DateTime(1988, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Елизавета", 1006, "Смирнова" },
                    { 1078, new DateTime(1996, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Макар", 1006, "Корнеев" },
                    { 1079, new DateTime(1991, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Давид", 1007, "Голованов" },
                    { 1080, new DateTime(1987, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Диана", 1007, "Колесникова" },
                    { 1103, new DateTime(1985, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Малика", 1008, "Козлова" },
                    { 1102, new DateTime(1985, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Ульяна", 1008, "Краснова" },
                    { 1101, new DateTime(2001, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Дмитрий", 1008, "Семенов" },
                    { 1100, new DateTime(1997, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Михаил", 1008, "Львов" },
                    { 1099, new DateTime(1996, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Вероника", 1008, "Пономарева" },
                    { 1098, new DateTime(1995, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Арина", 1008, "Воробьева" },
                    { 1097, new DateTime(1993, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Таисия", 1008, "Дубровина" },
                    { 1096, new DateTime(1998, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Арина", 1008, "Егорова" },
                    { 1095, new DateTime(1994, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Степан", 1008, "Ильин" },
                    { 1094, new DateTime(1991, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Никита", 1008, "Рубцов" },
                    { 1093, new DateTime(1985, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Мирослава", 1008, "Высоцкая" },
                    { 1092, new DateTime(1994, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Елизавета", 1008, "Константинова" },
                    { 1091, new DateTime(1989, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Анастасия", 1008, "Иванова" },
                    { 1090, new DateTime(1992, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Виктория", 1008, "Медведева" },
                    { 1089, new DateTime(1999, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Елизавета", 1007, "Романова" },
                    { 1088, new DateTime(1988, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Лев", 1007, "Иванов" },
                    { 1087, new DateTime(1990, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Виктория", 1007, "Яшина" },
                    { 1086, new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Георгий", 1007, "Большаков" },
                    { 1085, new DateTime(2001, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Лев", 1007, "Калинин" },
                    { 1084, new DateTime(1999, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Никита", 1007, "Тарасов" },
                    { 1083, new DateTime(1997, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Евдокия", 1007, "Прохорова" },
                    { 1082, new DateTime(1988, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Арина", 1007, "Чернышева" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1081, new DateTime(1995, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Константин", 1007, "Волков" },
                    { 1054, new DateTime(1997, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Матвей", 1006, "Воробьев" },
                    { 1053, new DateTime(1988, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Варвара", 1006, "Краснова" },
                    { 1052, new DateTime(1991, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Матвей", 1005, "Волков" },
                    { 1051, new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Владислав", 1005, "Капустин" },
                    { 1023, new DateTime(2000, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Кирилл", 1002, "Федоров" },
                    { 1022, new DateTime(1985, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Егор", 1002, "Степанов" },
                    { 1021, new DateTime(1986, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Савелий", 1002, "Воронов" },
                    { 1020, new DateTime(1988, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Денис", 1002, "Чернов" },
                    { 1019, new DateTime(1992, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Анастасия", 1002, "Сергеева" },
                    { 1018, new DateTime(1996, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Милана", 1002, "Куликова" },
                    { 1017, new DateTime(1992, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Мия", 1002, "Кузьмина" },
                    { 1016, new DateTime(1999, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Никита", 1001, "Румянцев" },
                    { 1015, new DateTime(1986, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Александра", 1001, "Петрова" },
                    { 1014, new DateTime(2001, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Кира", 1001, "Ковалева" },
                    { 1013, new DateTime(1991, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Ульяна", 1001, "Гаврилова" },
                    { 1012, new DateTime(1986, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "София", 1001, "Юдина" },
                    { 1011, new DateTime(1996, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Эвелина", 1001, "Горшкова" },
                    { 1010, new DateTime(1999, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Дарья", 1001, "Корнеева" },
                    { 1009, new DateTime(2000, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Майя", 1001, "Гришина" },
                    { 1008, new DateTime(1998, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Мария", 1001, "Соловьева" },
                    { 1007, new DateTime(1987, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Илья", 1001, "Харитонов" },
                    { 1006, new DateTime(1997, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Ольга", 1001, "Кузнецова" },
                    { 1005, new DateTime(1996, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Елизавета", 1001, "Волкова" },
                    { 1004, new DateTime(1999, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Эвелина", 1001, "Михайлова" },
                    { 1003, new DateTime(1993, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Тимофей", 1001, "Яковлев" },
                    { 1002, new DateTime(1989, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Милана", 1001, "Михайлова" },
                    { 1001, new DateTime(1995, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Ксения", 1001, "Пономарева" },
                    { 1024, new DateTime(1995, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Аиша", 1002, "Дубровина" },
                    { 1104, new DateTime(1986, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Полина", 1008, "Воробьева" },
                    { 1025, new DateTime(2001, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Матвей", 1002, "Озеров" },
                    { 1027, new DateTime(1986, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Константин", 1003, "Павлов" },
                    { 1050, new DateTime(2001, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Тимофей", 1005, "Федотов" },
                    { 1049, new DateTime(1991, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Арина", 1005, "Савельева" },
                    { 1048, new DateTime(1995, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Арина", 1005, "Зуева" },
                    { 1047, new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Анна", 1005, "Андрианова" },
                    { 1046, new DateTime(1994, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Платон", 1005, "Терехов" },
                    { 1045, new DateTime(1986, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Тимофей", 1005, "Тарасов" },
                    { 1044, new DateTime(1986, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Евгения", 1005, "Алексеева" },
                    { 1043, new DateTime(1998, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Любовь", 1005, "Покровская" },
                    { 1042, new DateTime(1999, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Амира", 1005, "Филатова" },
                    { 1041, new DateTime(1995, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Даниил", 1005, "Лаптев" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1040, new DateTime(1991, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Кира", 1005, "Савельева" },
                    { 1039, new DateTime(1998, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Лев", 1005, "Попов" },
                    { 1038, new DateTime(1993, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Артём", 1004, "Колпаков" },
                    { 1037, new DateTime(1990, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Максим", 1004, "Денисов" },
                    { 1036, new DateTime(1986, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Мария", 1004, "Пирогова" },
                    { 1035, new DateTime(1998, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Софья", 1004, "Винокурова" },
                    { 1034, new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Роман", 1004, "Кузьмин" },
                    { 1033, new DateTime(1989, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Ева", 1004, "Рябинина" },
                    { 1032, new DateTime(1985, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Артём", 1003, "Макаров" },
                    { 1031, new DateTime(1993, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Михаил", 1003, "Дмитриев" },
                    { 1030, new DateTime(1989, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Иван", 1003, "Иванов" },
                    { 1029, new DateTime(1996, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Николай", 1003, "Афанасьев" },
                    { 1028, new DateTime(1985, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Макар", 1003, "Захаров" },
                    { 1026, new DateTime(1987, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Нина", 1003, "Соловьева" },
                    { 1212, new DateTime(1988, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Максим", 1016, "Болдырев" },
                    { 1105, new DateTime(1993, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Владислав", 1008, "Нефедов" },
                    { 1107, new DateTime(1985, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "София", 1008, "Ракова" },
                    { 1183, new DateTime(1990, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Гордей", 1013, "Кузнецов" },
                    { 1182, new DateTime(1992, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Анна", 1013, "Щербакова" },
                    { 1181, new DateTime(1994, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Максим", 1013, "Лаптев" },
                    { 1180, new DateTime(1989, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Ульяна", 1013, "Тихонова" },
                    { 1179, new DateTime(1986, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Константин", 1013, "Шишкин" },
                    { 1178, new DateTime(1992, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Максим", 1012, "Виноградов" },
                    { 1177, new DateTime(1993, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Дарья", 1012, "Агеева" },
                    { 1176, new DateTime(1986, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Алина", 1012, "Макеева" },
                    { 1175, new DateTime(1994, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Анна", 1012, "Кулешова" },
                    { 1174, new DateTime(1994, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Илья", 1012, "Троицкий" },
                    { 1184, new DateTime(1985, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Лука", 1013, "Лаврентьев" },
                    { 1173, new DateTime(1988, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Ярослава", 1012, "Морозова" },
                    { 1171, new DateTime(1997, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Кирилл", 1012, "Самсонов" },
                    { 1170, new DateTime(1999, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Елизавета", 1012, "Иванова" },
                    { 1169, new DateTime(2000, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Иван", 1012, "Губанов" },
                    { 1168, new DateTime(1990, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Ева", 1012, "Соловьева" },
                    { 1167, new DateTime(1990, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Матвей", 1012, "Леонтьев" },
                    { 1166, new DateTime(1987, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Варвара", 1012, "Смирнова" },
                    { 1165, new DateTime(2000, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Таисия", 1012, "Вешнякова" },
                    { 1164, new DateTime(1992, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Сергей", 1012, "Кондратьев" },
                    { 1163, new DateTime(1988, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Анфиса", 1012, "Смирнова" },
                    { 1162, new DateTime(1997, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Георгий", 1012, "Белов" },
                    { 1172, new DateTime(1985, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Маргарита", 1012, "Кочергина" },
                    { 1185, new DateTime(1987, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Мирон", 1013, "Лавров" },
                    { 1186, new DateTime(1985, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Даниил", 1013, "Тихонов" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1187, new DateTime(1985, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Ника", 1014, "Кочетова" },
                    { 1210, new DateTime(1999, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Никита", 1016, "Быков" },
                    { 1209, new DateTime(1986, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Даниил", 1016, "Шилов" },
                    { 1208, new DateTime(1990, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "Полина", 1015, "Карпова" },
                    { 1207, new DateTime(1999, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Злата", 1015, "Соколова" },
                    { 1206, new DateTime(1987, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Таисия", 1015, "Морозова" },
                    { 1205, new DateTime(2000, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Алёна", 1015, "Фетисова" },
                    { 1204, new DateTime(1994, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Мирон", 1015, "Коновалов" },
                    { 1203, new DateTime(1989, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Максим", 1015, "Андреев" },
                    { 1202, new DateTime(1995, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Михаил", 1015, "Муратов" },
                    { 1201, new DateTime(1994, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Анастасия", 1015, "Парамонова" },
                    { 1200, new DateTime(1989, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Артур", 1015, "Некрасов" },
                    { 1199, new DateTime(1988, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Макар", 1015, "Семенов" },
                    { 1198, new DateTime(1996, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Алиса", 1015, "Алексеева" },
                    { 1425, new DateTime(1986, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Леон", 1028, "Воронин" },
                    { 1196, new DateTime(1999, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Матвей", 1015, "Потапов" },
                    { 1195, new DateTime(1996, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Аглая", 1015, "Смирнова" },
                    { 1194, new DateTime(1992, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Егор", 1015, "Гаврилов" },
                    { 1193, new DateTime(1999, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Елизавета", 1014, "Козловская" },
                    { 1192, new DateTime(1988, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Ангелина", 1014, "Иванова" },
                    { 1191, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Екатерина", 1014, "Елизарова" },
                    { 1190, new DateTime(2000, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Фёдор", 1014, "Виноградов" },
                    { 1189, new DateTime(1990, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 5f, "Анна", 1014, "Митрофанова" },
                    { 1188, new DateTime(1991, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Полина", 1014, "Сорокина" },
                    { 1161, new DateTime(1988, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Дарья", 1012, "Щукина" },
                    { 1160, new DateTime(1990, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Алина", 1012, "Ермакова" },
                    { 1159, new DateTime(1994, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Михаил", 1012, "Лопатин" },
                    { 1158, new DateTime(1995, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Ульяна", 1012, "Попова" },
                    { 1130, new DateTime(1989, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Михаил", 1009, "Смирнов" },
                    { 1129, new DateTime(1997, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Алексей", 1009, "Богданов" },
                    { 1128, new DateTime(1996, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Мирослава", 1009, "Яковлева" },
                    { 1127, new DateTime(1986, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.1f, "Давид", 1009, "Шубин" },
                    { 1126, new DateTime(1990, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Арсений", 1009, "Попов" },
                    { 1125, new DateTime(1989, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Мелисса", 1009, "Щеглова" },
                    { 1124, new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Андрей", 1009, "Бочаров" },
                    { 1123, new DateTime(1992, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Елизавета", 1009, "Фролова" },
                    { 1122, new DateTime(2001, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Мария", 1009, "Сорокина" },
                    { 1121, new DateTime(1997, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Оливия", 1009, "Крючкова" },
                    { 1120, new DateTime(1989, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.4f, "Артём", 1009, "Исаев" },
                    { 1119, new DateTime(1991, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Софья", 1009, "Алешина" },
                    { 1118, new DateTime(1995, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Тимофей", 1009, "Коновалов" },
                    { 1117, new DateTime(1986, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Анна", 1009, "Воронкова" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "DateOfBirth", "ExamScore", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 1116, new DateTime(1989, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Марк", 1009, "Кудряшов" },
                    { 1115, new DateTime(1992, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Дарья", 1009, "Фокина" },
                    { 1114, new DateTime(1992, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Екатерина", 1009, "Вавилова" },
                    { 1113, new DateTime(1985, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Серафима", 1009, "Волкова" },
                    { 1112, new DateTime(1989, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Вероника", 1009, "Кузнецова" },
                    { 1111, new DateTime(1991, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.8f, "Кирилл", 1009, "Жилин" },
                    { 1110, new DateTime(1986, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.7f, "Николай", 1009, "Исаев" },
                    { 1109, new DateTime(1997, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Павел", 1009, "Медведев" },
                    { 1108, new DateTime(1989, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3f, "Вероника", 1008, "Денисова" },
                    { 1131, new DateTime(1991, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Тимур", 1009, "Новиков" },
                    { 1106, new DateTime(1997, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Арсений", 1008, "Рогов" },
                    { 1132, new DateTime(2000, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Варвара", 1009, "Бирюкова" },
                    { 1134, new DateTime(1995, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.6f, "Иван", 1009, "Богданов" },
                    { 1157, new DateTime(1997, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Фёдор", 1012, "Наумов" },
                    { 1156, new DateTime(2001, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Арина", 1012, "Ларионова" },
                    { 1155, new DateTime(1992, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Константин", 1012, "Киселев" },
                    { 1154, new DateTime(2001, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Алиса", 1012, "Данилова" },
                    { 1153, new DateTime(1991, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Мария", 1012, "Воронова" },
                    { 1152, new DateTime(1998, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Степан", 1011, "Зотов" },
                    { 1151, new DateTime(1995, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.8f, "София", 1011, "Зорина" },
                    { 1150, new DateTime(1988, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.2f, "Даниил", 1011, "Калугин" },
                    { 1149, new DateTime(1989, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Ульяна", 1011, "Соловьева" },
                    { 1148, new DateTime(2001, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Роман", 1011, "Лебедев" },
                    { 1147, new DateTime(1986, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.1f, "Мирон", 1011, "Матвеев" },
                    { 1146, new DateTime(1997, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Илья", 1011, "Леонтьев" },
                    { 1145, new DateTime(2000, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.5f, "Ариана", 1011, "Демидова" },
                    { 1144, new DateTime(1999, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Вячеслав", 1010, "Михайлов" },
                    { 1143, new DateTime(1985, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4f, "Яна", 1010, "Михайлова" },
                    { 1142, new DateTime(1997, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Тимофей", 1010, "Кулаков" },
                    { 1141, new DateTime(1995, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.5f, "Наталья", 1010, "Фомина" },
                    { 1140, new DateTime(1993, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.7f, "Роман", 1010, "Степанов" },
                    { 1139, new DateTime(1994, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.3f, "Даниил", 1010, "Сычев" },
                    { 1138, new DateTime(1991, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.3f, "Кирилл", 1010, "Фадеев" },
                    { 1137, new DateTime(1998, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.6f, "Кира", 1009, "Васильева" },
                    { 1136, new DateTime(1985, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.4f, "Михаил", 1009, "Самсонов" },
                    { 1135, new DateTime(1987, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.9f, "Александр", 1009, "Агапов" },
                    { 1133, new DateTime(1995, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 4.2f, "Давид", 1009, "Гусев" },
                    { 1426, new DateTime(1986, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.9f, "Андрей", 1028, "Егоров" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1426);
        }
    }
}
