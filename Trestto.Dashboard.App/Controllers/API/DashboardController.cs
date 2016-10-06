using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Trestto.Dashboard.App.Controllers.API
{
    public class DashboardController : ApiController
    {
        [HttpGet]
        public List<string> blablas()
        {
            List<string> lsta = new List<string>();

            lsta.Add("www");
            lsta.Add("ww32w");
            lsta.Add("www2");
            lsta.Add("www1");
            lsta.Add("wwwas");
            lsta.Add("sdasdsad");
            return lsta;
        }
    }
}
