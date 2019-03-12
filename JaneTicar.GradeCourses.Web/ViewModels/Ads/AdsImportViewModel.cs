using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.ViewModels.Ads
{
    public class AdsImportViewModel
    {
        public Guid? Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

    }
}