# .SYNOPSIS
#   Uploads the Northwind documents to an Elasticsearch server.
# .DESCRIPTION
#   This utility script uploads the JSON version of Northwind to an Elasticsearch server.
# .PARAMETER $uri
#   The URI for the Elasticsearch server (i.e., "http://localhost:9200/")
# .PARAMETER $index
#   The index to add the documents to. The index must already exist
# .LINK
#   https://github.com/bradwilson/ElasticLINQDemos

param(
    [Parameter(Mandatory = $true)]
    [string]$uri,

    [string]$index = "northwind"
)

[Reflection.Assembly]::LoadWithPartialName("System.Net.Http") | Out-Null

if (-not $uri.EndsWith("/")) {
    $uri += "/"
}

$uri += $index + "/"
$utf8 = [Text.Encoding]::UTF8
$httpClient = New-Object 'System.Net.Http.HttpClient'

$result = $httpClient.GetAsync($uri + "_stats").GetAwaiter().GetResult()
if ($result.StatusCode -ne 200) {
    throw $("Index '" + $index + "' was not found on the Elasticsearch server.")
}

Get-ChildItem -Recurse -Filter "*.json" | ForEach-Object {
    $docUri = $uri + $(Resolve-Path $_.FullName -Relative).Substring(2).Replace("\", "/").Replace(".json", "")
    Write-Host $("PUT " + $docUri)

    $body = Get-Content $_.FullName -Encoding UTF8
    $content = New-Object 'System.Net.Http.StringContent' ($body, $utf8, "application/json")
    $result = $httpClient.PutAsync($docUri, $content).Result
    $result.EnsureSuccessStatusCode() | Out-Null
    $result.Dispose() | Out-Null
}

$httpClient.Dispose() | Out-Null
