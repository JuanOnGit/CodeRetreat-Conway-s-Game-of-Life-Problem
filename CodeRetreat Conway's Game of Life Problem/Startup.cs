using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CodeRetreat_Conway_s_Game_of_Life_Problem.Startup))]

namespace CodeRetreat_Conway_s_Game_of_Life_Problem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
