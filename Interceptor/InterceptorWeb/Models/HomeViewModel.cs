using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterceptorWeb.Models
{
    public class HomeViewModel
    {
        public string   Result { get; set; }

        public HomeViewModel(string res)
        {
            Result = res;
        }
    
    }


}