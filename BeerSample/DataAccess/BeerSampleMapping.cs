using System;
using ElasticLinq.Mapping;
using ElasticLinq.Request.Criteria;

namespace ElasticLinq
{
    public class BeerSampleMapping : CouchbaseElasticMapping
    {
        public override ICriteria GetTypeSelectionCriteria(Type type)
        {
            // The context Query method already creates the type filter
            return null;
        }
    }
}
