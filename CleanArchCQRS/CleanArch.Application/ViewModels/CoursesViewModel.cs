using CleanArch.Domain.Models;
using System.Collections.Generic;

namespace CleanArch.Application.ViewModels
{
    public class CoursesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StringUrl { get; set; }
    }
}
