using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace zip_it_api.Controllers
{
    public class ZipController : ApiController
    {
        // Post api/zip
        public IEnumerable<string> Post()
        {//todo actually zip somthing with params
            return new string[] { "value1", "value2" };
        }
    }
}
