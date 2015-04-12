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
                    Title = "Экзамен",
                    TitleShort = "Экз"
                },
                new TestType
                {
                    TestTypeId = 2,
                    Title = "Зачёт",
                    TitleShort = "Зач"
                },
                new TestType
                {
                    TestTypeId = 3,
                    Title = "Курсовой проект",
                    TitleShort = "Кур"
                },
                new TestType
                {
                    TestTypeId = 4,
                    Title = "Дифференцированный зачёт",
                    TitleShort = "Зач"
                },
                new TestType
                {
                    TestTypeId = 5,
                    Title = "Курсовой проект (недиф)",
                    TitleShort = "Кур"
                },
                new TestType
                {
                    TestTypeId = 6,
                    Title = "Практика",
                    TitleShort = "Прк"
                },
                new TestType
                {
                    TestTypeId = 7,
                    Title = "Практика (недиф)",
                    TitleShort = "Прк"
                }
            };

            context.TestTypes.AddRange(testtypes);
            context.SaveChanges();

            var marks = new List<Mark>
            {
                new Mark{Title = "Отлично", TitleShort = "Отл", GradeMark = 5, TestType = testtypes[0]},
                new Mark{Title = "Отлично", TitleShort = "Отл", GradeMark = 5, TestType = testtypes[2]},
                new Mark{Title = "Отлично", TitleShort = "Отл", GradeMark = 5, TestType = testtypes[3]},
                new Mark{Title = "Отлично", TitleShort = "Отл", GradeMark = 5, TestType = testtypes[5]},
           
                new Mark{Title = "Хорошо", TitleShort = "Хор", GradeMark = 4, TestType = testtypes[0]},
                new Mark{Title = "Хорошо", TitleShort = "Хор", GradeMark = 4, TestType = testtypes[2]},
                new Mark{Title = "Хорошо", TitleShort = "Хор", GradeMark = 4, TestType = testtypes[3]},
                new Mark{Title = "Хорошо", TitleShort = "Хор", GradeMark = 4, TestType = testtypes[5]},
          
                new Mark{Title = "Удовлетворительно", TitleShort = "Удов", GradeMark = 3, TestType = testtypes[2]},
                new Mark{Title = "Удовлетворительно", TitleShort = "Удов", GradeMark = 3, TestType = testtypes[3]},
                new Mark{Title = "Удовлетворительно", TitleShort = "Удов", GradeMark = 3, TestType = testtypes[0]},
                new Mark{Title = "Удовлетворительно", TitleShort = "Удов", GradeMark = 3, TestType = testtypes[5]},
                new Mark{Title = "Зачтено", TitleShort = "Зчт", GradeMark = 3, TestType = testtypes[4]},
                new Mark{Title = "Зачтено", TitleShort = "Зчт", GradeMark = 3, TestType = testtypes[1]},
                new Mark{Title = "Зачтено", TitleShort = "Зчт", GradeMark = 3, TestType = testtypes[6]},
         
                new Mark{Title = "Неудовлетворительно", TitleShort = "Неуд", GradeMark = 2, TestType = testtypes[2]},
                new Mark{Title = "Неудовлетворительно", TitleShort = "Неуд", GradeMark = 2, TestType = testtypes[3]},
                new Mark{Title = "Неудовлетворительно", TitleShort = "Неуд", GradeMark = 2, TestType = testtypes[0]},
                new Mark{Title = "Неудовлетворительно", TitleShort = "Неуд", GradeMark = 2, TestType = testtypes[5]},
                new Mark{Title = "Не зачтено", TitleShort = "Нзч", GradeMark = 2, TestType = testtypes[4]},
                new Mark{Title = "Не зачтено", TitleShort = "Нзч", GradeMark = 2, TestType = testtypes[1]},
                new Mark{Title = "Не зачтено", TitleShort = "Нзч", GradeMark = 2, TestType = testtypes[6]},
        
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[0]},
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[1]},
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[2]},
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[3]},
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[4]},
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[5]},
                new Mark{Title = "Неявка", TitleShort = "Я", GradeMark = 1, TestType = testtypes[6]},
   
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[0]},
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[1]},
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[2]},
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[3]},
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[4]},
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[5]},
                new Mark{Title = "Недопуск деканата", TitleShort = "Д", GradeMark = 0, TestType = testtypes[6]},

                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[0]},
                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[1]},
                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[2]},
                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[3]},
                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[4]},
                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[5]},
                new Mark{Title = "Недопуск кафедры", TitleShort = "Дк", GradeMark = -2, TestType = testtypes[6]},

                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[0]},
                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[1]},
                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[2]},
                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[3]},
                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[4]},
                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[5]},
                new Mark{Title = "Перенос", TitleShort = "П", GradeMark = -3, TestType = testtypes[6]}
            };

            context.Marks.AddRange(marks);
            context.SaveChanges();
        }
    }
}