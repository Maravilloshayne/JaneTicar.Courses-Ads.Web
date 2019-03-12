using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Courses
{
    public class UpdateDescriptionViewModel
    {
        public Guid? CourseId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}