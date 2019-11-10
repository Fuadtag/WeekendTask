using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _08_11_2019WeekendTask.Models;

namespace _08_11_2019WeekendTask.DAL
{
    public class _Context:DbContext
    {
        public _Context() : base("Context")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }

        public static implicit operator List<object>(_Context v)
        {
            throw new NotImplementedException();
        }
    }
}