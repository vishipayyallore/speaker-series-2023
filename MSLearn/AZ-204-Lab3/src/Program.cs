using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

//Update the blobServiceEndpoint value that you recorded previously in this lab.   
const string blobServiceEndpoint = "https://mediastorelab03.blob.core.windows.net/";

//Update the storageAccountName value that you recorded previously in this lab.
const string storageAccountName = "mediastorelab03";

//Update the storageAccountKey value that you recorded previously in this lab.
const string storageAccountKey = "DI7I58/Q5ugHtYzvDgPBbxSoQGZwBCaYjiyjuUp+KPy8BvHnZh1A4cKMF0Zc+FDI+K94Fqo8x6E1+AStUmYfJg==";

//The following line of code to create a new instance of the StorageSharedKeyCredential class by using the storageAccountName and storageAccountKey constants as constructor parameters
StorageSharedKeyCredential accountCredentials = new(storageAccountName, storageAccountKey);

//The following line of code to create a new instance of the BlobServiceClient class by using the blobServiceEndpoint constant and the accountCredentials variable as constructor parameters
BlobServiceClient serviceClient = new(new Uri(blobServiceEndpoint), accountCredentials);

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Displaying Account Info");
await DisplayAccountInfo(storageAccountName, serviceClient);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\nEnumerating Containers");
await EnumerateContainersAsync(serviceClient);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\n\nEnumerating Blobs");
string existingContainerName = "raster-graphics";
await EnumerateBlobsAsync(serviceClient, existingContainerName);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\nCreating a New Container");
string newContainerName = "vector-graphics";
BlobContainerClient containerClient = await GetContainerAsync(serviceClient, newContainerName);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("\n\nRetrieving Blob Url");
string uploadedBlobName = "graph.svg";
BlobClient blobClient = await GetBlobAsync(containerClient, uploadedBlobName);
await Console.Out.WriteLineAsync($"Blob Url:\t{blobClient.Uri}");
Console.ResetColor();

Console.WriteLine("\n\nThank You !!");
// **********************************

static async Task DisplayAccountInfo(string storageAccountName, BlobServiceClient serviceClient)
{
    //The following line of code to invoke the GetAccountInfoAsync method of the BlobServiceClient class to retrieve account metadata from the service
    AccountInfo info = await serviceClient.GetAccountInfoAsync();

    //Render a welcome message
    await Console.Out.WriteLineAsync($"Connected to Azure Storage Account");

    //Render the storage account's name
    await Console.Out.WriteLineAsync($"Account name:\t{storageAccountName}");

    //Render the type of storage account
    await Console.Out.WriteLineAsync($"Account kind:\t{info?.AccountKind}");

    //Render the currently selected stock keeping unit (SKU) for the storage account
    await Console.Out.WriteLineAsync($"Account sku:\t{info?.SkuName}");
}

static async Task EnumerateContainersAsync(BlobServiceClient client)
{
    /*Create an asynchronous foreach loop that iterates over the results of an invocation of the GetBlobContainersAsync method of the BlobServiceClient class. */
    await foreach (BlobContainerItem container in client.GetBlobContainersAsync())
    {
        //Print the name of each container
        await Console.Out.WriteLineAsync($"Container:\t{container.Name}");
    }
}

static async Task EnumerateBlobsAsync(BlobServiceClient client, string containerName)
{
    /* Get a new instance of the BlobContainerClient class by using the
       GetBlobContainerClient method of the BlobServiceClient class, 
       passing in the containerName parameter */
    BlobContainerClient container = client.GetBlobContainerClient(containerName);

    /* Render the name of the container that will be enumerated */
    await Console.Out.WriteLineAsync($"Searching:\t{container.Name}");

    /* Create an asynchronous foreach loop that iterates over the results of
        an invocation of the GetBlobsAsync method of the BlobContainerClient class */
    await foreach (BlobItem blob in container.GetBlobsAsync())
    {
        //Print the name of each blob    
        await Console.Out.WriteLineAsync($"Existing Blob:\t{blob.Name}");
    }
}

static async Task<BlobContainerClient> GetContainerAsync(BlobServiceClient client, string containerName)
{
    /* Get a new instance of the BlobContainerClient class by using the
        GetBlobContainerClient method of the BlobServiceClient class,
        passing in the containerName parameter */
    BlobContainerClient container = client.GetBlobContainerClient(containerName);

    /* Invoke the CreateIfNotExistsAsync method of the BlobContainerClient class */
    await container.CreateIfNotExistsAsync(PublicAccessType.Blob);

    /* Render the name of the container that was potentially created */
    await Console.Out.WriteLineAsync($"New Container:\t{container.Name}");

    /* Return the container as the result of the GetContainerAsync */
    return container;
}

static async Task<BlobClient> GetBlobAsync(BlobContainerClient client, string blobName)
{
    /* Get a new instance of the BlobClient class by using the GetBlobClient method
        of the BlobContainerClient class, and to pass in the blobName parameter */
    BlobClient blob = client.GetBlobClient(blobName);

    /* Render the name of the blob that was referenced */
    await Console.Out.WriteLineAsync($"Blob Found:\t{blob.Name}");

    /* Return blob as the result of the GetBlobAsync method */
    return blob;
}
