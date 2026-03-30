using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socialmediaapi.Model
{
    public class YoutubeModel
    {
    [Key]
    public int YoutubeId { get; set; } = 1;
    public string? YTUsername {get; set;} = "Nathan F.";
    public int YTFollowers { get; set; } = 8239;
    public int YTFollowStats { get; set; } = 144;
    public int YTLikes { get; set; } = 107;
    public int YTTotalViews { get; set; } = 1407;
    public int YTLikeStats { get; set; } = 19;
    public int YTViewStats { get; set; } = 12;
    }
}