using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Academ.io.Models;

namespace Academ.io.Data.SessionContextMigrations
{
    internal sealed class Configuration: DbMigrationsConfiguration<Contexts.SessionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"SessionContextMigrations";
        }

        protected override void Seed(Contexts.SessionContext context)
        {
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

            context.TestTypes.AddRange(testtypes);
            context.SaveChanges();

            foreach(TestType testtype in testtypes)
            {
                context.TestTypes.Attach(testtype);
            }

            var marks = new List<Mark>
            {
                new Mark{Name = "Отлично", ShortName = "Отл", Grade = 5, TestType = testtypes[0]},
                new Mark{Name = "Отлично", ShortName = "Отл", Grade = 5, TestType = testtypes[2]},
                new Mark{Name = "Отлично", ShortName = "Отл", Grade = 5, TestType = testtypes[3]},
                new Mark{Name = "Отлично", ShortName = "Отл", Grade = 5, TestType = testtypes[5]},
           
                new Mark{Name = "Хорошо", ShortName = "Хор", Grade = 4, TestType = testtypes[0]},
                new Mark{Name = "Хорошо", ShortName = "Хор", Grade = 4, TestType = testtypes[2]},
                new Mark{Name = "Хорошо", ShortName = "Хор", Grade = 4, TestType = testtypes[3]},
                new Mark{Name = "Хорошо", ShortName = "Хор", Grade = 4, TestType = testtypes[5]},
          
                new Mark{Name = "Удовлетворительно", ShortName = "Удов", Grade = 3, TestType = testtypes[2]},
                new Mark{Name = "Удовлетворительно", ShortName = "Удов", Grade = 3, TestType = testtypes[3]},
                new Mark{Name = "Удовлетворительно", ShortName = "Удов", Grade = 3, TestType = testtypes[0]},
                new Mark{Name = "Удовлетворительно", ShortName = "Удов", Grade = 3, TestType = testtypes[5]},
                new Mark{Name = "Зачтено", ShortName = "Зчт", Grade = 3, TestType = testtypes[4]},
                new Mark{Name = "Зачтено", ShortName = "Зчт", Grade = 3, TestType = testtypes[1]},
                new Mark{Name = "Зачтено", ShortName = "Зчт", Grade = 3, TestType = testtypes[6]},
         
                new Mark{Name = "Неудовлетворительно", ShortName = "Неуд", Grade = 2, TestType = testtypes[2]},
                new Mark{Name = "Неудовлетворительно", ShortName = "Неуд", Grade = 2, TestType = testtypes[3]},
                new Mark{Name = "Неудовлетворительно", ShortName = "Неуд", Grade = 2, TestType = testtypes[0]},
                new Mark{Name = "Неудовлетворительно", ShortName = "Неуд", Grade = 2, TestType = testtypes[5]},
                new Mark{Name = "Не зачтено", ShortName = "Нзч", Grade = 2, TestType = testtypes[4]},
                new Mark{Name = "Не зачтено", ShortName = "Нзч", Grade = 2, TestType = testtypes[1]},
                new Mark{Name = "Не зачтено", ShortName = "Нзч", Grade = 2, TestType = testtypes[6]},
        
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[0]},
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[1]},
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[2]},
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[3]},
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[4]},
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[5]},
                new Mark{Name = "Неявка", ShortName = "Я", Grade = 1, TestType = testtypes[6]},
   
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[0]},
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[1]},
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[2]},
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[3]},
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[4]},
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[5]},
                new Mark{Name = "Недопуск деканата", ShortName = "Д", Grade = 0, TestType = testtypes[6]},

                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[0]},
                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[1]},
                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[2]},
                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[3]},
                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[4]},
                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[5]},
                new Mark{Name = "Недопуск кафедры", ShortName = "Дк", Grade = -2, TestType = testtypes[6]},

                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[0]},
                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[1]},
                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[2]},
                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[3]},
                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[4]},
                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[5]},
                new Mark{Name = "Перенос", ShortName = "П", Grade = -3, TestType = testtypes[6]}
            };

            context.Marks.AddRange(marks);
            context.SaveChanges();
        }
    }
}