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
                    Name = "�������",
                    ShortName = "���"
                },
                new TestType
                {
                    TestTypeId = 2,
                    Name = "�����",
                    ShortName = "���"
                },
                new TestType
                {
                    TestTypeId = 3,
                    Name = "�������� ������",
                    ShortName = "���"
                },
                new TestType
                {
                    TestTypeId = 4,
                    Name = "������������������ �����",
                    ShortName = "���"
                },
                new TestType
                {
                    TestTypeId = 5,
                    Name = "�������� ������ (�����)",
                    ShortName = "���"
                },
                new TestType
                {
                    TestTypeId = 6,
                    Name = "��������",
                    ShortName = "���"
                },
                new TestType
                {
                    TestTypeId = 7,
                    Name = "�������� (�����)",
                    ShortName = "���"
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
                new Mark{Name = "�������", ShortName = "���", Grade = 5, TestType = testtypes[0]},
                new Mark{Name = "�������", ShortName = "���", Grade = 5, TestType = testtypes[2]},
                new Mark{Name = "�������", ShortName = "���", Grade = 5, TestType = testtypes[3]},
                new Mark{Name = "�������", ShortName = "���", Grade = 5, TestType = testtypes[5]},
           
                new Mark{Name = "������", ShortName = "���", Grade = 4, TestType = testtypes[0]},
                new Mark{Name = "������", ShortName = "���", Grade = 4, TestType = testtypes[2]},
                new Mark{Name = "������", ShortName = "���", Grade = 4, TestType = testtypes[3]},
                new Mark{Name = "������", ShortName = "���", Grade = 4, TestType = testtypes[5]},
          
                new Mark{Name = "�����������������", ShortName = "����", Grade = 3, TestType = testtypes[2]},
                new Mark{Name = "�����������������", ShortName = "����", Grade = 3, TestType = testtypes[3]},
                new Mark{Name = "�����������������", ShortName = "����", Grade = 3, TestType = testtypes[0]},
                new Mark{Name = "�����������������", ShortName = "����", Grade = 3, TestType = testtypes[5]},
                new Mark{Name = "�������", ShortName = "���", Grade = 3, TestType = testtypes[4]},
                new Mark{Name = "�������", ShortName = "���", Grade = 3, TestType = testtypes[1]},
                new Mark{Name = "�������", ShortName = "���", Grade = 3, TestType = testtypes[6]},
         
                new Mark{Name = "�������������������", ShortName = "����", Grade = 2, TestType = testtypes[2]},
                new Mark{Name = "�������������������", ShortName = "����", Grade = 2, TestType = testtypes[3]},
                new Mark{Name = "�������������������", ShortName = "����", Grade = 2, TestType = testtypes[0]},
                new Mark{Name = "�������������������", ShortName = "����", Grade = 2, TestType = testtypes[5]},
                new Mark{Name = "�� �������", ShortName = "���", Grade = 2, TestType = testtypes[4]},
                new Mark{Name = "�� �������", ShortName = "���", Grade = 2, TestType = testtypes[1]},
                new Mark{Name = "�� �������", ShortName = "���", Grade = 2, TestType = testtypes[6]},
        
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[0]},
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[1]},
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[2]},
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[3]},
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[4]},
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[5]},
                new Mark{Name = "������", ShortName = "�", Grade = 1, TestType = testtypes[6]},
   
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[0]},
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[1]},
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[2]},
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[3]},
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[4]},
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[5]},
                new Mark{Name = "�������� ��������", ShortName = "�", Grade = 0, TestType = testtypes[6]},

                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[0]},
                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[1]},
                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[2]},
                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[3]},
                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[4]},
                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[5]},
                new Mark{Name = "�������� �������", ShortName = "��", Grade = -2, TestType = testtypes[6]},

                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[0]},
                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[1]},
                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[2]},
                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[3]},
                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[4]},
                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[5]},
                new Mark{Name = "�������", ShortName = "�", Grade = -3, TestType = testtypes[6]}
            };

            context.Marks.AddRange(marks);
            context.SaveChanges();
        }
    }
}