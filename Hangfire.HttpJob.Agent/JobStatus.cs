﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangfire.HttpJob.Agent
{
    public enum JobStatus
    {
        Stop,
        Running,
        Stopping,
        Stoped,
    }
}