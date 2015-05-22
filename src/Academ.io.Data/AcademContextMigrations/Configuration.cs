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
                    Name = "�������",
                    ShortName = "���",
                    Grade = 5,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "���",
                    Grade = 5,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "���",
                    Grade = 5,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "���",
                    Grade = 5,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "���",
                    Grade = 4,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "���",
                    Grade = 4,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "���",
                    Grade = 4,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "���",
                    Grade = 4,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "�����������������",
                    ShortName = "����",
                    Grade = 3,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "�����������������",
                    ShortName = "����",
                    Grade = 3,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "�����������������",
                    ShortName = "����",
                    Grade = 3,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "�����������������",
                    ShortName = "����",
                    Grade = 3,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "���",
                    Grade = 3,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "���",
                    Grade = 3,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "���",
                    Grade = 3,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "�������������������",
                    ShortName = "����",
                    Grade = 2,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "�������������������",
                    ShortName = "����",
                    Grade = 2,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "�������������������",
                    ShortName = "����",
                    Grade = 2,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "�������������������",
                    ShortName = "����",
                    Grade = 2,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "�� �������",
                    ShortName = "���",
                    Grade = 2,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "�� �������",
                    ShortName = "���",
                    Grade = 2,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "�� �������",
                    ShortName = "���",
                    Grade = 2,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "������",
                    ShortName = "�",
                    Grade = 1,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "�������� ��������",
                    ShortName = "�",
                    Grade = 0,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "�������� �������",
                    ShortName = "��",
                    Grade = -2,
                    TestType = testtypes[6]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
                    Grade = -3,
                    TestType = testtypes[0]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
                    Grade = -3,
                    TestType = testtypes[1]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
                    Grade = -3,
                    TestType = testtypes[2]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
                    Grade = -3,
                    TestType = testtypes[3]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
                    Grade = -3,
                    TestType = testtypes[4]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
                    Grade = -3,
                    TestType = testtypes[5]
                },
                new Mark
                {
                    Name = "�������",
                    ShortName = "�",
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
                    Firstname = "����",
                    Middlename = "��������",
                    Lastname = "������",
                    Birthdate = new DateTime(1992, 2, 22),
                    Cardnumber = "09�002",
                    Group = "��5-122"
                },
                new Student
                {
                    StudentIdentity = new Guid("be83d0ef-86c0-4e53-aaf4-88e1afb1521e"),
                    Firstname = "���",
                    Middlename = "�������",
                    Lastname = "�����",
                    Birthdate = new DateTime(1991, 1, 11),
                    Cardnumber = "09�001",
                    Group = "��5-121"
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