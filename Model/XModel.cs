using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socialmediaapi.Model
{
    public class XModel
    {
    [Key]
    public int XId { get; set; } 
    public int XFollowers { get; set; } = 1044;
    public int XFollowStats { get; set; } = 99;
    public int XRetweets { get; set; } = 117;
    public int XLikes { get; set; } = 507;
    public int XRetweetStats { get; set; } = 303;
    public int XLikeStats { get; set; } = 553;
    }
}