using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CleanArch.Application.Services
{
    public class CourseService : ICoursesService
    {

        public CourseService(ICourseRepository courseRepository)
        {
            CourseRepository = courseRepository;
        }

        public ICourseRepository CourseRepository { get; }

        public IEnumerable<CoursesViewModel> GetCourses()
        {
            return CourseRepository.GetCourses().Select(i => 
                   new CoursesViewModel 
                   { 
                       Description=i.Description,
                       Id=i.Id,
                       Name=i.Name,
                       StringUrl=i.StringUrl
                   });
        }
    }
}
