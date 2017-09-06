﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Geode.Geometry;
using Geode.Services;

namespace Geode
{
    public class FeatureCollection<T>: IEnumerable<T> where T : IFeature
    {
        public string Type => "FeatureCollection";
        public IEnumerable<T> Features { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            return Features.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Features.GetEnumerator();
        }
    }

    public static class FeatureCollection
    {
        public static FeatureCollection<IFeature> CreateFeatures(IEnumerable<Object> objList) => FeatureService.CreateFeatures(objList);

        public static IFeatureCollection CreateFeatures(IFeatureCollectionConvertible featureCollection) => featureCollection.ConvertToFeatureCollection();
    }
}
