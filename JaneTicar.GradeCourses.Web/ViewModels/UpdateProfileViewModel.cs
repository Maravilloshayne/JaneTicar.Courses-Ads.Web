using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaneTicar.GradeCourses.Web.ViewModels
{
    public class UpdateProfileViewModel
    {
        public Guid? UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}