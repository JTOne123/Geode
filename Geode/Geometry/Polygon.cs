﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Geode.Geometry
{
    public class Polygon: IGeoType
    {
        public GeoType Type => GeoType.Polygon;
        public IEnumerable<IEnumerable<double>> Coordinates { get; set; }
        public IEnumerable Geometry => Coordinates;
        public Polygon(IEnumerable<IEnumerable<double>> coordinates)
        {
            Coordinates = coordinates;
        }
        public Polygon() { }
        public bool Equals(IGeoType other)
        {
            throw new NotImplementedException();
        }
    }
}
