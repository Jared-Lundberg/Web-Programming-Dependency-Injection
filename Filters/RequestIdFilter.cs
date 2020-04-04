using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DependencyInjection.Filters
{
	public class RequestIdFilter : IActionFilter
    {
		private string localId;

        private ILogger logger;

		public RequestIdFilter(IRequestIdGenerator localId, ILogger logger)
		{
			this.localId = localId.RequestId;
            this.logger = logger;
        }

		public void OnActionExecuted(ActionExecutedContext context)
		{
			logger.Log("Adding a request-id to the response: " + localId);
			context.HttpContext.Response.Headers.Add("request-id", new string[] { localId });
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			
		}
	}
}
