﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Geode.Geometry
{
    public interface IFeature<T> where T: IGeoType
    {
        string Type { get; }
        T Geometry { get; set; }
        IDictionary<string, object> Properties { get; set; }
    }
}