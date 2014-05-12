using System;
using System.Globalization;
using System.Linq;
using BeerSample.Models;
using ElasticLinq.Logging;
using ElasticLinq.Mapping;
using ElasticLinq.Retry;

namespace ElasticLinq
{
    public class BeerSampleContext : ElasticContext
    {
        public BeerSampleContext(string uri, ILog log = null, IRetryPolicy retryPolicy = null)
            : base(new ElasticConnection(new Uri(uri), index: "beer-sample"), new BeerSampleMapping(), log, retryPolicy) { }

        public new IQueryable<T> Query<T>()
            where T : BeerSampleDocument
        {
            return base.Query<T>().Where(doc => doc.type == typeof(T).Name.ToCamelCase(CultureInfo.CurrentCulture));
        }
    }
}
