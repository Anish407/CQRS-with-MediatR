using CleanArch.Application.ViewModels;
using System.Collections.Generic;

namespace CleanArch.Application.Interfaces
{
    public interface ICoursesService
    {
        IEnumerable<CoursesViewModel> GetCourses();
    }
}
