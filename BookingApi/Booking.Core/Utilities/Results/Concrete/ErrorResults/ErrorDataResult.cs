using System;

namespace CorePackage.Utilities.Results.Concrete.ErrorResults
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }
    }
}

