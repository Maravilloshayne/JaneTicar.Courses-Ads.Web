﻿using JaneTicar.GradeCourses.Web.Infrastructures.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Infrastructures.Data.Models
{
    public class Course : BaseModel
    {
        public string Title { get; set; }

        public DateTime Year { get; set; }

        public string CourseCode { get; set; }

        public string Content { get; set; }

        public string Description { get; set; }

        public string TemplateName { get; set; }

        public DateTime PostExpiry { get; set; }

        public bool IsPublished { get; set; }



    }
}