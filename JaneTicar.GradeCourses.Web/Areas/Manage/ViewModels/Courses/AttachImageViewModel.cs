using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Courses
{
    public class AttachImageViewModel
    {
        public Guid? CourseId { get; set; }
        public IFormFile Image { get; set; }
    }
}
