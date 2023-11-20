using Business.Concretes;
using DataAccess.Concretes;
using Entity.Concretes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            CourseManager courseManager = new CourseManager(new EfCourseDal());
            //Course Test
            CourseGetByIdTest(courseManager);
            //CourseGetAllTest(courseManager);
            //CourseGetByCategoryIdTest(courseManager);
            //CourseGetByPriceTest(courseManager);
            //CourseAddTest(courseManager);
            //CourseUpdateTest(courseManager);
            //CourseDeleteTest(courseManager);
            //CourseGetCourseDetailTest(courseManager);


        }

        private static void CourseGetCourseDetailTest(CourseManager courseManager)
        {
            var result = courseManager.GetCourseDetails();
            if (result == null)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.CourseName + " - " + course.CategoryName + " - " + course.Price);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CourseDeleteTest(CourseManager courseManager)
        {
            Course course = new Course();
            course.CourseId = 6;

            courseManager.Delete(course);
        }

        private static void CourseUpdateTest(CourseManager courseManager)
        {
            Course course = new Course();
            course.CourseId = 6;
            course.CourseName = "PostgreSql";
            course.CategoryId = 2;
            course.Description = "PostgreSQL Temelleri Eğitim Seti";
            course.Price = 6750;

            courseManager.Update(course);
        }

        private static void CourseAddTest(CourseManager courseManager)
        {
            Course course = new Course();
            course.CourseName = "PostgreSQL";
            course.CategoryId = 2;
            course.Description = "PostgreSql Temelleri Eğitim Seti";
            course.Price = 6500;

            courseManager.Add(course);
        }

        private static void CourseGetByPriceTest(CourseManager courseManager)
        {
            var result = courseManager.GetByPrice(6000, 7000);

            if (result.Success==true)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.CourseName + " - " + course.Price);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void CourseGetByCategoryIdTest(CourseManager courseManager)
        {
            var result = courseManager.GetByCategoryId(2);
            if (result.Success==true)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.CourseName + " - " + course.Description);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void CourseGetAllTest(CourseManager courseManager)
        {
            var result = courseManager.GetAll();
            if (result.Success==true)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.CourseName);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CourseGetByIdTest(CourseManager courseManager)
        {
            var result = courseManager.GetById(10);
            if (result.Success==true)
            {
                Console.WriteLine(result.Data.CourseName);
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}