using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DependencyInjection.Filters
{
	public class StopwatchFilter : IActionFilter
	{
        private StopwatchService watchService;

        public StopwatchFilter(StopwatchService watchService)
        {
            this.watchService = watchService;
        }

		public void OnActionExecuted(ActionExecutedContext context)
		{
			watchService.Lap("Action Executed");
			context.HttpContext.Response.Headers.Add("stopwatch", new string[] { watchService.ToString() });
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			watchService.Start("Action Executing");
		}
	}
}
