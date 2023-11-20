using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseAcademyContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var result = from co in context.Courses
                             join c in context.Categories
                             on co.CategoryId equals c.CategoryId
                             select new CourseDetailDto
                             {
                                 CourseId = co.CourseId,
                                 CourseName = co.CourseName,
                                 CategoryName = c.CategoryName,
                                 Price = co.Price
                             };

                return result.ToList();
            }
        }
    }
}
