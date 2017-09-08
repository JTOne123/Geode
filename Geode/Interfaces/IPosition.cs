﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Geode.Geometry
{
    public interface IPosition
    {
        IReadOnlyList<double> Position { get; }
    }

}