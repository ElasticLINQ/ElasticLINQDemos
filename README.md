# ElasticLINQ Demos

The code in this repository is used to demonstrate the usage of [ElasticLINQ](https://github.com/CenturyLinkCloud/ElasticLINQ), both with [Elasticsearch](http://www.elasticsearch.org) alone, and when using Elasticsearch with [Couchbase](http://www.couchbase.com/).

## Northwind

The Northwind demo uses data ported from [Microsoft's Northwind](http://www.microsoft.com/en-us/download/details.aspx?id=23654) database. The port work, available as [GZIPped JSON](https://github.com/ayende/ravendb/blob/master/Raven.Database/Server/Assets/EmbeddedData/Northwind.dump), was done by [Ayende](https://twitter.com/ayende) for the [RavenDB project](https://github.com/ayende/ravendb), which I adapted for Elasticsearch. There is an upload script in the [Northwind/data](https://github.com/bradwilson/ElasticLINQDemos/tree/master/Northwind/data) folder that will send the JSON documents to your Elasticsearch server.

## Beer Sample

The Beer Sample demo uses the "beer-sample" data from Couchbase, with the data pushed into ElasticSearch via XDCR to the Elasticsearch-Couchbase adapter.
