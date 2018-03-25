using System.ComponentModel.DataAnnotations;

namespace JSONBasedWebService.Core.Models
{
    public class ResponseItems
    {
        //[JsonProperty(PropertyName = "FooBar")]
        public string image { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
    }
}
