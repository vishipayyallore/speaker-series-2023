import openai
import requests

# Load config values
from dotenv import dotenv_values
config_details = dotenv_values(".env")

# Setting up the deployment name
deployment_name = config_details['COMPLETIONS_MODEL']

# The base URL for your Azure OpenAI resource. e.g. "https://<your resource name>.openai.azure.com"
openai.api_base = config_details['OPENAI_API_BASE']

# The API key for your Azure OpenAI resource.
openai.api_key = config_details["OPENAI_API_KEY"]
# print(openai.api_key)

# Currently OPENAI API have the following versions available: 2022-12-01. All versions follow the YYYY-MM-DD date structure.
openai.api_version = config_details['OPENAI_API_VERSION']

# Request URL
api_url = f"{openai.api_base}/openai/deployments/{deployment_name}/completions?api-version={openai.api_version}"
# print(api_url)

# Example prompt for request payload
prompt = "Tell me two jokes on intelligent people"

# Json payload
# To know more about the parameters, checkout this documentation: https://learn.microsoft.com/en-us/azure/cognitive-services/openai/reference
json_data = {
    "prompt": prompt,
    "temperature": 0,
    "max_tokens": 100,
    "echo": True,
}

# Including the api-key in HTTP headers
headers = {"api-key": openai.api_key}

try:
    # Request for creating a completion for the provided prompt and parameters
    response = requests.post(api_url, json=json_data, headers=headers)
    completion = response.json()

    # print the completion
    print(completion['choices'][0]['text'])

    # Here indicating if the response is filtered
    if completion['choices'][0]['finish_reason'] == "content_filter":
        print("The generated content is filtered.")
except:
    print("An exception has occurred. \n")
    print("Error Message:", completion['error']['message'])