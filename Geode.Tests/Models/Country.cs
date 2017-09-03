﻿using System;
using System.Collections.Generic;
using System.Text;
using Geode.Attributes;
using Geode.Geometries;

namespace Geode.Tests.Models
{
    [Feature]
    public class Country
    {
        public string Name { get; set; }
        [Geometry(GeoType.Polygon)]
        public IEnumerable<IEnumerable<int>> Boundary { get; set; }
    }
}