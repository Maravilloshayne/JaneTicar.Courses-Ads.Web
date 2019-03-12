using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Courses
{
    public class UpdateContentViewModel
    {
        public Guid? CourseId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
