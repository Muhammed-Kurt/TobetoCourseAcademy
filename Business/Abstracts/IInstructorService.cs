using Core.Utilities.Results.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IResult Add(Instructor instructor);
        IResult Delete(Instructor instructor);
        IResult Update(Instructor instructor);

        IDataResult<List<Instructor>> GetAll();
        IDataResult<Instructor> GetByInstructorId(int instructorId);
    }
}
