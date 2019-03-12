using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.ViewModels.Courses
{
    public class CoursesImportViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

    }
}