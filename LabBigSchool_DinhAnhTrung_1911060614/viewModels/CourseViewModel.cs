using LabBigSchool_DinhAnhTrung_1911060614.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabBigSchool_DinhAnhTrung_1911060614.viewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}