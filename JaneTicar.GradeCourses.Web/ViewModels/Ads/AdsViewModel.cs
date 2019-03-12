using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.ViewModels.Ads
{
    public class AdsViewModel
    {
        public Guid? AdId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public DateTime PostExpiry { get; set; }

        public bool IsPublished { get; set; }

    }
}
