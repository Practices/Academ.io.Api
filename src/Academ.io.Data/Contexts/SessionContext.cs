﻿using System.Data.Entity;
using Academ.io.Models;

namespace Academ.io.Data.Contexts
{
    public class SessionContext: DbContext
    {
        public SessionContext()
                : base("AcademContext")
        {
        }

        public DbSet<Mark> Marks { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
    }
}