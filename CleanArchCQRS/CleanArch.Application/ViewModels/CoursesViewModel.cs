using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Application.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
