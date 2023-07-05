// Note: the Azure OpenAI client library for .NET is in preview.
// Install the .NET library via NuGet: dotnet add package Azure.AI.OpenAI --version 1.0.0-beta.5 

using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;

var _configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddUserSecrets<Program>()
    .Build();

OpenAIClient client = new(new Uri(_configuration["CompletionConfiguration:OPEN_API_EndPoint"]!),
                            new AzureKeyCredential(_configuration["CompletionConfiguration:OPEN_API_Key"]!));

var promptWithoutDesiredOutput = "What are the top 10 countries with highest populations are along with their population count and capital city : \n";
var promptWithDesiredOutput = "Instructions: Please complete the below\n\nInput: \"\"\"What are the top 2 countries with highest populations are along with their population count and capital city :\"\"\"\n\nDesired Output: JSON Array \n\nOutput: \n";
var promptWithDesiredOutput1 = "Instructions: Please complete the below\n\nInput: \"\"\"What are the top 2 countries with highest populations are along with their population count and capital city :\"\"\"\n\nDesired Output: XML \n\nOutput: \n";

// If streaming is not selected
Response<Completions> completionsResponse = await client.GetCompletionsAsync(
    deploymentOrModelName: _configuration["CompletionConfiguration:ModelDeploymentName"]!,
    new CompletionsOptions()
    {
        Prompts = { promptWithoutDesiredOutput, promptWithDesiredOutput, promptWithDesiredOutput1 },
        Temperature = (float)1,
        MaxTokens = 120,
        NucleusSamplingFactor = (float)0.5,
        FrequencyPenalty = (float)0,
        PresencePenalty = (float)0,
        GenerationSampleCount = 1,
        Echo= false
    });
Completions completions = completionsResponse.Value;

ForegroundColor = ConsoleColor.Yellow;

int index = 0;
foreach (string? text in completions?.Choices?.Select(c => c.Text)?.ToArray()!)
{
    WriteLine($"{++index}. {text}\n");
}

ResetColor();   

WriteLine("\n\nPress any key ...");
ReadKey();
