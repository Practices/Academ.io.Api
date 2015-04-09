using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using Academ.io.Models;

namespace Academ.io.Data.StudentContextMigrations
{
    internal sealed class Configuration: DbMigrationsConfiguration<Contexts.StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"StudentContextMigrations";
        }

        protected override void Seed(Contexts.StudentContext context)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    StudentId = new Guid("89889959-faa8-4ad1-abab-b63be64d1b6a"),
                    Firstname = "Тест",
                    Middlename = "Тестович",
                    Lastname = "Тестов",
                    Birthdate = new DateTime(1992, 2, 22),
                    Cardnumber = "09Ц002",
                    Group = "ИУ5-122"
                },
                new Student
                {
                    StudentId = new Guid("be83d0ef-86c0-4e53-aaf4-88e1afb1521e"),
                    Firstname = "Сур",
                    Middlename = "Сурович",
                    Lastname = "Суров",
                    Birthdate = new DateTime(1991, 1, 11),
                    Cardnumber = "09Ц001",
                    Group = "ИУ5-121"
                }
            };

            if(!context.Database.Exists())
            {
                context.Students.AddRange(students);
                context.SaveChanges();
            }
        }
    }
}