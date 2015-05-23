using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            var testTypes = PopulateTestTypes(context);

            PopulateMarks(context,testTypes);

            var groups = PopulateGroups(context);

            
            PopulateStudents(context,groups);
            
            PopulateAcademUsers(context);
        }

        private List<TestType> PopulateTestTypes(Contexts.AcademContext context)
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

            return testtypes;
        }

        private  void PopulateMarks(Contexts.AcademContext context, List<TestType> testTypes)
        {
            #region Mark

            foreach (TestType testtype in testTypes)
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
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Отлично",
                    ShortName = "Отл",
                    Grade = 5,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Хорошо",
                    ShortName = "Хор",
                    Grade = 4,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Удовлетворительно",
                    ShortName = "Удов",
                    Grade = 3,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Зачтено",
                    ShortName = "Зчт",
                    Grade = 3,
                    TestType = testTypes[4]
                },
                new Mark
                {
                    Name = "Зачтено",
                    ShortName = "Зчт",
                    Grade = 3,
                    TestType = testTypes[1]
                },
                new Mark
                {
                    Name = "Зачтено",
                    ShortName = "Зчт",
                    Grade = 3,
                    TestType = testTypes[6]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Неудовлетворительно",
                    ShortName = "Неуд",
                    Grade = 2,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Не зачтено",
                    ShortName = "Нзч",
                    Grade = 2,
                    TestType = testTypes[4]
                },
                new Mark
                {
                    Name = "Не зачтено",
                    ShortName = "Нзч",
                    Grade = 2,
                    TestType = testTypes[1]
                },
                new Mark
                {
                    Name = "Не зачтено",
                    ShortName = "Нзч",
                    Grade = 2,
                    TestType = testTypes[6]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[1]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[4]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Неявка",
                    ShortName = "Я",
                    Grade = 1,
                    TestType = testTypes[6]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[1]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[4]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Недопуск деканата",
                    ShortName = "Д",
                    Grade = 0,
                    TestType = testTypes[6]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[1]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[4]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Недопуск кафедры",
                    ShortName = "Дк",
                    Grade = -2,
                    TestType = testTypes[6]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[0]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[1]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[2]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[3]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[4]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[5]
                },
                new Mark
                {
                    Name = "Перенос",
                    ShortName = "П",
                    Grade = -3,
                    TestType = testTypes[6]
                }
            };

            #endregion


            context.Marks.AddRange(marks);
            context.SaveChanges();
        }

        private List<Group> PopulateGroups(Contexts.AcademContext context)
        {
            List<Group> groups = new List<Group>
            {
                new Group
                {
                    GroupGuid = new Guid("47408eda-51d3-11e3-b65b-005056960017"),
                    Name = "ИУ5-123Ц"
                }
            };

            context.Groups.AddRange(groups);
            context.SaveChanges();

            return groups;
        }

        private void PopulateStudents(Contexts.AcademContext context,List<Group> groups)
        {
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
                    Group = groups[0]
                },
                new Student
                {
                    StudentIdentity = new Guid("be83d0ef-86c0-4e53-aaf4-88e1afb1521e"),
                    Firstname = "Сур",
                    Middlename = "Сурович",
                    Lastname = "Суров",
                    Birthdate = new DateTime(1991, 1, 11),
                    Cardnumber = "09Ц001",
                    Group = groups[0]
                }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        private void PopulateAcademUsers(Contexts.AcademContext context)
        {
            var user = new AcademUser
            {
                UserId = new Guid("8483d47b-38eb-4a03-bccc-56ea5be5e70b"),
                Groups = new Collection<Group>()
                
            };

            var group = context.Groups.ToList();

            user.Groups.Add(group[0]);

            context.AcademUsers.Add(user);

            context.SaveChanges();
        }
    }
}