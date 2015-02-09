using InterceptorWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterceptorWeb.Props
{
    public class ControllerExecutionFilter : ActionFilterAttribute
    {
        public TimeSpan ExecutionTime { get; set; }

        private DateTime ExecutionStartTime;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ExecutionStartTime = DateTime.Now;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            ExecutionTime = DateTime.Now - ExecutionStartTime;
            var result = filterContext.Result as ViewResultBase;
            if (result == null)
            {
                return;
            }

            var model = result.Model as HomeViewModel;
            if (model == null)
            {
                return;
            }

            model.Result = ExecutionTime.Milliseconds + " ms";
        }

    }
}