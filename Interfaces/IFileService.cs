﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadService.Interfaces
{
    public interface IFileService
    {
        Task WriteLog(string message);
    }
}
