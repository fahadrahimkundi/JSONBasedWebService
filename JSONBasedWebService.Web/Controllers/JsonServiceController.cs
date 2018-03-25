using JSONBasedWebService.Core.Models;
using JSONBasedWebService.Core.Parser;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JSONBasedWebService.Web.Controllers
{
    public class JsonServiceController : ApiController
    {
        readonly IParser _parser;

        public JsonServiceController(IParser parser)
        {
            _parser = parser;
        }

        [Route("~/")]
        public HttpResponseMessage Post(HttpRequestMessage request)
        {
            try
            {
                var jsonString = request.Content.ReadAsStringAsync();

                Response res = _parser.FilterData(jsonString.Result);

                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception e)
            {
                ErrorResponse err = new ErrorResponse()
                {
                    error = "Could not decode request: JSON parsing failed"
                };

                return Request.CreateResponse(HttpStatusCode.BadRequest, err);
            }
        }
    }
}