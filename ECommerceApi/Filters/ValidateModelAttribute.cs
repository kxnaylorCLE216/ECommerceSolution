using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ECommerceApi.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public bool IncludeModelState { get; set; } = false;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                if (IncludeModelState)
                {
                    context.Result = new BadRequestObjectResult(context.ModelState);
                }
                else
                {
                    context.Result = new BadRequestResult();
                }
            }
        }
    }
}