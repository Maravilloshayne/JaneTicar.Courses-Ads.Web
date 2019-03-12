using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Courses
{
    public class UpdateYearCourseCodeViewModel
    {
        public Guid? CourseId { get; set; }

        public DateTime Year { get; set; }

        public string CourseCode { get; set; }
    }
}