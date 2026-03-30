using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socialmediaapi.Model
{
    public class InstagramModel
    {
    [Key]
    public int InstagramId { get; set; } = 1;
    public string? IGUsername {get; set;} = "@realnathanf";
    public string? IGFollowers { get; set; } = "11k";
    public int IGFollowStats { get; set; } = 1099;
    public int IGLikes { get; set; } = 5462;
    public string? IGPageViews { get; set; } = "52k";
    public int IGLikeStats { get; set; } = 2257;
    public int IGViewStats { get; set; } = 1375;
    }
}