﻿using Pomelo.AspNetCore.TimedJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseCrawler.Core
{
    public class AnalyzeDoubanJob : Job
    {
        [Invoke(BeginS = "2017-01-01 00:15", Interval = 1000 * 7200, SkipWhileExecuting = true)]
        public void Run()
        {
            //Job要执行的逻辑代码
            DoubanHouseCrawler.AnalyzeDoubanHouseContentAll(true);
        }
    }
}
