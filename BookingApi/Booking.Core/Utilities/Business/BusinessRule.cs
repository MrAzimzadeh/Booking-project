using CorePackage.Utilities.Results.Abstract;
using CorePackage.Utilities.Results.Concrete.ErrorResults;
using CorePackage.Utilities.Results.Concrete.SuccessResults;
using System;

namespace CorePackage.Utilities.Business
{
    public class BusinessRule
    {
        public static IResult CheckRules(params IResult[] logic)
        {
            foreach (var method in logic)
            {
                if (!method.Success)
                {
                    return new ErrorResult();
                }
            }
            return new SuccessResult();
        }
    }
}

