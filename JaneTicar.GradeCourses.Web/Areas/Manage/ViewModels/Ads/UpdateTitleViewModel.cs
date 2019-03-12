using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Ads
{
    public class UpdateTitleViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public DateTime PostExpiry { get; set; }
    }
}