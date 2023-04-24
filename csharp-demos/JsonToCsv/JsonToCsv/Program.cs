using Newtonsoft.Json;

var jsonFilePath = "./DataStore/Students.json";
var output = JsonToCsv(jsonFilePath);
Console.WriteLine(output);
File.WriteAllText(@"./DataStore/Students.csv", output);

static string JsonToCsv(string jsonFilePath)
{
    var list = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(File.ReadAllText(jsonFilePath));
    var headers = list.First().Keys.ToArray();
    var csv = new List<string>
    {
        // Add header row
        string.Join(",", headers.Select(h => "\"" + h.Replace("\"", "\"\"") + "\""))
    };

    // Add data rows
    foreach (var item in list)
    {
        var values = new List<string>();
        foreach (var header in headers)
        {
            var value = item.ContainsKey(header) ? item[header]?.ToString() ?? "" : "";
            values.Add("\"" + value.Replace("\"", "\"\"") + "\"");
        }
        csv.Add(string.Join(",", values));
    }

    return string.Join("\r\n", csv);
}
