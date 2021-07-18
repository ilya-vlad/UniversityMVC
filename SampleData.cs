﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Models;

namespace MVC
{
    public class SampleData
    {
        public static void Initialize(UniversityContext context)
        {
            if (!context.Courses.Any())
            {
                context.Courses.AddRange(
                    new Course
                    {
                        Name = "Математика",
                        Description = "Царица наук"
                    },
                    new Course
                    {
                        Name = "Физика",
                        Description = "Основа всего"
                    },
                    new Course
                    {
                        Name = "Физкультура",
                        Description = "В здоровом теле - здоровый дух"
                    },
                    new Course
                    {
                        Name = "История",
                        Description = "У того, кто не знает прошлого - нет будущего"
                    }
                );
                context.SaveChanges();
            }

            if (!context.Groups.Any())
            {
                context.Groups.AddRange(
                    new Group { CourseId = 1, Name = "КБ-101"},
                    new Group { CourseId = 2, Name = "ЛП-102"},
                    new Group { CourseId = 3, Name = "РР-103"},
                    new Group { CourseId = 2, Name = "РС-104"},
                    new Group { CourseId = 1, Name = "РА-105"},
                    new Group { CourseId = 3, Name = "РА-202"},
                    new Group { CourseId = 4, Name = "АР-203"},
                    new Group { CourseId = 4, Name = "РА-204"},
                    new Group { CourseId = 1, Name = "НК-205"},
                    new Group { CourseId = 3, Name = "БК-301"},
                    new Group { CourseId = 4, Name = "РА-353"},
                    new Group { CourseId = 1, Name = "РА-333"},
                    new Group { CourseId = 3, Name = "ВП-322"},
                    new Group { CourseId = 3, Name = "УЦ-311"},
                    new Group { CourseId = 1, Name = "МВ-354"},
                    new Group { CourseId = 3, Name = "РА-344"}
                );
                context.SaveChanges();
            }

            if (!context.Students.Any())
            {
                context.Students.AddRange(                 
                    new Student { GroupId = 1, FirstName = "Иван", LastName = "Егоров" },
                    new Student { GroupId = 1, FirstName = "Полина", LastName = "Колесникова" },
                    new Student { GroupId = 1, FirstName = "София", LastName = "Кузнецова" },
                    new Student { GroupId = 1, FirstName = "Юрий", LastName = "Севастьянов" },                  
                    new Student { GroupId = 1, FirstName = "Елизавета", LastName = "Зубкова" },
                    new Student { GroupId = 1, FirstName = "Татьяна", LastName = "Баранова" },
                    new Student { GroupId = 1, FirstName = "Эмин", LastName = "Антипов" },
                    new Student { GroupId = 1, FirstName = "Яна", LastName = "Белякова" },
                    new Student { GroupId = 2, FirstName = "Вера", LastName = "Михайлова" },
                    new Student { GroupId = 2, FirstName = "Александр", LastName = "Копылов" },
                    new Student { GroupId = 2, FirstName = "Тимофей", LastName = "Зайцев" },
                    new Student { GroupId = 2, FirstName = "Влада", LastName = "Кузнецова" },                   
                    new Student { GroupId = 2, FirstName = "Кирилл", LastName = "Андреев" },
                    new Student { GroupId = 2, FirstName = "Мария", LastName = "Ефимова" },
                    new Student { GroupId = 2, FirstName = "Александр", LastName = "Власов" },
                    new Student { GroupId = 2, FirstName = "Валерия", LastName = "Афанасьева" },
                    new Student { GroupId = 2, FirstName = "Максим", LastName = "Кузин" },
                    new Student { GroupId = 2, FirstName = "Ксения", LastName = "Родина" },
                    new Student { GroupId = 2, FirstName = "Вероника", LastName = "Мальцева" },
                    new Student { GroupId = 3, FirstName = "Данил", LastName = "Вишневский" },
                    new Student { GroupId = 3, FirstName = "Василиса", LastName = "Федорова" },
                    new Student { GroupId = 3, FirstName = "Ксения", LastName = "Ефимова" },
                    new Student { GroupId = 3, FirstName = "Ева", LastName = "Семенова" },
                    new Student { GroupId = 3, FirstName = "Ульяна", LastName = "Лазарева" },
                    new Student { GroupId = 3, FirstName = "Артур", LastName = "Нечаев" },
                    new Student { GroupId = 3, FirstName = "Алиса", LastName = "Романова" },               
                    new Student { GroupId = 3, FirstName = "Владислав", LastName = "Коротков" },
                    new Student { GroupId = 3, FirstName = "Софья", LastName = "Грачева" },
                    new Student { GroupId = 3, FirstName = "Ева", LastName = "Новикова" },
                    new Student { GroupId = 3, FirstName = "Милана", LastName = "Калашникова" },
                    new Student { GroupId = 3, FirstName = "Варвара", LastName = "Антонова" },
                    new Student { GroupId = 3, FirstName = "Кирилл", LastName = "Гаврилов" },            
                    new Student { GroupId = 4, FirstName = "Мария", LastName = "Пименова" },
                    new Student { GroupId = 4, FirstName = "Марк", LastName = "Лавров" },
                    new Student { GroupId = 4, FirstName = "Тимофей", LastName = "Дмитриев" },
                    new Student { GroupId = 4, FirstName = "Елизавета", LastName = "Николаева" },
                    new Student { GroupId = 4, FirstName = "Валерия", LastName = "Иванова" },
                    new Student { GroupId = 4, FirstName = "Богдан", LastName = "Рыжов" },
                    new Student { GroupId = 4, FirstName = "Виктория", LastName = "Сергеева" },
                    new Student { GroupId = 4, FirstName = "Зоя", LastName = "Швецова" },
                    new Student { GroupId = 4, FirstName = "Мария", LastName = "Морозова" },
                    new Student { GroupId = 4, FirstName = "Степан", LastName = "Егоров" },
                    new Student { GroupId = 4, FirstName = "Яна", LastName = "Кудрявцева" },
                    new Student { GroupId = 4, FirstName = "Савва", LastName = "Крылов" },
                    new Student { GroupId = 4, FirstName = "Егор", LastName = "Андреев" },           
                    new Student { GroupId = 5, FirstName = "Артём", LastName = "Киселев" },
                    new Student { GroupId = 5, FirstName = "Стефания", LastName = "Данилова" },
                    new Student { GroupId = 5, FirstName = "Пётр", LastName = "Михайлов" },
                    new Student { GroupId = 5, FirstName = "Сафия", LastName = "Прохорова" },
                    new Student { GroupId = 5, FirstName = "Оливия", LastName = "Яковлева" },
                    new Student { GroupId = 5, FirstName = "Анастасия", LastName = "Матвеева" },
                    new Student { GroupId = 5, FirstName = "Анна", LastName = "Карасева" },
                    new Student { GroupId = 5, FirstName = "Даниил", LastName = "Климов" },
                    new Student { GroupId = 5, FirstName = "Никита", LastName = "Громов" },
                    new Student { GroupId = 5, FirstName = "Ксения", LastName = "Васильева" },
                    new Student { GroupId = 5, FirstName = "Маргарита", LastName = "Михайлова" },
                    new Student { GroupId = 5, FirstName = "Алина", LastName = "Старостина" },
                    new Student { GroupId = 5, FirstName = "Мирон", LastName = "Щербаков" },
                    new Student { GroupId = 5, FirstName = "Тимур", LastName = "Титов" },
                    new Student { GroupId = 5, FirstName = "Марьяна", LastName = "Гришина" },
                    new Student { GroupId = 5, FirstName = "Лука", LastName = "Виноградов" },
                    new Student { GroupId = 5, FirstName = "Артём", LastName = "Минаев" },
                    new Student { GroupId = 5, FirstName = "Пётр", LastName = "Ермаков" },
                    new Student { GroupId = 5, FirstName = "Ольга", LastName = "Ковалева" },
                    new Student { GroupId = 5, FirstName = "Есения", LastName = "Шарова" },
                    new Student { GroupId = 6, FirstName = "Марина", LastName = "Соболева" },
                    new Student { GroupId = 6, FirstName = "Марсель", LastName = "Галкин" },              
                    new Student { GroupId = 6, FirstName = "Анастасия", LastName = "Егорова" },
                    new Student { GroupId = 6, FirstName = "Лев", LastName = "Кочетков" },           
                    new Student { GroupId = 7, FirstName = "Максим", LastName = "Сурков" },
                    new Student { GroupId = 7, FirstName = "Софья", LastName = "Свешникова" },
                    new Student { GroupId = 7, FirstName = "Иван", LastName = "Журавлев" },
                    new Student { GroupId = 7, FirstName = "Григорий", LastName = "Макаров" },
                    new Student { GroupId = 7, FirstName = "Лука", LastName = "Бородин" },
                    new Student { GroupId = 7, FirstName = "Вероника", LastName = "Комарова" },          
                    new Student { GroupId = 7, FirstName = "Александра", LastName = "Шаповалова" },
                    new Student { GroupId = 7, FirstName = "Иван", LastName = "Крылов" },
                    new Student { GroupId = 7, FirstName = "Арина", LastName = "Горшкова" },
                    new Student { GroupId = 7, FirstName = "Артём", LastName = "Коротков" },
                    new Student { GroupId = 7, FirstName = "Евгения", LastName = "Скворцова" },             
                    new Student { GroupId = 8, FirstName = "Дарья", LastName = "Горбунова" },
                    new Student { GroupId = 8, FirstName = "Степан", LastName = "Крылов" },
                    new Student { GroupId = 8, FirstName = "Диана", LastName = "Соколова" },
                    new Student { GroupId = 8, FirstName = "Екатерина", LastName = "Алексеева" },
                    new Student { GroupId = 8, FirstName = "Маргарита", LastName = "Малышева" },
                    new Student { GroupId = 8, FirstName = "Виктор", LastName = "Шевцов" },
                    new Student { GroupId = 8, FirstName = "Вера", LastName = "Любимова" },            
                    new Student { GroupId = 9, FirstName = "Давид", LastName = "Александров" },
                    new Student { GroupId = 9, FirstName = "Георгий", LastName = "Власов" },
                    new Student { GroupId = 9, FirstName = "Артём", LastName = "Капустин" },
                    new Student { GroupId = 9, FirstName = "Адам", LastName = "Лукьянов" },
                    new Student { GroupId = 9, FirstName = "Егор", LastName = "Тихонов" },
                    new Student { GroupId = 9, FirstName = "Ярослав", LastName = "Никитин" },
                    new Student { GroupId = 9, FirstName = "Ариана", LastName = "Иванова" },
                    new Student { GroupId = 9, FirstName = "Кира", LastName = "Герасимова" },
                    new Student { GroupId = 9, FirstName = "Михаил", LastName = "Никифоров" },
                    new Student { GroupId = 9, FirstName = "Лидия", LastName = "Анисимова" },
                    new Student { GroupId = 9, FirstName = "Ксения", LastName = "Медведева" },
                    new Student { GroupId = 9, FirstName = "Тимофей", LastName = "Лаптев" },
                    new Student { GroupId = 9, FirstName = "Артемий", LastName = "Казаков" },
                    new Student { GroupId = 9, FirstName = "Ульяна", LastName = "Казакова" },
                    new Student { GroupId = 9, FirstName = "Игорь", LastName = "Васильев" },
                    new Student { GroupId = 9, FirstName = "Кирилл", LastName = "Романов" },
                    new Student { GroupId = 9, FirstName = "Анастасия", LastName = "Васильева" },
                    new Student { GroupId = 9, FirstName = "Арина", LastName = "Субботина" },
                    new Student { GroupId = 9, FirstName = "Александр", LastName = "Родионов" },
                    new Student { GroupId = 9, FirstName = "Лев", LastName = "Курочкин" },
                    new Student { GroupId = 10, FirstName = "Михаил", LastName = "Захаров" },
                    new Student { GroupId = 10, FirstName = "Мирослав", LastName = "Матвеев" },
                    new Student { GroupId = 10, FirstName = "Михаил", LastName = "Романов" },
                    new Student { GroupId = 10, FirstName = "Виктор", LastName = "Савельев" },
                    new Student { GroupId = 10, FirstName = "Айлин", LastName = "Корнеева" },
                    new Student { GroupId = 10, FirstName = "Милана", LastName = "Калашникова" },
                    new Student { GroupId = 10, FirstName = "Лидия", LastName = "Попова" },               
                    new Student { GroupId = 11, FirstName = "Максим", LastName = "Коновалов" },
                    new Student { GroupId = 11, FirstName = "София", LastName = "Романова" },
                    new Student { GroupId = 11, FirstName = "Марина", LastName = "Власова" },
                    new Student { GroupId = 11, FirstName = "Константин", LastName = "Николаев" },
                    new Student { GroupId = 11, FirstName = "Лев", LastName = "Леонтьев" },
                    new Student { GroupId = 11, FirstName = "Николь", LastName = "Егорова" },
                    new Student { GroupId = 11, FirstName = "Анастасия", LastName = "Белоусова" },
                    new Student { GroupId = 11, FirstName = "Дмитрий", LastName = "Федоров" },
                    new Student { GroupId = 12, FirstName = "Егор", LastName = "Герасимов" },
                    new Student { GroupId = 12, FirstName = "Варвара", LastName = "Галкина" },
                    new Student { GroupId = 12, FirstName = "Алиса", LastName = "Суханова" },
                    new Student { GroupId = 12, FirstName = "Александр", LastName = "Ефимов" },
                    new Student { GroupId = 12, FirstName = "Виктория", LastName = "Иванова" },
                    new Student { GroupId = 12, FirstName = "Алиса", LastName = "Медведева" },
                    new Student { GroupId = 12, FirstName = "Фёдор", LastName = "Кузьмин" },
                    new Student { GroupId = 12, FirstName = "Дмитрий", LastName = "Антонов" },             
                    new Student { GroupId = 12, FirstName = "Иван", LastName = "Новиков" },
                    new Student { GroupId = 12, FirstName = "Анастасия", LastName = "Баранова" },
                    new Student { GroupId = 12, FirstName = "Мария", LastName = "Титова" },
                    new Student { GroupId = 12, FirstName = "Мирослава", LastName = "Золотова" },
                    new Student { GroupId = 13, FirstName = "Анна", LastName = "Данилова" },
                    new Student { GroupId = 13, FirstName = "Дмитрий", LastName = "Соловьев" },
                    new Student { GroupId = 13, FirstName = "Кирилл", LastName = "Виноградов" },
                    new Student { GroupId = 13, FirstName = "Ева", LastName = "Макарова" },
                    new Student { GroupId = 13, FirstName = "Савелий", LastName = "Филатов" },
                    new Student { GroupId = 13, FirstName = "Софья", LastName = "Сычева" },
                    new Student { GroupId = 13, FirstName = "Степан", LastName = "Сергеев" },
                    new Student { GroupId = 13, FirstName = "Вероника", LastName = "Иванова" },
                    new Student { GroupId = 13, FirstName = "Василиса", LastName = "Малышева" },
                    new Student { GroupId = 13, FirstName = "Платон", LastName = "Демин" },
                    new Student { GroupId = 13, FirstName = "Максим", LastName = "Тихонов" },
                    new Student { GroupId = 13, FirstName = "Ярослав", LastName = "Юдин" },
                    new Student { GroupId = 13, FirstName = "Елизавета", LastName = "Серова" },           
                    new Student { GroupId = 14, FirstName = "Макар", LastName = "Киселев" },
                    new Student { GroupId = 14, FirstName = "Арсений", LastName = "Николаев" },               
                    new Student { GroupId = 14, FirstName = "Артём", LastName = "Петров" },
                    new Student { GroupId = 14, FirstName = "Софья", LastName = "Тихонова" },
                    new Student { GroupId = 14, FirstName = "Максим", LastName = "Богданов" },
                    new Student { GroupId = 14, FirstName = "София", LastName = "Власова" },
                    new Student { GroupId = 14, FirstName = "Константин", LastName = "Антипов" },
                    new Student { GroupId = 15, FirstName = "Лилия", LastName = "Овчинникова" },
                    new Student { GroupId = 15, FirstName = "Варвара", LastName = "Филиппова" },
                    new Student { GroupId = 15, FirstName = "Никита", LastName = "Попов" },
                    new Student { GroupId = 15, FirstName = "Дарья", LastName = "Герасимова" },
                    new Student { GroupId = 15, FirstName = "Арина", LastName = "Филатова" },
                    new Student { GroupId = 15, FirstName = "Анастасия", LastName = "Семенова" },
                    new Student { GroupId = 15, FirstName = "Вероника", LastName = "Корнеева" },
                    new Student { GroupId = 15, FirstName = "Лев", LastName = "Фадеев" },
                    new Student { GroupId = 15, FirstName = "Виктория", LastName = "Павлова" },
                    new Student { GroupId = 15, FirstName = "Мария", LastName = "Демина" },
                    new Student { GroupId = 15, FirstName = "Милана", LastName = "Гришина" },
                    new Student { GroupId = 15, FirstName = "Степан", LastName = "Куликов" },         
                    new Student { GroupId = 16, FirstName = "Полина", LastName = "Демидова" },
                    new Student { GroupId = 16, FirstName = "Мария", LastName = "Афанасьева" },
                    new Student { GroupId = 16, FirstName = "Екатерина", LastName = "Петрова" },
                    new Student { GroupId = 16, FirstName = "Лев", LastName = "Беляев" },
                    new Student { GroupId = 16, FirstName = "Богдан", LastName = "Григорьев" },
                    new Student { GroupId = 16, FirstName = "Сергей", LastName = "Зеленин" },
                    new Student { GroupId = 16, FirstName = "Филипп", LastName = "Латышев" },
                    new Student { GroupId = 16, FirstName = "Анна", LastName = "Лукина" },
                    new Student { GroupId = 16, FirstName = "Евгения", LastName = "Шульгина" },
                    new Student { GroupId = 16, FirstName = "Василиса", LastName = "Белова" },
                    new Student { GroupId = 16, FirstName = "Владимир", LastName = "Емельянов" }
                );
                context.SaveChanges();
            }
        }
    }
}
