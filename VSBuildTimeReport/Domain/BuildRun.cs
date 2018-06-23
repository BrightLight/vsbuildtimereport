﻿using System;

namespace VSBuildTimeReport.Domain
{
    public class BuildRun
    {
        public string SolutionName { get; set; }
        public DateTime BuildStarted { get; set; }
        public DateTime BuildEnded { get; set; }
        public long BuiltTimeInSeconds => (BuildEnded - BuildStarted).Seconds;
    }
}