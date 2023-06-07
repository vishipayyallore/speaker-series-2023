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

// If streaming is selected
Response<StreamingCompletions> response = await client.GetCompletionsStreamingAsync(
    _configuration["CompletionConfiguration:ModelDeploymentName"]!,
    new CompletionsOptions()
    {
        Prompts = { "What are the top 10 countries with highest populations are along with their population count and capital city : \n\n1. China - 1.4 billion - Beijing\n2. India - 1.3 billion - New Delhi\n3. United States - 328 million - Washington, D.C.\n4. Indonesia - 269 million - Jakarta\n5. Brazil - 211 million - Brasília\n6. Pakistan - 207 million - Islamabad\n7. Nigeria - 206 million - Abuja\n8. Bangladesh - 166 million - Dhaka\n9. Russia - 144 million - Moscow\n10. Mexico - 126 million - Mexico City" },
        Temperature = (float)1,
        MaxTokens = 100,
        NucleusSamplingFactor = (float)0.5,
        FrequencyPenalty = (float)0,
        PresencePenalty = (float)0,
        GenerationSampleCount = 1,
    });
using StreamingCompletions streamingCompletions = response.Value;

// If streaming is not selected
Response<Completions> completionsResponse = await client.GetCompletionsAsync(
    deploymentOrModelName: _configuration["CompletionConfiguration:ModelDeploymentName"]!,
    new CompletionsOptions()
    {
        Prompts = { "What are the top 10 countries with highest populations are along with their population count and capital city : \n" },
        Temperature = (float)1,
        MaxTokens = 120,
        NucleusSamplingFactor = (float)0.5,
        FrequencyPenalty = (float)0,
        PresencePenalty = (float)0,
        GenerationSampleCount = 1,
        Echo= true
    });
Completions completions = completionsResponse.Value;

int index = 0;
foreach (string? text in completions?.Choices?.Select(c => c.Text)?.ToArray()!)
{
    WriteLine($"{++index}. {text}");
}

WriteLine("\n\nPress any key ...");
ReadKey();
