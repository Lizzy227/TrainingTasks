﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallbacksTask
{
    internal interface ILogger
    {
        void StartLogging();
        void StopLogging();
    }
}
