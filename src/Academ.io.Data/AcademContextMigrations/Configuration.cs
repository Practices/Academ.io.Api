using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using Academ.io.Models;

namespace Academ.io.Data.AcademContextMigrations
{
    internal sealed class Configuration: DbMigrationsConfiguration<Contexts.AcademContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"AcademContextMigrations";
        }

        protected override void Seed(Contexts.AcademContext context)
        {
            #region TestType

            var testtypes = new List<TestType>
            {
                new TestType
                {
                    TestTypeId = 1,
                    Name = "Экзамен",
                    ShortName = "Экз"
                },
                new TestType
                {
                    TestTypeId = 2,
                    Name = "Зачёт",
                    ShortName = "Зач"
                },
                new TestType
                {
                    TestTypeId = 3,
                    Name = "Курсовой проект",
                    ShortName = "Кур"
                },
                new TestType
                {
                    TestTypeId = 4,
                    Name = "Дифференцированный зачёт",
                    ShortName = "Зач"
                },
                new TestType
                {
                    TestTypeId = 5,
                    Name = "Курсовой проект (недиф)",
                    ShortName = "Кур"
                },
                new TestType
                {
                    TestTypeId = 6,
                    Name = "Практика",
                    ShortName = "Прк"
                },
                new TestType
                {
                    TestTypeId = 7,
                    Name = "Практика (недиф)",
                    ShortName = "Прк"
                }
            };

            #endregion


            context.TestTypes.AddRange(testtypes);
            context.SaveChanges();

            #region Mark

            foreach(TestType testtype in testtypes)
            {
                context.TestTypes.Attach(testtype);
            }

            var marks = new List<Mark>
            {
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Зачтено",
                    ShortName = "Зчт",
                    Grade = 3,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "Зачтено",
                    ShortName = "Зчт",
                    Grade = 3,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "Зачтено",
                    ShortName = "Зчт",
                    Grade = 3,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Не зачтено",
                    ShortName = "Нзч",
                    Grade = 2,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "Не зачтено",
                    ShortName = "Нзч",
                    Grade = 2,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "Не зачтено",
                    ShortName = "Нзч",
                    Grade = 2,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testtypes[6]
                }
            };

            #endregion


            context.Marks.AddRange(marks);
            context.SaveChanges();

            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentIdentity = new Guid("89889959-faa8-4ad1-abab-b63be64d1b6a"),
                    Firstname = "Тест",
                    Middlename = "Тестович",
                    Lastname = "Тестов",
                    Birthdate = new DateTime(1992, 2, 22),
                    Cardnumber = "09Ц002",
                    Group = "ИУ5-122"
                },
                new Student
                {
                    StudentIdentity = new Guid("be83d0ef-86c0-4e53-aaf4-88e1afb1521e"),
                    Firstname = "Сур",
                    Middlename = "Сурович",
                    Lastname = "Суров",
                    Birthdate = new DateTime(1991, 1, 11),
                    Cardnumber = "09Ц001",
                    Group = "ИУ5-121"
                }
            };

            var user = new AcademUser
            {
                UserId = new Guid("8483d47b-38eb-4a03-bccc-56ea5be5e70b")
            };

            context.Students.AddRange(students);
            context.SaveChanges();

            students = context.Students.ToList();

            user.Students.Add(students[0]);

            context.AcademUsers.Add(user);

            context.SaveChanges();
        }
    }
}