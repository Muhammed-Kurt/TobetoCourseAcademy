using Core.Utilities.Results.Abstracts;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);

        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetByCategoryId(int categoryId);
        IDataResult<List<Course>> GetByPrice(decimal min, decimal max);
        IDataResult<Course> GetById(int courseId);

        IDataResult<List<CourseDetailDto>> GetCourseDetails();

        //RESTFUL --> HTTP(internet protokolü) --> 
    }
}
