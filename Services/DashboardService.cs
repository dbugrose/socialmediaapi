using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using socialmediaapi.Model;

namespace socialmediaapi.Services
{
    public class DashboardService
    {
        public async Task<DashboardModel> GetDashboard()
        {   DashboardModel dashboard = new DashboardModel
        {
            Facebook = new FacebookModel(),
            Instagram = new InstagramModel(),
            X = new XModel(),
            Youtube = new YoutubeModel()
        };
            return dashboard;
        }
    }
}