using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.sqlRepositories
{
    public class CourseRepositories : ICourseRepository
    {
        public CourseRepositories(UniversityDBContext dBContext)
        {
            DBContext = dBContext;
        }

        public UniversityDBContext DBContext { get; }

        public IEnumerable<Course> GetCourses() => DBContext.Courses;
        
    }
}
