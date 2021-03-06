﻿using System;
using System.Collections.Generic;

namespace Logger
{
    public interface ILogger
    {
        void Info(string msg, Dictionary<string, object> args = null);

        void Error(string msg, Dictionary<string, object> args = null);
    }
}
