using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstracts;

namespace Core.Utilities.Results.Concretes
{
    public class Result : IResult
    {
        //Getter readonlydir ve constructor içerisinde set edilebilirler.
        public Result(bool success,string message) : this(success) 
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;

        }

        public bool Success { get; }
        public string Message { get; }
    }
}
