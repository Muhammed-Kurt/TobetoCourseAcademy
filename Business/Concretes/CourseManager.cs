using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entity.Concretes;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            if (course.CourseName.Length < 2)
            {
                //magic string
                return new ErrorResult(Messages.CourseNameInvalid);
            }

            _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
           _courseDal.Delete(course);
           return new SuccessResult(Messages.CourseDeleted);
        }
        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(), Messages.CourseListed);
        }

        public IDataResult<List<Course>> GetByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == categoryId), Messages.CourseGetByCategoryIdListed);
        }

        public IDataResult<List<Course>> GetByPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.Price >= min && c.Price <= max), Messages.CourseGetByPrice);
        }

        public IDataResult<Course> GetById(int courseId)
        {
            var result = _courseDal.Get(co => co.CourseId == courseId);
            
            return new SuccessDataResult<Course>(_courseDal.Get(co => co.CourseId == courseId), Messages.CourseGetId);
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails(),Messages.CourseDetail);
        }
    }
}
