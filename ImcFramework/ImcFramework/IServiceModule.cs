﻿using Common.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcFramework
{
    public interface IServiceModule
    {
        string Name { get; }

        bool Enable { get; set; }

        void Start();

        void Stop();

        ILog Logger { get; set; }

        IEnumerable<IServiceModule> DependencyModules { get; set; }
    }

    public interface IServiceModule<T> : IServiceModule
    {
        T ServiceContext { get; set; }
    }
}
