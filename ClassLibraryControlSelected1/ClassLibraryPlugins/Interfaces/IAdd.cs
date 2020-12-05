﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPlugins.Interfaces
{
    public interface IAdd<T>
    {
        string Name { get; }
        void AddToSklad(T obj, int value);
    }
}
