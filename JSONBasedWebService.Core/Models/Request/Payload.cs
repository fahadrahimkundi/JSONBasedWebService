using System.Collections.Generic;

namespace JSONBasedWebService.Core.Models
{
    public class payload
    {
        public payload()
        {
        }

        public string country { get; set; }
        public string description { get; set; }
        public bool drm { get; set; }
        public string genre { get; set; }
        public int episodeCount { get; set; }
        public image image { get; set; }
        public string language { get; set; }
        public nextEpisode nextEpisode { get; set; }
        public string primaryColour { get; set; }
        public List<Season> seasons { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string tvChannel { get; set; }
    }
}