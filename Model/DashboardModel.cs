using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace socialmediaapi.Model
{
    public class DashboardModel
    {
        public int Id { get; set; } = 1;
        public string? TotalFollowers {get; set;} = "23,004";
        public FacebookModel Facebook { get; set; }
        public InstagramModel Instagram { get; set; }
        public XModel X { get; set; }
        public YoutubeModel Youtube { get; set; }
    }
}