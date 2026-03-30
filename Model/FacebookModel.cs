using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace socialmediaapi.Model
{
    public class FacebookModel
    {
        [Key]
        public int FacebookId { get; set; } = 1;
        public string? FBUsername {get; set;} = "@nathanf";
        public int FBFollowers { get; set; } = 1987;
        public int FBFollowStats { get; set; } = 12;
        public int FBPageViews { get; set; } = 87;
        public int FBLikes { get; set; } = 52;
        public int FBViewStats { get; set; } = 3;
        public int FBLikeStats { get; set; } = 2;

    }
}