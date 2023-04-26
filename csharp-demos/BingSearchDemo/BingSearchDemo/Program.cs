// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Newtonsoft.Json;
using System;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;
using System.Xml;

// This sample uses the Bing Web Search API v7 to retrieve different kinds of media from the web.

// Add your Bing Search V7 subscription key and endpoint to your environment variables
string subscriptionKey = Environment.GetEnvironmentVariable("BING_SEARCH_V7_SUBSCRIPTION_KEY")!;
string endpoint = $"{Environment.GetEnvironmentVariable("BING_SEARCH_V7_ENDPOINT")}/v7.0/search";

const string query = "hummingbirds";

// Create a dictionary to store relevant headers
Dictionary<String, String> relevantHeaders = new();

OutputEncoding = Encoding.UTF8;

WriteLine("Searching the Web for: " + query);

// Construct the URI of the search request
var uriQuery = $"{endpoint}?q={Uri.EscapeDataString(query)}";

// Perform the Web request and get the response
WebRequest request = HttpWebRequest.Create(uriQuery);
request.Headers["Ocp-Apim-Subscription-Key"] = subscriptionKey;
HttpWebResponse response = (HttpWebResponse)request.GetResponseAsync().Result;
string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

// Extract Bing HTTP headers
foreach (String header in response.Headers)
{
    if (header.StartsWith("BingAPIs-") || header.StartsWith("X-MSEdge-"))
        relevantHeaders[header] = response.Headers[header];
}

// Show headers
WriteLine("Relevant HTTP Headers:");
foreach (var header in relevantHeaders)
{
    WriteLine(header.Key + ": " + header.Value);
}

WriteLine("JSON Response:");
dynamic parsedJson = JsonConvert.DeserializeObject(json);
WriteLine(JsonConvert.SerializeObject(parsedJson));
