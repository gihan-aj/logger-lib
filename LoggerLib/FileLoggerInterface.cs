﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerLib
{
    public interface IFileLogger : ILogger
    {
        void SetFilePath(string path);
    }
}
