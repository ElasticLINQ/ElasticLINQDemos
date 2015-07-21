using System;
using System.Linq;
using ElasticLinq.Logging;
using ElasticLinq.Retry;
using Northwind.Models;

namespace ElasticLinq
{
    public class NorthwindContext : ElasticContext
    {
        public NorthwindContext(string uri, ILog log = null, IRetryPolicy retryPolicy = null)
            : base(new ElasticConnection(new Uri(uri), index: "northwind"), new NorthwindMapping(), log, retryPolicy)
        { }

        public TModel Load<TModel>(NorthwindKey foreignKey)
        {
#if DEBUG
            var modelDocumentType = Mapping.GetDocumentType(typeof(TModel));
            if (modelDocumentType != foreignKey.TypeName)
                throw new ArgumentException(string.Format("Model type {0} has a document type name of {1}, which does not match this foreign key's type name of {2}", typeof(TModel).FullName, modelDocumentType, foreignKey.TypeName), "TModel");
#endif

            return Query<TModel>().FirstOrDefault(model => ElasticFields.Id == foreignKey.ID);
        }
    }
}
