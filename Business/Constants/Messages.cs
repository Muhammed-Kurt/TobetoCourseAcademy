using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //Success Messages
        public static string CourseAdded = "Course Successfully Added";
        public static string CourseDeleted = "Course Successfully Deleted";
        public static string CourseUpdated = "Course Successfully Updated";
        public static string CourseNameInvalid = "Course Name Invalid";
        public static string CourseListed = "Course Listed";
        public static string CourseGetByCategoryIdListed = "Course Data Listed By CategoryID ";
        public static string CourseGetByPrice = "Course Listed By Price";
        public static string CourseGetId = "Course Listed By Id";
        public static string CourseDetail = "Course Listed By Details";

        public static string InstructorAdded = "Instructor Successfully Added";
        public static string InstructorDeleted = "Instructor Successfully Deleted";
        public static string InstructorUpdated = "Instructor Successfully Updated";
        public static string InstructorGetId = "Intructor Listed By Id";
        public static string InstructorListed = "Instructor Listed";

        public static string CategoryAdded = "Category Successfully Added";
        public static string CategoryDeleted = "Category Successfully Deleted";
        public static string CategoryUpdated = "Category Successfully Updated";
        public static string CategoryGetId = "Category Listed By Id";
        public static string CategoryListed = "Category Listed";
        //Error Messages
        public static string MaintenanceTime = "Maintenance Time";
    }
}
