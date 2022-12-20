using Lesson_17.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Lesson_17.Filters
{
    public class CheckCorrectDataFilter : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is ArgumentOutOfRangeException) { }
        }
    }
}
