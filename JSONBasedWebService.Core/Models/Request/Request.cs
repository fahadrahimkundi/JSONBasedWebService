using System.Collections.Generic;

namespace JSONBasedWebService.Core.Models
{
    public class Request
    {
        public List<payload> payload { get; set; }
        public int skip { get; set; }
        public int take { get; set; }
        public int totalRecords { get; set; }
    }
}