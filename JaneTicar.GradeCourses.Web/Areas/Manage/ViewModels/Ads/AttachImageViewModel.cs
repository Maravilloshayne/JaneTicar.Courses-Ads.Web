using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Ads
{
    public class AttachImageViewModel
    {
        public Guid? AdId { get; set; }
        public IFormFile Image { get; set; }
    }
}
