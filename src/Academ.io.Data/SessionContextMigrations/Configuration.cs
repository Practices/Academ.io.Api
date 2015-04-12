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
                    Title = "�������",
                    TitleShort = "���"
                },
                new TestType
                {
                    TestTypeId = 2,
                    Title = "�����",
                    TitleShort = "���"
                },
                new TestType
                {
                    TestTypeId = 3,
                    Title = "�������� ������",
                    TitleShort = "���"
                },
                new TestType
                {
                    TestTypeId = 4,
                    Title = "������������������ �����",
                    TitleShort = "���"
                },
                new TestType
                {
                    TestTypeId = 5,
                    Title = "�������� ������ (�����)",
                    TitleShort = "���"
                },
                new TestType
                {
                    TestTypeId = 6,
                    Title = "��������",
                    TitleShort = "���"
                },
                new TestType
                {
                    TestTypeId = 7,
                    Title = "�������� (�����)",
                    TitleShort = "���"
                }
            };

            context.TestTypes.AddRange(testtypes);
            context.SaveChanges();

            var marks = new List<Mark>
            {
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 5, TestType = testtypes[0]},
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 5, TestType = testtypes[2]},
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 5, TestType = testtypes[3]},
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 5, TestType = testtypes[5]},
           
                new Mark{Title = "������", TitleShort = "���", GradeMark = 4, TestType = testtypes[0]},
                new Mark{Title = "������", TitleShort = "���", GradeMark = 4, TestType = testtypes[2]},
                new Mark{Title = "������", TitleShort = "���", GradeMark = 4, TestType = testtypes[3]},
                new Mark{Title = "������", TitleShort = "���", GradeMark = 4, TestType = testtypes[5]},
          
                new Mark{Title = "�����������������", TitleShort = "����", GradeMark = 3, TestType = testtypes[2]},
                new Mark{Title = "�����������������", TitleShort = "����", GradeMark = 3, TestType = testtypes[3]},
                new Mark{Title = "�����������������", TitleShort = "����", GradeMark = 3, TestType = testtypes[0]},
                new Mark{Title = "�����������������", TitleShort = "����", GradeMark = 3, TestType = testtypes[5]},
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 3, TestType = testtypes[4]},
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 3, TestType = testtypes[1]},
                new Mark{Title = "�������", TitleShort = "���", GradeMark = 3, TestType = testtypes[6]},
         
                new Mark{Title = "�������������������", TitleShort = "����", GradeMark = 2, TestType = testtypes[2]},
                new Mark{Title = "�������������������", TitleShort = "����", GradeMark = 2, TestType = testtypes[3]},
                new Mark{Title = "�������������������", TitleShort = "����", GradeMark = 2, TestType = testtypes[0]},
                new Mark{Title = "�������������������", TitleShort = "����", GradeMark = 2, TestType = testtypes[5]},
                new Mark{Title = "�� �������", TitleShort = "���", GradeMark = 2, TestType = testtypes[4]},
                new Mark{Title = "�� �������", TitleShort = "���", GradeMark = 2, TestType = testtypes[1]},
                new Mark{Title = "�� �������", TitleShort = "���", GradeMark = 2, TestType = testtypes[6]},
        
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[0]},
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[1]},
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[2]},
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[3]},
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[4]},
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[5]},
                new Mark{Title = "������", TitleShort = "�", GradeMark = 1, TestType = testtypes[6]},
   
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[0]},
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[1]},
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[2]},
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[3]},
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[4]},
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[5]},
                new Mark{Title = "�������� ��������", TitleShort = "�", GradeMark = 0, TestType = testtypes[6]},

                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[0]},
                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[1]},
                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[2]},
                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[3]},
                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[4]},
                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[5]},
                new Mark{Title = "�������� �������", TitleShort = "��", GradeMark = -2, TestType = testtypes[6]},

                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[0]},
                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[1]},
                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[2]},
                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[3]},
                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[4]},
                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[5]},
                new Mark{Title = "�������", TitleShort = "�", GradeMark = -3, TestType = testtypes[6]}
            };

            context.Marks.AddRange(marks);
            context.SaveChanges();
        }
    }
}