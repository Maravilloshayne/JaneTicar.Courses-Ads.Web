﻿using JaneTicar.GradeCourses.Web.Infrastructures.Data.Helpers;
using JaneTicar.GradeCourses.Web.Infrastructures.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.Areas.Manage.ViewModels.Ads
{
    public class IndexViewModel
    {
        public Page<Ad> Ads { get; set; }
    }
}
