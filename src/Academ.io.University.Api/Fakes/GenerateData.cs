using System;
using System.Collections.Generic;
using Academ.io.Models;
using Academ.io.University.Api.Models;

namespace Academ.io.University.Api.Fakes
{
    public static class GenerateData
    {
        public static List<StudentModel> GetStudents()
        {
            var data = new List<StudentModel>
            {
                new StudentModel
                {
                    StudentId = "89889959-faa8-4ad1-abab-b63be64d1b6a",
                    Firstname = "Иван",
                    Middlename = "Иванович",
                    Lastname = "Иванов",
                    Birthdate = new DateTime(1995, 5, 25),
                    CardNumber = "15Ц001",
                    GroupId = "89889959-faa8-4ad1-abab-b631e64d1b6a",
                    Group = "ИУ5-121"
                },
                new StudentModel
                {
                    StudentId = "89889919-faa8-4ad1-abab-b63be64d1b6a",
                    Firstname = "Андрей",
                    Middlename = "Андреевич",
                    Lastname = "Андреев",
                    Birthdate = new DateTime(1996, 5, 25),
                    CardNumber = "15Ц002",
                    GroupId = "89889959-faa8-4ad1-abab-b631e64d1b1a",
                    Group = "ИУ5-122"
                },
                new StudentModel
                {
                    StudentId = "89189959-faa8-4ad1-abab-563be64d1b6a",
                    Firstname = "Тест",
                    Middlename = "Тестович",
                    Lastname = "Тестов",
                    Birthdate = new DateTime(1992, 2, 22),
                    CardNumber = "09Ц002",
                    GroupId = "89889959-faa8-4ad1-abab-b631e64d1b1a",
                    Group = "ИУ5-122",
                },
                new StudentModel
                {
                    StudentId = "be83d0ef-86c0-4e53-aaf4-88e1afb1521e",
                    Firstname = "Сур",
                    Middlename = "Сурович",
                    Lastname = "Суров",
                    Birthdate = new DateTime(1991, 1, 11),
                    CardNumber = "09Ц001",
                    GroupId = "89889959-faa8-4ad1-a7ab-b631e64d1b6a",
                    Group = "ИУ5-123"
                }
            };
            return data;
        }

        public static List<DisciplineModel> GetDisciplines()
        {
            var data = new List<DisciplineModel>
            {
                new DisciplineModel
                {
                    DisciplineId = new Guid("be0483a0-35a9-11e3-830f-005056960017"),
                    DisciplineName = "Курсовая работа - Надежность и достоверность",
                    DisciplineDepartment = "ИУ5",
                    Mark = 5,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2014, 12, 22),
                    TestType = 3
                },
                new DisciplineModel
                {
                    DisciplineId = new Guid("bde12af4-35a9-11e3-a7ef-005056960017"),
                    DisciplineName = "Курсовая работа -Эргономический анализ систем обработки и отображеия информации",
                    DisciplineDepartment = "ИУ5",
                    Mark = 3,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2015, 02, 02),
                    TestType = 3
                },
                new DisciplineModel
                {
                    DisciplineId = new Guid("bdf7fcca-35a9-11e3-9abc-005056960017"),
                    DisciplineName = "IT-менеджмент",
                    DisciplineDepartment = "ИУ5",
                    Mark = 3,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2014, 12, 23),
                    TestType = 2
                },
                new DisciplineModel
                {
                    DisciplineId = new Guid("bde12cca-35a9-11e3-9fac-005056960017"),
                    DisciplineName = "Эргономический анализ систем обработки и отображения информации",
                    DisciplineDepartment = "ИУ5",
                    Mark = 3,
                    Audlek = 51,
                    Term = 11,
                    TestDate = new DateTime(2015, 01, 15),
                    TestType = 1
                }
            };

            return data;
        } 


    }
}