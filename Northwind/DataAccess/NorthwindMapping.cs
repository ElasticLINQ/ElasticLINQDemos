﻿using System;
using System.Linq;
using ElasticLinq.Mapping;
using ElasticLinq.Request.Criteria;

namespace ElasticLinq
{
    public class NorthwindMapping : ElasticMapping
    {
        public override string GetDocumentType(Type type)
        {
            var attr = type.GetCustomAttributes(typeof(DocumentTypeAttribute), true)
                           .Cast<DocumentTypeAttribute>()
                           .FirstOrDefault();

            return attr != null ? attr.TypeName : base.GetDocumentType(type);
        }

        public override ICriteria GetTypeExistsCriteria(Type docType)
        {
            // Document type is sufficient to ensure the type exists
            return null;
        }
    }
}
