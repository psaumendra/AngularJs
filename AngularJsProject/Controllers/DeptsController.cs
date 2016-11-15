using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJsProject.Controllers
{
    public class DeptsController : ApiController
    {
        public HttpResponseMessage get()
        {
            string response = "{\"depts\": [{\"DName\": \"CSE\", \"did\": 1, \"teachers\": [{\"name\": \"Teacher1\"},{\"name\": \"teacher2\"}], \"students\": [{\"name\": \"Rakesh\", \"roll\": 12},{\"name\": \"Siba\", \"roll\": 11}]},{\"DName\": \"EEE\", \"did\": 2, \"teachers\": [{\"name\": \"Teacher3\"},{\"name\": \"teacher2\"}], \"students\": [{\"name\": \"Prabhu\", \"roll\": 10},{\"name\": \"Rabi\", \"roll\": 11}]}]}";
            return Request.CreateResponse(HttpStatusCode.OK, (JObject)JsonConvert.DeserializeObject(response));
        }
    }
}
