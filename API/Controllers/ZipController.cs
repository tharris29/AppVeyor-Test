using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class ZipController : ApiController
    {
        public HttpResponseMessage Post()
        {
            //todo allow upload and zip
            HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            return result;
        } 
    }
}