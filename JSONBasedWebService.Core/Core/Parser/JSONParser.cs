using JSONBasedWebService.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JSONBasedWebService.Core.Parser
{
    public class JSONParser : IParser
    {
        public Response FilterData(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }
            else
            {
                JsonSerializerSettings settings = new JsonSerializerSettings()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                Request results = JsonConvert.DeserializeObject<Request>(data, settings);

                if (results != null && results.payload != null)
                {
                    List<payload> validPayloads = results.payload.Where(p => p.drm && p.episodeCount > 0).ToList<payload>();

                    List<ResponseItems> responseItems = validPayloads.Select(p => new ResponseItems()
                    {
                        image = p.image.showImage,
                        slug = p.slug,
                        title = p.title
                    }).ToList();

                    Response res = new Response()
                    {
                        response = responseItems
                    };

                    return res;
                }
                else
                {
                    throw new ArgumentNullException("payload not found");
                }
            }
        }
    }
}