﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Geode.Geometry
{
    public class Polyline : IGeoType
    {
        public GeoType Type => GeoType.LineString;
        public IEnumerable<IEnumerable<double>> Coordinates { get; set; }
        public Polyline(IEnumerable<IEnumerable<double>> coordinates)
        {
            Coordinates = coordinates;
        }
        public IEnumerable Geometry => Coordinates;

        public bool Equals(IGeoType other)
        {
            throw new NotImplementedException();
        }
    }
}
