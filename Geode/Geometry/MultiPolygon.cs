﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Geode.Geometry
{
    public class MultiPolygon : IGeoType
    {
        public GeoType Type => GeoType.MultiLineString;
        public IEnumerable<IEnumerable<IEnumerable<double>>> Coordinates { get; set; }
        public MultiPolygon(IEnumerable<IEnumerable<IEnumerable<double>>> coordinates)
        {
            Coordinates = coordinates;
        }
        public MultiPolygon() { }
        public IEnumerable Geometry => Coordinates;
        public bool Equals(IGeoType other)
        {
            throw new NotImplementedException();
        }
    }
}