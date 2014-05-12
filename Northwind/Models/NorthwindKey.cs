using System;
using Newtonsoft.Json;

namespace Northwind.Models
{
    [JsonConverter(typeof(NorthwindKeyConverter))]
    public class NorthwindKey : IEquatable<NorthwindKey>
    {
        public NorthwindKey(string typeName, string id)
        {
            TypeName = typeName;
            ID = id;
        }

        public string TypeName { get; private set; }

        public string ID { get; private set; }

        public static NorthwindKey Parse(string compositeID)
        {
            string[] parts = compositeID.Split('/');
            if (parts.Length != 2)
                throw new ArgumentException("Foreign keys must be in the form of 'entities/id'", "compositeID");

            return new NorthwindKey(parts[0], parts[1]);
        }

        public override bool Equals(object obj)
        {
            var other = obj as NorthwindKey;
            if (other == null)
                return false;

            return Equals(other);
        }

        public bool Equals(NorthwindKey other)
        {
            return ToString() == other.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("{0}/{1}", TypeName, ID);
        }
    }
}